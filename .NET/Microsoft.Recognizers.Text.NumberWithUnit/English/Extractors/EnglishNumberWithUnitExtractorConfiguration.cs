﻿using System.Collections.Immutable;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.Recognizers.Definitions.English;
using Microsoft.Recognizers.Text.Number.English;
using Microsoft.Recognizers.Text.Number;

namespace Microsoft.Recognizers.Text.NumberWithUnit.English
{
    public abstract class EnglishNumberWithUnitExtractorConfiguration : INumberWithUnitExtractorConfiguration
    {
        protected EnglishNumberWithUnitExtractorConfiguration(CultureInfo ci)
        {
            this.CultureInfo = ci;
            this.UnitNumExtractor = NumberExtractor.GetInstance();
            this.BuildPrefix = NumbersWithUnitDefinitions.BuildPrefix;
            this.BuildSuffix = NumbersWithUnitDefinitions.BuildSuffix;
            this.ConnectorToken = string.Empty;
            this.CompoundUnitRegex = new Regex(NumbersWithUnitDefinitions.CompoundUnitRegex, RegexOptions.IgnoreCase);
        }

        public abstract string ExtractType { get; }

        public CultureInfo CultureInfo { get; }

        public IExtractor UnitNumExtractor { get; }

        public string BuildPrefix { get; }

        public string BuildSuffix { get; }

        public string ConnectorToken { get; }

        public Regex CompoundUnitRegex { get; set; }

        public abstract ImmutableDictionary<string, string> SuffixList { get; }

        public abstract ImmutableDictionary<string, string> PrefixList { get; }

        public abstract ImmutableList<string> AmbiguousUnitList { get; }
    }
}