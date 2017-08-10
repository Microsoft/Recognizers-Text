﻿using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.Recognizers.Text.DateTime.English.Utilities;
using Microsoft.Recognizers.Text.Number;
using Microsoft.Recognizers.Text.Number.English;
using Microsoft.Recognizers.Resources.English;
using Microsoft.Recognizers.Resources;

namespace Microsoft.Recognizers.Text.DateTime.English
{
    public class EnglishCommonDateTimeParserConfiguration : BaseDateParserConfiguration
    {
        public EnglishCommonDateTimeParserConfiguration()
        {
            UtilityConfiguration = new EnlighDatetimeUtilityConfiguration();
            UnitMap = DateTimeDefinitions.UnitMap.ToImmutableDictionary();
            UnitValueMap = DateTimeDefinitions.UnitValueMap.ToImmutableDictionary();
            SeasonMap = DateTimeDefinitions.SeasonMap.ToImmutableDictionary();
            CardinalMap = DateTimeDefinitions.CardinalMap.ToImmutableDictionary();
            DayOfWeek = DateTimeDefinitions.DayOfWeek.ToImmutableDictionary();
            MonthOfYear = DateTimeDefinitions.MonthOfYear.ToImmutableDictionary();
            Numbers = DateTimeDefinitions.Numbers.ToImmutableDictionary();
            DoubleNumbers = DateTimeDefinitions.DoubleNumbers.ToImmutableDictionary();
            CardinalExtractor = new CardinalExtractor();
            IntegerExtractor = new IntegerExtractor();
            OrdinalExtractor = new OrdinalExtractor();
            NumberParser = new BaseNumberParser(new EnglishNumberParserConfiguration());
            DateExtractor = new BaseDateExtractor(new EnglishDateExtractorConfiguration());
            TimeExtractor = new BaseTimeExtractor(new EnglishTimeExtractorConfiguration());
            DateTimeExtractor = new BaseDateTimeExtractor(new EnglishDateTimeExtractorConfiguration());
            DurationExtractor = new BaseDurationExtractor(new EnglishDurationExtractorConfiguration());
            DatePeriodExtractor=new BaseDatePeriodExtractor(new EnglishDatePeriodExtractorConfiguration());
            TimePeriodExtractor = new BaseTimePeriodExtractor(new EnglishTimePeriodExtractorConfiguration());
            DateTimePeriodExtractor = new BaseDateTimePeriodExtractor(new EnglishDateTimePeriodExtractorConfiguration());
            DateParser = new BaseDateParser(new EnglishDateParserConfiguration(this));
            TimeParser = new TimeParser(new EnglishTimeParserConfiguration(this));
            DateTimeParser = new BaseDateTimeParser(new EnglishDateTimeParserConfiguration(this));
            DurationParser = new BaseDurationParser(new EnglishDurationParserConfiguration(this));
            DatePeriodParser = new BaseDatePeriodParser(new EnglishDatePeriodParserConfiguration(this));
            TimePeriodParser = new BaseTimePeriodParser(new EnglishTimePeriodParserConfiguration(this));
            DateTimePeriodParser = new BaseDateTimePeriodParser(new EnglishDateTimePeriodParserConfiguration(this));
        }

        public override IImmutableDictionary<string, int> DayOfMonth => BaseDateTimeDefinitions.DayOfMonthDictionary.ToImmutableDictionary().AddRange(DateTimeDefinitions.DayOfMonth);
    }
}