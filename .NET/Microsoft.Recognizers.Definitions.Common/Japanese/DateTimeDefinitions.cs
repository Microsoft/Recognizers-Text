﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Japanese\Japanese-DateTime.yaml
//     - Language: Japanese
//     - ClassName: DateTimeDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Japanese
{
    using System;
    using System.Collections.Generic;

    public static class DateTimeDefinitions
    {
      public const string MonthRegex = @"(?<month>正月|一月|二月|三月|四月|五月|六月|七月|八月|九月|十月|十一月|十二月|01月|02月|03月|04月|05月|06月|07月|08月|09月|10月|11月|12月|1月|2月|3月|4月|5月|6月|7月|8月|9月)";
      public const string MonthRegexForPeriod = @"(?<month>正月|一月|二月|三月|四月|五月|六月|七月|八月|九月|十月|十一月|十二月|01月|02月|03月|04月|05月|06月|07月|08月|09月|10月|11月|12月|1月|2月|3月|4月|5月|6月|7月|8月|9月)(?=\b|t|まで|から)?";
      public const string MonthNumRegexForPeriod = @"(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)(?=\b|t|まで|から)?";
      public const string DayRegex = @"(?<day>01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|1|2|3|4|5|6|7|8|9)日?";
      public const string DayRegexForPeriod = @"(?<day>01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|1|20|21|22|23|24|25|26|27|28|29|2|30|31|3|4|5|6|7|8|9)日?(?=\b|t|まで|から)?";
      public const string DateDayRegexInJapanese = @"(?<day>初一|三十|一日|十一日|二十一日|三十一日|二日|三日|四日|五日|六日|七日|八日|九日|十二日|十三日|十四日|十五日|十六日|十七日|十八日|十九日|二十二日|二十三日|二十四日|二十五日|二十六日|二十七日|二十八日|二十九日|一日|十一日|十日|二十一日|二十日|三十一日|三十日|二日|三日|四日|五日|六日|七日|八日|九日|十二日|十三日|十四日|十五日|十六日|十七日|十八日|十九日|二十二日|二十三日|二十四日|二十五日|二十六日|二十七日|二十八日|二十九日|十日|二十日|三十日|10日|11日|12日|13日|14日|15日|16日|17日|18日|19日|1日|20日|21日|22日|23日|24日|25日|26日|27日|28日|29日|2日|30日|31日|3日|4日|5日|6日|7日|8日|9日|一号|十一号|二十一号|三十一号|二号|三号|四号|五号|六号|七号|八号|九号|十二号|十三号|十四号|十五号|十六号|十七号|十八号|十九号|二十二号|二十三号|二十四号|二十五号|二十六号|二十七号|二十八号|二十九号|一号|十一号|十号|二十一号|二十号|三十一号|三十号|二号|三号|四号|五号|六号|七号|八号|九号|十二号|十三号|十四号|十五号|十六号|十七号|十八号|十九号|二十二号|二十三号|二十四号|二十五号|二十六号|二十七号|二十八号|二十九号|十号|二十号|三十号|10号|11号|12号|13号|14号|15号|16号|17号|18号|19号|1号|20号|21号|22号|23号|24号|25号|26号|27号|28号|29号|2号|30号|31号|3号|4号|5号|6号|7号|8号|9号)";
      public const string DayRegexNumInJapanese = @"(?<day>一|十一|二十一|三十一|二|三|四|五|六|七|八|九|十二|十三|十四|十五|十六|十七|十八|十九|二十二|二十三|二十四|二十五|二十六|二十七|二十八|二十九|一|十一|十|二十一|二十|三十一|三十|二|三|四|五|六|七|八|九|十二|十三|十四|十五|十六|十七|十八|十九|二十二|二十三|二十四|二十五|二十六|二十七|二十八|二十九|十|二十|廿|卅)";
      public const string MonthNumRegex = @"(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)";
      public const string TwoNumYear = @"50";
      public const string YearNumRegex = @"(?<year>((1[5-9]|20)\d{2})|2100)年?";
      public const string YearRegex = @"(?<year>(\d{2,4}))年?";
      public const string ZeroToNineIntegerRegexJap = @"[一二三四五六七八九零壹贰叁肆伍陆柒捌玖〇两千俩倆仨]";
      public static readonly string DateYearInJapaneseRegex = $@"(?<yearJap>({ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}|{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}|{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}))";
      public const string WeekDayRegex = @"(?<weekday>日曜日?|月曜日?|火曜日?|水曜日?|木曜日?|金曜日?|土曜日?)\s?";
      public const string LunarRegex = @"(农历|初一|正月|大年)";
      public static readonly string DateThisRegex = $@"(这个|这一个|这|这一|本){WeekDayRegex}";
      public static readonly string DateLastRegex = $@"(上一个|上个|上一|上|最后一个|最后)(的)?{WeekDayRegex}";
      public static readonly string DateNextRegex = $@"(下一个|下个|下一|下)(的)?{WeekDayRegex}";
      public const string SpecialMonthRegex = @"(先月|来月|今月|前月|再来月|昨月|先々月)";
      public const string SpecialYearRegex = @"(昨年|来年|今年|前年|ことし|らいねん)";
      public const string SpecialDayRegex = @"(最近|前天|后天|昨天|明天|今天|今日|明日|昨日|大后天|大前天|後天|大後天|きょう|あす|あした|きのう|明後日|一昨日|この日|前日|二日前|おととい|あさって)";
      public const string SpecialDayWithNumRegex = @"^[.]";
      public static readonly string WeekDayOfMonthRegex = $@"((({MonthRegex}|{MonthNumRegex})的\s*)(?<cardinal>第一个|第二个|第三个|第四个|第五个|最后一个)\s*{WeekDayRegex})";
      public const string DateThisRe = @"这个|这一个|这|这一|本|今";
      public const string DateLastRe = @"上个|上一个|上|上一|去";
      public const string DateNextRe = @"下个|下一个|下|下一|明";
      public static readonly string RelativeRegex = $@"(?<order>({DateThisRe}|{DateLastRe}|{DateNextRe}))";
      public static readonly string SpecialDate = $@"(?<thisyear>({DateThisRe}|{DateLastRe}|{DateNextRe})年)?(?<thismonth>({DateThisRe}|{DateLastRe}|{DateNextRe})月)?{DateDayRegexInJapanese}";
      public const string DateUnitRegex = @"(?<unit>年|个月|周|日|天)";
      public const string BeforeRegex = @"以前|之前|前";
      public const string AfterRegex = @"以后|以後|之后|之後|后|後";
      public static readonly string DateRegexList1 = $@"({YearRegex}[/\\\-]?{MonthRegex}[/\\\-]?{DayRegexForPeriod}\s*({WeekDayRegex})?)";
      public static readonly string DateRegexList2 = $@"({YearRegex}{MonthRegexForPeriod}\s*)";
      public static readonly string DateRegexList3 = $@"((({YearRegex}|{DateYearInJapaneseRegex})年)(\s*))?({LunarRegex}(\s*))?{MonthRegex}(\s*)({DateDayRegexInJapanese}|{DayRegex})((\s*|,|，){WeekDayRegex})?({BeforeRegex}|{AfterRegex})?";
      public static readonly string DateRegexList4 = $@"{MonthNumRegex}\s*/\s*{DayRegex}((\s+|\s*,\s*){YearRegex})?";
      public static readonly string DateRegexList5 = $@"{DayRegex}\s*/\s*{MonthNumRegex}((\s+|\s*,\s*){YearRegex})?";
      public static readonly string DateRegexList6 = $@"{MonthNumRegex}\s*[/\\\-]\s*{DayRegex}\s*[/\\\-]\s*{YearRegex}";
      public static readonly string DateRegexList7 = $@"{DayRegex}\s*[/\\\-\.]\s*{MonthNumRegex}\s*[/\\\-\.]\s*{YearNumRegex}";
      public static readonly string DateRegexList8 = $@"{YearNumRegex}\s*[/\\\-\. ]\s*{MonthNumRegex}\s*[/\\\-\. ]\s*{DayRegexForPeriod}";
      public static readonly string DateRegexList9 = $@"(\s*{MonthRegex}[/\\\-]?{DayRegexForPeriod}\s*({WeekDayRegex})?)";
      public static readonly string DateRegexList10 = $@"({YearRegex}[/\\\-]{MonthNumRegex}[/\\\-]{DayRegexForPeriod})";
      public static readonly string DateRegexList11 = $@"({YearRegex}[/\\\-]{MonthNumRegexForPeriod})";
      public const string DatePeriodTillRegex = @"(?<till>到|至|--|-|—|——|~|–)";
      public const string DatePeriodTillSuffixRequiredRegex = @"(?<till>与|和)";
      public const string DatePeriodDayRegexInJapanese = @"(?<day>初一|三十|一日|十一日|二十一日|三十一日|二日|三日|四日|五日|六日|七日|八日|九日|十二日|十三日|十四日|十五日|十六日|十七日|十八日|十九日|二十二日|二十三日|二十四日|二十五日|二十六日|二十七日|二十八日|二十九日|一日|十一日|十日|二十一日|二十日|三十一日|三十日|二日|三日|四日|五日|六日|七日|八日|九日|十二日|十三日|十四日|十五日|十六日|十七日|十八日|十九日|二十二日|二十三日|二十四日|二十五日|二十六日|二十七日|二十八日|二十九日|十日|二十日|三十日|10日|11日|12日|13日|14日|15日|16日|17日|18日|19日|1日|20日|21日|22日|23日|24日|25日|26日|27日|28日|29日|2日|30日|31日|3日|4日|5日|6日|7日|8日|9日|一号|十一号|二十一号|三十一号|二号|三号|四号|五号|六号|七号|八号|九号|十二号|十三号|十四号|十五号|十六号|十七号|十八号|十九号|二十二号|二十三号|二十四号|二十五号|二十六号|二十七号|二十八号|二十九号|一号|十一号|十号|二十一号|二十号|三十一号|三十号|二号|三号|四号|五号|六号|七号|八号|九号|十二号|十三号|十四号|十五号|十六号|十七号|十八号|十九号|二十二号|二十三号|二十四号|二十五号|二十六号|二十七号|二十八号|二十九号|十号|二十号|三十号|10号|11号|12号|13号|14号|15号|16号|17号|18号|19号|1号|20号|21号|22号|23号|24号|25号|26号|27号|28号|29号|2号|30号|31号|3号|4号|5号|6号|7号|8号|9号|一|十一|二十一|三十一|二|三|四|五|六|七|八|九|十二|十三|十四|十五|十六|十七|十八|十九|二十二|二十三|二十四|二十五|二十六|二十七|二十八|二十九|一|十一|十|二十一|二十|三十一|三十|二|三|四|五|六|七|八|九|十二|十三|十四|十五|十六|十七|十八|十九|二十二|二十三|二十四|二十五|二十六|二十七|二十八|二十九|十|二十|三十||廿|卅)";
      public const string DatePeriodThisRegex = @"这个|这一个|这|这一|本";
      public const string DatePeriodLastRegex = @"上个|上一个|上|上一";
      public const string DatePeriodNextRegex = @"下个|下一个|下|下一";
      public static readonly string RelativeMonthRegex = $@"(?<relmonth>({DatePeriodThisRegex}|{DatePeriodLastRegex}|{DatePeriodNextRegex})\s*月)";
      public static readonly string DatePeriodYearRegex = $@"(({YearNumRegex})(\s*年)?|({YearRegex})\s*年)(?=[\u4E00-\u9FFF]|\s|$|\W)";
      public static readonly string StrictYearRegex = $@"{DatePeriodYearRegex}";
      public const string YearRegexInNumber = @"(?<year>(\d{3,4}))";
      public static readonly string DatePeriodYearInJapaneseRegex = $@"(?<yearJap>({ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}|{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}|{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}{ZeroToNineIntegerRegexJap}))年";
      public static readonly string MonthSuffixRegex = $@"(?<msuf>({RelativeMonthRegex}|{MonthRegex}))";
      public static readonly string SimpleCasesRegex = $@"((从)\s*)?(({DatePeriodYearRegex}|{DatePeriodYearInJapaneseRegex})\s*)?{MonthSuffixRegex}({DatePeriodDayRegexInJapanese}|{DayRegex})\s*{DatePeriodTillRegex}\s*({DatePeriodDayRegexInJapanese}|{DayRegex})((\s+|\s*,\s*){DatePeriodYearRegex})?";
      public static readonly string YearAndMonth = $@"({YearNumRegex}{MonthRegex}(\b|から)$)";
      public static readonly string SimpleYearAndMonth = $@"({YearNumRegex}[/\\\-]{MonthNumRegex}(\b|から)$)";
      public static readonly string PureNumYearAndMonth = $@"({YearRegexInNumber}\s*[-\.\/]\s*{MonthNumRegex})|({MonthNumRegex}\s*\/\s*{YearRegexInNumber})";
      public static readonly string OneWordPeriodRegex = $@"(((明年|今年|去年)\s*)?{MonthRegex}|({DatePeriodThisRegex}|{DatePeriodLastRegex}|{DatePeriodNextRegex})\s*(周末|周|月|年)|周末|今年|明年|去年|前年|后年)";
      public static readonly string WeekOfMonthRegex = $@"(?<wom>{MonthSuffixRegex}的(?<cardinal>第一|第二|第三|第四|第五|最后一)\s*周\s*)";
      public const string UnitRegex = @"(?<unit>年|(个)?月|周|日|天)";
      public static readonly string FollowedUnit = $@"^\s*{UnitRegex}";
      public static readonly string NumberCombinedWithUnit = $@"(?<num>\d+(\.\d*)?){UnitRegex}";
      public static readonly string YearMonthDayRange = $@"({YearNumRegex}[/\\\-]?({MonthRegex}|{MonthNumRegex})[/\\\-]?{DayRegexForPeriod}から{YearNumRegex}[/\\\-]?({MonthRegex}|{MonthNumRegex})[/\\\-]?{DayRegexForPeriod}まで)";
      public static readonly string YearMonthRange = $@"({YearNumRegex}[/\\\-]?({MonthRegex}|{MonthNumRegex})から{YearNumRegex}[/\\\-]?({MonthRegex}|{MonthNumRegex})まで)";
      public static readonly string MonthDayRange = $@"(({MonthRegex}|{MonthNumRegex})[/\\\-]?{DayRegexForPeriod}から({MonthRegex}|{MonthNumRegex})[/\\\-]?{DayRegexForPeriod}まで)";
      public static readonly string YearToYear = $@"({YearNumRegex}から{YearNumRegex}まで)";
      public static readonly string MonthToMonth = $@"({MonthRegex}から{MonthRegex}まで)";
      public static readonly string DayToDay = $@"({DayRegex}から{DayRegex}まで)";
      public const string PastRegex = @"(?<past>(前|上|之前|近|过去))";
      public const string FutureRegex = @"(?<future>(后|後|(?<![一两几]\s*)下|之后|之後|未来(的)?))";
      public const string SeasonRegex = @"(?<season>春|夏|秋|冬)(天|季)?";
      public static readonly string SeasonWithYear = $@"(({DatePeriodYearRegex}|{DatePeriodYearInJapaneseRegex}|(?<yearrel>明年|今年|去年))(的)?)?{SeasonRegex}";
      public static readonly string QuarterRegex = $@"(({DatePeriodYearRegex}|{DatePeriodYearInJapaneseRegex}|(?<yearrel>明年|今年|去年))(的)?)?(第(?<cardinal>1|2|3|4|一|二|三|四)季度)";
      public const string CenturyRegex = @"(?<century>\d|1\d|2\d)世纪";
      public const string CenturyRegexInJapanese = @"(?<century>一|二|三|四|五|六|七|八|九|十|十一|十二|十三|十四|十五|十六|十七|十八|十九|二十|二十一|二十二)世纪";
      public static readonly string RelativeCenturyRegex = $@"(?<relcentury>({DatePeriodLastRegex}|{DatePeriodThisRegex}|{DatePeriodNextRegex}))世纪";
      public const string DecadeRegexInJapanese = @"(?<decade>十|一十|二十|三十|四十|五十|六十|七十|八十|九十)";
      public static readonly string DecadeRegex = $@"(?<centurysuf>({CenturyRegex}|{CenturyRegexInJapanese}|{RelativeCenturyRegex}))?(?<decade>(\d0|{DecadeRegexInJapanese}))年代";
      public const string PrepositionRegex = @"(?<prep>^的|在$)";
      public const string NowRegex = @"(?<now>现在|马上|立刻|刚刚才|刚刚|刚才)";
      public const string NightRegex = @"(?<night>早|晚)";
      public const string TimeOfTodayRegex = @"(今晚|今早|今晨|明晚|明早|明晨|昨晚)(的|在)?";
      public const string DateTimePeriodTillRegex = @"(?<till>到|直到|--|-|—|——)";
      public const string DateTimePeriodPrepositionRegex = @"(?<prep>^\s*的|在\s*$)";
      public static readonly string HourRegex = $@"\b{BaseDateTime.HourRegex}";
      public const string HourNumRegex = @"(?<hour>[零〇一二两三四五六七八九]|二十[一二三四]?|十[一二三四五六七八九]?)";
      public const string ZhijianRegex = @"^\s*(之间|之内|期间|中间|间)";
      public const string DateTimePeriodThisRegex = @"这个|这一个|这|这一";
      public const string DateTimePeriodLastRegex = @"上个|上一个|上|上一";
      public const string DateTimePeriodNextRegex = @"下个|下一个|下|下一";
      public const string AmPmDescRegex = @"(?<daydesc>(am|a\.m\.|a m|a\. m\.|a\.m|a\. m|a m|pm|p\.m\.|p m|p\. m\.|p\.m|p\. m|p m))";
      public const string TimeOfDayRegex = @"(?<timeOfDay>凌晨|清晨|早上|早|上午|中午|下午|午后|晚上|夜里|夜晚|半夜|夜间|深夜|傍晚|晚)";
      public static readonly string SpecificTimeOfDayRegex = $@"((({DateTimePeriodThisRegex}|{DateTimePeriodNextRegex}|{DateTimePeriodLastRegex})\s+{TimeOfDayRegex})|(今晚|今早|今晨|明晚|明早|明晨|昨晚))";
      public const string DateTimePeriodUnitRegex = @"(个)?(?<unit>(小时|分钟|秒钟|时|分|秒))";
      public static readonly string DateTimePeriodFollowedUnit = $@"^\s*{DateTimePeriodUnitRegex}";
      public static readonly string DateTimePeriodNumberCombinedWithUnit = $@"\b(?<num>\d+(\.\d*)?){DateTimePeriodUnitRegex}";
      public const string DurationYearRegex = @"((\d{3,4})|0\d|两千)\s*年";
      public const string DurationHalfSuffixRegex = @"半";
      public static readonly Dictionary<string, string> DurationSuffixList = new Dictionary<string, string>
        {
            { @"M", @"分钟" },
            { @"S", @"秒钟|秒" },
            { @"H", @"个小时|小时" },
            { @"D", @"天" },
            { @"W", @"星期|个星期|周" },
            { @"Mon", @"个月" },
            { @"Y", @"年" }
        };
      public static readonly IList<string> DurationAmbiguousUnits = new List<string>
        {
            @"分钟",
            @"秒钟",
            @"秒",
            @"个小时",
            @"小时",
            @"天",
            @"星期",
            @"个星期",
            @"周",
            @"个月",
            @"年"
        };
      public static readonly string LunarHolidayRegex = $@"(({DatePeriodYearRegex}|{DatePeriodYearInJapaneseRegex}|(?<yearrel>明年|今年|去年))(的)?)?(?<holiday>除夕|春节|中秋节|中秋|元宵节|端午节|端午|重阳节)";
      public static readonly string HolidayRegexList1 = $@"(({DatePeriodYearRegex}|{DatePeriodYearInJapaneseRegex}|(?<yearrel>明年|今年|去年))(的)?)?(?<holiday>新年|五一|劳动节|元旦节|元旦|愚人节|圣诞节|植树节|国庆节|情人节|教师节|儿童节|妇女节|青年节|建军节|女生节|光棍节|双十一|清明节|清明)";
      public static readonly string HolidayRegexList2 = $@"(({DatePeriodYearRegex}|{DatePeriodYearInJapaneseRegex}|(?<yearrel>明年|今年|去年))(的)?)?(?<holiday>母亲节|父亲节|感恩节|万圣节)";
      public const string SetUnitRegex = @"(?<unit>年|月|周|星期|日|天|小时|时|分钟|分|秒钟|秒)";
      public static readonly string SetEachUnitRegex = $@"(?<each>(每个|每一|每)\s*{SetUnitRegex})";
      public const string SetEachPrefixRegex = @"(?<each>(每)\s*$)";
      public const string SetLastRegex = @"(?<last>last|this|next)";
      public const string SetEachDayRegex = @"(每|每一)(天|日)\s*$";
      public const string TimeHourNumRegex = @"(00|01|02|03|04|05|06|07|08|09|0|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|1|2|3|4|5|6|7|8|9)";
      public const string TimeMinuteNumRegex = @"(00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)";
      public const string TimeSecondNumRegex = @"(00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)";
      public const string TimeHourJapRegex = @"([零〇一二两三四五六七八九]|二十[一二三四]?|十[一二三四五六七八九]?)";
      public const string TimeMinuteJapRegex = @"([二三四五]?十[一二三四五六七八九]?|六十|[零〇一二三四五六七八九])";
      public static readonly string TimeSecondJapRegex = $@"{TimeMinuteJapRegex}";
      public const string TimeClockDescRegex = @"(点\s*整|点\s*钟|点|时)";
      public const string TimeMinuteDescRegex = @"(分钟|分|)";
      public const string TimeSecondDescRegex = @"(秒钟|秒)";
      public const string TimeBanHourPrefixRegex = @"(第)";
      public static readonly string TimeHourRegex = $@"(?<!{TimeBanHourPrefixRegex})(?<hour>{TimeHourJapRegex}|{TimeHourNumRegex}){TimeClockDescRegex}";
      public static readonly string TimeMinuteRegex = $@"(?<min>{TimeMinuteJapRegex}|{TimeMinuteNumRegex}){TimeMinuteDescRegex}";
      public static readonly string TimeSecondRegex = $@"(?<sec>{TimeSecondJapRegex}|{TimeSecondNumRegex}){TimeSecondDescRegex}";
      public const string TimeHalfRegex = @"(?<half>过半|半)";
      public const string TimeQuarterRegex = @"(?<quarter>[一两二三四1-4])\s*(刻钟|刻)";
      public static readonly string TimeJapaneseTimeRegex = $@"{TimeHourRegex}({TimeQuarterRegex}|{TimeHalfRegex}|((过|又)?{TimeMinuteRegex})({TimeSecondRegex})?)?";
      public static readonly string TimeDigitTimeRegex = $@"(?<hour>{TimeHourNumRegex}):(?<min>{TimeMinuteNumRegex})(:(?<sec>{TimeSecondNumRegex}))?";
      public const string TimeDayDescRegex = @"(?<daydesc>凌晨|清晨|早上|早|上午|中午|下午|午后|晚上|夜里|夜晚|半夜|午夜|夜间|深夜|傍晚|晚)";
      public const string TimeApproximateDescPreffixRegex = @"(大[约概]|差不多|可能|也许|约|不超过|不多[于过]|最[多长少]|少于|[超短长多]过|几乎要|将近|差点|快要|接近|至少|起码|超出|不到)";
      public const string TimeApproximateDescSuffixRegex = @"(之前|以前|以后|以後|之后|之後|前|后|後|左右)";
      public static readonly string TimeRegexes1 = $@"{TimeApproximateDescPreffixRegex}?{TimeDayDescRegex}?{TimeJapaneseTimeRegex}{TimeApproximateDescSuffixRegex}?";
      public static readonly string TimeRegexes2 = $@"{TimeApproximateDescPreffixRegex}?{TimeDayDescRegex}?{TimeDigitTimeRegex}{TimeApproximateDescSuffixRegex}?(\s*{AmPmDescRegex}?)";
      public static readonly string TimeRegexes3 = $@"差{TimeMinuteRegex}{TimeJapaneseTimeRegex}";
      public const string TimePeriodTimePeriodConnectWords = @"(起|至|到|–|-|—|~|～)";
      public static readonly string TimePeriodLeftJapTimeRegex = $@"(从)?(?<left>{TimeDayDescRegex}?({TimeJapaneseTimeRegex}))";
      public static readonly string TimePeriodRightJapTimeRegex = $@"{TimePeriodTimePeriodConnectWords}(?<right>{TimeDayDescRegex}?{TimeJapaneseTimeRegex})(之间)?";
      public static readonly string TimePeriodLeftDigitTimeRegex = $@"(从)?(?<left>{TimeDayDescRegex}?({TimeDigitTimeRegex}))";
      public static readonly string TimePeriodRightDigitTimeRegex = $@"{TimePeriodTimePeriodConnectWords}(?<right>{TimeDayDescRegex}?{TimeDigitTimeRegex})(之间)?";
      public static readonly string TimePeriodShortLeftJapTimeRegex = $@"(从)?(?<left>{TimeDayDescRegex}?({TimeHourJapRegex}))";
      public static readonly string TimePeriodShortLeftDigitTimeRegex = $@"(从)?(?<left>{TimeDayDescRegex}?({TimeHourNumRegex}))";
      public static readonly string TimePeriodRegexes1 = $@"({TimePeriodLeftDigitTimeRegex}{TimePeriodRightDigitTimeRegex}|{TimePeriodLeftJapTimeRegex}{TimePeriodRightJapTimeRegex})";
      public static readonly string TimePeriodRegexes2 = $@"({TimePeriodShortLeftDigitTimeRegex}{TimePeriodRightDigitTimeRegex}|{TimePeriodShortLeftJapTimeRegex}{TimePeriodRightJapTimeRegex})";
      public const string ParserConfigurationBefore = @"(之前|以前|前)";
      public const string ParserConfigurationAfter = @"(之后|之後|以后|以後|后|後)";
      public const string ParserConfigurationUntil = @"(直到|直至|截至|截止(到)?)";
      public const string ParserConfigurationSincePrefix = @"(自从|自|自打|打)";
      public const string ParserConfigurationSinceSuffix = @"(以来|开始)";
      public const string ParserConfigurationLastWeekDayToken = @"最后一个";
      public const string ParserConfigurationNextMonthToken = @"下一个";
      public const string ParserConfigurationLastMonthToken = @"上一个";
      public const string ParserConfigurationDatePrefix = @" ";
      public static readonly Dictionary<string, string> ParserConfigurationUnitMap = new Dictionary<string, string>
        {
            { @"年", @"Y" },
            { @"月", @"MON" },
            { @"个月", @"MON" },
            { @"日", @"D" },
            { @"周", @"W" },
            { @"天", @"D" },
            { @"小时", @"H" },
            { @"时", @"H" },
            { @"分钟", @"M" },
            { @"分", @"M" },
            { @"秒钟", @"S" },
            { @"秒", @"S" },
            { @"星期", @"W" }
        };
      public static readonly Dictionary<string, long> ParserConfigurationUnitValueMap = new Dictionary<string, long>
        {
            { @"years", 31536000 },
            { @"year", 31536000 },
            { @"months", 2592000 },
            { @"month", 2592000 },
            { @"weeks", 604800 },
            { @"week", 604800 },
            { @"days", 86400 },
            { @"day", 86400 },
            { @"hours", 3600 },
            { @"hour", 3600 },
            { @"hrs", 3600 },
            { @"hr", 3600 },
            { @"h", 3600 },
            { @"minutes", 60 },
            { @"minute", 60 },
            { @"mins", 60 },
            { @"min", 60 },
            { @"seconds", 1 },
            { @"second", 1 },
            { @"secs", 1 },
            { @"sec", 1 }
        };
      public static readonly Dictionary<string, string> ParserConfigurationSeasonMap = new Dictionary<string, string>
        {
            { @"春", @"SP" },
            { @"夏", @"SU" },
            { @"秋", @"FA" },
            { @"冬", @"WI" }
        };
      public static readonly Dictionary<string, int> ParserConfigurationSeasonValueMap = new Dictionary<string, int>
        {
            { @"SP", 3 },
            { @"SU", 6 },
            { @"FA", 9 },
            { @"WI", 12 }
        };
      public static readonly Dictionary<string, int> ParserConfigurationCardinalMap = new Dictionary<string, int>
        {
            { @"一", 1 },
            { @"二", 2 },
            { @"三", 3 },
            { @"四", 4 },
            { @"五", 5 },
            { @"1", 1 },
            { @"2", 2 },
            { @"3", 3 },
            { @"4", 4 },
            { @"5", 5 },
            { @"第一个", 1 },
            { @"第二个", 2 },
            { @"第三个", 3 },
            { @"第四个", 4 },
            { @"第五个", 5 },
            { @"第一", 1 },
            { @"第二", 2 },
            { @"第三", 3 },
            { @"第四", 4 },
            { @"第五", 5 }
        };
      public static readonly Dictionary<string, int> ParserConfigurationDayOfMonth = new Dictionary<string, int>
        {
            { @"01", 1 },
            { @"02", 2 },
            { @"03", 3 },
            { @"04", 4 },
            { @"05", 5 },
            { @"06", 6 },
            { @"07", 7 },
            { @"08", 8 },
            { @"09", 9 },
            { @"1", 1 },
            { @"2", 2 },
            { @"3", 3 },
            { @"4", 4 },
            { @"5", 5 },
            { @"6", 6 },
            { @"7", 7 },
            { @"8", 8 },
            { @"9", 9 },
            { @"10", 10 },
            { @"11", 11 },
            { @"12", 12 },
            { @"13", 13 },
            { @"14", 14 },
            { @"15", 15 },
            { @"16", 16 },
            { @"17", 17 },
            { @"18", 18 },
            { @"19", 19 },
            { @"20", 20 },
            { @"21", 21 },
            { @"22", 22 },
            { @"23", 23 },
            { @"24", 24 },
            { @"25", 25 },
            { @"26", 26 },
            { @"27", 27 },
            { @"28", 28 },
            { @"29", 29 },
            { @"30", 30 },
            { @"31", 31 },
            { @"1日", 1 },
            { @"2日", 2 },
            { @"3日", 3 },
            { @"4日", 4 },
            { @"5日", 5 },
            { @"6日", 6 },
            { @"7日", 7 },
            { @"8日", 8 },
            { @"9日", 9 },
            { @"10日", 10 },
            { @"11日", 11 },
            { @"12日", 12 },
            { @"13日", 13 },
            { @"14日", 14 },
            { @"15日", 15 },
            { @"16日", 16 },
            { @"17日", 17 },
            { @"18日", 18 },
            { @"19日", 19 },
            { @"20日", 20 },
            { @"21日", 21 },
            { @"22日", 22 },
            { @"23日", 23 },
            { @"24日", 24 },
            { @"25日", 25 },
            { @"26日", 26 },
            { @"27日", 27 },
            { @"28日", 28 },
            { @"29日", 29 },
            { @"30日", 30 },
            { @"31日", 31 },
            { @"一日", 1 },
            { @"十一日", 11 },
            { @"二十日", 20 },
            { @"十日", 10 },
            { @"二十一日", 21 },
            { @"三十一日", 31 },
            { @"二日", 2 },
            { @"三日", 3 },
            { @"四日", 4 },
            { @"五日", 5 },
            { @"六日", 6 },
            { @"七日", 7 },
            { @"八日", 8 },
            { @"九日", 9 },
            { @"十二日", 12 },
            { @"十三日", 13 },
            { @"十四日", 14 },
            { @"十五日", 15 },
            { @"十六日", 16 },
            { @"十七日", 17 },
            { @"十八日", 18 },
            { @"十九日", 19 },
            { @"二十二日", 22 },
            { @"二十三日", 23 },
            { @"二十四日", 24 },
            { @"二十五日", 25 },
            { @"二十六日", 26 },
            { @"二十七日", 27 },
            { @"二十八日", 28 },
            { @"二十九日", 29 },
            { @"三十日", 30 }
        };
      public static readonly Dictionary<string, int> ParserConfigurationDayOfWeek = new Dictionary<string, int>
        {
            { @"月曜", 1 },
            { @"火曜", 2 },
            { @"水曜", 3 },
            { @"木曜", 4 },
            { @"金曜", 5 },
            { @"土曜", 6 },
            { @"日曜", 0 },
            { @"月曜日", 1 },
            { @"火曜日", 2 },
            { @"水曜日", 3 },
            { @"木曜日", 4 },
            { @"金曜日", 5 },
            { @"土曜日", 6 },
            { @"日曜日", 0 }
        };
      public static readonly Dictionary<string, int> ParserConfigurationMonthOfYear = new Dictionary<string, int>
        {
            { @"1", 1 },
            { @"2", 2 },
            { @"3", 3 },
            { @"4", 4 },
            { @"5", 5 },
            { @"6", 6 },
            { @"7", 7 },
            { @"8", 8 },
            { @"9", 9 },
            { @"10", 10 },
            { @"11", 11 },
            { @"12", 12 },
            { @"01", 1 },
            { @"02", 2 },
            { @"03", 3 },
            { @"04", 4 },
            { @"05", 5 },
            { @"06", 6 },
            { @"07", 7 },
            { @"08", 8 },
            { @"09", 9 },
            { @"一月", 1 },
            { @"二月", 2 },
            { @"三月", 3 },
            { @"四月", 4 },
            { @"五月", 5 },
            { @"六月", 6 },
            { @"七月", 7 },
            { @"八月", 8 },
            { @"九月", 9 },
            { @"十月", 10 },
            { @"十一月", 11 },
            { @"十二月", 12 },
            { @"1月", 1 },
            { @"2月", 2 },
            { @"3月", 3 },
            { @"4月", 4 },
            { @"5月", 5 },
            { @"6月", 6 },
            { @"7月", 7 },
            { @"8月", 8 },
            { @"9月", 9 },
            { @"10月", 10 },
            { @"11月", 11 },
            { @"12月", 12 },
            { @"01月", 1 },
            { @"02月", 2 },
            { @"03月", 3 },
            { @"04月", 4 },
            { @"05月", 5 },
            { @"06月", 6 },
            { @"07月", 7 },
            { @"08月", 8 },
            { @"09月", 9 }
        };
      public const string DateTimeSimpleAmRegex = @"(?<am>早|晨)";
      public const string DateTimeSimplePmRegex = @"(?<pm>晚)";
      public const string DateTimePeriodMORegex = @"(凌晨|清晨|早上|早|上午)";
      public const string DateTimePeriodAFRegex = @"(中午|下午|午后|傍晚)";
      public const string DateTimePeriodEVRegex = @"(晚上|夜里|夜晚|晚)";
      public const string DateTimePeriodNIRegex = @"(半夜|夜间|深夜)";
      public static readonly Dictionary<string, int> DurationUnitValueMap = new Dictionary<string, int>
        {
            { @"Y", 31536000 },
            { @"Mon", 2592000 },
            { @"W", 604800 },
            { @"D", 86400 },
            { @"H", 3600 },
            { @"M", 60 },
            { @"S", 1 }
        };
      public static readonly Dictionary<string, string> HolidayNoFixedTimex = new Dictionary<string, string>
        {
            { @"父亲节", @"-06-WXX-6-3" },
            { @"母亲节", @"-05-WXX-7-2" },
            { @"感恩节", @"-11-WXX-4-4" }
        };
      public const string MergedBeforeRegex = @"(前|之前)$";
      public const string MergedAfterRegex = @"(后|後|之后|之後)$";
      public static readonly Dictionary<char, int> TimeNumberDictionary = new Dictionary<char, int>
        {
            { '零', 0 },
            { '一', 1 },
            { '二', 2 },
            { '三', 3 },
            { '四', 4 },
            { '五', 5 },
            { '六', 6 },
            { '七', 7 },
            { '八', 8 },
            { '九', 9 },
            { '〇', 0 },
            { '两', 2 },
            { '十', 10 }
        };
      public static readonly Dictionary<string, int> TimeLowBoundDesc = new Dictionary<string, int>
        {
            { @"中午", 11 },
            { @"下午", 12 },
            { @"午后", 12 },
            { @"晚上", 18 },
            { @"夜里", 18 },
            { @"夜晚", 18 },
            { @"夜间", 18 },
            { @"深夜", 18 },
            { @"傍晚", 18 },
            { @"晚", 18 },
            { @"pm", 12 }
        };
      public const string DefaultLanguageFallback = @"DMY";
    }
}