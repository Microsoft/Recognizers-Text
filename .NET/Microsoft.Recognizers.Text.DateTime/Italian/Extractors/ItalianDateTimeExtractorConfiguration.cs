﻿using System.Text.RegularExpressions;
using Microsoft.Recognizers.Definitions.Italian;
using Microsoft.Recognizers.Text.DateTime.Italian.Utilities;
using Microsoft.Recognizers.Text.DateTime.Utilities;

namespace Microsoft.Recognizers.Text.DateTime.Italian
{
    public class ItalianDateTimeExtractorConfiguration : BaseOptionsConfiguration, IDateTimeExtractorConfiguration
    {
        public static readonly Regex PrepositionRegex =
          new Regex(
            DateTimeDefinitions.PrepositionRegex, // à - time at which, en - length of time, dans - amount of time
            RegexOptions.Singleline);

        public static readonly Regex NowRegex =
            new Regex(
                DateTimeDefinitions.NowRegex, // right now, as soon as possible, recently, previously
                RegexOptions.Singleline);

        public static readonly Regex SuffixRegex =
            new Regex(
                DateTimeDefinitions.SuffixRegex, // in the evening, afternoon, morning, night
                RegexOptions.Singleline);

        public static readonly Regex TimeOfDayRegex =
            new Regex(
                DateTimeDefinitions.TimeOfDayRegex,
                RegexOptions.Singleline);

        public static readonly Regex SpecificTimeOfDayRegex =
            new Regex(
                DateTimeDefinitions.SpecificTimeOfDayRegex,
                RegexOptions.Singleline);

        public static readonly Regex TimeOfTodayAfterRegex =
             new Regex(
                 DateTimeDefinitions.TimeOfTodayAfterRegex,
                 RegexOptions.Singleline);

        public static readonly Regex TimeOfTodayBeforeRegex =
            new Regex(
                DateTimeDefinitions.TimeOfTodayBeforeRegex,
                RegexOptions.Singleline);

        public static readonly Regex SimpleTimeOfTodayAfterRegex =
            new Regex(
                DateTimeDefinitions.SimpleTimeOfTodayAfterRegex,
                RegexOptions.Singleline);

        public static readonly Regex SimpleTimeOfTodayBeforeRegex =
            new Regex(
                DateTimeDefinitions.SimpleTimeOfTodayBeforeRegex,
                RegexOptions.Singleline);

        public static readonly Regex SpecificEndOfRegex =
            new Regex(
                DateTimeDefinitions.SpecificEndOfRegex,
                RegexOptions.Singleline);

        public static readonly Regex UnspecificEndOfRegex =
            new Regex(
                DateTimeDefinitions.UnspecificEndOfRegex,
                RegexOptions.Singleline);

        public static readonly Regex UnitRegex =
            new Regex(
                DateTimeDefinitions.TimeUnitRegex,
                RegexOptions.Singleline);

        public static readonly Regex NumberAsTimeRegex =
            new Regex(
                DateTimeDefinitions.NumberAsTimeRegex,
                RegexOptions.Singleline);

        public static readonly Regex DateNumberConnectorRegex = new Regex(
            DateTimeDefinitions.DateNumberConnectorRegex,
            RegexOptions.Singleline);

        public ItalianDateTimeExtractorConfiguration(IOptionsConfiguration config)
            : base(config)
        {
            IntegerExtractor = Number.Italian.IntegerExtractor.GetInstance();
            DatePointExtractor = new BaseDateExtractor(new ItalianDateExtractorConfiguration(this));
            TimePointExtractor = new BaseTimeExtractor(new ItalianTimeExtractorConfiguration(this));
            DurationExtractor = new BaseDurationExtractor(new ItalianDurationExtractorConfiguration(this));
            UtilityConfiguration = new ItalianDatetimeUtilityConfiguration();
        }

        public IExtractor IntegerExtractor { get; }

        public IDateExtractor DatePointExtractor { get; }

        public IDateTimeExtractor TimePointExtractor { get; }

        public IDateTimeUtilityConfiguration UtilityConfiguration { get; }

        Regex IDateTimeExtractorConfiguration.NowRegex => NowRegex;

        Regex IDateTimeExtractorConfiguration.SuffixRegex => SuffixRegex;

        Regex IDateTimeExtractorConfiguration.TimeOfTodayAfterRegex => TimeOfTodayAfterRegex;

        Regex IDateTimeExtractorConfiguration.SimpleTimeOfTodayAfterRegex => SimpleTimeOfTodayAfterRegex;

        Regex IDateTimeExtractorConfiguration.TimeOfTodayBeforeRegex => TimeOfTodayBeforeRegex;

        Regex IDateTimeExtractorConfiguration.SimpleTimeOfTodayBeforeRegex => SimpleTimeOfTodayBeforeRegex;

        Regex IDateTimeExtractorConfiguration.TimeOfDayRegex => TimeOfDayRegex;

        Regex IDateTimeExtractorConfiguration.SpecificEndOfRegex => SpecificEndOfRegex;

        Regex IDateTimeExtractorConfiguration.UnspecificEndOfRegex => UnspecificEndOfRegex;

        Regex IDateTimeExtractorConfiguration.UnitRegex => UnitRegex;

        Regex IDateTimeExtractorConfiguration.NumberAsTimeRegex => NumberAsTimeRegex;

        Regex IDateTimeExtractorConfiguration.DateNumberConnectorRegex => DateNumberConnectorRegex;

        public IDateTimeExtractor DurationExtractor { get; }

        public bool IsConnector(string text)
        {
            return string.IsNullOrEmpty(text) || text.Equals(",") ||
                        PrepositionRegex.IsMatch(text) || text.Equals("t") || text.Equals("pour") ||
                        text.Equals("vers");
        }
    }
}
