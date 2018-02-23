﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Recognizers.Text
{
    internal class ModelFactory<TModelOptions> : Dictionary<(string culture, Type modelType), Func<TModelOptions, IModel>>
    {
        private static ConcurrentDictionary<(string culture, Type modelType, string modelOptions), IModel> cache = new ConcurrentDictionary<(string culture, Type modelType, string modelOptions), IModel>();

        private static readonly string fallbackCulture = Culture.English;

        public T GetModel<T>(string culture, bool fallbackToDefaultCulture, TModelOptions options) where T : IModel
        {
            if (string.IsNullOrEmpty(culture))
            {
                throw new ArgumentNullException("culture", "Culture is required.");
            }

            if (TryGetModel(culture, options, out T model))
            {
                return model;
            }
            else if (fallbackToDefaultCulture && TryGetModel(fallbackCulture, options, out model))
            {
                return model;
            }

            throw new ArgumentException($"Could not find Model with the specified configuration: {culture}, {typeof(T).ToString()}");
        }

        public void InitializeModels(string targetCulture, TModelOptions options)
        {
            this.Keys
                .Where(key => string.IsNullOrEmpty(targetCulture) || key.culture.Equals(targetCulture))
                .ToList()
                .ForEach(key => this.InitializeModel(key.modelType, key.culture, options));
        }

        private void InitializeModel(Type modelType, string culture, TModelOptions options)
        {
            this.TryGetModel(modelType, culture, options, out IModel model);
        }

        private bool TryGetModel<T>(string culture, TModelOptions options, out T model) where T : IModel
        {
            var result = this.TryGetModel(typeof(T), culture, options, out IModel outModel);
            model = (T)outModel;
            return result;
        }

        private bool TryGetModel(Type modelType, string culture, TModelOptions options, out IModel model)
        {
            // Look in cache
            var cacheKey = (culture.ToLowerInvariant(), modelType, options.ToString());
            if (cache.ContainsKey(cacheKey))
            {
                model = cache[cacheKey];
                return true;
            }

            // Use Factory to create instance
            var key = GenerateKey(culture, modelType);
            if (this.ContainsKey(key))
            {
                var factoryMethod = this[key];
                model = factoryMethod(options);

                // Store in cache
                cache[cacheKey] = model;

                return true;
            }

            model = default(IModel);
            return false;
        }

        public new void Add((string culture, Type modelType) config, Func<TModelOptions, IModel> modelCreator)
        {
            base.Add(GenerateKey(config.culture, config.modelType), modelCreator);
        }

        private static (string culture, Type modelType) GenerateKey(string culture, Type modelType)
        {
            return (culture.ToLowerInvariant(), modelType);
        }
    }
}
