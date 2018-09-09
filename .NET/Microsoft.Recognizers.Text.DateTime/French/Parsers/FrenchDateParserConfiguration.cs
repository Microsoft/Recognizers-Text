﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.French;
using Microsoft.Recognizers.Text.DateTime.Utilities;

namespace Microsoft.Recognizers.Text.DateTime.French
{
    public class FrenchDateParserConfiguration : BaseOptionsConfiguration, IDateParserConfiguration
    {
        public string DateTokenPrefix { get; }

        public IExtractor IntegerExtractor { get; }

        public IExtractor OrdinalExtractor { get; }

        public IExtractor CardinalExtractor { get; }

        public IParser NumberParser { get; }

        public IDateTimeExtractor DurationExtractor { get; }

        public IDateTimeExtractor DateExtractor { get; }

        public IDateTimeParser DurationParser { get; }

        public IImmutableDictionary<string, string> UnitMap { get; }

        public IEnumerable<Regex> DateRegexes { get; }

        public Regex OnRegex { get; }

        public Regex SpecialDayRegex { get; }

        public Regex SpecialDayWithNumRegex { get; }

        public Regex NextRegex { get; }

        public Regex ThisRegex { get; }

        public Regex LastRegex { get; }

        public Regex UnitRegex { get; }

        public Regex WeekDayRegex { get; }

        public Regex StrictWeekDay { get; }

        public Regex MonthRegex { get; }

        public Regex WeekDayOfMonthRegex { get; }

        public Regex ForTheRegex { get; }

        public Regex WeekDayAndDayOfMothRegex { get; }

        public Regex RelativeMonthRegex { get; }

        public Regex YearSuffix { get; }

        public Regex RelativeWeekDayRegex { get; }

        public IImmutableDictionary<string, int> DayOfMonth { get; }

        public IImmutableDictionary<string, int> DayOfWeek { get; }

        public IImmutableDictionary<string, int> MonthOfYear { get; }

        public IImmutableDictionary<string, int> CardinalMap { get; }

        public IDateTimeUtilityConfiguration UtilityConfiguration { get; }

        public FrenchDateParserConfiguration(ICommonDateTimeParserConfiguration config) : base(config)
        {
            DateTokenPrefix = DateTimeDefinitions.DateTokenPrefix;
            IntegerExtractor = config.IntegerExtractor;
            OrdinalExtractor = config.OrdinalExtractor;
            CardinalExtractor = config.CardinalExtractor;
            NumberParser = config.NumberParser;
            DurationExtractor = config.DurationExtractor;
            DateExtractor = config.DateExtractor;
            DurationParser = config.DurationParser;
            DateRegexes = new FrenchDateExtractorConfiguration(this).DateRegexList;
            OnRegex = FrenchDateExtractorConfiguration.OnRegex;
            SpecialDayRegex = FrenchDateExtractorConfiguration.SpecialDayRegex;
            SpecialDayWithNumRegex = FrenchDateExtractorConfiguration.SpecialDayWithNumRegex;
            NextRegex = FrenchDateExtractorConfiguration.NextRegex;
            ThisRegex = FrenchDateExtractorConfiguration.ThisRegex;
            LastRegex = FrenchDateExtractorConfiguration.LastRegex;
            UnitRegex = FrenchDateExtractorConfiguration.DateUnitRegex;
            WeekDayRegex = FrenchDateExtractorConfiguration.WeekDayRegex;
            StrictWeekDay = FrenchDateExtractorConfiguration.StrictWeekDay;
            MonthRegex = FrenchDateExtractorConfiguration.MonthRegex;
            WeekDayOfMonthRegex = FrenchDateExtractorConfiguration.WeekDayOfMonthRegex;
            ForTheRegex = FrenchDateExtractorConfiguration.ForTheRegex;
            WeekDayAndDayOfMothRegex = FrenchDateExtractorConfiguration.WeekDayAndDayOfMothRegex;
            RelativeMonthRegex = FrenchDateExtractorConfiguration.RelativeMonthRegex;
            YearSuffix = FrenchDateExtractorConfiguration.YearSuffix;
            RelativeWeekDayRegex = FrenchDateExtractorConfiguration.RelativeWeekDayRegex;
            DayOfMonth = config.DayOfMonth;
            DayOfWeek = config.DayOfWeek;
            MonthOfYear = config.MonthOfYear;
            CardinalMap = config.CardinalMap;
            UnitMap = config.UnitMap;
            UtilityConfiguration = config.UtilityConfiguration;
        }

        public int GetSwiftDay(string text)
        {
            var trimmedText = text.Trim().ToLowerInvariant();

            var swift = 0;
            if (trimmedText.Equals("aujourd'hui") || trimmedText.Equals("auj")) //today
            {
                swift = 0;
            }
            else if (trimmedText.Equals("demain") || trimmedText.Equals("a2m1") || 
                     trimmedText.Equals("lendemain") || trimmedText.Equals("jour suivant"))
            {
                swift = 1;
            }
            else if (trimmedText.Equals("hier")) // yesterday
            {
                swift = -1;
            }
            else if (trimmedText.EndsWith("après demain") || // day after tomorrow
                     trimmedText.EndsWith("après-demain"))
            {
                swift = 2;
            }
            else if (trimmedText.StartsWith("avant-hier") || // day before yesterday
                     trimmedText.StartsWith("avant hier"))
            {
                swift = -2;
            }
            else if (trimmedText.EndsWith("dernier")) // dernier
            {
                swift = -1;
            }
            return swift;
        }

        public int GetSwiftMonth(string text)
        {
            var trimmedText = text.Trim().ToLowerInvariant();
            var swift = 0;
            if (trimmedText.EndsWith("prochaine") || trimmedText.EndsWith("prochain"))
            {
                swift = 1;
            }
            else if (trimmedText.Equals("dernière") || trimmedText.Equals("dernières") ||
                    trimmedText.Equals("derniere") || trimmedText.Equals("dernieres"))
            {
                swift = -1;
            }
            return swift;
        }

        public bool IsCardinalLast(string text)
        {
            var trimmedText = text.Trim().ToLowerInvariant();
            return (trimmedText.Equals("dernière") || trimmedText.Equals("dernières") ||
                    trimmedText.Equals("derniere") || trimmedText.Equals("dernieres"));
        }
    }
}
