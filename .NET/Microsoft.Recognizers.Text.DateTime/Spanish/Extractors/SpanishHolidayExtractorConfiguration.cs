﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.Spanish;

namespace Microsoft.Recognizers.Text.DateTime.Spanish
{
    public class SpanishHolidayExtractorConfiguration : BaseDateTimeOptionsConfiguration, IHolidayExtractorConfiguration
    {
        public static readonly Regex[] HolidayRegexList =
        {
            RegexCache.Get(DateTimeDefinitions.HolidayRegex1, RegexFlags),
            RegexCache.Get(DateTimeDefinitions.HolidayRegex2, RegexFlags),
            RegexCache.Get(DateTimeDefinitions.HolidayRegex3, RegexFlags),
        };

        private const RegexOptions RegexFlags = RegexOptions.Singleline | RegexOptions.ExplicitCapture;

        public SpanishHolidayExtractorConfiguration(IDateTimeOptionsConfiguration config)
            : base(config)
        {
        }

        public IEnumerable<Regex> HolidayRegexes => HolidayRegexList;
    }
}
