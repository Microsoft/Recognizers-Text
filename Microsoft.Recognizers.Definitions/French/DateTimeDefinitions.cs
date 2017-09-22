﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\French\French-DateTime.yaml
//     - Language: French
//     - ClassName: DateTimeDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.French
{
	using System;
	using System.Collections.Generic;

	public static class DateTimeDefinitions
	{
		public const string TillRegex = @"(?<till>à|au|et|jusqu'[aà]|avant|--|-|—|——)";
		public const string RangeConnectorRegex = @"(?<and>et|de la|au|et\s*la|--|-|—|——)";
		public const string RelativeRegex = @"(?<order>prochain|ce|cette|l[ae]|derni[eè]re|pr[eé]c[eé]dente|au\s+cours+(de|du\s*))";
		public const string NextSuffixRegex = @"(?<order>prochain|prochaine|prochaines|suivante)\b";
		public const string PastSuffixRegex = @"(?<order>dernier|derni[eè]re|pr[eé]c[eé]dente)\b";
		public const string ThisPrefixRegex = @"(?<order>ce|cette|au\s+cours+(du|de))\b";
		public const string DayRegex = @"(?<day>01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|1er|1|21|20|22|23|24|25|26|27|28|29|2|30|31|3|4|5|6|7|8|9)(?=\b|t)";
		public const string MonthNumRegex = @"(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)\b";
		public const string PeriodYearRegex = @"\b(?<year>19\d{2}|20\d{2})\b";
		public const string WeekDayRegex = @"(?<weekday>Dimanche|Lundi|Mardi|Mecredi|Jeudi|Vendredi|Samedi|Lun|Mar|Mer|Jeu|Ven|Sam|Dim)\b";
		public static readonly string RelativeMonthRegex = $@"(?<relmonth>({ThisPrefixRegex}\s+mois)|(mois\s+{PastSuffixRegex})|(mois\s+{NextSuffixRegex}))\b";
		public const string EngMonthRegex = @"(?<month>Avril|Avr\.|Avr|Août|D[eé]cembre|D[eé]c|D[eé]c\.|F[eé]vrier|F[eé]v|F[eé]vr\.|F[eé]vr|Javier|Jan|Janv\.|Janv|Juillet|Jul|Juil|Juil\.|Juin|Jun|Mars|Mar|Mai|Novembre|Nov|Nov\.|Octobre|Oct|Oct\.|Septembre|Sep|Sept|Sept\.)";
		public static readonly string MonthSuffixRegex = $@"(?<msuf>(en\s*|le\s*|de\s*|dans\s*)?({RelativeMonthRegex}|{EngMonthRegex}))";
		public const string DateUnitRegex = @"(?<unit>l'ann[eé]e|ann[eé]es|an|mois|semaines|semaine|journ[eé]e|journ[eé]es|jour|jours)\b";
		public static readonly string SimpleCasesRegex = $@"\b((d[ue])|entre\s+)?({DayRegex})\s*{TillRegex}\s*({DayRegex})\s+{MonthSuffixRegex}((\s+|\s*,\s*){PeriodYearRegex})?\b";
		public static readonly string MonthFrontSimpleCasesRegex = $@"\b((d[ue]|entre)\s+)?{MonthSuffixRegex}\s+((d[ue]|entre)\s+)?({DayRegex})\s*{TillRegex}\s*({DayRegex})((\s+|\s*,\s*){PeriodYearRegex})?\b";
		public static readonly string MonthFrontBetweenRegex = $@"\b{MonthSuffixRegex}\s+(entre|d[ue]\s+)({DayRegex})\s*{RangeConnectorRegex}\s*({DayRegex})((\s+|\s*,\s*){PeriodYearRegex})?\b";
		public static readonly string BetweenRegex = $@"\b(entre|d[ue]\s+)({DayRegex})\s*{RangeConnectorRegex}\s*({DayRegex})\s+{MonthSuffixRegex}((\s+|\s*,\s*){PeriodYearRegex})?\b";
		public const string YearWordRegex = @"\b(?<year>l'ann[ée]e)\b";
		public static readonly string MonthWithYear = $@"\b((?<month>Avril|Avr\.|Avr|Août|Aout|Decembre|D[eé]c|Dec\.|F[eé]v|F[eé]vr|Fev|F[eé]vrier|F[eé]v\.|Janvier|Jan|Janv|Janv\.|Jan\.|Jul|Juillet|Juil\.|Jun|Juin|Mar|Mars|Mai|Novembre|Nov|Nov\.|Octobre|Oct|Oct\.|Septembre|Sep|Sept|Sept\.),?(\s+de)?\s+({PeriodYearRegex}|(?<order>cette)\s*{YearWordRegex})|{YearWordRegex}\s*({PastSuffixRegex}|{NextSuffixRegex}))";
		public static readonly string OneWordPeriodRegex = $@"\b(({RelativeRegex}\s+)?(?<month>Avril|Avr\.|Avr|Août|Aout|D[eé]cembre|Dec|D[eé]c\.|F[eé]vrier|Fev|F[eé]v\.|F[eé]vr|Janvier|Janv\.|Janv|Jan|Jan\.|Jul|Juillet|Juil\.|Jun|Juin|Mar|Mars|Mai|Nov|Novembre|Nov\.|Oct|Octobre|Oct\.|Sep|Septembre|Sept\.)|{RelativeRegex}\s+(weekend|week-end|semaine|mois|ans|l'année)|weekend|week-end|(mois|l'année))\b";
		public static readonly string MonthNumWithYear = $@"({PeriodYearRegex}[/\-\.]{MonthNumRegex})|({MonthNumRegex}[/\-]{PeriodYearRegex})";
		public static readonly string WeekOfMonthRegex = $@"(?<wom>(le\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4|cinqi[èe]me|5)\s+semaine\s+{MonthSuffixRegex})";
		public static readonly string WeekOfYearRegex = $@"(?<woy>(le\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4|cinqi[èe]me|5)\s+semaine(\s+de)?\s+({PeriodYearRegex}|{RelativeRegex}\s+ann[ée]e))";
		public static readonly string FollowedDateUnit = $@"^\s*{DateUnitRegex}";
		public static readonly string NumberCombinedWithDateUnit = $@"\b(?<num>\d+(\.\d*)?){DateUnitRegex}";
		public static readonly string QuarterRegex = $@"(le\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4)\s+quart(\s+de|\s*,\s*)?\s+({PeriodYearRegex}|{RelativeRegex}\s+l'année)";
		public static readonly string QuarterRegexYearFront = $@"({PeriodYearRegex}|l'année\s+({{PastSuffixRegex}}|{{NextSuffixRegex}})|{RelativeRegex}\s+ann[eé]e)\s+(le\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4)\s+quarts";
		public static readonly string SeasonRegex = $@"\b((<seas>printemps|été|automne|hiver)+\s*({NextSuffixRegex}|{PastSuffixRegex}))|(?<season>({RelativeRegex}\s+)?(?<seas>printemps|[ée]t[ée]|automne|hiver)((\s+de|\s*,\s*)?\s+({PeriodYearRegex}|{RelativeRegex}\s+year))?)\b";
		public const string WhichWeekRegex = @"(semaine)(\s*)(?<number>\d\d|\d|0\d)";
		public const string WeekOfRegex = @"(semaine)(\s*)(de)";
		public const string MonthOfRegex = @"(mois)(\s*)(de)";
		public const string MonthRegex = @"(?<month>Avril|Avr|Avr\.|Août|Aout|Decembre|D[eé]c|Dec\.|F[eé]vrier|F[eé]vr|Fev|F[eé]v|F[eé]v\.|Janvier|Janv\.|Janv|Jan|Jan\.|Juillet|Juil|Juil\.|Juin|Mars|Mai|Novembre|Nov|Nov\.|Octobre|Oct|Oct\.|Septembre|Sep|Sept|Sept\.)";
		public const string DateYearRegex = @"(?<year>19\d{2}|20\d{2}|((9\d|0\d|1\d|2\d)(?!\s*\:)))";
		public static readonly string OnRegex = $@"(?<=\ben\s+)({DayRegex}s?)\b";
		public const string RelaxedOnRegex = @"(?<=\b(en|le|dans|du)\s+)((?<day>10|11|12|13|14|15|16|17|18|19|1er|20|21|22|23|24|25|26|27|28|29|2|30h|31|3|4|5|6|7|8|9)s?)\b";
		public static readonly string ThisRegex = $@"\b((cette(\s*semaine)?\s+){WeekDayRegex})|({WeekDayRegex}(\s+cette\s*semaine))\b";
		public static readonly string LastDateRegex = $@"\b(({WeekDayRegex}(\s*(de)?\s*la\s*semaine\s+{PastSuffixRegex}))|({WeekDayRegex}(\s+{PastSuffixRegex})))\b";
		public static readonly string NextDateRegex = $@"\b(({WeekDayRegex}(\s+{NextSuffixRegex}))|({WeekDayRegex}(\s*(de)?\s*la\s*semaine\s+{NextSuffixRegex})))\b";
		public const string SpecialDayRegex = @"\b(avant[\s|-]hier|apr[eè]s(-demain|demain)|(le\s)?jour suivant|(le\s+)?dernier jour|hier|lendemain|demain|aujourd'hui)\b";
		public const string StrictWeekDay = @"\b(?<weekday>Dimanche|Lundi|Mardi|Mecredi|Jeudi|Vendredi|Samedi|Lun|Mar|Mer|Jeu|Ven|Sam|Dim)s?\b";
		public static readonly string WeekDayOfMonthRegex = $@"(?<wom>(le\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4|cinqi[èe]me|5)\s+{WeekDayRegex}\s+{MonthSuffixRegex})";
		public static readonly string SpecialDate = $@"(?<=\b([àa]|au|le)\s+){DayRegex}\b";
		public static readonly string DateExtractor1 = $@"\b({WeekDayRegex}(\s+|\s*,\s*))?{MonthRegex}\s*[/\\\.\-]?\s*{DayRegex}\b";
		public static readonly string DateExtractor2 = $@"\b({WeekDayRegex}(\s+|\s*,\s*))?{DayRegex}(\s+|\s*,\s*|\s+){MonthRegex}\s*[\.\-]?\s*{DateYearRegex}\b";
		public static readonly string DateExtractor3 = $@"\b({WeekDayRegex}(\s+|\s*,\s*))?{DayRegex}(\s+|\s*,\s*|\s*-\s*){MonthRegex}((\s+|\s*,\s*){DateYearRegex})?\b";
		public static readonly string DateExtractor4 = $@"\b{MonthNumRegex}\s*[/\\\-]\s*{DayRegex}\s*[/\\\-]\s*{DateYearRegex}";
		public static readonly string DateExtractor5 = $@"\b{DayRegex}\s*[/\\\-]\s*{MonthNumRegex}\s*[/\\\-]\s*{DateYearRegex}";
		public static readonly string DateExtractor6 = $@"(?<=\b(le|sur|sur l[ae])\s+){MonthNumRegex}[\-\.\/]{DayRegex}\b";
		public static readonly string DateExtractor7 = $@"\b{DayRegex}\s*/\s*{MonthNumRegex}((\s+|\s*,\s*){DateYearRegex})?\b";
		public static readonly string DateExtractor8 = $@"(?<=\b(le)\s+){DayRegex}[\\\-]{MonthNumRegex}\b";
		public static readonly string DateExtractor9 = $@"\b{DayRegex}\s*/\s*{MonthNumRegex}((\s+|\s*,\s*){DateYearRegex})?\b";
		public static readonly string DateExtractorA = $@"\b{DateYearRegex}\s*[/\\\-]\s*{MonthNumRegex}\s*[/\\\-]\s*{DayRegex}";
		public static readonly string OfMonth = $@"^\s*de\s*{MonthRegex}";
		public static readonly string MonthEnd = $@"{MonthRegex}\s*(le)?\s*$";
		public const string RangeUnitRegex = @"\b(?<unit>l'année|ann[eé]e(s)?|mois|semaines|semaine)\b";
		public const string DescRegex = @"(?<desc>ampm|am\b|a\.m\.|a m\b|a\. m\.|a\.m\b|a\. m\b|pm\b|p\.m\.|p m\b|p\. m\.|p\.m\b|p\. m\b|p\b\b)";
		public const string HourNumRegex = @"\b(?<hournum>zero|un|deux|trois|quatre|cinq|six|sept|huit|neuf|dix|onze|douze|treize|quatorze|quinze|dix-six|dix-sept|dix-huit|dix-neuf|vingt|vingt-et-un|vingt-deux|vingt-trois)\b";
		public const string MinuteNumRegex = @"(?<minnum>un|deux|trois|quatre|cinq|six|sept|huit|neuf|dix|onze|douze|treize|quatorze|quinze|seize|dix-sept|dix-huit|dix-neuf|vingt|trente|quarante|cinquante)";
		public const string DeltaMinuteNumRegex = @"(?<deltaminnum>un|deux|trois|quatre|cinq|six|sept|huit|neuf|dix|onze|douze|treize|quatorze|quinze|seize|dix-sept|dix-huit|dix-neuf|vingt|trente|quarante|cinquante)";
		public const string OclockRegex = @"(?<oclock>heure|heures)";
		public const string PmRegex = @"(?<pm>(dans l'\s*)?apr[eè]s(\s*|-)midi|((du|ce|de|le)?\s*(soir[ée]e|soir))|(dans l[ea]\s+)?soir[eé]e|(dans la\s+)?nuit)";
		public const string AmRegex = @"(?<am>(du|de|ce|dans l[ea]|le)?\s*matin|(du|de|ce|(du|de|dans)\s*l[ea]|le)?\s*matin[ée]e)";
		public static readonly string LessThanOneHour = $@"(?<lth>(une\s+)?quart|trois quart(s)?|demi( heure)?|{BaseDateTime.DeltaMinuteRegex}(\s+(minute|minutes|min|mins))|{DeltaMinuteNumRegex}(\s+(minute|minutes|min|mins)))";
		public static readonly string EngTimeRegex = $@"(?<engtime>{HourNumRegex}\s+({MinuteNumRegex}|(?<tens>vingt|trente|quarante|cinquante)\s+{MinuteNumRegex}))";
		public static readonly string TimePrefix = $@"(?<prefix>(et {LessThanOneHour}|{LessThanOneHour} [àa]))";
		public static readonly string TimeSuffix = $@"(?<suffix>{AmRegex}|{PmRegex}|{OclockRegex})";
		public static readonly string BasicTime = $@"(?<basictime>{EngTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}:{BaseDateTime.MinuteRegex}(:{BaseDateTime.SecondRegex})?|{BaseDateTime.HourRegex})";
		public const string MidnightRegex = @"(?<midnight>minuit)";
		public const string MorningRegex = @"(?<morning>matin|matin[ée]e)";
		public const string AfternoonRegex = @"(?<afternoon>apr[eè]s(-|\s*)midi)";
		public static readonly string MidmorningRegex = $@"(?<midmorning>milieu\s*d[ue]\s*{MorningRegex})";
		public const string MiddayRegex = @"(?<midday>milieu(\s*|-)d[eu]\s*(jour|midi)|apr[eè]s(-|\s*)midi)";
		public static readonly string MidafternoonRegex = $@"(?<midafternoon>milieu\s*d'+{AfternoonRegex})";
		public static readonly string MidTimeRegex = $@"(?<mid>({MidnightRegex}|{MidmorningRegex}|{MidafternoonRegex}|{MiddayRegex}))";
		public static readonly string AtRegex = $@"\b(((?<=\b[àa]\s+)({EngTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}|{MidTimeRegex}))|{MidTimeRegex})\b";
		public static readonly string IshRegex = $@"\b(peu\s*pr[èe]s\s*{BaseDateTime.HourRegex}|peu\s*pr[èe]s\s*{EngTimeRegex}|peu\s*pr[èe]s\s*[àa]\s*{BaseDateTime.HourRegex}|peu pr[èe]s midi)\b";
		public const string TimeUnitRegex = @"(?<unit>heures|heure|hrs|hr|h|minutes|minute|mins|min|secondes|seconde|secs|sec)\b";
		public static readonly string ConnectNumRegex = $@"{BaseDateTime.HourRegex}(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59)\s*{DescRegex}";
		public static readonly string TimeRegex1 = $@"\b({TimePrefix}\s+)?({EngTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\s*{DescRegex}";
		public static readonly string TimeRegex2 = $@"(\b{TimePrefix}\s+)?(T)?{BaseDateTime.HourRegex}(\s*)?:(\s*)?{BaseDateTime.MinuteRegex}((\s*)?:(\s*)?{BaseDateTime.SecondRegex})?((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex3 = $@"(\b{TimePrefix}\s+)?{BaseDateTime.HourRegex}\.{BaseDateTime.MinuteRegex}(\s*{DescRegex})";
		public static readonly string TimeRegex4 = $@"\b{TimePrefix}\s+{BasicTime}(\s*{DescRegex})?\s+{TimeSuffix}\b";
		public static readonly string TimeRegex5 = $@"\b{TimePrefix}\s+{BasicTime}((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex6 = $@"{BasicTime}(\s*{DescRegex})?\s+{TimeSuffix}\b";
		public static readonly string TimeRegex7 = $@"\b{TimeSuffix}\s+[àa]\s+{BasicTime}((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex8 = $@"\b{TimeSuffix}\s+{BasicTime}((\s*{DescRegex})|\b)";
		public static readonly string TimeRegex9 = $@"\b{PeriodHourNumRegex}\s+{FivesRegex}((\s*{DescRegex})|\b)";
		public const string FivesRegex = @"(?<tens>(quinze|vingt(\s*|-*(cinq))?|trente(\s*|-*(cinq))?|quarante(\s*|-*(cinq))??|cinquante(\s*|-*(cinq))?|dix|cinq))\b";
		public const string HourRegex = @"(?<hour>00|01|02|03|04|05|06|07|08|09|0|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|1|2|3|4|5|6|7|8|9)";
		public const string PeriodHourNumRegex = @"(?<hour>vingt-et-un|vingt-deux|vingt-trois|vingt-quatre|zero|une|deux|trois|quatre|cinq|six|sept|huit|neuf|dix|onze|douze|treize|quatorze|quinze|seize|dix-sept|dix-huit|dix-neuf|vingt)";
		public const string PeriodDescRegex = @"(?<desc>pm|am|p\.m\.|a\.m\.|p)";
		public const string PeriodPmRegex = @"(?<pm>dans l'apr[eè]s-midi|soir|dans la soir[eé]e|dans la nuit|d[eu] soir)s?";
		public const string PeriodAmRegex = @"(?<am>matin|d[eu] matin|matin[ée]e)s?";
		public static readonly string PureNumFromTo = $@"((du|de|depuis)\s+)?({HourRegex}|{PeriodHourNumRegex})(\s*(?<leftDesc>{PeriodDescRegex}))?\s*{TillRegex}\s*({HourRegex}|{PeriodHourNumRegex})\s*(?<rightDesc>{PmRegex}|{AmRegex}|{PeriodDescRegex})?";
		public static readonly string PureNumBetweenAnd = $@"(entre|du|de\s+)({HourRegex}|{PeriodHourNumRegex})(\s*(?<leftDesc>{PeriodDescRegex}))?\s*{RangeConnectorRegex}\s*({HourRegex}|{PeriodHourNumRegex})\s*(?<rightDesc>{PmRegex}|{AmRegex}|{PeriodDescRegex})?";
		public const string PrepositionRegex = @"(?<prep>^([aà] la|en|sur|de)$)";
		public const string TimeOfDayRegex = @"\b(?<timeOfDay>((((dans\s+(l[ea])?\s+)?((?<early>d[eé]but(\s+|-))|(?<late>fin de(\s+|-)))?(matin|apr[eè]s-midi|nuit|soir[eé]e)))|(((\s+(l[ea])?\s+)?)(jour|journ[eé]e)))s?)\b";
		public static readonly string SpecificTimeOfDayRegex = $@"\b(({RelativeRegex}\s+{TimeOfDayRegex})\b|\bsoir|\bdu soir)s?\b";
		public static readonly string TimeFollowedUnit = $@"^\s*{TimeUnitRegex}";
		public static readonly string TimeNumberCombinedWithUnit = $@"\b(?<num>\d+(\.\d*)?){TimeUnitRegex}";
		public const string NowRegex = @"\b(?<now>(ce\s+)?moment|maintenant|d[eè]s que possible|dqp|r[eé]cemment|auparavant)\b";
		public const string SuffixRegex = @"^\s*(dans\s+l[ea]\s+)|(en\s+)|(du)?(matin|matin([eé]e)?|apr[eè]s-midi|soir[eé]e|nuit)\b";
		public const string DateTimeTimeOfDayRegex = @"\b(?<timeOfDay>matin|matin[ée]e|apr[eè]s-midi|nuit|soir)\b";
		public static readonly string DateTimeSpecificTimeOfDayRegex = $@"\b(({RelativeRegex}\s+{DateTimeTimeOfDayRegex})\b|\b(ce|cette\s+)(soir|nuit))\b";
		public static readonly string TimeOfTodayAfterRegex = $@"^\s*(,\s*)?(en|dans|du\s+)?{DateTimeSpecificTimeOfDayRegex}";
		public static readonly string TimeOfTodayBeforeRegex = $@"{DateTimeSpecificTimeOfDayRegex}(\s*,)?(\s+([àa]|pour))?\s*$";
		public static readonly string SimpleTimeOfTodayAfterRegex = $@"({HourNumRegex}|{BaseDateTime.HourRegex})\s*(,\s*)?(en|[àa]\s+)?{DateTimeSpecificTimeOfDayRegex}";
		public static readonly string SimpleTimeOfTodayBeforeRegex = $@"{DateTimeSpecificTimeOfDayRegex}(\s*,)?(\s+([àa]|vers))?\s*({HourNumRegex}|{BaseDateTime.HourRegex})";
		public const string TheEndOfRegex = @"(la\s+)?fin(\s+de)?\s*$";
		public const string PeriodTimeOfDayRegex = @"\b((dans\s+(le)?\s+)?((?<early>d[eé]but(\s+|-|de|de la))|(?<late>fin(\s+|-|d[eu])))?(?<timeOfDay>matin|apr[eè]s-midi|nuit|soir))\b";
		public static readonly string PeriodSpecificTimeOfDayRegex = $@"\b(({RelativeRegex}\s+{PeriodTimeOfDayRegex})\b|\b(ce|cette\s+)(soir|nuit))\b";
		public static readonly string PeriodTimeOfDayWithDateRegex = $@"\b(({TimeOfDayRegex}))\b";
		public const string DurationUnitRegex = @"(?<unit>ans|ann[eé]e|mois|semaines|semaine|jour|jours|heures|heure|hrs|hr|h|minutes|minute|mins|min|secondes|seconde|secs|sec|ann[eé]es|journ[eé]e)\b";
		public const string SuffixAndRegex = @"(?<suffix>\s*(et)\s+((un|une)\s+)?(?<suffix_num>demi|quart))";
		public const string PeriodicRegex = @"\b(?<periodic>quotidienne|quotidien|journellement|mensuel|mensuelle|jour|jours|hebdomadaire|bihebdomadaire|annuellement|annuel)\b";
		public static readonly string EachUnitRegex = $@"(?<each>(chaque|toutes les|tous les)\s*{DurationUnitRegex})";
		public const string EachPrefixRegex = @"(?<each>(chaque|tous les|toutes les)\s*$)";
		public const string SetLastRegex = @"(?<last>prochain|dernier|pass[ée]s|pr[eé]c[eé]dent|courant|en\s*cours)";
		public const string EachDayRegex = @"^\s*(chaque|tous les)\s*(jour|jours)\b";
		public static readonly string DurationFollowedUnit = $@"^\s*{SuffixAndRegex}?(\s+|-)?{DurationUnitRegex}";
		public static readonly string NumberCombinedWithDurationUnit = $@"\b(?<num>\d+(\.\d*)?)(-)?{DurationUnitRegex}";
		public static readonly string AnUnitRegex = $@"\b(((?<half>demi\s+)?(-)\s+{DurationUnitRegex}))";
		public const string AllRegex = @"\b(?<all>toute\s(l['ea])\s?(?<unit>ann[eé]e|mois|semaine|semaines|jour|jours|journ[eé]e))\b";
		public const string HalfRegex = @"(((un|une)\s*)|\b)(?<half>demi?(\s*|-)+(?<unit>ann[eé]e|ans|mois|semaine|jour|heure))\b";
		public const string ConjunctionRegex = @"\b((et(\s+de|pour)?)|avec)\b";
		public const string YearRegex = @"\b(?<year>19\d{2}|20\d{2})\b";
		public static readonly string HolidayRegex1 = $@"\b(?<holiday>vendredi saint|mercredi des cendres|mardi gras|nouvel an chinois|nouvel an|jour de l'an|new year|premier-mai|ler-mai|1-mai|poisson d'avril|veillée de noël|veilee de noel|noël|noel|thanksgiving|halloween|yuandan)(\s+(de\s+)?({YearRegex}|{ThisPrefixRegex}\s+ann[eé]e|ann[eé]e\s+({PastSuffixRegex}|{NextSuffixRegex})))?\b";
		public static readonly string HolidayRegex2 = $@"\b(?<holiday>martin luther king|martin luther king jr|toussaint|st patrick|st george|cinco de mayo|l'ind[eé]pendance|guy fawkes)(\s+(de\s+)?({YearRegex}|{ThisPrefixRegex}\s+ann[eé]e|ann[eé]e\s+({PastSuffixRegex}|{NextSuffixRegex})))?\b";
		public static readonly string HolidayRegex3 = $@"(?<holiday>(canberra|p[aâ]ques|colomb|thanks\s*giving|f[eê]te\s*du\s*travail|m[eè]res|p[eè]res|nationale|d'armistice|assomption|femme|comm[ée]moratif)\s+(day))(\s+(de\s+)?({YearRegex}|{{ThisPrefixRegex}}\s+ann[eé]e|ann[eé]e\s+({{PastSuffixRegex}}|{{NextSuffixRegex}})))?";
		public const string DateTokenPrefix = "le ";
		public const string TimeTokenPrefix = "à ";
		public const string TokenBeforeDate = "le ";
		public const string TokenBeforeTime = "à ";
		public const string AMTimeRegex = @"(?<am>matin)";
		public const string PMTimeRegex = @"\b(?<pm>apr[eè]s-midi|soir|nuit)\b";
		public const string BeforeRegex = @"\b(avant)\b";
		public const string AfterRegex = @"\b(apr[eè]s|depuis)\b";
		public const string AgoPrefixRegex = @"\b(y a)\b";
		public const string LaterRegex = @"\b(plus tard)\b";
		public const string InConnectorRegex = @"\b(dans|en|sur)\b";
		public const string AmDescRegex = @"(am\b|a\.m\.|a m\b|a\. m\.|a\.m\b|a\. m\b)";
		public const string PmDescRegex = @"(pm\b|p\.m\.|p\b|p m\b|p\. m\.|p\.m\b|p\. m\b)";
		public const string AmPmDescRegex = @"(ampm)";
		public const string MorningStartEndRegex = @"(^(matin))|((matin)$)";
		public const string AfternoonStartEndRegex = @"(^(apr[eè]s-midi))|((apr[eè]s-midi)$)";
		public const string EveningStartEndRegex = @"(^(soir))|((soir)$)";
		public const string NightStartEndRegex = @"(^(nuit))|((nuit)$)";
		public const string InExactNumberRegex = @"\b(quelque|quel qu[ée]s|quelqu[ée]s|plusieurs)\b";
		public static readonly string InExactNumberUnitRegex = $@"({InExactNumberRegex})\s+({DurationUnitRegex})";
		public static readonly string RelativeTimeUnitRegex = $@"({RelativeRegex})\s+({TimeUnitRegex})";
		public const string ConnectorRegex = @"^(,|pour|t|vers)$";
		public const string FromToRegex = @"\b(du|de|depuis).+(à|au)\b.+";
		public static readonly Dictionary<string, string> UnitMap = new Dictionary<string, string>
		{
			{ "annees", "Y" },
			{ "annee", "Y" },
			{ "ans", "Y" },
			{ "mois", "MON" },
			{ "semaines", "W" },
			{ "semaine", "W" },
			{ "journees", "D" },
			{ "journee", "D" },
			{ "jour", "D" },
			{ "jours", "D" },
			{ "heures", "H" },
			{ "heure", "H" },
			{ "hrs", "H" },
			{ "hr", "H" },
			{ "h", "H" },
			{ "minutes", "M" },
			{ "minute", "M" },
			{ "mins", "M" },
			{ "min", "M" },
			{ "secondes", "S" },
			{ "seconde", "S" },
			{ "secs", "S" },
			{ "sec", "S" }
		};
		public static readonly Dictionary<string, long> UnitValueMap = new Dictionary<string, long>
		{
			{ "annees", 31536000 },
			{ "annee", 31536000 },
			{ "l'annees", 31536000 },
			{ "l'annee", 31536000 },
			{ "ans", 31536000 },
			{ "mois", 2592000 },
			{ "semaines", 604800 },
			{ "semaine", 604800 },
			{ "journees", 86400 },
			{ "journee", 86400 },
			{ "jour", 86400 },
			{ "jours", 86400 },
			{ "heures", 3600 },
			{ "heure", 3600 },
			{ "hrs", 3600 },
			{ "hr", 3600 },
			{ "h", 3600 },
			{ "minutes", 60 },
			{ "minute", 60 },
			{ "mins", 60 },
			{ "min", 60 },
			{ "secondes", 1 },
			{ "seconde", 1 },
			{ "secs", 1 },
			{ "sec", 1 }
		};
		public static readonly Dictionary<string, string> SeasonMap = new Dictionary<string, string>
		{
			{ "printemps", "SP" },
			{ "été", "SU" },
			{ "automne", "FA" },
			{ "hiver", "WI" }
		};
		public static readonly Dictionary<string, int> SeasonValueMap = new Dictionary<string, int>
		{
			{ "SP", 3 },
			{ "SU", 6 },
			{ "FA", 9 },
			{ "WI", 12 }
		};
		public static readonly Dictionary<string, int> CardinalMap = new Dictionary<string, int>
		{
			{ "premier", 1 },
			{ "1er", 1 },
			{ "deuxième", 2 },
			{ "2e", 2 },
			{ "troisième", 3 },
			{ "troisieme", 3 },
			{ "3e", 3 },
			{ "quatrième", 4 },
			{ "4e", 4 },
			{ "cinqième", 5 },
			{ "5e", 5 }
		};
		public static readonly Dictionary<string, int> DayOfWeek = new Dictionary<string, int>
		{
			{ "lundi", 1 },
			{ "mardi", 2 },
			{ "mecredi", 3 },
			{ "jeudi", 4 },
			{ "vendredi", 5 },
			{ "samedi", 6 },
			{ "dimanche", 0 },
			{ "lun", 1 },
			{ "mar", 2 },
			{ "mer", 3 },
			{ "jeu", 4 },
			{ "ven", 5 },
			{ "sam", 6 },
			{ "dim", 0 }
		};
		public static readonly Dictionary<string, int> MonthOfYear = new Dictionary<string, int>
		{
			{ "janvier", 1 },
			{ "fevrier", 2 },
			{ "mars", 3 },
			{ "mar", 3 },
			{ "avril", 4 },
			{ "avr", 4 },
			{ "mai", 5 },
			{ "juin", 6 },
			{ "jun", 6 },
			{ "juillet", 7 },
			{ "aout", 8 },
			{ "septembre", 9 },
			{ "octobre", 10 },
			{ "novembre", 11 },
			{ "decembre", 12 },
			{ "janv", 1 },
			{ "janv.", 1 },
			{ "jan", 1 },
			{ "fevr", 2 },
			{ "fevr.", 2 },
			{ "févr.", 2 },
			{ "févr", 2 },
			{ "fev", 2 },
			{ "juil", 7 },
			{ "jul", 7 },
			{ "sep", 9 },
			{ "sept.", 9 },
			{ "sept", 9 },
			{ "oct", 10 },
			{ "oct.", 10 },
			{ "nov", 11 },
			{ "nov.", 11 },
			{ "dec", 12 },
			{ "déc.", 12 },
			{ "déc", 12 },
			{ "1", 1 },
			{ "2", 2 },
			{ "3", 3 },
			{ "4", 4 },
			{ "5", 5 },
			{ "6", 6 },
			{ "7", 7 },
			{ "8", 8 },
			{ "9", 9 },
			{ "10", 10 },
			{ "11", 11 },
			{ "12", 12 },
			{ "01", 1 },
			{ "02", 2 },
			{ "03", 3 },
			{ "04", 4 },
			{ "05", 5 },
			{ "06", 6 },
			{ "07", 7 },
			{ "08", 8 },
			{ "09", 9 }
		};
		public static readonly Dictionary<string, int> Numbers = new Dictionary<string, int>
		{
			{ "zero", 0 },
			{ "un", 1 },
			{ "une", 1 },
			{ "a", 1 },
			{ "deux", 2 },
			{ "trois", 3 },
			{ "quatre", 4 },
			{ "cinq", 5 },
			{ "six", 6 },
			{ "sept", 7 },
			{ "huit", 8 },
			{ "neuf", 9 },
			{ "dix", 10 },
			{ "onze", 11 },
			{ "douze", 12 },
			{ "treize", 13 },
			{ "quatorze", 14 },
			{ "quinze", 15 },
			{ "seize", 16 },
			{ "dix-sept", 17 },
			{ "dix-huit", 18 },
			{ "dix-neuf", 19 },
			{ "vingt-et-un", 21 },
			{ "vingt et un", 21 },
			{ "vingt", 20 },
			{ "vingt deux", 22 },
			{ "vingt-deux", 22 },
			{ "vingt trois", 23 },
			{ "vingt-trois", 23 },
			{ "vingt quatre", 24 },
			{ "vingt-quatre", 24 },
			{ "vingt cinq", 25 },
			{ "vingt-cinq", 25 },
			{ "vingt six", 26 },
			{ "vingt-six", 26 },
			{ "vingt sept", 27 },
			{ "vingt-sept", 27 },
			{ "vingt huit", 28 },
			{ "vingt-huit", 28 },
			{ "vingt neuf", 29 },
			{ "vingt-neuf", 29 },
			{ "trente", 30 },
			{ "trente et un", 31 },
			{ "trente-et-un", 31 },
			{ "trente deux", 32 },
			{ "trente-deux", 32 },
			{ "trente trois", 33 },
			{ "trente-trois", 33 },
			{ "trente quatre", 34 },
			{ "trente-quatre", 34 },
			{ "trente cinq", 35 },
			{ "trente-cinq", 35 },
			{ "trente six", 36 },
			{ "trente-six", 36 },
			{ "trente sept", 37 },
			{ "trente-sept", 37 },
			{ "thirty eight", 38 },
			{ "trente-huit", 38 },
			{ "thirty nine", 39 },
			{ "trente-neuf", 39 },
			{ "quarante", 40 },
			{ "quarante et un", 41 },
			{ "quarante-et-un", 41 },
			{ "quarante deux", 42 },
			{ "quarante-duex", 42 },
			{ "quarante trois", 43 },
			{ "quarante-trois", 43 },
			{ "quarante quatre", 44 },
			{ "quarante-quatre", 44 },
			{ "quarante cinq", 45 },
			{ "quarante-cinq", 45 },
			{ "quarante six", 46 },
			{ "quarante-six", 46 },
			{ "quarante sept", 47 },
			{ "quarante-sept", 47 },
			{ "quarante huit", 48 },
			{ "quarante-huit", 48 },
			{ "quarante neuf", 49 },
			{ "quarante-neuf", 49 },
			{ "cinquante", 50 },
			{ "cinquante et un", 51 },
			{ "cinquante-et-un", 51 },
			{ "cinquante deux", 52 },
			{ "cinquante-deux", 52 },
			{ "cinquante trois", 53 },
			{ "cinquante-trois", 53 },
			{ "cinquante quatre", 54 },
			{ "cinquante-quatre", 54 },
			{ "cinquante cinq", 55 },
			{ "cinquante-cinq", 55 },
			{ "cinquante six", 56 },
			{ "cinquante-six", 56 },
			{ "cinquante sept", 57 },
			{ "cinquante-sept", 57 },
			{ "cinquante huit", 58 },
			{ "cinquante-huit", 58 },
			{ "cinquante neuf", 59 },
			{ "cinquante-neuf", 59 },
			{ "soixante", 60 },
			{ "soixante et un", 61 },
			{ "soixante-et-un", 61 },
			{ "soixante deux", 62 },
			{ "soixante-deux", 62 },
			{ "soixante trois", 63 },
			{ "soixante-trois", 63 },
			{ "soixante quatre", 64 },
			{ "soixante-quatre", 64 },
			{ "soixante cinq", 65 },
			{ "soixante-cinq", 65 },
			{ "soixante six", 66 },
			{ "soixante-six", 66 },
			{ "soixante sept", 67 },
			{ "soixante-sept", 67 },
			{ "soixante huit", 68 },
			{ "soixante-huit", 68 },
			{ "soixante neuf", 69 },
			{ "soixante-neuf", 69 },
			{ "soixante dix", 70 },
			{ "soixante-dix", 70 },
			{ "soixante et onze", 71 },
			{ "soixante-et-onze", 71 },
			{ "soixante douze", 72 },
			{ "soixante-douze", 72 },
			{ "soixante treize", 73 },
			{ "soixante-treize", 73 },
			{ "soixante quatorze", 74 },
			{ "soixante-quatore", 74 },
			{ "soixante quinze", 75 },
			{ "soixante-quinze", 75 },
			{ "soixante seize", 76 },
			{ "soixante-seize", 76 },
			{ "soixante dix sept", 77 },
			{ "soixante-dix-sept", 77 },
			{ "soixante dix huit", 78 },
			{ "soixante-dix-huit", 78 },
			{ "soixante dix neuf", 79 },
			{ "soixante-dix-neuf", 79 },
			{ "quatre vingt", 80 },
			{ "quatre-vingt", 80 },
			{ "quatre vingt un", 91 },
			{ "quatre-vingt-un", 91 },
			{ "quatre vingt deux", 92 },
			{ "quatre-vingt-duex", 82 },
			{ "quatre vingt trois", 93 },
			{ "quatre-vingt-trois", 93 },
			{ "quatre vingt quatre", 94 },
			{ "quatre-vingt-quatre", 94 },
			{ "quatre vingt cinq", 95 },
			{ "quatre-vingt-cinq", 95 },
			{ "quatre vingt six", 86 },
			{ "quatre-vingt-six", 96 },
			{ "quatre vingt sept", 97 },
			{ "quatre-vingt-sept", 97 },
			{ "quatre vingt huit", 98 },
			{ "quatre-vingt-huit", 98 },
			{ "quatre vingt neuf", 99 },
			{ "quatre-vingt-neuf", 99 },
			{ "quatre vingt dix", 90 },
			{ "quatre-vingt-dix", 90 },
			{ "quatre-vingt-deux", 92 },
			{ "quantre vingt six", 96 },
			{ "cent", 100 }
		};
		public static readonly Dictionary<string, int> DayOfMonth = new Dictionary<string, int>
		{
			{ "1er", 1 },
			{ "1", 1 },
			{ "2", 2 },
			{ "3", 3 },
			{ "4", 4 },
			{ "5", 5 },
			{ "6", 6 },
			{ "7", 7 },
			{ "8", 8 },
			{ "9", 9 },
			{ "10", 10 },
			{ "11", 11 },
			{ "12", 12 },
			{ "13", 13 },
			{ "14", 14 },
			{ "15", 15 },
			{ "16", 16 },
			{ "17", 17 },
			{ "18", 18 },
			{ "19", 19 },
			{ "20", 20 },
			{ "21", 21 },
			{ "22", 22 },
			{ "23", 23 },
			{ "24", 24 },
			{ "25", 25 },
			{ "26", 26 },
			{ "27", 27 },
			{ "28", 28 },
			{ "29", 29 },
			{ "30", 30 },
			{ "31", 31 }
		};
		public static readonly Dictionary<string, double> DoubleNumbers = new Dictionary<string, double>
		{
			{ "demi", 0.5 },
			{ "quart", 0.25 }
		};
		public static readonly Dictionary<string, IEnumerable<string>> HolidayNames = new Dictionary<string, IEnumerable<string>>
		{
			{ "peres", new string[] { "fatherday", "fathersday" } },
			{ "pères", new string[] { "fatherday", "fathersday" } },
			{ "meres", new string[] { "motherday", "mothersday" } },
			{ "mères", new string[] { "motherday", "mothersday" } },
			{ "thanksgiving", new string[] { "thanksgivingday", "thanksgiving" } },
			{ "martinlutherking", new string[] { "martinlutherkingday", "martinlutherkingjrday" } },
			{ "canberra", new string[] { "canberraday" } },
			{ "travail", new string[] { "labourday", "laborday" } },
			{ "colomb", new string[] { "columbusday" } },
			{ "commémoratif", new string[] { "memorialday" } },
			{ "commemoratif", new string[] { "memorialday" } },
			{ "yuandan", new string[] { "yuandan" } },
			{ "toussaint", new string[] { "allsaintsday" } },
			{ "femme", new string[] { "femaleday" } },
			{ "noel", new string[] { "christmas" } },
			{ "noël", new string[] { "christmas" } },
			{ "newyear", new string[] { "newyear" } },
			{ "newyearday", new string[] { "newyearday" } },
			{ "newyearsday", new string[] { "newyearsday" } },
			{ "inaugurationday", new string[] { "inaugurationday" } },
			{ "groundhougday", new string[] { "groundhougday" } },
			{ "valentinesday", new string[] { "valentinesday" } },
			{ "stpatrickday", new string[] { "stpatrickday" } },
			{ "aprilfools", new string[] { "aprilfools" } },
			{ "stgeorgeday", new string[] { "stgeorgeday" } },
			{ "mayday", new string[] { "mayday" } },
			{ "cincodemayoday", new string[] { "cincodemayoday" } },
			{ "baptisteday", new string[] { "baptisteday" } },
			{ "usindependenceday", new string[] { "usindependenceday" } },
			{ "independenceday", new string[] { "independenceday" } },
			{ "bastilleday", new string[] { "bastilleday" } },
			{ "halloween", new string[] { "halloweenday" } },
			{ "guyfawkesday", new string[] { "guyfawkesday" } },
			{ "veteransday", new string[] { "veteransday" } },
			{ "christmaseve", new string[] { "christmaseve" } },
			{ "newyeareve", new string[] { "newyearseve", "newyeareve" } }
		};
	}
}