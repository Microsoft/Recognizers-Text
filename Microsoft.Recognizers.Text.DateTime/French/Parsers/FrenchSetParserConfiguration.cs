﻿using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace Microsoft.Recognizers.Text.DateTime.French
{
    public class FrenchSetParserConfiguration : ISetParserConfiguration
    {
        public IExtractor DurationExtractor { get; }

        public IDateTimeParser DurationParser { get; }

        public IExtractor TimeExtractor { get; }

        public IDateTimeParser TimeParser { get; }

        public IExtractor DateExtractor { get; }

        public IDateTimeParser DateParser { get; }

        public IExtractor DateTimeExtractor { get; }

        public IDateTimeParser DateTimeParser { get; }

        public IExtractor DatePeriodExtractor { get; }

        public IDateTimeParser DatePeriodParser { get; }

        public IExtractor TimePeriodExtractor { get; }

        public IDateTimeParser TimePeriodParser { get; }

        public IExtractor DateTimePeriodExtractor { get; }

        public IDateTimeParser DateTimePeriodParser { get; }

        public IImmutableDictionary<string, string> UnitMap { get; }

        public Regex EachPrefixRegex { get; }

        public Regex PeriodicRegex { get; }

        public Regex EachUnitRegex { get; }

        public Regex EachDayRegex { get; }

        public FrenchSetParserConfiguration(ICommonDateTimeParserConfiguration config)
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

            EachPrefixRegex = FrenchSetExtractorConfiguration.EachPrefixRegex;
            PeriodicRegex = FrenchSetExtractorConfiguration.PeriodicRegex;
            EachUnitRegex = FrenchSetExtractorConfiguration.EachUnitRegex;
            EachDayRegex = FrenchSetExtractorConfiguration.EachDayRegex;
        }

        public bool GetMatchedDailyTimex(string text, out string timex)
        {
            var trimedText = text.Trim().ToLowerInvariant();
            if (trimedText.Equals("quotidien") || trimedText.Equals("quotidienne") || 
                trimedText.Equals("jours") || trimedText.Equals("journellement")) // daily
            {
                timex = "P1D";
            }
            else if (trimedText.Equals("hebdomadaire"))           // weekly
            {
                timex = "P1W";
            }
            else if (trimedText.Equals("bihebdomadaire"))          // bi weekly
            {
                timex = "P2W";
            }
            else if (trimedText.Equals("mensuel") || trimedText.Equals("mensuelle"))              // monthly
            {
                timex = "P1M";
            }
            else if (trimedText.Equals("annuel") || trimedText.Equals("annuellement")) // yearly/annually
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
            var trimedText = text.Trim().ToLowerInvariant();
            if (trimedText.Equals("jour")||trimedText.Equals("journee"))
            {
                timex = "P1D";
            }
            else if (trimedText.Equals("semaine"))
            {
                timex = "P1W";
            }
            else if (trimedText.Equals("mois"))
            {
                timex = "P1M";
            }
            else if (trimedText.Equals("an")||trimedText.Equals("annee")) // year
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
