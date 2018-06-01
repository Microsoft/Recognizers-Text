﻿using Microsoft.Recognizers.Definitions.Chinese;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Microsoft.Recognizers.Text.Number.Chinese
{
    public class ChineseNumberRangeParserConfiguration :INumberRangeParserConfiguration
    {
        public CultureInfo CultureInfo { get; private set; }

        public IExtractor NumberExtractor { get; private set; }

        public IExtractor OrdinalExtractor { get; private set; }

        public IParser NumberParser { get; private set; }

        public Regex MoreOrEqual { get; private set; }

        public Regex LessOrEqual { get; private set; }

        public Regex MoreOrEqualSuffix { get; private set; }

        public Regex LessOrEqualSuffix { get; private set; }

        public Regex MoreOrEqualSeparate { get; private set; }

        public Regex LessOrEqualSeparate { get; private set; }

        public ChineseNumberRangeParserConfiguration() : this(new CultureInfo(Culture.Chinese))
        {
        }

        public ChineseNumberRangeParserConfiguration(CultureInfo ci)
        {
            CultureInfo = ci;

            NumberExtractor = new NumberExtractor();
            OrdinalExtractor = new OrdinalExtractor();
            NumberParser =  new BaseCJKNumberParser(new ChineseNumberParserConfiguration());
            MoreOrEqual = new Regex(NumbersDefinitions.MoreOrEqual, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            LessOrEqual = new Regex(NumbersDefinitions.LessOrEqual, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MoreOrEqualSuffix = new Regex(NumbersDefinitions.MoreOrEqualSuffix, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            LessOrEqualSuffix = new Regex(NumbersDefinitions.LessOrEqualSuffix, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MoreOrEqualSeparate = new Regex(NumbersDefinitions.OneNumberRangeMoreSeparateRegex, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            LessOrEqualSeparate = new Regex(NumbersDefinitions.OneNumberRangeLessSeparateRegex, RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }
    }
}
