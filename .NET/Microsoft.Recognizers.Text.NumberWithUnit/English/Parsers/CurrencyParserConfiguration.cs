﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Globalization;
using Microsoft.Recognizers.Definitions.English;

namespace Microsoft.Recognizers.Text.NumberWithUnit.English
{
    public class CurrencyParserConfiguration : EnglishNumberWithUnitParserConfiguration
    {
        public CurrencyParserConfiguration() : this(new CultureInfo(Culture.English)) { }

        public CurrencyParserConfiguration(CultureInfo ci) : base(ci)
        {
            this.BindDictionary(CurrencyExtractorConfiguration.CurrencySuffixList);
            this.BindDictionary(CurrencyExtractorConfiguration.CurrencyPrefixList);
            this.CurrencyIsoCodeList = NumbersWithUnitDefinitions.CurrencyIsoCodeList.ToImmutableDictionary();
            this.CurrencyFractionCodeList = NumbersWithUnitDefinitions.CurrencyFractionList.ToImmutableDictionary();
        }

    }
}
