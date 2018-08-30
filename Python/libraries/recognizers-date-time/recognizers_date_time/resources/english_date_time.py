# ------------------------------------------------------------------------------
# <auto-generated>
#     This code was generated by a tool.
#     Changes to this file may cause incorrect behavior and will be lost if
#     the code is regenerated.
# </auto-generated>
# ------------------------------------------------------------------------------

from .base_date_time import BaseDateTime
# pylint: disable=line-too-long
class EnglishDateTime:
    TillRegex = f'(?<till>to|till|til|until|thru|through|--|-|—|——|~|–)'
    RangeConnectorRegex = f'(?<and>and|through|to|--|-|—|——|~|–)'
    RelativeRegex = f'(?<order>following|next|coming|upcoming|this|last|past|previous|current|the)'
    StrictRelativeRegex = f'(?<order>following|next|coming|upcoming|this|last|past|previous|current)'
    NextPrefixRegex = f'(following|next|upcoming|coming)\\b'
    AfterNextSuffixRegex = f'\\b(after\\s+(the\\s+)?next)\\b'
    PastPrefixRegex = f'(last|past|previous)\\b'
    ThisPrefixRegex = f'(this|current)\\b'
    CenturySuffixRegex = f'(^century)\\b'
    ReferencePrefixRegex = f'(that|same)\\b'
    FutureSuffixRegex = f'\\b(in\\s+the\\s+)?(future|hence)\\b'
    DayRegex = f'(the\\s*)?(?<day>01|02|03|04|05|06|07|08|09|10th|10|11th|11st|11|12nd|12th|12|13rd|13th|13|14th|14|15th|15|16th|16|17th|17|18th|18|19th|19|1st|1|20th|20|21st|21th|21|22nd|22th|22|23rd|23th|23|24th|24|25th|25|26th|26|27th|27|28th|28|29th|29|2nd|2|30th|30|31st|31|3rd|3|4th|4|5th|5|6th|6|7th|7|8th|8|9th|9)(?=\\b|t)'
    ImplicitDayRegex = f'(the\\s*)?(?<day>10th|11th|11st|12nd|12th|13rd|13th|14th|15th|16th|17th|18th|19th|1st|20th|21st|21th|22nd|22th|23rd|23th|24th|25th|26th|27th|28th|29th|2nd|30th|31st|3rd|4th|5th|6th|7th|8th|9th)\\b'
    MonthNumRegex = f'(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)\\b'
    CenturyRegex = f'\\b(?<century>((one|two)\\s+thousand(\\s+and)?(\\s+(one|two|three|four|five|six|seven|eight|nine)\\s+hundred(\\s+and)?)?)|((twenty one|twenty two|one|two|three|four|five|six|seven|eight|nine|ten|eleven|twelve|thirteen|fourteen|fifteen|sixteen|seventeen|eighteen|nineteen|twenty)(\\s+hundred)?(\\s+and)?))\\b'
    WrittenNumRegex = f'(one|two|three|four|five|six|seven|eight|nine|ten|eleven|twelve|thirteen|fourteen|fifteen|sixteen|seventeen|eighteen|nineteen|twenty|thirty|forty|fourty|fifty|sixty|seventy|eighty|ninety)'
    FullTextYearRegex = f'\\b((?<firsttwoyearnum>{CenturyRegex})\\s+(?<lasttwoyearnum>((zero|twenty|thirty|forty|fourty|fifty|sixty|seventy|eighty|ninety)\\s+{WrittenNumRegex})|{WrittenNumRegex}))\\b|\\b(?<firsttwoyearnum>{CenturyRegex})\\b'
    YearNumRegex = f'\\b(?<year>((1[5-9]|20)\\d{{2}})|2100)\\b'
    YearRegex = f'({YearNumRegex}|{FullTextYearRegex})'
    WeekDayRegex = f'\\b(?<weekday>Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|Mon|Tues|Tue|Wedn|Weds|Wed|Thurs|Thur|Thu|Fri|Sat|Sun)s?\\b'
    SingleWeekDayRegex = f'\\b(?<weekday>Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|Mon|Tue|Tues|Wedn|Weds|Wed|Thurs|Thur|Thu|Fri|((?<=on\\s+)(Sat|Sun)))\\b'
    RelativeMonthRegex = f'(?<relmonth>(of\\s+)?{RelativeRegex}\\s+month)\\b'
    WrittenMonthRegex = f'(((the\\s+)?month of\\s+)?(?<month>April|Apr|August|Aug|December|Dec|February|Feb|January|Jan|July|Jul|June|Jun|March|Mar|May|November|Nov|October|Oct|September|Sept|Sep))'
    MonthSuffixRegex = f'(?<msuf>(in\\s+|of\\s+|on\\s+)?({RelativeMonthRegex}|{WrittenMonthRegex}))'
    DateUnitRegex = f'(?<unit>years?|months?|weeks?|(?<business>business\\s+)?days?)\\b'
    SimpleCasesRegex = f'\\b((from|between)\\s+)?({DayRegex})\\s*{TillRegex}\\s*({DayRegex}\\s+{MonthSuffixRegex}|{MonthSuffixRegex}\\s+{DayRegex})((\\s+|\\s*,\\s*){YearRegex})?\\b'
    MonthFrontSimpleCasesRegex = f'\\b((from|between)\\s+)?{MonthSuffixRegex}\\s+((from)\\s+)?({DayRegex})\\s*{TillRegex}\\s*({DayRegex})((\\s+|\\s*,\\s*){YearRegex})?\\b'
    MonthFrontBetweenRegex = f'\\b{MonthSuffixRegex}\\s+(between\\s+)({DayRegex})\\s*{RangeConnectorRegex}\\s*({DayRegex})((\\s+|\\s*,\\s*){YearRegex})?\\b'
    BetweenRegex = f'\\b(between\\s+)({DayRegex})\\s*{RangeConnectorRegex}\\s*({DayRegex})\\s+{MonthSuffixRegex}((\\s+|\\s*,\\s*){YearRegex})?\\b'
    MonthWithYear = f'\\b(({WrittenMonthRegex}(\\.)?(\\s*),?(\\s+of)?(\\s*)({YearRegex}|(?<order>following|next|last|this)\\s+year))|(({YearRegex}|(?<order>following|next|last|this)\\s+year)(\\s*),?(\\s*){WrittenMonthRegex}))\\b'
    OneWordPeriodRegex = f'\\b((((the\\s+)?month of\\s+)?({StrictRelativeRegex}\\s+)?(?<month>April|Apr|August|Aug|December|Dec|February|Feb|January|Jan|July|Jul|June|Jun|March|Mar|May|November|Nov|October|Oct|September|Sep|Sept))|(month|year) to date|({RelativeRegex}\\s+)?(my\\s+)?(weekend|week|month|year)(?!(\\s+of)?\\s+\\d+)(\\s+{AfterNextSuffixRegex})?)\\b'
    MonthNumWithYear = f'\\b(({YearNumRegex}(\\s*)[/\\-\\.](\\s*){MonthNumRegex})|({MonthNumRegex}(\\s*)[/\\-](\\s*){YearNumRegex}))\\b'
    WeekOfMonthRegex = f'\\b(?<wom>(the\\s+)?(?<cardinal>first|1st|second|2nd|third|3rd|fourth|4th|fifth|5th|last)\\s+week\\s+{MonthSuffixRegex})\\b'
    WeekOfYearRegex = f'\\b(?<woy>(the\\s+)?(?<cardinal>first|1st|second|2nd|third|3rd|fourth|4th|fifth|5th|last)\\s+week(\\s+of)?\\s+({YearRegex}|{RelativeRegex}\\s+year))\\b'
    FollowedDateUnit = f'^\\s*{DateUnitRegex}'
    NumberCombinedWithDateUnit = f'\\b(?<num>\\d+(\\.\\d*)?){DateUnitRegex}'
    QuarterTermRegex = f'\\b(((?<cardinal>first|1st|second|2nd|third|3rd|fourth|4th)\\s+quarter)|(Q(?<number>[1-4])))\\b'
    QuarterRegex = f'(the\\s+)?{QuarterTermRegex}((\\s+of|\\s*,\\s*)?\\s+({YearRegex}|{RelativeRegex}\\s+year))?'
    QuarterRegexYearFront = f'({YearRegex}|{RelativeRegex}\\s+year)\\s+(the\\s+)?{QuarterTermRegex}'
    HalfYearTermRegex = f'(?<cardinal>first|1st|second|2nd)\\s+half'
    HalfYearFrontRegex = f'(?<year>((1[5-9]|20)\\d{{2}})|2100)\\s*(the\\s+)?H(?<number>[1-2])'
    HalfYearBackRegex = f'(the\\s+)?(H(?<number>[1-2])|({HalfYearTermRegex}))(\\s+of|\\s*,\\s*)?\\s+({YearRegex})'
    HalfYearRelativeRegex = f'(the\\s+)?{HalfYearTermRegex}(\\s+of|\\s*,\\s*)?\\s+({RelativeRegex}\\s+year)'
    AllHalfYearRegex = f'({HalfYearFrontRegex})|({HalfYearBackRegex})|({HalfYearRelativeRegex})'
    EarlyPrefixRegex = f'(?<EarlyPrefix>early|beginning of|start of|(?<RelEarly>earlier(\\s+in)?))'
    MidPrefixRegex = f'(?<MidPrefix>mid-?|middle of)'
    LaterPrefixRegex = f'(?<LatePrefix>late|end of|(?<RelLate>later(\\s+in)?))'
    PrefixPeriodRegex = f'({EarlyPrefixRegex}|{MidPrefixRegex}|{LaterPrefixRegex})'
    PrefixDayRegex = f'((?<EarlyPrefix>early)|(?<MidPrefix>mid|middle)|(?<LatePrefix>late|later))(\\s+in)?(\\s+the\\s+day)?$'
    SeasonDescRegex = f'(?<seas>spring|summer|fall|autumn|winter)'
    SeasonRegex = f'\\b(?<season>({PrefixPeriodRegex}\\s+)?({RelativeRegex}\\s+)?{SeasonDescRegex}((\\s+of|\\s*,\\s*)?\\s+({YearRegex}|{RelativeRegex}\\s+year))?)\\b'
    WhichWeekRegex = f'(week)(\\s*)(?<number>\\d\\d|\\d|0\\d)'
    WeekOfRegex = f'(the\\s+)?(week)(\\s+of)(\\s+the)?'
    MonthOfRegex = f'(month)(\\s*)(of)'
    MonthRegex = f'(?<month>April|Apr|August|Aug|December|Dec|February|Feb|January|Jan|July|Jul|June|Jun|March|Mar|May|November|Nov|October|Oct|September|Sept|Sep)'
    AmbiguousMonthP0Regex = f'\\b((^may i)|(i|you|he|she|we|they)\\s+may|(may\\s+((((also|not|(also not)|well)\\s+)?(be|contain|constitute|email|e-mail|take|have|result|involve|get|work|reply))|(or may not))))\\b'
    AmDescRegex = f'(am\\b|a\\.m\\.|a m\\b|a\\. m\\.|a\\.m\\b|a\\. m\\b|a m\\b)'
    PmDescRegex = f'(pm\\b|p\\.m\\.|p\\b|p m\\b|p\\. m\\.|p\\.m\\b|p\\. m\\b|p m\\b)'
    DateYearRegex = f'(?<year>((1\\d|20)\\d{{2}})|2100|(([0-27-9]\\d)\\b(?!(\\s*((\\:)|{AmDescRegex}|{PmDescRegex})))))'
    YearSuffix = f'(,?\\s*({DateYearRegex}|{FullTextYearRegex}))'
    OnRegex = f'(?<=\\bon\\s+)({DayRegex}s?)\\b'
    RelaxedOnRegex = f'(?<=\\b(on|at|in)\\s+)((?<day>10th|11th|11st|12nd|12th|13rd|13th|14th|15th|16th|17th|18th|19th|1st|20th|21st|21th|22nd|22th|23rd|23th|24th|25th|26th|27th|28th|29th|2nd|30th|31st|3rd|4th|5th|6th|7th|8th|9th)s?)\\b'
    ThisRegex = f'\\b((this(\\s*week)?(\\s*on)?\\s+){WeekDayRegex})|({WeekDayRegex}((\\s+of)?\\s+this\\s*week))\\b'
    LastDateRegex = f'\\b({PastPrefixRegex}(\\s*week)?\\s+{WeekDayRegex})|({WeekDayRegex}(\\s+last\\s*week))\\b'
    NextDateRegex = f'\\b({NextPrefixRegex}(\\s*week(\\s*,?\\s*on)?)?\\s+{WeekDayRegex})|((on\\s+)?{WeekDayRegex}((\\s+of)?\\s+(the\\s+following|(the\\s+)?next)\\s*week))\\b'
    SpecialDayRegex = f'\\b((the\\s+)?day before yesterday|(the\\s+)?day after (tomorrow|tmr)|((the\\s+)?({RelativeRegex}|my)\\s+day)|yesterday|tomorrow|tmr|today)\\b'
    SpecialDayWithNumRegex = f'\\b((?<number>{WrittenNumRegex})\\s+days?\\s+from\\s+(?<day>yesterday|tomorrow|tmr|today))\\b'
    RelativeDayRegex = f'\\b(((the\\s+)?{RelativeRegex}\\s+day))\\b'
    SetWeekDayRegex = f'\\b(?<prefix>on\\s+)?(?<weekday>morning|afternoon|evening|night|Sunday|Monday|Tuesday|Wednesday|Thursday|Friday|Saturday)s\\b'
    WeekDayOfMonthRegex = f'(?<wom>(the\\s+)?(?<cardinal>first|1st|second|2nd|third|3rd|fourth|4th|fifth|5th|last)\\s+{WeekDayRegex}\\s+{MonthSuffixRegex})'
    RelativeWeekDayRegex = f'\\b({WrittenNumRegex}\\s+{WeekDayRegex}\\s+(from\\s+now|later))\\b'
    SpecialDate = f'(?=\\b(on|at)\\s+the\\s+){DayRegex}\\b'
    DateExtractor1 = f'\\b((this\\s+)?{WeekDayRegex}\\s*[,-]?\\s*)?(({MonthRegex}(\\.)?\\s*[/\\\\.,-]?\\s*{DayRegex})|(\\({MonthRegex}\\s*[-.]\\s*{DayRegex}\\)))(\\s*\\(\\s*{WeekDayRegex}\\s*\\))?'
    DateExtractor2 = f'\\b{DateExtractor1}(\\s+|\\s*,\\s*|\\s+of\\s+){DateYearRegex}\\b'
    DateExtractor3 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}(\\.)?(\\s+|\\s*,\\s*|\\s+of\\s+|\\s*-\\s*){MonthRegex}(\\.)?((\\s+|\\s*,\\s*){DateYearRegex})?\\b'
    DateExtractor4 = f'\\b{MonthNumRegex}\\s*[/\\\\\\-]\\s*{DayRegex}(\\.)?\\s*[/\\\\\\-]\\s*{DateYearRegex}'
    DateExtractor5 = f'\\b{DayRegex}\\s*[/\\\\\\-\\.]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\.]\\s*{DateYearRegex}'
    DateExtractor6 = f'(?<=\\b(on|in|at)\\s+)({WeekDayRegex}\\s+)?{MonthNumRegex}[\\-\\.]{DayRegex}\\b'
    DateExtractor7 = f'\\b({WeekDayRegex}\\s+)?{MonthNumRegex}\\s*/\\s*{DayRegex}((\\s+|\\s*,\\s*|\\s+of\\s+){DateYearRegex})?\\b'
    DateExtractor8 = f'(?<=\\b(on|in|at)\\s+)({WeekDayRegex}\\s+)?{DayRegex}[\\\\\\-]{MonthNumRegex}\\b'
    DateExtractor9 = f'\\b({WeekDayRegex}\\s+)?{DayRegex}\\s*/\\s*{MonthNumRegex}((\\s+|\\s*,\\s*|\\s+of\\s+){DateYearRegex})?\\b'
    DateExtractorA = f'\\b({WeekDayRegex}\\s+)?{DateYearRegex}\\s*[/\\\\\\-\\.]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\.]\\s*{DayRegex}'
    OfMonth = f'^\\s*of\\s*{MonthRegex}'
    MonthEnd = f'{MonthRegex}\\s*(the)?\\s*$'
    WeekDayEnd = f'(this\\s+)?{WeekDayRegex}\\s*,?\\s*$'
    RangeUnitRegex = f'\\b(?<unit>years|year|months|month|weeks|week)\\b'
    OclockRegex = f'(?<oclock>o\\s*’\\s*clock|o\\s*‘\\s*clock|o\\s*\'\\s*clock|o\\s*clock)'
    DescRegex = f'((({OclockRegex}\\s+)?(?<desc>ampm|am\\b|a\\.m\\.|a m\\b|a\\. m\\.|a\\.m\\b|a\\. m\\b|a m\\b|pm\\b|p\\.m\\.|p m\\b|p\\. m\\.|p\\.m\\b|p\\. m\\b|p\\b|p m\\b))|{OclockRegex})'
    HourNumRegex = f'\\b(?<hournum>zero|one|two|three|four|five|six|seven|eight|nine|ten|eleven|twelve)\\b'
    MinuteNumRegex = f'(?<minnum>one|two|three|four|five|six|seven|eight|nine|ten|eleven|twelve|thirteen|fourteen|fifteen|sixteen|seventeen|eighteen|nineteen|twenty|thirty|forty|fifty)'
    DeltaMinuteNumRegex = f'(?<deltaminnum>one|two|three|four|five|six|seven|eight|nine|ten|eleven|twelve|thirteen|fourteen|fifteen|sixteen|seventeen|eighteen|nineteen|twenty|thirty|forty|fifty)'
    PmRegex = f'(?<pm>(((at|in|around|on|for)\\s+(the\\s+)?)?(afternoon|evening|midnight|lunchtime))|((at|in|around|on|for)\\s+(the\\s+)?night))'
    PmRegexFull = f'(?<pm>((at|in|around|on|for)\\s+(the\\s+)?)?(afternoon|evening|midnight|night|lunchtime))'
    AmRegex = f'(?<am>((at|in|around|on|for)\\s+(the\\s+)?)?(morning))'
    LunchRegex = f'\\b(lunchtime)\\b'
    NightRegex = f'\\b(midnight|night)\\b'
    CommonDatePrefixRegex = f'^[\\.]'
    LessThanOneHour = f'(?<lth>(a\\s+)?quarter|three quarter(s)?|half( an hour)?|{BaseDateTime.DeltaMinuteRegex}(\\s+(minute|minutes|min|mins))|{DeltaMinuteNumRegex}(\\s+(minute|minutes|min|mins)))'
    WrittenTimeRegex = f'(?<writtentime>{HourNumRegex}\\s+({MinuteNumRegex}|(?<tens>twenty|thirty|forty|fourty|fifty)\\s+{MinuteNumRegex}))'
    TimePrefix = f'(?<prefix>({LessThanOneHour} past|{LessThanOneHour} to))'
    TimeSuffix = f'(?<suffix>{AmRegex}|{PmRegex}|{OclockRegex})'
    TimeSuffixFull = f'(?<suffix>{AmRegex}|{PmRegexFull}|{OclockRegex})'
    BasicTime = f'\\b(?<basictime>{WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}:{BaseDateTime.MinuteRegex}(:{BaseDateTime.SecondRegex})?|{BaseDateTime.HourRegex})'
    MidnightRegex = f'(?<midnight>midnight|mid-night|mid night)'
    MidmorningRegex = f'(?<midmorning>midmorning|mid-morning|mid morning)'
    MidafternoonRegex = f'(?<midafternoon>midafternoon|mid-afternoon|mid afternoon)'
    MiddayRegex = f'(?<midday>midday|mid-day|mid day|((12\\s)?noon))'
    MidTimeRegex = f'(?<mid>({MidnightRegex}|{MidmorningRegex}|{MidafternoonRegex}|{MiddayRegex}))'
    AtRegex = f'\\b(((?<=\\bat\\s+)({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}(\\s*((?<iam>a)|(?<ipm>p)))?|{MidTimeRegex}))|{MidTimeRegex})\\b'
    IshRegex = f'\\b({BaseDateTime.HourRegex}(-|——)?ish|noonish|noon)\\b'
    TimeUnitRegex = f'([^A-Za-z]{{1,}}|\\b)(?<unit>hours|hour|hrs|hr|h|minutes|minute|mins|min|seconds|second|secs|sec)\\b'
    RestrictedTimeUnitRegex = f'(?<unit>hour|minute)\\b'
    FivesRegex = f'(?<tens>(fifteen|twenty(\\s*five)?|thirty(\\s*five)?|forty(\\s*five)?|fourty(\\s*five)?|fifty(\\s*five)?|ten|five))\\b'
    HourRegex = f'\\b{BaseDateTime.HourRegex}'
    PeriodHourNumRegex = f'\\b(?<hour>twenty one|twenty two|twenty three|twenty four|zero|one|two|three|four|five|six|seven|eight|nine|ten|eleven|twelve|thirteen|fourteen|fifteen|sixteen|seventeen|eighteen|nineteen|twenty)\\b'
    ConnectNumRegex = f'\\b{BaseDateTime.HourRegex}(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59)\\s*{DescRegex}'
    TimeRegex1 = f'\\b({TimePrefix}\\s+)?({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\\s*{DescRegex}'
    TimeRegex2 = f'(\\b{TimePrefix}\\s+)?(T)?{BaseDateTime.HourRegex}(\\s*)?:(\\s*)?{BaseDateTime.MinuteRegex}((\\s*)?:(\\s*)?{BaseDateTime.SecondRegex})?((\\s*{DescRegex})|\\b)'
    TimeRegex3 = f'(\\b{TimePrefix}\\s+)?{BaseDateTime.HourRegex}\\.{BaseDateTime.MinuteRegex}(\\s*{DescRegex})'
    TimeRegex4 = f'\\b{TimePrefix}\\s+{BasicTime}(\\s*{DescRegex})?\\s+{TimeSuffix}\\b'
    TimeRegex5 = f'\\b{TimePrefix}\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex6 = f'{BasicTime}(\\s*{DescRegex})?\\s+{TimeSuffix}\\b'
    TimeRegex7 = f'\\b{TimeSuffixFull}\\s+at\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex8 = f'\\b{TimeSuffixFull}\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex9 = f'\\b{PeriodHourNumRegex}\\s+{FivesRegex}((\\s*{DescRegex})|\\b)'
    TimeRegex10 = f'\\b({TimePrefix}\\s+)?{BaseDateTime.HourRegex}(\\s*h\\s*){BaseDateTime.MinuteRegex}(\\s*{DescRegex})?'
    PureNumFromTo = f'((from|between)\\s+)?({HourRegex}|{PeriodHourNumRegex})(\\s*(?<leftDesc>{DescRegex}))?\\s*{TillRegex}\\s*({HourRegex}|{PeriodHourNumRegex})(?<rightDesc>\\s*({PmRegex}|{AmRegex}|{DescRegex}))?'
    PureNumBetweenAnd = f'(between\\s+)({HourRegex}|{PeriodHourNumRegex})(\\s*(?<leftDesc>{DescRegex}))?\\s*{RangeConnectorRegex}\\s*({HourRegex}|{PeriodHourNumRegex})(?<rightDesc>\\s*({PmRegex}|{AmRegex}|{DescRegex}))?'
    SpecificTimeFromTo = f'((from|between)\\s+)?(?<time1>({TimeRegex2}|({HourRegex}|{PeriodHourNumRegex})(\\s*(?<leftDesc>{DescRegex}))?))\\s*{TillRegex}\\s*(?<time2>({TimeRegex2}|({HourRegex}|{PeriodHourNumRegex})(\\s*(?<rightDesc>{DescRegex}))?))'
    SpecificTimeBetweenAnd = f'(between\\s+)(?<time1>({TimeRegex2}|({HourRegex}|{PeriodHourNumRegex})(\\s*(?<leftDesc>{DescRegex}))?))\\s*{RangeConnectorRegex}\\s*(?<time2>({TimeRegex2}|({HourRegex}|{PeriodHourNumRegex})(\\s*(?<rightDesc>{DescRegex}))?))'
    PrepositionRegex = f'(?<prep>^(at|on|of)(\\s+the)?$)'
    TimeOfDayRegex = f'\\b(?<timeOfDay>((((in\\s+(the)?\\s+)?((?<early>early(\\s+|-))|(?<late>late(\\s+|-)))?(morning|afternoon|night|evening)))|(((in\\s+(the)?\\s+)?)(daytime|business\\s+hour)))s?)\\b'
    SpecificTimeOfDayRegex = f'\\b(({StrictRelativeRegex}\\s+{TimeOfDayRegex})\\b|\\btonight)s?\\b'
    TimeFollowedUnit = f'^\\s*{TimeUnitRegex}'
    TimeNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\.\\d*)?){TimeUnitRegex}'
    BusinessHourSplitStrings = ['business', 'hour']
    NowRegex = f'\\b(?<now>(right\\s+)?now|as soon as possible|asap|recently|previously)\\b'
    SuffixRegex = f'^\\s*(in the\\s+)?(morning|afternoon|evening|night)\\b'
    DateTimeTimeOfDayRegex = f'\\b(?<timeOfDay>morning|afternoon|night|evening)\\b'
    DateTimeSpecificTimeOfDayRegex = f'\\b(({RelativeRegex}\\s+{DateTimeTimeOfDayRegex})\\b|\\btonight)\\b'
    TimeOfTodayAfterRegex = f'^\\s*(,\\s*)?(in\\s+)?{DateTimeSpecificTimeOfDayRegex}'
    TimeOfTodayBeforeRegex = f'{DateTimeSpecificTimeOfDayRegex}(\\s*,)?(\\s+(at|around|in|on))?\\s*$'
    SimpleTimeOfTodayAfterRegex = f'({HourNumRegex}|{BaseDateTime.HourRegex})\\s*(,\\s*)?(in\\s+)?{DateTimeSpecificTimeOfDayRegex}'
    SimpleTimeOfTodayBeforeRegex = f'\\b{DateTimeSpecificTimeOfDayRegex}(\\s*,)?(\\s+(at|around))?\\s*({HourNumRegex}|{BaseDateTime.HourRegex})\\b'
    TheEndOfRegex = f'(the\\s+)?end of(\\s+the)?\\s*$'
    PeriodTimeOfDayRegex = f'\\b((in\\s+(the)?\\s+)?((?<early>early(\\s+|-))|(?<late>late(\\s+|-)))?(?<timeOfDay>morning|afternoon|night|evening))\\b'
    PeriodSpecificTimeOfDayRegex = f'\\b(({StrictRelativeRegex}\\s+{PeriodTimeOfDayRegex})\\b|\\btonight)\\b'
    PeriodTimeOfDayWithDateRegex = f'\\b(({TimeOfDayRegex}(\\s+(on|of))?))\\b'
    LessThanRegex = f'\\b(less\\s+than)\\b'
    MoreThanRegex = f'\\b(more\\s+than)\\b'
    DurationUnitRegex = f'(?<unit>{DateUnitRegex}|hours?|hrs?|h|minutes?|mins?|seconds?|secs?)\\b'
    SuffixAndRegex = f'(?<suffix>\\s*(and)\\s+((an|a)\\s+)?(?<suffix_num>half|quarter))'
    PeriodicRegex = f'\\b(?<periodic>daily|monthly|weekly|biweekly|yearly|annually|annual)\\b'
    EachUnitRegex = f'(?<each>(each|every)(?<other>\\s+other)?\\s*{DurationUnitRegex})'
    EachPrefixRegex = f'\\b(?<each>(each|(every))\\s*$)'
    SetEachRegex = f'\\b(?<each>(each|(every))\\s*)'
    SetLastRegex = f'(?<last>following|next|upcoming|this|last|past|previous|current)'
    EachDayRegex = f'^\\s*(each|every)\\s*day\\b'
    DurationFollowedUnit = f'^\\s*{SuffixAndRegex}?(\\s+|-)?{DurationUnitRegex}'
    NumberCombinedWithDurationUnit = f'\\b(?<num>\\d+(\\.\\d*)?)(-)?{DurationUnitRegex}'
    AnUnitRegex = f'\\b((?<half>half\\s+)?(an|a)|another)\\s+{DurationUnitRegex}'
    DuringRegex = f'\\b(for|during)\\s+the\\s+(?<unit>year|month|week|day)\\b'
    AllRegex = f'\\b(?<all>(all|full|whole)(\\s+|-)(?<unit>year|month|week|day))\\b'
    HalfRegex = f'(((a|an)\\s*)|\\b)(?<half>half\\s+(?<unit>year|month|week|day|hour))\\b'
    ConjunctionRegex = f'\\b((and(\\s+for)?)|with)\\b'
    HolidayRegex1 = f'\\b(?<holiday>clean monday|good friday|ash wednesday|mardi gras|washington\'s birthday|mao\'s birthday|chinese new Year|new years\' eve|new year\'s eve|new year \'s eve|new years eve|new year eve|new years\'|new year\'s|new year \'s|new years|new year|may\\s*day|yuan dan|april fools|christmas eve|christmas|xmas|thanksgiving|halloween|yuandan|easter)(\\s+(of\\s+)?({YearRegex}|{RelativeRegex}\\s+year))?\\b'
    HolidayRegex2 = f'\\b(?<holiday>all saint\'s|tree planting day|white lover|st patrick|st george|cinco de mayo|us independence|all hallow|all souls|guy fawkes)(\\s+(of\\s+)?({YearRegex}|{RelativeRegex}\\s+year))?\\b'
    HolidayRegex3 = f'(?<holiday>(independence|mlk|martin luther king|martin luther king jr|canberra|easter|columbus|thanks\\s*giving|christmas|xmas|labour|(international|int\'l)\\s+workers\'?|mother\'s|mother|mothers|father\'s|father|fathers|female|single|teacher\'s|youth|children|arbor|girls|chsmilbuild|lover|labor|inauguration|groundhog|valentine\'s|baptiste|bastille|halloween|veterans|memorial|mid(-| )autumn|moon|spring|lantern|qingming|dragon boat|new years\'|new year\'s|new year \'s|new years|new year)\\s+(day))(\\s+(of\\s+)?({YearRegex}|{RelativeRegex}\\s+year))?'
    DateTokenPrefix = 'on '
    TimeTokenPrefix = 'at '
    TokenBeforeDate = 'on '
    TokenBeforeTime = 'at '
    AMTimeRegex = f'(?<am>morning)'
    PMTimeRegex = f'\\b(?<pm>afternoon|evening|night)\\b'
    InclusiveModPrepositions = f'(?<include>((on|in|at)\\s+or\\s+)|(\\s+or\\s+(on|in|at)))'
    BeforeRegex = f'(\\b{InclusiveModPrepositions}?(before|in\\s+advance\\s+of|prior\\s+to|(no\\s+later|earlier|sooner)\\s+than|ending\\s+(with|on)|by|till|til|until|(?<include>as\\s+late\\s+as)){InclusiveModPrepositions}?\\b\\s*)|(?<!\\w|>)((?<include><=)|<)'
    AfterRegex = f'(\\b{InclusiveModPrepositions}?(after(?!\\s+or equal to)|(?<!no\\s+)later than){InclusiveModPrepositions}?\\b\\s*)|(?<!\\w|<)((?<include>>=)|>)'
    SinceRegex = f'(\\b(since|after\\s+or\\s+equal\\s+to|starting\\s+(from|on|with)|as\\s+early\\s+as)\\b\\s*)|(?<!\\w|<)(>=)'
    AroundRegex = f'(\\b(around|circa)\\s*\\b)'
    AgoRegex = f'\\b(ago|before (?<day>yesterday|today))\\b'
    LaterRegex = f'\\b(later|from now|(from|after) (?<day>tomorrow|tmr|today))\\b'
    InConnectorRegex = f'\\b(in)\\b'
    WithinNextPrefixRegex = f'\\b(within(\\s+the)?(\\s+(?<next>{NextPrefixRegex}))?)\\b'
    AmPmDescRegex = f'(ampm)'
    MorningStartEndRegex = f'(^(morning|{AmDescRegex}))|((morning|{AmDescRegex})$)'
    AfternoonStartEndRegex = f'(^(afternoon|{PmDescRegex}))|((afternoon|{PmDescRegex})$)'
    EveningStartEndRegex = f'(^(evening))|((evening)$)'
    NightStartEndRegex = f'(^(overnight|tonight|night))|((overnight|tonight|night)$)'
    InexactNumberRegex = f'\\b(a few|few|some|several|(?<NumTwoTerm>(a\\s+)?couple(\\s+of)?))\\b'
    InexactNumberUnitRegex = f'({InexactNumberRegex})\\s+({DurationUnitRegex})'
    RelativeTimeUnitRegex = f'((({NextPrefixRegex}|{PastPrefixRegex}|{ThisPrefixRegex})\\s+({TimeUnitRegex}))|((the|my))\\s+({RestrictedTimeUnitRegex}))'
    RelativeDurationUnitRegex = f'(((?<=({NextPrefixRegex}|{PastPrefixRegex}|{ThisPrefixRegex})\\s+)({DurationUnitRegex}))|((the|my))\\s+({RestrictedTimeUnitRegex}))'
    ReferenceDatePeriodRegex = f'\\b{ReferencePrefixRegex}\\s+(?<duration>week|month|year|weekend)\\b'
    ConnectorRegex = f'^(-|,|for|t|around|@)$'
    FromToRegex = f'\\b(from).+(to)\\b.+'
    SingleAmbiguousMonthRegex = f'^(the\\s+)?(may|march)$'
    SingleAmbiguousTermsRegex = f'^(the\\s+)?(day|week|month|year)$'
    UnspecificDatePeriodRegex = f'^(week|weekend|month|year)$'
    PrepositionSuffixRegex = f'\\b(on|in|at|around|from|to)$'
    FlexibleDayRegex = f'(?<DayOfMonth>([A-Za-z]+\\s)?[A-Za-z\\d]+)'
    ForTheRegex = f'\\b((((?<=for\\s+)the\\s+{FlexibleDayRegex})|((?<=on\\s+)(the\\s+)?{FlexibleDayRegex}(?<=(st|nd|rd|th))))(?<end>\\s*(,|\\.|!|\\?|$)))'
    WeekDayAndDayOfMonthRegex = f'\\b{WeekDayRegex}\\s+(the\\s+{FlexibleDayRegex})\\b'
    RestOfDateRegex = f'\\bRest\\s+(of\\s+)?((the|my|this|current)\\s+)?(?<duration>week|month|year)\\b'
    RestOfDateTimeRegex = f'\\bRest\\s+(of\\s+)?((the|my|this|current)\\s+)?(?<unit>day)\\b'
    MealTimeRegex = f'\\b(at\\s+)?(?<mealTime>lunchtime)\\b'
    NumberEndingPattern = f'^(\\s+(?<meeting>meeting|appointment|conference|call|skype call)\\s+to\\s+(?<newTime>{PeriodHourNumRegex}|{HourRegex})((\\.)?$|(\\.,|,|!|\\?)))'
    OneOnOneRegex = f'\\b(1\\s*:\\s*1)|(one (on )?one|one\\s*-\\s*one|one\\s*:\\s*one)\\b'
    LaterEarlyPeriodRegex = f'\\b({PrefixPeriodRegex})\\s*\\b\\s*(?<suffix>{OneWordPeriodRegex})\\b'
    WeekWithWeekDayRangeRegex = f'\\b((?<week>({NextPrefixRegex}|{PastPrefixRegex}|this)\\s+week)((\\s+between\\s+{WeekDayRegex}\\s+and\\s+{WeekDayRegex})|(\\s+from\\s+{WeekDayRegex}\\s+to\\s+{WeekDayRegex})))\\b'
    GeneralEndingRegex = f'^\\s*((\\.,)|\\.|,|!|\\?)?\\s*$'
    MiddlePauseRegex = f'\\s*(,)\\s*'
    DurationConnectorRegex = f'^\\s*(?<connector>\\s+|and|,)\\s*$'
    PrefixArticleRegex = f'\\bthe\\s+'
    OrRegex = f'\\s*((\\b|,\\s*)(or|and)\\b|,)\\s*'
    YearPlusNumberRegex = f'\\b(Year\\s+((?<year>(\\d{{3,4}}))|{FullTextYearRegex}))\\b'
    NumberAsTimeRegex = f'\\b({WrittenTimeRegex}|{PeriodHourNumRegex}|{BaseDateTime.HourRegex})\\b'
    TimeBeforeAfterRegex = f'\\b(((?<=\\b(before|no later than|by|after)\\s+)({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}|{MidTimeRegex}))|{MidTimeRegex})\\b'
    DateNumberConnectorRegex = f'^\\s*(?<connector>\\s+at)\\s*$'
    DecadeRegex = f'(?<decade>noughties|twenties|thirties|forties|fifties|sixties|seventies|eighties|nineties|two thousands)'
    DecadeWithCenturyRegex = f'(the\\s+)?(((?<century>\\d|1\\d|2\\d)?(\')?(?<decade>\\d0)(\')?s)|(({CenturyRegex}(\\s+|-)(and\\s+)?)?{DecadeRegex})|({CenturyRegex}(\\s+|-)(and\\s+)?(?<decade>tens|hundreds)))'
    RelativeDecadeRegex = f'\\b((the\\s+)?{RelativeRegex}\\s+((?<number>[\\w,]+)\\s+)?decades?)\\b'
    YearAfterRegex = f'\\b(or\\s+(above|after))\\b'
    YearPeriodRegex = f'((((from|during|in)\\s+)?{YearRegex}\\s*({TillRegex})\\s*{YearRegex})|(((between)\\s+){YearRegex}\\s*({RangeConnectorRegex})\\s*{YearRegex}))'
    ComplexDatePeriodRegex = f'(((from|during|in)\\s+)?(?<start>.+)\\s*({TillRegex})\\s*(?<end>.+)|((between)\\s+)(?<start>.+)\\s*({RangeConnectorRegex})\\s*(?<end>.+))'
    UnitMap = dict([('years', 'Y'),
                    ('year', 'Y'),
                    ('months', 'MON'),
                    ('month', 'MON'),
                    ('weeks', 'W'),
                    ('week', 'W'),
                    ('days', 'D'),
                    ('day', 'D'),
                    ('hours', 'H'),
                    ('hour', 'H'),
                    ('hrs', 'H'),
                    ('hr', 'H'),
                    ('h', 'H'),
                    ('minutes', 'M'),
                    ('minute', 'M'),
                    ('mins', 'M'),
                    ('min', 'M'),
                    ('seconds', 'S'),
                    ('second', 'S'),
                    ('secs', 'S'),
                    ('sec', 'S')])
    UnitValueMap = dict([('years', 31536000),
                         ('year', 31536000),
                         ('months', 2592000),
                         ('month', 2592000),
                         ('weeks', 604800),
                         ('week', 604800),
                         ('days', 86400),
                         ('day', 86400),
                         ('hours', 3600),
                         ('hour', 3600),
                         ('hrs', 3600),
                         ('hr', 3600),
                         ('h', 3600),
                         ('minutes', 60),
                         ('minute', 60),
                         ('mins', 60),
                         ('min', 60),
                         ('seconds', 1),
                         ('second', 1),
                         ('secs', 1),
                         ('sec', 1)])
    SeasonMap = dict([('spring', 'SP'),
                      ('summer', 'SU'),
                      ('fall', 'FA'),
                      ('autumn', 'FA'),
                      ('winter', 'WI')])
    SeasonValueMap = dict([('SP', 3),
                           ('SU', 6),
                           ('FA', 9),
                           ('WI', 12)])
    CardinalMap = dict([('first', 1),
                        ('1st', 1),
                        ('second', 2),
                        ('2nd', 2),
                        ('third', 3),
                        ('3rd', 3),
                        ('fourth', 4),
                        ('4th', 4),
                        ('fifth', 5),
                        ('5th', 5)])
    DayOfWeek = dict([('monday', 1),
                      ('tuesday', 2),
                      ('wednesday', 3),
                      ('thursday', 4),
                      ('friday', 5),
                      ('saturday', 6),
                      ('sunday', 0),
                      ('mon', 1),
                      ('tue', 2),
                      ('tues', 2),
                      ('wed', 3),
                      ('wedn', 3),
                      ('weds', 3),
                      ('thu', 4),
                      ('thur', 4),
                      ('thurs', 4),
                      ('fri', 5),
                      ('sat', 6),
                      ('sun', 0)])
    MonthOfYear = dict([('january', 1),
                        ('february', 2),
                        ('march', 3),
                        ('april', 4),
                        ('may', 5),
                        ('june', 6),
                        ('july', 7),
                        ('august', 8),
                        ('september', 9),
                        ('october', 10),
                        ('november', 11),
                        ('december', 12),
                        ('jan', 1),
                        ('feb', 2),
                        ('mar', 3),
                        ('apr', 4),
                        ('jun', 6),
                        ('jul', 7),
                        ('aug', 8),
                        ('sep', 9),
                        ('sept', 9),
                        ('oct', 10),
                        ('nov', 11),
                        ('dec', 12),
                        ('1', 1),
                        ('2', 2),
                        ('3', 3),
                        ('4', 4),
                        ('5', 5),
                        ('6', 6),
                        ('7', 7),
                        ('8', 8),
                        ('9', 9),
                        ('10', 10),
                        ('11', 11),
                        ('12', 12),
                        ('01', 1),
                        ('02', 2),
                        ('03', 3),
                        ('04', 4),
                        ('05', 5),
                        ('06', 6),
                        ('07', 7),
                        ('08', 8),
                        ('09', 9)])
    Numbers = dict([('zero', 0),
                    ('one', 1),
                    ('a', 1),
                    ('an', 1),
                    ('two', 2),
                    ('three', 3),
                    ('four', 4),
                    ('five', 5),
                    ('six', 6),
                    ('seven', 7),
                    ('eight', 8),
                    ('nine', 9),
                    ('ten', 10),
                    ('eleven', 11),
                    ('twelve', 12),
                    ('thirteen', 13),
                    ('fourteen', 14),
                    ('fifteen', 15),
                    ('sixteen', 16),
                    ('seventeen', 17),
                    ('eighteen', 18),
                    ('nineteen', 19),
                    ('twenty', 20),
                    ('twenty one', 21),
                    ('twenty two', 22),
                    ('twenty three', 23),
                    ('twenty four', 24),
                    ('twenty five', 25),
                    ('twenty six', 26),
                    ('twenty seven', 27),
                    ('twenty eight', 28),
                    ('twenty nine', 29),
                    ('thirty', 30),
                    ('thirty one', 31),
                    ('thirty two', 32),
                    ('thirty three', 33),
                    ('thirty four', 34),
                    ('thirty five', 35),
                    ('thirty six', 36),
                    ('thirty seven', 37),
                    ('thirty eight', 38),
                    ('thirty nine', 39),
                    ('forty', 40),
                    ('forty one', 41),
                    ('forty two', 42),
                    ('forty three', 43),
                    ('forty four', 44),
                    ('forty five', 45),
                    ('forty six', 46),
                    ('forty seven', 47),
                    ('forty eight', 48),
                    ('forty nine', 49),
                    ('fifty', 50),
                    ('fifty one', 51),
                    ('fifty two', 52),
                    ('fifty three', 53),
                    ('fifty four', 54),
                    ('fifty five', 55),
                    ('fifty six', 56),
                    ('fifty seven', 57),
                    ('fifty eight', 58),
                    ('fifty nine', 59),
                    ('sixty', 60),
                    ('sixty one', 61),
                    ('sixty two', 62),
                    ('sixty three', 63),
                    ('sixty four', 64),
                    ('sixty five', 65),
                    ('sixty six', 66),
                    ('sixty seven', 67),
                    ('sixty eight', 68),
                    ('sixty nine', 69),
                    ('seventy', 70),
                    ('seventy one', 71),
                    ('seventy two', 72),
                    ('seventy three', 73),
                    ('seventy four', 74),
                    ('seventy five', 75),
                    ('seventy six', 76),
                    ('seventy seven', 77),
                    ('seventy eight', 78),
                    ('seventy nine', 79),
                    ('eighty', 80),
                    ('eighty one', 81),
                    ('eighty two', 82),
                    ('eighty three', 83),
                    ('eighty four', 84),
                    ('eighty five', 85),
                    ('eighty six', 86),
                    ('eighty seven', 87),
                    ('eighty eight', 88),
                    ('eighty nine', 89),
                    ('ninety', 90),
                    ('ninety one', 91),
                    ('ninety two', 92),
                    ('ninety three', 93),
                    ('ninety four', 94),
                    ('ninety five', 95),
                    ('ninety six', 96),
                    ('ninety seven', 97),
                    ('ninety eight', 98),
                    ('ninety nine', 99),
                    ('one hundred', 100)])
    DayOfMonth = dict([('1st', 1),
                       ('2nd', 2),
                       ('3rd', 3),
                       ('4th', 4),
                       ('5th', 5),
                       ('6th', 6),
                       ('7th', 7),
                       ('8th', 8),
                       ('9th', 9),
                       ('10th', 10),
                       ('11th', 11),
                       ('11st', 11),
                       ('12th', 12),
                       ('12nd', 12),
                       ('13th', 13),
                       ('13rd', 13),
                       ('14th', 14),
                       ('15th', 15),
                       ('16th', 16),
                       ('17th', 17),
                       ('18th', 18),
                       ('19th', 19),
                       ('20th', 20),
                       ('21st', 21),
                       ('21th', 21),
                       ('22nd', 22),
                       ('22th', 22),
                       ('23rd', 23),
                       ('23th', 23),
                       ('24th', 24),
                       ('25th', 25),
                       ('26th', 26),
                       ('27th', 27),
                       ('28th', 28),
                       ('29th', 29),
                       ('30th', 30),
                       ('31st', 31)])
    DoubleNumbers = dict([('half', 0.5),
                          ('quarter', 0.25)])
    HolidayNames = dict([('easterday', ['easterday', 'easter']),
                         ('fathers', ['fatherday', 'fathersday']),
                         ('mothers', ['motherday', 'mothersday']),
                         ('thanksgiving', ['thanksgivingday', 'thanksgiving']),
                         ('martinlutherking', ['mlkday', 'martinlutherkingday', 'martinlutherkingjrday']),
                         ('washingtonsbirthday', ['washingtonsbirthday', 'washingtonbirthday']),
                         ('canberra', ['canberraday']),
                         ('labour', ['labourday', 'laborday']),
                         ('columbus', ['columbusday']),
                         ('memorial', ['memorialday']),
                         ('yuandan', ['yuandan']),
                         ('maosbirthday', ['maosbirthday']),
                         ('teachersday', ['teachersday', 'teacherday']),
                         ('singleday', ['singleday']),
                         ('allsaintsday', ['allsaintsday']),
                         ('youthday', ['youthday']),
                         ('childrenday', ['childrenday', 'childday']),
                         ('femaleday', ['femaleday']),
                         ('treeplantingday', ['treeplantingday']),
                         ('arborday', ['arborday']),
                         ('girlsday', ['girlsday']),
                         ('whiteloverday', ['whiteloverday']),
                         ('loverday', ['loverday']),
                         ('christmas', ['christmasday', 'christmas']),
                         ('xmas', ['xmasday', 'xmas']),
                         ('newyear', ['newyear']),
                         ('newyearday', ['newyearday']),
                         ('newyearsday', ['newyearsday']),
                         ('inaugurationday', ['inaugurationday']),
                         ('groundhougday', ['groundhougday']),
                         ('valentinesday', ['valentinesday']),
                         ('stpatrickday', ['stpatrickday']),
                         ('aprilfools', ['aprilfools']),
                         ('stgeorgeday', ['stgeorgeday']),
                         ('mayday', ['mayday', 'intlworkersday', 'internationalworkersday']),
                         ('cincodemayoday', ['cincodemayoday']),
                         ('baptisteday', ['baptisteday']),
                         ('usindependenceday', ['usindependenceday']),
                         ('independenceday', ['independenceday']),
                         ('bastilleday', ['bastilleday']),
                         ('halloweenday', ['halloweenday']),
                         ('allhallowday', ['allhallowday']),
                         ('allsoulsday', ['allsoulsday']),
                         ('guyfawkesday', ['guyfawkesday']),
                         ('veteransday', ['veteransday']),
                         ('christmaseve', ['christmaseve']),
                         ('newyeareve', ['newyearseve', 'newyeareve'])])
    WrittenDecades = dict([('hundreds', 0),
                           ('tens', 10),
                           ('twenties', 20),
                           ('thirties', 30),
                           ('forties', 40),
                           ('fifties', 50),
                           ('sixties', 60),
                           ('seventies', 70),
                           ('eighties', 80),
                           ('nineties', 90)])
    SpecialDecadeCases = dict([('noughties', 2000),
                               ('two thousands', 2000)])
    DefaultLanguageFallback = 'MDY'
    SuperfluousWordList = ['preferably', 'how about', 'maybe', 'say', 'like']
    DurationDateRestrictions = ['today', 'now']
    AmbiguityFiltersDict = dict([('\\bmorning|afternoon|evening|night|day\\b', '\\bgood\\s+(morning|afternoon|evening|night|day)\\b'),
                                 ('\\bmay\\b', '\\b((^may i)|(i|you|he|she|we|they)\\s+may|(may\\s+((((also|not|(also not)|well)\\s+)?(be|contain|constitute|email|e-mail|take|have|result|involve|get|work|reply))|(or may not))))\\b')])
# pylint: enable=line-too-long
