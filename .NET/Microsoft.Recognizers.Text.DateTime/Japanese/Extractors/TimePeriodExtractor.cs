﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.Japanese;

namespace Microsoft.Recognizers.Text.DateTime.Japanese
{
    public class TimePeriodExtractor : BaseDateTimeExtractor<PeriodType>
    {
        internal sealed override ImmutableDictionary<Regex, PeriodType> Regexes { get; }

        protected sealed override string ExtractType { get; } = Constants.SYS_DATETIME_TIMEPERIOD;
    
        public TimePeriodExtractor()
        {
            var regexes = new Dictionary<Regex, PeriodType>
            {
                {
                    new Regex(DateTimeDefinitions.TimePeriodRegexes1, RegexOptions.Singleline),
                    PeriodType.FullTime
                },
                {
                    new Regex(DateTimeDefinitions.TimePeriodRegexes2, RegexOptions.Singleline),
                    PeriodType.ShortTime
                },
                {
                    new Regex(DateTimeDefinitions.TimeOfDayRegex, RegexOptions.Singleline),
                    PeriodType.ShortTime
                }
            };

            Regexes = regexes.ToImmutableDictionary();
        }
    }

    public enum PeriodType
    {
        ShortTime,
        FullTime
    }
}