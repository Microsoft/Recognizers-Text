﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Recognizers.Text.Choice
{
    public abstract class ChoiceModel : IModel
    {
        protected ChoiceModel(IParser parser, IExtractor extractor)
        {
            this.Parser = parser;
            this.Extractor = extractor;
        }

        public abstract string ModelTypeName { get; }

        protected IExtractor Extractor { get; private set; }

        protected IParser Parser { get; private set; }

        public List<ModelResult> Parse(string query)
        {
            var parseResults = Enumerable.Empty<ParseResult>();

            try
            {
                var extractResults = Extractor.Extract(query);
                parseResults = extractResults.Select(r => Parser.Parse(r));

            }
            catch (Exception)
            {
                // Nothing to do. Exceptions in parse should not break users of recognizers.
                // No result.
            }

            return parseResults.Select(pr => new ModelResult()
            {
                Start = pr.Start.Value,
                End = pr.Start.Value + pr.Length.Value - 1,
                Resolution = GetResolution(pr),
                Text = pr.Text,
                TypeName = ModelTypeName,
            }).ToList();
        }

        protected abstract SortedDictionary<string, object> GetResolution(ParseResult parseResult);
    }
}