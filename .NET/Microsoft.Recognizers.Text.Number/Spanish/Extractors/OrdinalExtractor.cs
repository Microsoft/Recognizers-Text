﻿using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.Spanish;

namespace Microsoft.Recognizers.Text.Number.Spanish
{
    public class OrdinalExtractor : BaseNumberExtractor
    {
        internal sealed override ImmutableDictionary<Regex, TypeTag> Regexes { get; }

        protected sealed override string ExtractType { get; } = Constants.SYS_NUM_ORDINAL; // "Ordinal";

        private static readonly ConcurrentDictionary<string, OrdinalExtractor> Instances =
            new ConcurrentDictionary<string, OrdinalExtractor>();

        public static OrdinalExtractor GetInstance(string placeholder = "")
        {

            if (!Instances.ContainsKey(placeholder))
            {
                var instance = new OrdinalExtractor();
                Instances.TryAdd(placeholder, instance);
            }

            return Instances[placeholder];
        }

        private OrdinalExtractor()
        {
            var regexes = new Dictionary<Regex, TypeTag>
            {
                {
                    new Regex(NumbersDefinitions.OrdinalSuffixRegex, RegexOptions.IgnoreCase | RegexOptions.Singleline),
                    RegexTagGenerator.GenerateRegexTag(Constants.ORDINAL_PREFIX, Constants.NUMBER_SUFFIX)
                },
                {
                    new Regex(NumbersDefinitions.OrdinalNounRegex, RegexOptions.IgnoreCase | RegexOptions.Singleline),
                    RegexTagGenerator.GenerateRegexTag(Constants.ORDINAL_PREFIX, Constants.SPANISH)
                }
            };

            this.Regexes = regexes.ToImmutableDictionary();
        }
    }
}