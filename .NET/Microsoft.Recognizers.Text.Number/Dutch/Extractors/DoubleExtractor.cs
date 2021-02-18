﻿using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.Dutch;

namespace Microsoft.Recognizers.Text.Number.Dutch
{
    public class DoubleExtractor : BaseNumberExtractor
    {
        private const RegexOptions RegexFlags = RegexOptions.Singleline | RegexOptions.ExplicitCapture;

        private static readonly ConcurrentDictionary<string, DoubleExtractor> Instances = new ConcurrentDictionary<string, DoubleExtractor>();

        private DoubleExtractor(BaseNumberOptionsConfiguration config)
            : base(config.Options)
        {
            var regexes = new Dictionary<Regex, TypeTag>
            {
                {
                    RegexCache.Get(NumbersDefinitions.DoubleDecimalPointRegex(config.Placeholder), RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.NUMBER_SUFFIX)
                },
                {
                    RegexCache.Get(NumbersDefinitions.DoubleWithoutIntegralRegex(config.Placeholder), RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.NUMBER_SUFFIX)
                },
                {
                    RegexCache.Get(NumbersDefinitions.DoubleWithMultiplierRegex, RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.NUMBER_SUFFIX)
                },
                {
                    RegexCache.Get(NumbersDefinitions.DoubleWithRoundNumber, RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.NUMBER_SUFFIX)
                },
                {
                    RegexCache.Get(NumbersDefinitions.DoubleAllFloatRegex, RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.DUTCH)
                },
                {
                    RegexCache.Get(NumbersDefinitions.DoubleExponentialNotationRegex, RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.POWER_SUFFIX)
                },
                {
                    RegexCache.Get(NumbersDefinitions.DoubleCaretExponentialNotationRegex, RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.POWER_SUFFIX)
                },
                {
                    GenerateLongFormatNumberRegexes(LongFormatType.DoubleNumDotComma, config.Placeholder, RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.NUMBER_SUFFIX)
                },
                {
                    GenerateLongFormatNumberRegexes(LongFormatType.DoubleNumNoBreakSpaceComma, config.Placeholder, RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.NUMBER_SUFFIX)
                },
                {
                    GenerateLongFormatNumberRegexes(LongFormatType.DoubleNumBlankComma, config.Placeholder, RegexFlags),
                    RegexTagGenerator.GenerateRegexTag(Constants.DOUBLE_PREFIX, Constants.NUMBER_SUFFIX)
                },
            };

            Regexes = regexes.ToImmutableDictionary();
        }

        internal sealed override ImmutableDictionary<Regex, TypeTag> Regexes { get; }

        protected sealed override string ExtractType { get; } = Constants.SYS_NUM_DOUBLE; // "Double";

        public static DoubleExtractor GetInstance(BaseNumberOptionsConfiguration config)
        {

            var extractorKey = config.Placeholder;

            if (!Instances.ContainsKey(extractorKey))
            {
                var instance = new DoubleExtractor(config);
                Instances.TryAdd(extractorKey, instance);
            }

            return Instances[extractorKey];
        }
    }
}