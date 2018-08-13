﻿using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace Microsoft.Recognizers.Text.DateTime.Portuguese
{
    public class PortugueseSetParserConfiguration : BaseOptionsConfiguration, ISetParserConfiguration
    {
        public IDateTimeExtractor DurationExtractor { get; }

        public IDateTimeParser DurationParser { get; }

        public IDateTimeExtractor TimeExtractor { get; }

        public IDateTimeParser TimeParser { get; }

        public IDateTimeExtractor DateExtractor { get; }

        public IDateTimeParser DateParser { get; }

        public IDateTimeExtractor DateTimeExtractor { get; }

        public IDateTimeParser DateTimeParser { get; }

        public IDateTimeExtractor DatePeriodExtractor { get; }

        public IDateTimeParser DatePeriodParser { get; }

        public IDateTimeExtractor TimePeriodExtractor { get; }

        public IDateTimeParser TimePeriodParser { get; }

        public IDateTimeExtractor DateTimePeriodExtractor { get; }

        public IDateTimeParser DateTimePeriodParser { get; }

        public IImmutableDictionary<string, string> UnitMap { get; }

        public Regex EachPrefixRegex { get; }

        public Regex PeriodicRegex { get; }

        public Regex EachUnitRegex { get; }

        public Regex EachDayRegex { get; }

        public Regex SetWeekDayRegex { get; }

        public Regex SetEachRegex { get; }

        public PortugueseSetParserConfiguration(ICommonDateTimeParserConfiguration config) : base(config)
        {
            DurationExtractor = config.DurationExtractor;
            TimeExtractor = config.TimeExtractor;
            DateExtractor = config.DateExtractor;
            DateTimeExtractor = config.DateTimeExtractor;
            DatePeriodExtractor = config.DatePeriodExtractor;
            TimePeriodExtractor = config.TimePeriodExtractor;
            DateTimePeriodExtractor = config.DateTimePeriodExtractor;

            DurationParser = config.DurationParser;
            TimeParser = config.TimeParser;
            DateParser = config.DateParser;
            DateTimeParser = config.DateTimeParser;
            DatePeriodParser = config.DatePeriodParser;
            TimePeriodParser = config.TimePeriodParser;
            DateTimePeriodParser = config.DateTimePeriodParser;
            UnitMap = config.UnitMap;

            EachPrefixRegex = PortugueseSetExtractorConfiguration.EachPrefixRegex;
            PeriodicRegex = PortugueseSetExtractorConfiguration.PeriodicRegex;
            EachUnitRegex = PortugueseSetExtractorConfiguration.EachUnitRegex;
            EachDayRegex = PortugueseSetExtractorConfiguration.EachDayRegex;
            SetWeekDayRegex = PortugueseSetExtractorConfiguration.SetWeekDayRegex;
            SetEachRegex = PortugueseSetExtractorConfiguration.SetEachRegex;
        }

        public bool GetMatchedDailyTimex(string text, out string timex)
        {
            var trimedText = text.Trim().ToLowerInvariant().Normalized();

            if (trimedText.EndsWith("diario") || trimedText.EndsWith("diaria") || trimedText.EndsWith("diariamente"))
            {
                timex = "P1D";
            }
            else if (trimedText.Equals("semanalmente"))
            {
                timex = "P1W";
            }
            else if (trimedText.Equals("quinzenalmente"))
            {
                timex = "P2W";
            }
            else if (trimedText.Equals("mensalmente"))
            {
                timex = "P1M";
            }
            else if (trimedText.Equals("anualmente"))
            {
                timex = "P1Y";
            }
            else
            {
                timex = null;
                return false;
            }

            return true;
        }

        public bool GetMatchedUnitTimex(string text, out string timex)
        {
            var trimedText = text.Trim().ToLowerInvariant().Normalized();

            if (trimedText.Equals("dia") || trimedText.Equals("dias"))
            {
                timex = "P1D";
            }
            else if (trimedText.Equals("semana") || trimedText.Equals("semanas"))
            {
                timex = "P1W";
            }
            else if (trimedText.Equals("mes") || trimedText.Equals("meses"))
            {
                timex = "P1M";
            }
            else if (trimedText.Equals("ano") || trimedText.Equals("anos"))
            {
                timex = "P1Y";
            }
            else
            {
                timex = null;
                return false;
            }

            return true;
        }
    }

}