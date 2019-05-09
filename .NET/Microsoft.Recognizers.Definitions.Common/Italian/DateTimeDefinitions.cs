﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Italian\Italian-DateTime.yaml
//     - Language: Italian
//     - ClassName: DateTimeDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Italian
{
	using System;
	using System.Collections.Generic;

	public static class DateTimeDefinitions
	{
		public const string TillRegex = @"(?<till>fino al|fino a|al|a|--|-|—|——|~)";
		public const string RangeConnectorRegex = @"(?<and>e|al|a|--|-|—|——)";
		public const string RelativeRegex = @"(?<order>prossim[oa]|quest[oa]|ultim[oa]|passat[oa]|precedente|corrente|il|mio)";
		public const string NextSuffixRegex = @"(?<order>prossim[oa]|seguente)\b";
		public const string PastSuffixRegex = @"(?<order>precedente)\b";
		public const string ThisPrefixRegex = @"(quest[oa]|corrente)\b";
		public const string RangePrefixRegex = @"(du|de|des|depuis|entre)";
		public const string DayRegex = @"(il\s*)?(?<day>01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|1|20|21|22|23|24|25|26|27|28|29|2|30|31|3|4|5|6|7|8|9)(?=\b|t)";
		public const string MonthNumRegex = @"(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)\b";
		public static readonly string YearRegex = $@"({BaseDateTime.FourDigitYearRegex})";
		public const string WeekDayRegex = @"\b(?<weekday>Domenica|Lunedì|Martedì|Mercoledì|Giovedì|Venerdì|Sabato|Lun|Mar|Mer|Gio|Ven|Sab|Dom)\b";
		public static readonly string RelativeMonthRegex = $@"(?<relmonth>({ThisPrefixRegex}\s+mese)|(mese\s+{PastSuffixRegex})|(mese\s+{NextSuffixRegex}))\b";
		public const string EngMonthRegex = @"(((il\s+)?mese di\s+)?(?<month>Aprile|Apr|Agosto|Ago|Dicembre|Dic|Febbraio|Feb|Gennaio|Gen|Luglio|Lug|Giugno|Giu|Marzo|Mar|Maggio|Mar|Novembre|Nov|Ottobre|Ott|Settembre|Set))";
		public static readonly string MonthSuffixRegex = $@"(?<msuf>(in\s+|di\s+|a\s+)?({RelativeMonthRegex}|{EngMonthRegex}))";
		public const string DateUnitRegex = @"(?<unit>anni|anno|mesi|mese|settimane|settimana|giorni|giorno)\b";
		public static readonly string SimpleCasesRegex = $@"\b((da|tra)\s+)?({DayRegex})\s*{TillRegex}\s*({DayRegex})\s+{MonthSuffixRegex}((\s+|\s*,\s*){YearRegex})?\b";
		public static readonly string MonthFrontSimpleCasesRegex = $@"\b((da|tra)\s+)?{MonthSuffixRegex}\s+((da|tra)\s+)?({DayRegex})\s*{TillRegex}\s*({DayRegex})((\s+|\s*,\s*){YearRegex})?\b";
		public static readonly string MonthFrontBetweenRegex = $@"\b{MonthSuffixRegex}\s+(tra\s+)({DayRegex})\s*{RangeConnectorRegex}\s*({DayRegex})((\s+|\s*,\s*){YearRegex})?\b";
		public static readonly string BetweenRegex = $@"\b(tra\s+)({DayRegex})\s*{RangeConnectorRegex}\s*({DayRegex})\s+{MonthSuffixRegex}((\s+|\s*,\s*){YearRegex})?\b";
		public const string YearWordRegex = @"\b(?<year>l'anno)\b";
		public static readonly string MonthWithYear = $@"\b((?<month>Aprile|Apr|Agosto|Ago|Dicembre|Dic|Febbraio|Feb|Gennaio|Gen|Luglio|Lug|Giugno|Giu|Marzo|Mar|Maggio|Mag|Novembre|Nov|Ottobre|Ott|Settembre|Set),?(\s+del)?\s+({YearRegex}|(?<order>prossimo|passato|questo)\s+anno))";
		public static readonly string OneWordPeriodRegex = $@"\b((((il\s+)?mese di\s+)?({RelativeRegex}\s+)?(?<month>Aprile|Apr|Agosto|Ago|Dicembre|Dic|Febbraio|Feb|Gennaio|Gen|Luglio|Lug|Giugno|Giu|Marzo|Mar|Maggio|Mag|Novembre|Nov|Ottobre|Ott|Settembre|Set))|(mese|anno) nella data|({RelativeRegex}\s+)?(weekend|settimana|mese|anno)(\s+{{AfterNextSuffixRegex}})?)\b";
		public static readonly string MonthNumWithYear = $@"({YearRegex}[/\-\.]{MonthNumRegex})|({MonthNumRegex}[/\-]{YearRegex})";
		public static readonly string WeekOfMonthRegex = $@"(?<wom>(il\s+)?(?<cardinal>prima|seconda|terza|quarta|quinta|ultima)\s+settimana\s+{MonthSuffixRegex})";
		public static readonly string WeekOfYearRegex = $@"(?<woy>(the\s+)?(?<cardinal>prima|seconda|terza|quarta|quinta|ultima)\s+settimana(\s+del)?\s+({YearRegex}|{RelativeRegex}\s+year))";
		public static readonly string FollowedDateUnit = $@"^\s*{DateUnitRegex}";
		public static readonly string NumberCombinedWithDateUnit = $@"\b(?<num>\d+(\.\d*)?){DateUnitRegex}";
		public static readonly string QuarterRegex = $@"(the\s+)?(?<cardinal>primo|secondo|terzo|quarto)\s+trimestre(\s+of|\s*,\s*)?\s+({YearRegex}|{RelativeRegex}\s+year)";
		public static readonly string QuarterRegexYearFront = $@"({YearRegex}|l'anno\s+({PastSuffixRegex}|{NextSuffixRegex})|{RelativeRegex}\s+anno)\s+(le\s+)?(?<cardinal>primo|secondo|terzo|quarto)\s+trimestre";
		public const string AllHalfYearRegex = @"^[.]";
		public const string PrefixDayRegex = @"^[.]";
		public const string CenturySuffixRegex = @"^[.]";
		public static readonly string SeasonRegex = $@"\b((<seas>primavera|estate|autunno|inverno)+\s*({NextSuffixRegex}|{PastSuffixRegex}))|(?<season>({RelativeRegex}\s+)?(?<seas>primavera|estate|autunno|inverno)((\s+del|\s*,\s*)?\s+({YearRegex}|{RelativeRegex}\s+l'anno))?)\b";
		public const string WhichWeekRegex = @"\b(settimana)(\s*)(?<number>5[0-3]|[1-4]\d|0?[1-9])\b";
		public const string WeekOfRegex = @"(settimana)(\s*)(del)";
		public const string MonthOfRegex = @"(mese)(\s*)(di)";
		public const string MonthRegex = @"(?<month>Aprile|Apr|Agosto|Ago|Dicembre|Dic|Febbraio|Feb|Gennaio|Gen|Luglio|Lug|Giugno|Giu|Marzo|Mar|Maggio|Mar|Novembre|Nov|Ottobre|Ott|Settembre|Set)";
		public static readonly string DateYearRegex = $@"(?<year>19\d{{2}}|20\d{{2}}|(([0-27-9]\d)(?!(\s*((\:)|{AmDescRegex}|{PmDescRegex})))))";
		public static readonly string OnRegex = $@"(?<=\b(di|su)\s+)({DayRegex}s?)\b";
		public const string RelaxedOnRegex = @"(?<=\b(il|del|di|al|a)\s+)((?<day>10th|11th|11st|12nd|12th|13rd|13th|14th|15th|16th|17th|18th|19th|1st|20th|21st|22nd|23rd|24th|25th|26th|27th|28th|29th|2nd|30th|31st|3rd|4th|5th|6th|7th|8th|9th)s?)\b";
		public static readonly string ThisRegex = $@"\b((questa(\s*settimana)?(\s*in)?\s+){WeekDayRegex})|({WeekDayRegex}((\s+di)?\s+questa\s*settimana))\b";
		public static readonly string LastDateRegex = $@"\b(({WeekDayRegex}(\s*(della)?\s*la\s*settimana\s+{PastSuffixRegex}))|({WeekDayRegex}(\s+{PastSuffixRegex})))\b";
		public const string StrictWeekDay = @"\b(?<weekday>Domenica|Lunedì|Martedì|Mercoledì|Giovedì|Venerdì|Sabato|Lun|Mar|Mer|Gio|Ven|Sab|Dom)s?\b";
		public static readonly string NextDateRegex = $@"\b(({WeekDayRegex}(\s+{NextSuffixRegex}))|({WeekDayRegex}(\s*(de)?\s*la\s*settimana\s+{NextSuffixRegex})))\b";
		public static readonly string SpecialDayRegex = $@"\b(avant[\s|-]ieri|dopo(-domani|\s*domani)|(le\s)?il giorno seguente|(il\s+)?{RelativeRegex}giorno dopo|ieri|l'indomani|domani|oggi)\b";
		public const string SpecialDayWithNumRegex = @"^[.]";
		public static readonly string RelativeDayRegex = $@"\b(((the\s+)?{RelativeRegex}\s+day))\b";
		public const string SetWeekDayRegex = @"\b(?<prefix>di\s+)?(?<weekday>mattina|pomeriggio|sera|notte|Domenica|Lunedì|Martedì|Mercoledì|Giovedì|Venerdì|Sabato)s\b";
		public static readonly string WeekDayOfMonthRegex = $@"(?<wom>(la\s+)?(?<cardinal>prima|seconda|terza|quarta|quinta|ultima)\s+{WeekDayRegex}\s+{MonthSuffixRegex})";
		public const string RelativeWeekDayRegex = @"^[.]";
		public const string NumberEndingPattern = @"^[.]";
		public const string UpcomingPrefixRegex = @".^";
		public const string NextPrefixRegex = @".^";
		public const string PastPrefixRegex = @".^";
		public const string PreviousPrefixRegex = @".^";
		public static readonly string SpecialDate = $@"(?=\b(di|al)\s+il\s+){DayRegex}\b";
		public static readonly string DateExtractor1 = $@"\b({WeekDayRegex}(\s+|\s*,\s*))?{MonthRegex}\s*[/\\\.\-]?\s*{DayRegex}\b";
		public static readonly string DateExtractor2 = $@"\b({WeekDayRegex}(\s+|\s*,\s*))?{DayRegex}(\s+|\s*,\s*|\s+){MonthRegex}\s*[\.\-]?\s*{DateYearRegex}\b";
		public static readonly string DateExtractor3 = $@"\b({WeekDayRegex}(\s+|\s*,\s*))?{DayRegex}(\s+|\s*,\s*|\s*-\s*){MonthRegex}((\s+|\s*,\s*){DateYearRegex})?\b";
		public static readonly string DateExtractor4 = $@"\b{MonthNumRegex}\s*[/\\\-]\s*{DayRegex}\s*[/\\\-]\s*{DateYearRegex}";
		public static readonly string DateExtractor5 = $@"\b{DayRegex}\s*[/\\\-]\s*({MonthNumRegex}|{MonthRegex})\s*[/\\\-]\s*{DateYearRegex}";
		public static readonly string DateExtractor6 = $@"(?<=\b(le|sur|sur l[ae])\s+){MonthNumRegex}[\-\.\/]{DayRegex}\b";
		public static readonly string DateExtractor7 = $@"\b{DayRegex}\s*/\s*{MonthNumRegex}((\s+|\s*,\s*){DateYearRegex})?\b";
		public static readonly string DateExtractor8 = $@"(?<=\b(le)\s+){DayRegex}[\\\-]{MonthNumRegex}\b";
		public static readonly string DateExtractor9 = $@"\b{DayRegex}\s*/\s*{MonthNumRegex}((\s+|\s*,\s*){DateYearRegex})?\b";
		public static readonly string DateExtractorA = $@"\b{DateYearRegex}\s*[/\\\-]\s*{MonthNumRegex}\s*[/\\\-]\s*{DayRegex}";
		public static readonly string OfMonth = $@"^\s*di\s*{MonthRegex}";
		public static readonly string MonthEnd = $@"{MonthRegex}\s*(il)?\s*$";
		public static readonly string WeekDayEnd = $@"{WeekDayRegex}\s*,?\s*$";
		public const string RangeUnitRegex = @"\b(?<unit>l'anno|ann[oi]?|mesi|settimane|settimana)\b";
		public const string SpecialDescRegex = @"(p\b)";
		public static readonly string AmDescRegex = $@"(h|{BaseDateTime.BaseAmDescRegex})";
		public static readonly string PmDescRegex = $@"(h|{BaseDateTime.BasePmDescRegex})";
		public static readonly string AmPmDescRegex = $@"(h|{BaseDateTime.BaseAmPmDescRegex})";
		public static readonly string DescRegex = $@"(?<desc>{AmPmDescRegex}|{AmDescRegex}|{PmDescRegex}|{SpecialDescRegex})";
		public const string HourNumRegex = @"\b(?<hournum>zero|uno|due|tre|quattro|cinque|sei|sette|otto|nove|dieci|undici|dodici)\b";
		public const string MinuteNumRegex = @"(?<minnum>uno|due|tre|quattro|cinque|sei|sette|otto|nove|dieci|undici|dodici|tredici|quattordici|quindici|sedici|diciassette|diciotto|diciannove|venti|trenta|quaranta|cinquanta)";
		public const string DeltaMinuteNumRegex = @"(?<deltaminnum>uno|due|tre|quattro|cinque|sei|sette|otto|nove|dieci|undici|dodici|treidic|quattordici|quindici|sedici|diciassette|diciotto|diciannove|venti|trenta|quaranta|cinquanta)";
		public const string OclockRegex = @"(?<oclock>ora|ore|h)";
		public const string PmRegex = @"(?<pm>(((di|al|nel|a|per|intorno)\s+(il\s+)?)?(pomeriggio|pranzo))|((di|nella|intorno|la|per)\s+(the\s+)?(notte|sera|mezzanotte)))";
		public const string AmRegex = @"(?<am>((la|alla|intorno|per)\s+(la\s+)?)?(mattina))";
		public static readonly string LessThanOneHour = $@"(?<lth>(a\s+)?quarto|tre quarti?|mezza( ora)?|{BaseDateTime.DeltaMinuteRegex}(\s+(minute|minutes|min|mins))|{DeltaMinuteNumRegex}(\s+(minute|minutes|min|mins)))";
		public static readonly string EngTimeRegex = $@"(?<engtime>{HourNumRegex}\s+({MinuteNumRegex}|(?<tens>venti|trenta|quaranta|cinquanta)\s+{MinuteNumRegex}))";
		public static readonly string TimePrefix = $@"(?<prefix>(ore\s*e\s+{LessThanOneHour}|e {LessThanOneHour}|{LessThanOneHour} [a]))";
		public static readonly string TimeSuffix = $@"(?<suffix>{AmRegex}|{PmRegex}|{OclockRegex})";
		public static readonly string BasicTime = $@"\b(?<basictime>{EngTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}:{BaseDateTime.MinuteRegex}(:{BaseDateTime.SecondRegex})?|{BaseDateTime.HourRegex})";
		public const string MidnightRegex = @"(?<midnight>mezzanotte|mezza notte)";
		public const string CommonDatePrefixRegex = @"^[\.]";
		public const string MorningRegex = @"(?<morning>mattin[oa])";
		public const string AfternoonRegex = @"(?<afternoon>(d'|l')?pomeriggio)";
		public static readonly string MidmorningRegex = $@"(?<midmorning>metà\s*{MorningRegex})";
		public const string MiddayRegex = @"(?<midday>metà\s*(giornata|mattinata)|mezzogiorno)";
		public static readonly string MidafternoonRegex = $@"(?<midafternoon>metà\s*{AfternoonRegex})";
		public static readonly string MidTimeRegex = $@"(?<mid>({MidnightRegex}|{MidmorningRegex}|{MidafternoonRegex}|{MiddayRegex}))";
		public static readonly string AtRegex = $@"\b(((?<=\b[àa]\s+)({EngTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}|{MidTimeRegex}))|{MidTimeRegex})\b";
		public static readonly string IshRegex = $@"\b(poco\s*prima\s*{BaseDateTime.HourRegex}|porco\s*prima\s*{EngTimeRegex}|poco\s*prima\s*di\s*{BaseDateTime.HourRegex}|poco prima di mezzogiorno)\b";
		public const string TimeUnitRegex = @"(?<unit>ore|ora|hrs|hr|h|minuti|minuto|mins|min|secondi|secondo|secs|sec)\b";
		public const string RestrictedTimeUnitRegex = @"(?<unit>ore|minute)\b";
		public static readonly string ConnectNumRegex = $@"{BaseDateTime.HourRegex}(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59)\s*{DescRegex}";
		public const string FivesRegex = @"(?<tens>(quindici|venti(\s*cinque)?|trenta(\s*cinque)?|quaranta(\s*cinque)?|cinquanta(\s*cinque)?|dieci|cinque))\b";
		public const string PeriodHourNumRegex = @"\b(?<hour>ventuno|ventidue|ventitre|ventiquattro|zero|uno|due|tre|quattro|cinque|sei|sette|otto|nove|dieci|undici|dodici|tredici|quattordici|quindici|sedici|diciassette|diciotto|diciannove|venti)\b";
		public static readonly string TimeRegex1 = $@"\b({EngTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\s*{DescRegex}(\s+{TimePrefix})?";
		public static readonly string TimeRegex2 = $@"(\b{TimePrefix}\s+)?(t)?{BaseDateTime.HourRegex}(\s*)?:(\s*)?{BaseDateTime.MinuteRegex}((\s*)?:(\s*)?{BaseDateTime.SecondRegex})?((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex3 = $@"\b{BaseDateTime.HourRegex}\.{BaseDateTime.MinuteRegex}(\s*{DescRegex})(\s+{TimePrefix})?";
		public static readonly string TimeRegex4 = $@"\b{BasicTime}(\s*{DescRegex})?(\s+{TimePrefix})?\s+{TimeSuffix}\b";
		public static readonly string TimeRegex5 = $@"\b{BasicTime}((\s*{DescRegex})|\b)(\s+{TimePrefix})?";
		public static readonly string TimeRegex6 = $@"{BasicTime}(\s*{DescRegex})?\s+{TimeSuffix}\b";
		public static readonly string TimeRegex7 = $@"\b{TimeSuffix}\s+[àa]\s+{BasicTime}((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex8 = $@"\b{TimeSuffix}\s+{BasicTime}((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex9 = $@"\b{PeriodHourNumRegex}\s+{FivesRegex}((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex10 = $@"(\b{TimePrefix}\s+)?{BaseDateTime.HourRegex}(\s*h\s*){BaseDateTime.MinuteRegex}(\s*{DescRegex})?";
		public const string HourRegex = @"(?<hour>00|01|02|03|04|05|06|07|08|09|0|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|1|2|3|4|5|6|7|8|9)";
		public const string PeriodDescRegex = @"(?<desc>pm|am|p\.m\.|a\.m\.|p)";
		public const string PeriodPmRegex = @"(?<pm>dans l'apr[eè]s-midi|ce soir|d[eu] soir|dans l[ea] soir[eé]e|dans la nuit|d[eu] soir[ée]e)s?";
		public const string PeriodAmRegex = @"(?<am>matin|d[eu] matin|matin[ée]e)s?";
		public static readonly string PureNumFromTo = $@"((du|de|des|depuis)\s+)?({HourRegex}|{PeriodHourNumRegex})(\s*(?<leftDesc>{PeriodDescRegex}))?\s*{TillRegex}\s*({HourRegex}|{PeriodHourNumRegex})\s*(?<rightDesc>{PmRegex}|{AmRegex}|{PeriodDescRegex})?";
		public static readonly string PureNumBetweenAnd = $@"(entre\s+)({HourRegex}|{PeriodHourNumRegex})(\s*(?<leftDesc>{PeriodDescRegex}))?\s*{RangeConnectorRegex}\s*({HourRegex}|{PeriodHourNumRegex})\s*(?<rightDesc>{PmRegex}|{AmRegex}|{PeriodDescRegex})?";
		public const string SpecificTimeFromTo = @"^[.]";
		public const string SpecificTimeBetweenAnd = @"^[.]";
		public const string PrepositionRegex = @"(?<prep>^([aà] la|en|sur\s*l[ea]|sur|de)$)";
		public const string TimeOfDayRegex = @"\b(?<timeOfDay>((((dalle\s+?\s+)?((?<early>d[eé]but(\s+|-)|t[oô]t(\s+|-)(l[ea]\s*)?)|(?<late>fin\s*|fin de(\s+(la)?)|tard\s*))?(matin[ée]e|matin|((d|l)?'?)apr[eè]s[-|\s*]midi|nuit|soir[eé]e|soir)))|(((\s+(l[ea])?\s+)?)(jour|journ[eé]e)))s?)\b";
		public static readonly string SpecificTimeOfDayRegex = $@"\b(({RelativeRegex}\s+{TimeOfDayRegex})|({TimeOfDayRegex}\s*({NextSuffixRegex}))\b|\bsoir|\bdu soir)s?\b";
		public static readonly string TimeFollowedUnit = $@"^\s*{TimeUnitRegex}";
		public static readonly string TimeNumberCombinedWithUnit = $@"\b(?<num>\d+(\.\d*)?){TimeUnitRegex}";
		public const string NowRegex = @"\b(?<now>(proprio\s+)?adesso|il prima possibile|asap|recentemente|precedentemente)\b";
		public const string SuffixRegex = @"^\s*(nel\s+)?(mattina|pomeriggio|sera|notte)\b";
		public const string DateTimeTimeOfDayRegex = @"\b(?<timeOfDay>mattina|pomeriggio|sera|notte)\b";
		public static readonly string DateTimeSpecificTimeOfDayRegex = $@"\b(({RelativeRegex}\s+{DateTimeTimeOfDayRegex})\b|\bquesta notte)\b";
		public static readonly string TimeOfTodayAfterRegex = $@"^\s*(,\s*)?(en|dans|du\s+)?{DateTimeSpecificTimeOfDayRegex}";
		public static readonly string TimeOfTodayBeforeRegex = $@"{DateTimeSpecificTimeOfDayRegex}(\s*,)?(\s+(alle|intorno|a))?\s*$";
		public static readonly string SimpleTimeOfTodayAfterRegex = $@"({HourNumRegex}|{BaseDateTime.HourRegex})\s*(,\s*)?(en|[àa]\s+)?{DateTimeSpecificTimeOfDayRegex}";
		public static readonly string SimpleTimeOfTodayBeforeRegex = $@"{DateTimeSpecificTimeOfDayRegex}(\s*,)?(\s+(di|verso))?\s*({HourNumRegex}|{BaseDateTime.HourRegex})";
		public const string SpecificEndOfRegex = @"(alla\s+)?fine di(\s+del)?\s*$";
		public const string UnspecificEndOfRegex = @"^[.]";
		public const string UnspecificEndOfRangeRegex = @"^[.]";
		public const string PeriodTimeOfDayRegex = @"\b((alla\s+(al)?\s+)?((?<early>prima(\s+|-))|(?<late>tarda(\s+|-)))?(?<timeOfDay>mattina|pomeriggio|notte|sera))\b";
		public static readonly string PeriodSpecificTimeOfDayRegex = $@"\b(({RelativeRegex}\s+{PeriodTimeOfDayRegex})\b|\b(ce|cette\s+)(soir|nuit))\b";
		public static readonly string PeriodTimeOfDayWithDateRegex = $@"\b(({TimeOfDayRegex}))\b";
		public const string LessThanRegex = @"^[.]";
		public const string MoreThanRegex = @"^[.]";
		public const string DurationUnitRegex = @"(?<unit>anni|anno|mesi|mese|settimane|settimana|giorni|giorno|ore|ora|hrs|hr|h|minuti|minuto|mins|min|secondi|secondo|secs|sec)\b";
		public const string SuffixAndRegex = @"(?<suffix>\s*(et)\s+((un|uno|una)\s+)?(?<suffix_num>mezzo|metà|quarto))";
		public const string PeriodicRegex = @"\b(?<periodic>giornaliero|mensile|settimanale|bisettimanale|annuale)\b";
		public static readonly string EachUnitRegex = $@"(?<each>(ogni|tutte le|tutti)(?<other>\s+altri)?\s*{DurationUnitRegex})";
		public const string EachPrefixRegex = @"\b(?<each>(ogni|tutte le|(tutti gli))\s*$)";
		public const string SetEachRegex = @"\b(?<each>(ogni|tutti gli|(tutte le))\s*)";
		public const string SetLastRegex = @"(?<last>prossimo|questo|questa|ultimo|ultima|prossima|passata|passato|recedente|corrente)";
		public const string EachDayRegex = @"^\s*(ogni|tutte i|tutto il )\s*(giorni|giorno)\b";
		public static readonly string DurationFollowedUnit = $@"^\s*{SuffixAndRegex}?(\s+|-)?{DurationUnitRegex}";
		public static readonly string NumberCombinedWithDurationUnit = $@"\b(?<num>\d+(\.\d*)?)(-)?{DurationUnitRegex}";
		public static readonly string AnUnitRegex = $@"\b(((?<half>demi\s+)?(-)\s+{DurationUnitRegex}))";
		public const string DuringRegex = @"^[.]";
		public const string AllRegex = @"\b(?<all>(tutto|tutta|intero|intera)(\s+|-)(?<unit>anno|mese|settimana|giorno))\b";
		public const string HalfRegex = @"(((a)\s*)|\b)(?<half>metà\s+(?<unit>anno|mese|settimana|giorno|ora))\b";
		public const string ConjunctionRegex = @"\b((e(\s+per)?)|con)\b";
		public static readonly string HolidayRegex1 = $@"\b(?<holiday>le ceneri|mercoledì delle ceneri|martedì grasso|capodanno cinese|capodanno|primo dell'anno|festa del papà|pesce d'aprile|la vigilia|la vigilia di natale|natale|giorno di natale|halloween|pasqua|lunedì dell'angelo)(\s+(del\s+)?({YearRegex}|{{RelativeRegex}}\s+year))?\b";
		public static readonly string HolidayRegex2 = $@"\b(?<holiday>i morti|tutti i santi|giorno dell'independenza|la liberazione|festa del lavoro|festa dei lavoratori)(\s+(del\s+)?({YearRegex}|{{RelativeRegex}}\s+year))?\b";
		public static readonly string HolidayRegex3 = $@"(?<holiday>(pasqua|natale|donne|della memoria|festa della mamma|festa delle donne|festa della donna|san valentino|ferragosto|la madonna|la notte della madonna)\s+(giorno))(\s+(del\s+)?({YearRegex}|{{RelativeRegex}}\s+year))?";
		public const string DateTokenPrefix = @"di ";
		public const string TimeTokenPrefix = @"alle ";
		public const string TokenBeforeDate = @"di ";
		public const string TokenBeforeTime = @"alle ";
		public const string AMTimeRegex = @"(?<am>mattin[oa])";
		public const string PMTimeRegex = @"\b(?<pm>pomeriggio|sera|notte)\b";
		public const string BeforeRegex = @"\b(prima|prima di|prima della|(non dopo|precedente|presto) della fine|della fine (di|con)|della|fino a|a|al|fino al)\b";
		public const string BeforeRegex2 = @"\b(entro\s*(la|il?)?)\b";
		public const string AfterRegex = @"\b(dopo(?!\s+o uguale a)|(?<!no\s+)dopo di)\b";
		public const string SinceRegex = @"\b(a partire da|dopo il|a partire (da|del))\b";
		public const string AroundRegex = @"^[.]";
		public const string AgoPrefixRegex = @"\b(di)\b";
		public const string LaterRegex = @"\b(dopo|da adesso)\b";
		public const string AgoRegex = @"^[.]";
		public const string InConnectorRegex = @"\b(di)\b";
		public const string SinceYearSuffixRegex = @"^[.]";
		public const string WithinNextPrefixRegex = @"^[.]";
		public const string MorningStartEndRegex = @"(^(mattin[oa]))|((mattin[oa])$)";
		public const string AfternoonStartEndRegex = @"(^((di|al)?pomeriggio))|(((di|il)?pomeriggio)$)";
		public const string EveningStartEndRegex = @"(^(sera))|((sera)$)";
		public const string NightStartEndRegex = @"(^(notte|questa notte))|((notte|questa notte)$)";
		public const string InexactNumberRegex = @"\b(un pò|alcuni|parecchi)\b";
		public static readonly string InexactNumberUnitRegex = $@"({InexactNumberRegex})\s+({DurationUnitRegex})";
		public static readonly string RelativeTimeUnitRegex = $@"(((({ThisPrefixRegex})?)\s+({TimeUnitRegex}(\s*{NextSuffixRegex}|{PastSuffixRegex})?))|((le))\s+({RestrictedTimeUnitRegex}))";
		public static readonly string RelativeDurationUnitRegex = $@"((\b({DurationUnitRegex})(\s+{NextSuffixRegex}|{PastSuffixRegex})?)|((le|my))\s+({RestrictedTimeUnitRegex}))";
		public const string ReferenceDatePeriodRegex = @"^[.]";
		public const string ConnectorRegex = @"^(-|,|per|al|intorno)$";
		public const string ConnectorAndRegex = @"\b(e\s*(il|la?)?)\b.+";
		public const string FromRegex = @"((di|del|della)?)$";
		public const string FromRegex2 = @"((dopo|di|del)(\s*la|le|il?)?)$";
		public const string FromToRegex = @"\b(da).+(a)\b.+";
		public const string SingleAmbiguousMonthRegex = @"^(a\s+)?(maggio|marzo)$";
		public const string UnspecificDatePeriodRegex = @"^[.]";
		public const string PrepositionSuffixRegex = @"\b(il|al|a|del|di|da|dal|fino al|fino a)$";
		public const string FlexibleDayRegex = @"(?<DayOfMonth>([A-Za-z]+\s)?[A-Za-z\d]+)";
		public static readonly string ForTheRegex = $@"\b(((dal {FlexibleDayRegex})|(di (il\s+)?{FlexibleDayRegex}(?<=(st|nd|rd|th))))(?<end>\s*(,|\.|!|\?|$)))";
		public static readonly string WeekDayAndDayOfMonthRegex = $@"\b{WeekDayRegex}\s+(del\s+{FlexibleDayRegex})\b";
		public static readonly string WeekDayAndDayRegex = $@"\b{WeekDayRegex}\s+(?!(the)){DayRegex}(?!([-]|(\s+({AmDescRegex}|{{PmDescRegex|{OclockRegex}}}))))\b";
		public const string RestOfDateRegex = @"Fine\s+(di\s+)?((del|questo|questa|corrente)\s+)?(?<duration>settimana|mese|anno)\b";
		public const string RestOfDateTimeRegex = @"Fine\s+(di\s+)?((del|questo|questa|corrente)\s+)?(?<unit>giorno)\b";
		public const string LaterEarlyPeriodRegex = @"^[.]";
		public const string WeekWithWeekDayRangeRegex = @"^[.]";
		public const string GeneralEndingRegex = @"^\s*((\.,)|\.|,|!|\?)?\s*$";
		public const string MiddlePauseRegex = @"\s*(,)\s*";
		public const string DurationConnectorRegex = @"^\s*(?<connector>\s+|e|,)\s*$";
		public const string PrefixArticleRegex = @"\bil\s+";
		public const string OrRegex = @"\s*(o)\s*";
		public static readonly string YearPlusNumberRegex = $@"\b(Anno\s+((?<year>(\d{{3,4}}))|{FullTextYearRegex}))\b";
		public static readonly string NumberAsTimeRegex = $@"\b({EngTimeRegex}|{PeriodHourNumRegex}|{BaseDateTime.HourRegex})\b";
		public static readonly string TimeBeforeAfterRegex = $@"\b(((?<=\b(prima|non prima di|per|dopo)\s+)({EngTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}|{MidTimeRegex}))|{MidTimeRegex})\b";
		public const string DateNumberConnectorRegex = @"^\s*(?<connector>\s+il)\s*$";
		public const string CenturyRegex = @"^[.]";
		public const string DecadeRegex = @"(?<decade>venti|trenta|quaranta|cinquanta|sessanta|settanta|ottanta|novanta|due mila)";
		public static readonly string DecadeWithCenturyRegex = $@"(il\s+)?(((?<century>\d|1\d|2\d)?(')?(?<decade>\d0)(')?s)|(({CenturyRegex}(\s+|-)(e\s+)?)?{DecadeRegex})|({CenturyRegex}(\s+|-)(e\s+)?(?<decade>dieci|cento)))";
		public static readonly string RelativeDecadeRegex = $@"\b((il\s+)?{RelativeRegex}\s+((?<number>[\w,]+)\s+)?cento?)\b";
		public const string FullTextYearRegex = @"^[.]";
		public static readonly string YearSuffix = $@"(,?\s*({DateYearRegex}|{FullTextYearRegex}))";
		public const string SuffixAfterRegex = @"\b(o\s+(dopo|passato))\b";
		public static readonly string YearPeriodRegex = $@"(((dal|durante|nel|tra)\s+)?{YearRegex}\s*{TillRegex}\s*{YearRegex})";
		public const string FutureSuffixRegex = @"^[.]";
		public const string ComplexDatePeriodRegex = @"^[.]";
		public static readonly Dictionary<string, string> UnitMap = new Dictionary<string, string>
		{
			{ @"anni", @"Y" },
			{ @"anno", @"Y" },
			{ @"mesi", @"MON" },
			{ @"mese", @"MON" },
			{ @"settimane", @"W" },
			{ @"settimana", @"W" },
			{ @"giorni", @"D" },
			{ @"giorno", @"D" },
			{ @"ore", @"H" },
			{ @"ora", @"H" },
			{ @"hrs", @"H" },
			{ @"hr", @"H" },
			{ @"h", @"H" },
			{ @"minuti", @"M" },
			{ @"minuto", @"M" },
			{ @"mins", @"M" },
			{ @"min", @"M" },
			{ @"secondi", @"S" },
			{ @"secondo", @"S" },
			{ @"secs", @"S" },
			{ @"sec", @"S" }
		};
		public static readonly Dictionary<string, long> UnitValueMap = new Dictionary<string, long>
		{
			{ @"anni", 31536000 },
			{ @"anno", 31536000 },
			{ @"mesi", 2592000 },
			{ @"mese", 2592000 },
			{ @"settimane", 604800 },
			{ @"settimana", 604800 },
			{ @"giorni", 86400 },
			{ @"giorno", 86400 },
			{ @"ore", 3600 },
			{ @"ora", 3600 },
			{ @"hrs", 3600 },
			{ @"hr", 3600 },
			{ @"h", 3600 },
			{ @"minuti", 60 },
			{ @"minuto", 60 },
			{ @"mins", 60 },
			{ @"min", 60 },
			{ @"secondi", 1 },
			{ @"secondo", 1 },
			{ @"secs", 1 },
			{ @"sec", 1 }
		};
		public static readonly Dictionary<string, string> SeasonMap = new Dictionary<string, string>
		{
			{ @"primavera", @"SP" },
			{ @"estate", @"SU" },
			{ @"autunno", @"FA" },
			{ @"inverno", @"WI" }
		};
		public static readonly Dictionary<string, int> SeasonValueMap = new Dictionary<string, int>
		{
			{ @"SP", 3 },
			{ @"SU", 6 },
			{ @"FA", 9 },
			{ @"WI", 12 }
		};
		public static readonly Dictionary<string, int> CardinalMap = new Dictionary<string, int>
		{
			{ @"primo", 1 },
			{ @"prima", 1 },
			{ @"seconda", 2 },
			{ @"secondo", 2 },
			{ @"terzo", 3 },
			{ @"terza", 3 },
			{ @"quarta", 4 },
			{ @"quarto", 4 },
			{ @"quinta", 5 },
			{ @"quinto", 5 }
		};
		public static readonly Dictionary<string, int> DayOfWeek = new Dictionary<string, int>
		{
			{ @"lunedì", 1 },
			{ @"martedì", 2 },
			{ @"mercoledì", 3 },
			{ @"giovedì", 4 },
			{ @"venerdì", 5 },
			{ @"sabato", 6 },
			{ @"domenica", 0 },
			{ @"lun", 1 },
			{ @"mar", 2 },
			{ @"mer", 3 },
			{ @"gio", 4 },
			{ @"ven", 5 },
			{ @"sab", 6 },
			{ @"dom", 0 }
		};
		public static readonly Dictionary<string, int> MonthOfYear = new Dictionary<string, int>
		{
			{ @"gennaio", 1 },
			{ @"febbraio", 2 },
			{ @"marzo", 3 },
			{ @"aprile", 4 },
			{ @"maggio", 5 },
			{ @"giugno", 6 },
			{ @"luglio", 7 },
			{ @"agosto", 8 },
			{ @"settembre", 9 },
			{ @"ottobre", 10 },
			{ @"novembre", 11 },
			{ @"dicembre", 12 },
			{ @"gen", 1 },
			{ @"feb", 2 },
			{ @"mar", 3 },
			{ @"apr", 4 },
			{ @"giu", 6 },
			{ @"lug", 7 },
			{ @"ago", 8 },
			{ @"set", 9 },
			{ @"ott", 10 },
			{ @"nov", 11 },
			{ @"dic", 12 },
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
			{ @"09", 9 }
		};
		public static readonly Dictionary<string, int> Numbers = new Dictionary<string, int>
		{
			{ @"zero", 0 },
			{ @"uno", 1 },
			{ @"un", 1 },
			{ @"una", 1 },
			{ @"due", 2 },
			{ @"tre", 3 },
			{ @"quattro", 4 },
			{ @"cinque", 5 },
			{ @"sei", 6 },
			{ @"sette", 7 },
			{ @"otto", 8 },
			{ @"nove", 9 },
			{ @"dieci", 10 },
			{ @"undici", 11 },
			{ @"dodici", 12 },
			{ @"tredici", 13 },
			{ @"quattordici", 14 },
			{ @"quindici", 15 },
			{ @"sedici", 16 },
			{ @"diciassette", 17 },
			{ @"diciotto", 18 },
			{ @"diciannove", 19 },
			{ @"venti", 20 },
			{ @"ventuno", 21 },
			{ @"ventidue", 22 },
			{ @"twenty three", 23 },
			{ @"twenty four", 24 },
			{ @"twenty five", 25 },
			{ @"twenty six", 26 },
			{ @"twenty seven", 27 },
			{ @"twenty eight", 28 },
			{ @"twenty nine", 29 },
			{ @"thirty", 30 },
			{ @"thirty one", 31 },
			{ @"thirty two", 32 },
			{ @"thirty three", 33 },
			{ @"thirty four", 34 },
			{ @"thirty five", 35 },
			{ @"thirty six", 36 },
			{ @"thirty seven", 37 },
			{ @"thirty eight", 38 },
			{ @"thirty nine", 39 },
			{ @"forty", 40 },
			{ @"forty one", 41 },
			{ @"forty two", 42 },
			{ @"forty three", 43 },
			{ @"forty four", 44 },
			{ @"forty five", 45 },
			{ @"forty six", 46 },
			{ @"forty seven", 47 },
			{ @"forty eight", 48 },
			{ @"forty nine", 49 },
			{ @"fifty", 50 },
			{ @"fifty one", 51 },
			{ @"fifty two", 52 },
			{ @"fifty three", 53 },
			{ @"fifty four", 54 },
			{ @"fifty five", 55 },
			{ @"fifty six", 56 },
			{ @"fifty seven", 57 },
			{ @"fifty eight", 58 },
			{ @"fifty nine", 59 },
			{ @"sixty", 60 },
			{ @"sixty one", 61 },
			{ @"sixty two", 62 },
			{ @"sixty three", 63 },
			{ @"sixty four", 64 },
			{ @"sixty five", 65 },
			{ @"sixty six", 66 },
			{ @"sixty seven", 67 },
			{ @"sixty eight", 68 },
			{ @"sixty nine", 69 },
			{ @"seventy", 70 },
			{ @"seventy one", 71 },
			{ @"seventy two", 72 },
			{ @"seventy three", 73 },
			{ @"seventy four", 74 },
			{ @"seventy five", 75 },
			{ @"seventy six", 76 },
			{ @"seventy seven", 77 },
			{ @"seventy eight", 78 },
			{ @"seventy nine", 79 },
			{ @"eighty", 80 },
			{ @"eighty one", 81 },
			{ @"eighty two", 82 },
			{ @"eighty three", 83 },
			{ @"eighty four", 84 },
			{ @"eighty five", 85 },
			{ @"eighty six", 86 },
			{ @"eighty seven", 87 },
			{ @"eighty eight", 88 },
			{ @"eighty nine", 89 },
			{ @"ninety", 90 },
			{ @"ninety one", 91 },
			{ @"ninety two", 92 },
			{ @"ninety three", 93 },
			{ @"ninety four", 94 },
			{ @"ninety five", 95 },
			{ @"ninety six", 96 },
			{ @"ninety seven", 97 },
			{ @"ninety eight", 98 },
			{ @"ninety nine", 99 },
			{ @"one hundred", 100 }
		};
		public static readonly Dictionary<string, int> DayOfMonth = new Dictionary<string, int>
		{
			{ @"1st", 1 },
			{ @"2nd", 2 },
			{ @"3rd", 3 },
			{ @"4th", 4 },
			{ @"5th", 5 },
			{ @"6th", 6 },
			{ @"7th", 7 },
			{ @"8th", 8 },
			{ @"9th", 9 },
			{ @"10th", 10 },
			{ @"11th", 11 },
			{ @"11st", 11 },
			{ @"12th", 12 },
			{ @"12nd", 12 },
			{ @"13th", 13 },
			{ @"13rd", 13 },
			{ @"14th", 14 },
			{ @"15th", 15 },
			{ @"16th", 16 },
			{ @"17th", 17 },
			{ @"18th", 18 },
			{ @"19th", 19 },
			{ @"20th", 20 },
			{ @"21st", 21 },
			{ @"22nd", 22 },
			{ @"23rd", 23 },
			{ @"24th", 24 },
			{ @"25th", 25 },
			{ @"26th", 26 },
			{ @"27th", 27 },
			{ @"28th", 28 },
			{ @"29th", 29 },
			{ @"30th", 30 },
			{ @"31st", 31 }
		};
		public static readonly Dictionary<string, double> DoubleNumbers = new Dictionary<string, double>
		{
			{ @"mezzo", 0.5 },
			{ @"quarto", 0.25 }
		};
		public static readonly Dictionary<string, IEnumerable<string>> HolidayNames = new Dictionary<string, IEnumerable<string>>
		{
			{ @"pasqua", new string[] { @"pasqua" } },
			{ @"lunedidellangelo", new string[] { @"lunedidellangelo" } },
			{ @"festadelpapa", new string[] { @"festadelpapa" } },
			{ @"festadellamamma", new string[] { @"festadellamamma" } },
			{ @"giornodellamemoria", new string[] { @"giornodellamemoria" } },
			{ @"martedigrasso", new string[] { @"martedigrasso" } },
			{ @"leceneri", new string[] { @"leceneri", @"mercoledidelleceneri" } },
			{ @"tuttiisanti", new string[] { @"tuttiisanti" } },
			{ @"imorti", new string[] { @"imorti" } },
			{ @"festadelladonna", new string[] { @"festadelladonna" } },
			{ @"lamadonna", new string[] { @"lamadonna" } },
			{ @"ferragosto", new string[] { @"ferragosto" } },
			{ @"natale", new string[] { @"natale" } },
			{ @"vigiliadinatale", new string[] { @"vigiliadinatale" } },
			{ @"capodanno", new string[] { @"capodanno" } },
			{ @"sanvalentino", new string[] { @"sanvalentino" } },
			{ @"stpatrickday", new string[] { @"stpatrickday" } },
			{ @"pescedaprile", new string[] { @"pescedaprile" } },
			{ @"festadeilavoratori", new string[] { @"festadeilavoratori" } },
			{ @"liberazione", new string[] { @"liberazione" } },
			{ @"festadellarepubblica", new string[] { @"festadellarepubblica" } },
			{ @"halloween", new string[] { @"halloween" } },
			{ @"cenonedicapodoanno", new string[] { @"cenonedicapodoanno" } }
		};
		public static readonly Dictionary<string, int> WrittenDecades = new Dictionary<string, int>
		{
			{ @"cento", 0 },
			{ @"dieci", 10 },
			{ @"decennio", 10 },
			{ @"venti", 20 },
			{ @"ventennio", 20 },
			{ @"trenta", 30 },
			{ @"quaranta", 40 },
			{ @"cinquanta", 50 },
			{ @"sessanta", 60 },
			{ @"settanta", 70 },
			{ @"ottanta", 80 },
			{ @"novanta", 90 }
		};
		public static readonly Dictionary<string, int> SpecialDecadeCases = new Dictionary<string, int>
		{
			{ @"questo secolo", 2000 },
			{ @"duemila", 2000 }
		};
		public const string DefaultLanguageFallback = @"DMY";
		public static readonly string[] DurationDateRestrictions = {  };
		public static readonly IList<string> MorningTermList = new List<string>
		{
			@"matinee",
			@"matin",
			@"matinée"
		};
		public static readonly IList<string> AfternoonTermList = new List<string>
		{
			@"apres-midi",
			@"apres midi",
			@"après midi",
			@"après-midi"
		};
		public static readonly IList<string> EveningTermList = new List<string>
		{
			@"soir",
			@"soiree",
			@"soirée"
		};
		public static readonly IList<string> DaytimeTermList = new List<string>
		{
			@"jour",
			@"journee",
			@"journée"
		};
		public static readonly IList<string> NightTermList = new List<string>
		{
			@"nuit"
		};
		public static readonly string[] SameDayTerms = {  };
		public static readonly string[] PlusOneDayTerms = {  };
		public static readonly string[] MinusOneDayTerms = {  };
		public static readonly string[] PlusTwoDayTerms = {  };
		public static readonly string[] MinusTwoDayTerms = {  };
		public static readonly IList<string> FutureStartTerms = new List<string>
		{
			@"cette"
		};
		public static readonly IList<string> FutureEndTerms = new List<string>
		{
			@"prochaine",
			@"prochain"
		};
		public static readonly IList<string> LastCardinalTerms = new List<string>
		{
			@"dernières",
			@"dernière",
			@"dernieres",
			@"derniere",
			@"dernier"
		};
		public static readonly IList<string> MonthTerms = new List<string>
		{
			@"mois"
		};
		public static readonly IList<string> MonthToDateTerms = new List<string>
		{
			@"mois à ce jour"
		};
		public static readonly IList<string> WeekendTerms = new List<string>
		{
			@"fin de semaine",
			@"le weekend"
		};
		public static readonly IList<string> WeekTerms = new List<string>
		{
			@"semaine"
		};
		public static readonly IList<string> YearTerms = new List<string>
		{
			@"années",
			@"ans",
			@"l'annees",
			@"l'annee"
		};
		public static readonly IList<string> YearToDateTerms = new List<string>
		{
			@"année à ce jour",
			@"an à ce jour"
		};
	}
}