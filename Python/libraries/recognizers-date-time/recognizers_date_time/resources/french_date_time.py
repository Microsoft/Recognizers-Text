# ------------------------------------------------------------------------------
# <auto-generated>
#     This code was generated by a tool.
#     Changes to this file may cause incorrect behavior and will be lost if
#     the code is regenerated.
# </auto-generated>
# ------------------------------------------------------------------------------

from .base_date_time import BaseDateTime
# pylint: disable=line-too-long
class FrenchDateTime:
    TillRegex = f'(?<till>au|[aà]|et|jusqu\'[aà]|avant|--|-|—|——)'
    RangeConnectorRegex = f'(?<and>et|de la|au|[aà]|et\\s*la|--|-|—|——)'
    RelativeRegex = f'(?<order>prochain|prochaine|de|du|ce|cette|l[ae]|derni[eè]re|pr[eé]c[eé]dente|au\\s+cours+(de|du\\s*))'
    NextSuffixRegex = f'(?<order>prochain|prochaine|prochaines|suivante)\\b'
    PastSuffixRegex = f'(?<order>dernier|derni[eè]re|pr[eé]c[eé]dente)\\b'
    ThisPrefixRegex = f'(?<order>ce|cette|au\\s+cours+(du|de))\\b'
    DayRegex = f'(?<day>01|02|03|04|05|06|07|08|09|10|11|11e|12|12e|13|13e|14|14e|15|15e|16|16e|17|17e|18|18e|19|19e|1er|1|21|21e|20|20e|22|22e|23|23e|24|24e|25|25e|26|26e|27|27e|28|28e|29|29e|2|2e|30|30e|31|31e|3|3e|4|4e|5|5e|6|6e|7|7e|8|8e|9|9e)(?=\\b|t)'
    MonthNumRegex = f'(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)\\b'
    DescRegex = f'(?<desc>h|ampm|am\\b|a\\.m\\.|a m\\b|a\\. m\\.|a\\.m\\b|a\\. m\\b|pm\\b|p\\.m\\.|p m\\b|p\\. m\\.|p\\.m\\b|p\\. m\\b|p\\b\\b)'
    AmDescRegex = f'(h|am\\b|a\\.m\\.|a m\\b|a\\. m\\.|a\\.m\\b|a\\. m\\b)'
    PmDescRegex = f'(h|pm\\b|p\\.m\\.|p\\b|p m\\b|p\\. m\\.|p\\.m\\b|p\\. m\\b)'
    AmPmDescRegex = f'(h|ampm)'
    TwoDigitYearRegex = f'\\b(?<![$])(?<year>([0-27-9]\\d))(?!(\\s*((\\:)|{AmDescRegex}|{PmDescRegex}|\\.\\d)))\\b'
    FullTextYearRegex = f'^[\\*]'
    YearRegex = f'({BaseDateTime.FourDigitYearRegex}|{FullTextYearRegex})'
    WeekDayRegex = f'(?<weekday>Dimanche|Lundi|Mardi|Mercredi|Jeudi|Vendredi|Samedi|Lun|Mar|Mer|Jeu|Ven|Sam|Dim)\\b'
    RelativeMonthRegex = f'(?<relmonth>({ThisPrefixRegex}\\s+mois)|(mois\\s+{PastSuffixRegex})|(mois\\s+{NextSuffixRegex}))\\b'
    WrittenMonthRegex = f'(?<month>Avril|Avr\\.|Avr|Août|D[eé]cembre|D[eé]c|D[eé]c\\.|F[eé]vrier|F[eé]v|F[eé]vr\\.|F[eé]vr|Javier|Jan|Janv\\.|Janv|Juillet|Jul|Juil|Juil\\.|Juin|Jun|Mars|Mar|Mai|Novembre|Nov|Nov\\.|Octobre|Oct|Oct\\.|Septembre|Sep|Sept|Sept\\.)'
    MonthSuffixRegex = f'(?<msuf>(en\\s*|le\\s*|de\\s*|dans\\s*)?({RelativeMonthRegex}|{WrittenMonthRegex}))'
    DateUnitRegex = f'(?<unit>l\'ann[eé]e|ann[eé]es|an|mois|semaines|semaine|jours|jour|journ[eé]e|journ[eé]es)\\b'
    SimpleCasesRegex = f'\\b((d[ue])|entre\\s+)?({DayRegex})\\s*{TillRegex}\\s*({DayRegex})\\s+{MonthSuffixRegex}((\\s+|\\s*,\\s*){YearRegex})?\\b'
    MonthFrontSimpleCasesRegex = f'\\b((d[ue]|entre)\\s+)?{MonthSuffixRegex}\\s+((d[ue]|entre)\\s+)?({DayRegex})\\s*{TillRegex}\\s*({DayRegex})((\\s+|\\s*,\\s*){YearRegex})?\\b'
    MonthFrontBetweenRegex = f'\\b{MonthSuffixRegex}\\s+(entre|d[ue]\\s+)({DayRegex})\\s*{RangeConnectorRegex}\\s*({DayRegex})((\\s+|\\s*,\\s*){YearRegex})?\\b'
    BetweenRegex = f'\\b(entre\\s+)({DayRegex})\\s*{RangeConnectorRegex}\\s*({DayRegex})\\s+{MonthSuffixRegex}((\\s+|\\s*,\\s*){YearRegex})?\\b'
    YearWordRegex = f'\\b(?<year>l\'ann[ée]e)\\b'
    MonthWithYear = f'\\b((?<month>Avril|Avr\\.|Avr|Août|Aout|D[ée]cembre|D[eé]c|Dec\\.|F[eé]v|F[eé]vr|Fev|F[eé]vrier|F[eé]v\\.|Janvier|Jan|Janv|Janv\\.|Jan\\.|Jul|Juillet|Juil\\.|Jun|Juin|Mar|Mars|Mai|Novembre|Nov|Nov\\.|Octobre|Oct|Oct\\.|Septembre|Sep|Sept|Sept\\.)(\\s*),?(\\s+de)?(\\s*)({YearRegex}|(?<order>cette)\\s*{YearWordRegex})|{YearWordRegex}\\s*({PastSuffixRegex}|{NextSuffixRegex}))'
    OneWordPeriodRegex = f'\\b(({RelativeRegex}\\s+)?(?<month>Avril|Avr\\.|Avr|Août|Aout|D[eé]cembre|D[ée]c|D[eé]c\\.|F[eé]vrier|Fev|F[eé]v\\.|F[eé]vr|Janvier|Janv\\.|Janv|Jan|Jan\\.|Jul|Juillet|Juil\\.|Jun|Juin|Mar|Mars|Mai|Nov|Novembre|Nov\\.|Oct|Octobre|Oct\\.|Sep|Septembre|Sept\\.)|{RelativeRegex}\\s+(weekend|fin de semaine|week-end|semaine|mois|ans|l\'année)|weekend|week-end|(mois|l\'année))\\b'
    MonthNumWithYear = f'({YearRegex}(\\s*)[/\\-\\.](\\s*){MonthNumRegex})|({MonthNumRegex}(\\s*)[/\\-](\\s*){YearRegex})'
    WeekOfMonthRegex = f'(?<wom>(le\\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4|cinqi[èe]me|5)\\s+semaine\\s+{MonthSuffixRegex})'
    WeekOfYearRegex = f'(?<woy>(le\\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4|cinqi[èe]me|5)\\s+semaine(\\s+de)?\\s+({YearRegex}|{RelativeRegex}\\s+ann[ée]e))'
    FollowedDateUnit = f'^\\s*{DateUnitRegex}'
    NumberCombinedWithDateUnit = f'\\b(?<num>\\d+(\\.\\d*)?){DateUnitRegex}'
    QuarterRegex = f'(le\\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4)\\s+quart(\\s+de|\\s*,\\s*)?\\s+({YearRegex}|{RelativeRegex}\\s+l\'ann[eé]e)'
    QuarterRegexYearFront = f'({YearRegex}|l\'année\\s+({PastSuffixRegex}|{NextSuffixRegex})|{RelativeRegex}\\s+ann[eé]e)\\s+(le\\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4)\\s+quarts'
    AllHalfYearRegex = f'^[.]'
    PrefixDayRegex = f'^[.]'
    CenturySuffixRegex = f'^[.]'
    SeasonRegex = f'\\b((<seas>printemps|été|automne|hiver)+\\s*({NextSuffixRegex}|{PastSuffixRegex}))|(?<season>({RelativeRegex}\\s+)?(?<seas>printemps|[ée]t[ée]|automne|hiver)((\\s+de|\\s*,\\s*)?\\s+({YearRegex}|{RelativeRegex}\\s+l\'ann[eé]e))?)\\b'
    WhichWeekRegex = f'(semaine)(\\s*)(?<number>\\d\\d|\\d|0\\d)'
    WeekOfRegex = f'(semaine)(\\s*)(de)'
    MonthOfRegex = f'(mois)(\\s*)(de)'
    MonthRegex = f'(?<month>Avril|Avr|Avr\\.|Août|Aout|D[ée]cembre|D[eé]c|Dec\\.|F[eé]vrier|F[eé]vr|Fev|F[eé]v|F[eé]v\\.|Janvier|Janv\\.|Janv|Jan|Jan\\.|Juillet|Juil|Juil\\.|Juin|Mars|Mai|Novembre|Nov|Nov\\.|Octobre|Oct|Oct\\.|Septembre|Sep|Sept|Sept\\.)'
    OnRegex = f'(?<=\\b(en|sur\\s*l[ea]|sur)\\s+)({DayRegex}s?)\\b'
    RelaxedOnRegex = f'(?<=\\b(en|le|dans|sur\\s*l[ea]|du|sur)\\s+)((?<day>10e|11e|12e|13e|14e|15e|16e|17e|18e|19e|1er|20e|21e|22e|23e|24e|25e|26e|27e|28e|29e|2e|30e|31e|3e|4e|5e|6e|7e|8e|9e)s?)\\b'
    ThisRegex = f'\\b((cette(\\s*semaine)?\\s+){WeekDayRegex})|({WeekDayRegex}(\\s+cette\\s*semaine))\\b'
    LastDateRegex = f'\\b(({WeekDayRegex}(\\s*(de)?\\s*la\\s*semaine\\s+{PastSuffixRegex}))|({WeekDayRegex}(\\s+{PastSuffixRegex})))\\b'
    NextDateRegex = f'\\b(({WeekDayRegex}(\\s+{NextSuffixRegex}))|({WeekDayRegex}(\\s*(de)?\\s*la\\s*semaine\\s+{NextSuffixRegex})))\\b'
    SpecialDayRegex = f'\\b(avant[\\s|-]hier|apr[eè]s(-demain|\\s*demain)|(le\\s)?jour suivant|(le\\s+)?dernier jour|hier|lendemain|demain|de la journ[ée]e|aujourd\'hui)\\b'
    SpecialDayWithNumRegex = f'^[.]'
    StrictWeekDay = f'\\b(?<weekday>Dimanche|Lundi|Mardi|Mercredi|Jeudi|Vendredi|Samedi|Lun|Mar|Mer|Jeu|Ven|Sam|Dim)s?\\b'
    SetWeekDayRegex = f'\\b(?<prefix>le\\s+)?(?<weekday>matin|matin[ée]e|apres-midi|soir[ée]e|soir|Dimanche|Lundi|Mardi|Mercredi|Jeudi|Vendredi|Samedi)s\\b'
    WeekDayOfMonthRegex = f'(?<wom>(le\\s+)?(?<cardinal>premier|1er|duexi[èe]me|2|troisi[èe]me|3|quatri[èe]me|4|cinqi[èe]me|5)\\s+{WeekDayRegex}\\s+{MonthSuffixRegex})'
    RelativeWeekDayRegex = f'^[.]'
    NumberEndingPattern = f'^[.]'
    SpecialDate = f'(?<=\\b([àa]|au|le)\\s+){DayRegex}\\b'
    DateYearRegex = f'(?<year>{YearRegex}|{TwoDigitYearRegex})'
    DateExtractor1 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{MonthRegex}\\s*[/\\\\\\.\\-]?\\s*{DayRegex}\\b'
    DateExtractor2 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}(\\s+|\\s*,\\s*|\\s+){MonthRegex}\\s*[\\.\\-]?\\s*{DateYearRegex}\\b'
    DateExtractor3 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}(\\s+|\\s*,\\s*|\\s*-\\s*){MonthRegex}((\\s+|\\s*,\\s*){DateYearRegex})?\\b'
    DateExtractor4 = f'\\b{MonthNumRegex}\\s*[/\\\\\\-]\\s*{DayRegex}\\s*[/\\\\\\-]\\s*{DateYearRegex}'
    DateExtractor5 = f'\\b{DayRegex}\\s*[/\\\\\\-\\.]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\.]\\s*{DateYearRegex}'
    DateExtractor6 = f'(?<=\\b(le|sur|sur l[ae])\\s+){MonthNumRegex}[\\-\\.\\/]{DayRegex}\\b'
    DateExtractor7 = f'\\b{DayRegex}\\s*/\\s*{MonthNumRegex}((\\s+|\\s*,\\s*){DateYearRegex})?\\b'
    DateExtractor8 = f'(?<=\\b(le)\\s+){DayRegex}[\\\\\\-]{MonthNumRegex}\\b'
    DateExtractor9 = f'\\b{DayRegex}\\s*/\\s*{MonthNumRegex}((\\s+|\\s*,\\s*){DateYearRegex})?\\b'
    DateExtractorA = f'\\b{DateYearRegex}\\s*[/\\\\\\-\\.]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\.]\\s*{DayRegex}'
    OfMonth = f'^\\s*de\\s*{MonthRegex}'
    MonthEnd = f'{MonthRegex}\\s*(le)?\\s*$'
    WeekDayEnd = f'{WeekDayRegex}\\s*,?\\s*$'
    RangeUnitRegex = f'\\b(?<unit>l\'année|ann[eé]e(s)?|mois|semaines|semaine)\\b'
    HourNumRegex = f'\\b(?<hournum>zero|un|deux|trois|quatre|cinq|six|sept|huit|neuf|dix|onze|douze|treize|quatorze|quinze|dix-six|dix-sept|dix-huit|dix-neuf|vingt|vingt-et-un|vingt-deux|vingt-trois)\\b'
    MinuteNumRegex = f'(?<minnum>un|deux|trois|quatre|cinq|six|sept|huit|neuf|dix|onze|douze|treize|quatorze|quinze|seize|dix-sept|dix-huit|dix-neuf|vingt|trente|quarante|cinquante)'
    DeltaMinuteNumRegex = f'(?<deltaminnum>un|deux|trois|quatre|cinq|six|sept|huit|neuf|dix|onze|douze|treize|quatorze|quinze|seize|dix-sept|dix-huit|dix-neuf|vingt|trente|quarante|cinquante)'
    OclockRegex = f'(?<oclock>heure|heures|h)'
    PmRegex = f'(?<pm>(dans l\'\\s*)?apr[eè]s(\\s*|-)midi|(du|ce|de|le)\\s*(soir[ée]e|soir)|(dans l[ea]\\s+)?(nuit|soir[eé]e))'
    AmRegex = f'(?<am>(du|de|ce|(du|de|dans)\\s*l[ea]|le)?\\s*matin[ée]e|(du|de|ce|dans l[ea]|le)?\\s*matin)'
    LessThanOneHour = f'(?<lth>(une\\s+)?quart|trois quart(s)?|demie( heure)?|{BaseDateTime.DeltaMinuteRegex}(\\s+(minute|minutes|min|mins))|{DeltaMinuteNumRegex}(\\s+(minute|minutes|min|mins)))'
    WrittenTimeRegex = f'(?<writtentime>{HourNumRegex}\\s+({MinuteNumRegex}|(?<tens>vingt|trente|quarante|cinquante)\\s+{MinuteNumRegex}))'
    TimePrefix = f'(?<prefix>(heures\\s*et\\s+{LessThanOneHour}|et {LessThanOneHour}|{LessThanOneHour} [àa]))'
    TimeSuffix = f'(?<suffix>{AmRegex}|{PmRegex}|{OclockRegex})'
    BasicTime = f'(?<basictime>{WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}:{BaseDateTime.MinuteRegex}(:{BaseDateTime.SecondRegex})?|{BaseDateTime.HourRegex})'
    MidnightRegex = f'(?<midnight>minuit)'
    CommonDatePrefixRegex = f'^[\\.]'
    MorningRegex = f'(?<morning>matin[ée]e|matin)'
    AfternoonRegex = f'(?<afternoon>(d\'|l\')?apr[eè]s(-|\\s*)midi)'
    MidmorningRegex = f'(?<midmorning>milieu\\s*d[ue]\\s*{MorningRegex})'
    MiddayRegex = f'(?<midday>milieu(\\s*|-)d[eu]\\s*(jour|midi)|apr[eè]s(-|\\s*)midi)'
    MidafternoonRegex = f'(?<midafternoon>milieu\\s*d\'+{AfternoonRegex})'
    MidTimeRegex = f'(?<mid>({MidnightRegex}|{MidmorningRegex}|{MidafternoonRegex}|{MiddayRegex}))'
    AtRegex = f'\\b(((?<=\\b[àa]\\s+)({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}|{MidTimeRegex}))|{MidTimeRegex})\\b'
    IshRegex = f'\\b(peu\\s*pr[èe]s\\s*{BaseDateTime.HourRegex}|peu\\s*pr[èe]s\\s*{WrittenTimeRegex}|peu\\s*pr[èe]s\\s*[àa]\\s*{BaseDateTime.HourRegex}|peu pr[èe]s midi)\\b'
    TimeUnitRegex = f'(?<unit>heures|heure|hrs|hr|h|minutes|minute|mins|min|secondes|seconde|secs|sec)\\b'
    RestrictedTimeUnitRegex = f'(?<unit>huere|minute)\\b'
    ConnectNumRegex = f'{BaseDateTime.HourRegex}(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59)\\s*{DescRegex}'
    FivesRegex = f'(?<tens>(quinze|vingt(\\s*|-*(cinq))?|trente(\\s*|-*(cinq))?|quarante(\\s*|-*(cinq))??|cinquante(\\s*|-*(cinq))?|dix|cinq))\\b'
    PeriodHourNumRegex = f'(?<hour>vingt-et-un|vingt-deux|vingt-trois|vingt-quatre|zero|une|deux|trois|quatre|cinq|six|sept|huit|neuf|dix|onze|douze|treize|quatorze|quinze|seize|dix-sept|dix-huit|dix-neuf|vingt)'
    TimeRegex1 = f'\\b({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\\s*{DescRegex}(\\s+{TimePrefix})?'
    TimeRegex2 = f'(\\b{TimePrefix}\\s+)?(T)?{BaseDateTime.HourRegex}(\\s*)?:(\\s*)?{BaseDateTime.MinuteRegex}((\\s*)?:(\\s*)?{BaseDateTime.SecondRegex})?((\\s*{DescRegex})|\\b)'
    TimeRegex3 = f'\\b{BaseDateTime.HourRegex}\\.{BaseDateTime.MinuteRegex}(\\s*{DescRegex})(\\s+{TimePrefix})?'
    TimeRegex4 = f'\\b{BasicTime}(\\s*{DescRegex})?(\\s+{TimePrefix})?\\s+{TimeSuffix}\\b'
    TimeRegex5 = f'\\b{BasicTime}((\\s*{DescRegex})|\\b)(\\s+{TimePrefix})?'
    TimeRegex6 = f'{BasicTime}(\\s*{DescRegex})?\\s+{TimeSuffix}\\b'
    TimeRegex7 = f'\\b{TimeSuffix}\\s+[àa]\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex8 = f'\\b{TimeSuffix}\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex9 = f'\\b{PeriodHourNumRegex}\\s+{FivesRegex}((\\s*{DescRegex})|\\b)'
    TimeRegex10 = f'\\b{BaseDateTime.HourRegex}(\\s*h\\s*){BaseDateTime.MinuteRegex}(\\s*{DescRegex})?(\\s+{TimePrefix})?'
    HourRegex = f'\\b{BaseDateTime.HourRegex}'
    PeriodDescRegex = f'(?<desc>pm|am|p\\.m\\.|a\\.m\\.|p)'
    PeriodPmRegex = f'(?<pm>dans l\'apr[eè]s-midi|ce soir|d[eu] soir|dans l[ea] soir[eé]e|dans la nuit|d[eu] soir[ée]e)s?'
    PeriodAmRegex = f'(?<am>matin|d[eu] matin|matin[ée]e)s?'
    PureNumFromTo = f'((du|de|des|depuis)\\s+)?({HourRegex}|{PeriodHourNumRegex})(\\s*(?<leftDesc>{PeriodDescRegex}))?\\s*{TillRegex}\\s*({HourRegex}|{PeriodHourNumRegex})\\s*(?<rightDesc>{PmRegex}|{AmRegex}|{PeriodDescRegex})?'
    PureNumBetweenAnd = f'(entre\\s+)({HourRegex}|{PeriodHourNumRegex})(\\s*(?<leftDesc>{PeriodDescRegex}))?\\s*{RangeConnectorRegex}\\s*({HourRegex}|{PeriodHourNumRegex})\\s*(?<rightDesc>{PmRegex}|{AmRegex}|{PeriodDescRegex})?'
    SpecificTimeFromTo = f'^[.]'
    SpecificTimeBetweenAnd = f'^[.]'
    PrepositionRegex = f'(?<prep>^([aà] la|en|sur\\s*l[ea]|sur|de)$)'
    TimeOfDayRegex = f'\\b(?<timeOfDay>((((dans\\s+(l[ea])?\\s+)?((?<early>d[eé]but(\\s+|-)|t[oô]t(\\s+|-)(l[ea]\\s*)?)|(?<late>fin\\s*|fin de(\\s+(la)?)|tard\\s*))?(matin[ée]e|matin|((d|l)?\'?)apr[eè]s[-|\\s*]midi|nuit|soir[eé]e|soir)))|(((\\s+(l[ea])?\\s+)?)(jour|journ[eé]e)))s?)\\b'
    SpecificTimeOfDayRegex = f'\\b(({RelativeRegex}\\s+{TimeOfDayRegex})|({TimeOfDayRegex}\\s*({NextSuffixRegex}))\\b|\\bsoir|\\bdu soir)s?\\b'
    TimeFollowedUnit = f'^\\s*{TimeUnitRegex}'
    TimeNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\.\\d*)?){TimeUnitRegex}'
    NowRegex = f'\\b(?<now>(ce\\s+)?moment|maintenant|d[eè]s que possible|dqp|r[eé]cemment|auparavant)\\b'
    SuffixRegex = f'^\\s*(dans\\s+l[ea]\\s+)|(en\\s+)|(du)?(matin|matin([eé]e)?|apr[eè]s-midi|soir[eé]e|nuit)\\b'
    DateTimeTimeOfDayRegex = f'\\b(?<timeOfDay>matin[ée]e|matin|apr[eè]s-midi|nuit|soir)\\b'
    DateTimeSpecificTimeOfDayRegex = f'\\b(({RelativeRegex}\\s+{DateTimeTimeOfDayRegex})\\b|\\b(ce|cette\\s+)(soir|nuit))\\b'
    TimeOfTodayAfterRegex = f'^\\s*(,\\s*)?(en|dans|du\\s+)?{DateTimeSpecificTimeOfDayRegex}'
    TimeOfTodayBeforeRegex = f'{DateTimeSpecificTimeOfDayRegex}(\\s*,)?(\\s+([àa]|pour))?\\s*$'
    SimpleTimeOfTodayAfterRegex = f'({HourNumRegex}|{BaseDateTime.HourRegex})\\s*(,\\s*)?(en|[àa]\\s+)?{DateTimeSpecificTimeOfDayRegex}'
    SimpleTimeOfTodayBeforeRegex = f'{DateTimeSpecificTimeOfDayRegex}(\\s*,)?(\\s+([àa]|vers))?\\s*({HourNumRegex}|{BaseDateTime.HourRegex})'
    TheEndOfRegex = f'(la\\s+)?fin(\\s+de\\s*|\\s*de*l[ea])?\\s*$'
    PeriodTimeOfDayRegex = f'\\b((dans\\s+(le)?\\s+)?((?<early>d[eé]but(\\s+|-|d[ue]|de la)|t[oô]t)|(?<late>tard\\s*|fin(\\s+|-|d[eu])?))?(?<timeOfDay>matin|((d|l)?\'?)apr[eè]s-midi|nuit|soir[eé]e|soir))\\b'
    PeriodSpecificTimeOfDayRegex = f'\\b(({RelativeRegex}\\s+{PeriodTimeOfDayRegex})\\b|\\b(ce|cette\\s+)(soir|nuit))\\b'
    PeriodTimeOfDayWithDateRegex = f'\\b(({TimeOfDayRegex}))\\b'
    LessThanRegex = f'^[.]'
    MoreThanRegex = f'^[.]'
    DurationUnitRegex = f'(?<unit>ans|ann[eé]e|mois|semaines|semaine|jour|jours|heures|heure|hrs|hr|h|minutes|minute|mins|min|secondes|seconde|secs|sec|ann[eé]es|journ[eé]e)\\b'
    SuffixAndRegex = f'(?<suffix>\\s*(et)\\s+((un|une)\\s+)?(?<suffix_num>demi|quart))'
    PeriodicRegex = f'\\b(?<periodic>quotidienne|quotidien|journellement|mensuel|mensuelle|jour|jours|hebdomadaire|bihebdomadaire|annuellement|annuel)\\b'
    EachUnitRegex = f'(?<each>(chaque|toutes les|tous les)(?<other>\\s+autres)?\\s*{DurationUnitRegex})'
    EachPrefixRegex = f'\\b(?<each>(chaque|tous les|(toutes les))\\s*$)'
    SetEachRegex = f'\\b(?<each>(chaque|tous les|(toutes les))\\s*)'
    SetLastRegex = f'(?<last>prochain|dernier|derni[eè]re|pass[ée]s|pr[eé]c[eé]dent|courant|en\\s*cours)'
    EachDayRegex = f'^\\s*(chaque|tous les)\\s*(jour|jours)\\b'
    DurationFollowedUnit = f'^\\s*{SuffixAndRegex}?(\\s+|-)?{DurationUnitRegex}'
    NumberCombinedWithDurationUnit = f'\\b(?<num>\\d+(\\.\\d*)?)(-)?{DurationUnitRegex}'
    AnUnitRegex = f'\\b(((?<half>demi\\s+)?(-)\\s+{DurationUnitRegex}))'
    DuringRegex = f'^[.]'
    AllRegex = f'\\b(?<all>toute\\s(l[\'ea])\\s?(?<unit>ann[eé]e|mois|semaine|semaines|jour|jours|journ[eé]e))\\b'
    HalfRegex = f'(((un|une)\\s*)|\\b)(?<half>demi?(\\s*|-)+(?<unit>ann[eé]e|ans|mois|semaine|jour|heure))\\b'
    ConjunctionRegex = f'\\b((et(\\s+de|pour)?)|avec)\\b'
    HolidayRegex1 = f'\\b(?<holiday>vendredi saint|mercredi des cendres|p[aâ]ques|l\'action de gr[âa]ce|mardi gras|la saint-sylvestre|la saint sylvestre|la Saint-Valentin|la saint valentin|nouvel an chinois|nouvel an|r[eé]veillon de Nouvel an|jour de l\'an|premier-mai|ler-mai|1-mai|poisson d\'avril|r[eé]veillon de No[eë]l|veille de no[eë]l|noël|noel|thanksgiving|halloween|yuandan)(\\s+((d[ue]\\s+|d\'))?({YearRegex}|({ThisPrefixRegex}\\s+)ann[eé]e|ann[eé]e\\s+({PastSuffixRegex}|{NextSuffixRegex})))?\\b'
    HolidayRegex2 = f'\\b(?<holiday>martin luther king|martin luther king jr|toussaint|st patrick|st george|cinco de mayo|l\'ind[eé]pendance|guy fawkes)(\\s+(de\\s+)?({YearRegex}|{ThisPrefixRegex}\\s+ann[eé]e|ann[eé]e\\s+({PastSuffixRegex}|{NextSuffixRegex})))?\\b'
    HolidayRegex3 = f'(?<holiday>(jour\\s*(d[eu]|des)\\s*(canberra|p[aâ]ques|colomb|bastille|la prise de la bastille|l\'ind[eé]pendance|l\'ind[eé]pendance am[eé]ricaine|thanks\\s*giving|bapt[êe]me|nationale|d\'armistice|inaugueration|marmotte|assomption|femme|comm[ée]moratif)))(\\s+(de\\s+)?({YearRegex}|{ThisPrefixRegex}\\s+ann[eé]e|ann[eé]e\\s+({PastSuffixRegex}|{NextSuffixRegex})))?'
    HolidayRegex4 = f'(?<holiday>(F[eê]te\\s*(d[eu]|des)\\s*)(travail|m[eè]re|m[eè]res|p[eè]re|p[eè]res))(\\s+(de\\s+)?({YearRegex}|{ThisPrefixRegex}\\s+ann[eé]e|ann[eé]e\\s+({PastSuffixRegex}|{NextSuffixRegex})))?\\b'
    DateTokenPrefix = 'le '
    TimeTokenPrefix = 'à '
    TokenBeforeDate = 'le '
    TokenBeforeTime = 'à '
    AMTimeRegex = f'(?<am>matin[ée]e|matin)'
    PMTimeRegex = f'\\b(?<pm>(d\'|l\')?apr[eè]s-midi|soir|nuit|\\s*ce soir|du soir)\\b'
    BeforeRegex = f'\\b(avant)\\b'
    BeforeRegex2 = f'\\b(entre\\s*(le|la(s)?)?)\\b'
    AfterRegex = f'\\b(apres)\\b'
    SinceRegex = f'\\b(depuis)\\b'
    AroundRegex = f'^[.]'
    AgoPrefixRegex = f'\\b(y a)\\b'
    LaterRegex = f'\\b(plus tard)\\b'
    AgoRegex = f'^[.]'
    InConnectorRegex = f'\\b(dans|en|sur)\\b'
    WithinNextPrefixRegex = f'^[.]'
    MorningStartEndRegex = f'(^(matin))|((matin)$)'
    AfternoonStartEndRegex = f'(^((d\'|l\')?apr[eè]s-midi))|(((d\'|l\')?apr[eè]s-midi)$)'
    EveningStartEndRegex = f'(^(soir[ée]e|soir))|((soir[ée]e|soir)$)'
    NightStartEndRegex = f'(^(nuit))|((nuit)$)'
    InexactNumberRegex = f'\\b(quelque|quel qu[ée]s|quelqu[ée]s|plusieur|plusieurs|divers)\\b'
    InexactNumberUnitRegex = f'({InexactNumberRegex})\\s+({DurationUnitRegex})'
    RelativeTimeUnitRegex = f'(((({ThisPrefixRegex})?)\\s+({TimeUnitRegex}(\\s*{NextSuffixRegex}|{PastSuffixRegex})?))|((le))\\s+({RestrictedTimeUnitRegex}))'
    RelativeDurationUnitRegex = f'(((?<=({ThisPrefixRegex})\\s+)?\\b({DurationUnitRegex})(\\s+{NextSuffixRegex}|{PastSuffixRegex})?)|((le|my))\\s+({RestrictedTimeUnitRegex}))'
    ReferenceDatePeriodRegex = f'^[.]'
    ConnectorRegex = f'^(,|pour|t|vers)$'
    ConnectorAndRegex = f'\\b(et\\s*(le|la(s)?)?)\\b.+'
    FromRegex = f'((de|du)?)$'
    FromRegex2 = f'((depuis|de)(\\s*la(s)?)?)$'
    FromToRegex = f'\\b(du|de|des|depuis).+(à|a|au)\\b.+'
    SingleAmbiguousMonthRegex = f'^(le\\s+)?(may|march)$'
    UnspecificDatePeriodRegex = f'^[.]'
    PrepositionSuffixRegex = f'\\b(du|de|[àa]|vers|dans)$'
    FlexibleDayRegex = f'(?<DayOfMonth>([A-Za-z]+\\s)?[A-Za-z\\d]+)'
    ForTheRegex = f'\\b(((pour le {FlexibleDayRegex})|(dans (le\\s+)?{FlexibleDayRegex}(?<=(st|nd|rd|th))))(?<end>\\s*(,|\\.|!|\\?|$)))'
    WeekDayAndDayOfMonthRegex = f'\\b{WeekDayRegex}\\s+(le\\s+{FlexibleDayRegex})\\b'
    RestOfDateRegex = f'\\b(Reste|fin)\\s+(d[eu]\\s+)?((le|cette|ce)\\s+)?(?<duration>semaine|mois|l\'ann[ée]e)\\b'
    RestOfDateTimeRegex = f'\\b(Reste|fin)\\s+(d[eu]\\s+)?((le|cette|ce)\\s+)?(?<unit>jour)\\b'
    LaterEarlyPeriodRegex = f'^[.]'
    WeekWithWeekDayRangeRegex = f'^[.]'
    GeneralEndingRegex = f'^[.]'
    MiddlePauseRegex = f'^[.]'
    DurationConnectorRegex = f'^[.]'
    PrefixArticleRegex = f'^[\\.]'
    OrRegex = f'^[.]'
    YearPlusNumberRegex = f'^[.]'
    NumberAsTimeRegex = f'^[.]'
    TimeBeforeAfterRegex = f'^[.]'
    DateNumberConnectorRegex = f'^[.]'
    CenturyRegex = f'^[.]'
    DecadeRegex = f'^[.]'
    DecadeWithCenturyRegex = f'^[.]'
    RelativeDecadeRegex = f'^[.]'
    YearSuffix = f'(,?\\s*({DateYearRegex}|{FullTextYearRegex}))'
    YearAfterRegex = f'^[.]'
    YearPeriodRegex = f'^[.]'
    FutureSuffixRegex = f'^[.]'
    ComplexDatePeriodRegex = f'^[.]'
    UnitMap = dict([('annees', 'Y'),
                    ('annee', 'Y'),
                    ('ans', 'Y'),
                    ('mois', 'MON'),
                    ('semaines', 'W'),
                    ('semaine', 'W'),
                    ('journees', 'D'),
                    ('journee', 'D'),
                    ('jour', 'D'),
                    ('jours', 'D'),
                    ('heures', 'H'),
                    ('heure', 'H'),
                    ('hrs', 'H'),
                    ('hr', 'H'),
                    ('h', 'H'),
                    ('minutes', 'M'),
                    ('minute', 'M'),
                    ('mins', 'M'),
                    ('min', 'M'),
                    ('secondes', 'S'),
                    ('seconde', 'S'),
                    ('secs', 'S'),
                    ('sec', 'S')])
    UnitValueMap = dict([('annees', 31536000),
                         ('annee', 31536000),
                         ('l\'annees', 31536000),
                         ('l\'annee', 31536000),
                         ('ans', 31536000),
                         ('mois', 2592000),
                         ('semaines', 604800),
                         ('semaine', 604800),
                         ('journees', 86400),
                         ('journee', 86400),
                         ('jour', 86400),
                         ('jours', 86400),
                         ('heures', 3600),
                         ('heure', 3600),
                         ('hrs', 3600),
                         ('hr', 3600),
                         ('h', 3600),
                         ('minutes', 60),
                         ('minute', 60),
                         ('mins', 60),
                         ('min', 60),
                         ('secondes', 1),
                         ('seconde', 1),
                         ('secs', 1),
                         ('sec', 1)])
    SeasonMap = dict([('printemps', 'SP'),
                      ('été', 'SU'),
                      ('automne', 'FA'),
                      ('hiver', 'WI')])
    SeasonValueMap = dict([('SP', 3),
                           ('SU', 6),
                           ('FA', 9),
                           ('WI', 12)])
    CardinalMap = dict([('premier', 1),
                        ('1er', 1),
                        ('deuxième', 2),
                        ('2e', 2),
                        ('troisième', 3),
                        ('troisieme', 3),
                        ('3e', 3),
                        ('quatrième', 4),
                        ('4e', 4),
                        ('cinqième', 5),
                        ('5e', 5)])
    DayOfWeek = dict([('lundi', 1),
                      ('mardi', 2),
                      ('mercredi', 3),
                      ('jeudi', 4),
                      ('vendredi', 5),
                      ('samedi', 6),
                      ('dimanche', 0),
                      ('lun', 1),
                      ('mar', 2),
                      ('mer', 3),
                      ('jeu', 4),
                      ('ven', 5),
                      ('sam', 6),
                      ('dim', 0)])
    MonthOfYear = dict([('janvier', 1),
                        ('fevrier', 2),
                        ('février', 2),
                        ('mars', 3),
                        ('mar', 3),
                        ('avril', 4),
                        ('avr', 4),
                        ('mai', 5),
                        ('juin', 6),
                        ('jun', 6),
                        ('juillet', 7),
                        ('aout', 8),
                        ('août', 8),
                        ('septembre', 9),
                        ('octobre', 10),
                        ('novembre', 11),
                        ('decembre', 12),
                        ('décembre', 12),
                        ('janv', 1),
                        ('janv.', 1),
                        ('jan', 1),
                        ('fevr', 2),
                        ('fevr.', 2),
                        ('févr.', 2),
                        ('févr', 2),
                        ('fev', 2),
                        ('juil', 7),
                        ('jul', 7),
                        ('sep', 9),
                        ('sept.', 9),
                        ('sept', 9),
                        ('oct', 10),
                        ('oct.', 10),
                        ('nov', 11),
                        ('nov.', 11),
                        ('dec', 12),
                        ('déc.', 12),
                        ('déc', 12),
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
                    ('un', 1),
                    ('une', 1),
                    ('a', 1),
                    ('deux', 2),
                    ('trois', 3),
                    ('quatre', 4),
                    ('cinq', 5),
                    ('six', 6),
                    ('sept', 7),
                    ('huit', 8),
                    ('neuf', 9),
                    ('dix', 10),
                    ('onze', 11),
                    ('douze', 12),
                    ('treize', 13),
                    ('quatorze', 14),
                    ('quinze', 15),
                    ('seize', 16),
                    ('dix-sept', 17),
                    ('dix-huit', 18),
                    ('dix-neuf', 19),
                    ('vingt-et-un', 21),
                    ('vingt et un', 21),
                    ('vingt', 20),
                    ('vingt deux', 22),
                    ('vingt-deux', 22),
                    ('vingt trois', 23),
                    ('vingt-trois', 23),
                    ('vingt quatre', 24),
                    ('vingt-quatre', 24),
                    ('vingt cinq', 25),
                    ('vingt-cinq', 25),
                    ('vingt six', 26),
                    ('vingt-six', 26),
                    ('vingt sept', 27),
                    ('vingt-sept', 27),
                    ('vingt huit', 28),
                    ('vingt-huit', 28),
                    ('vingt neuf', 29),
                    ('vingt-neuf', 29),
                    ('trente', 30),
                    ('trente et un', 31),
                    ('trente-et-un', 31),
                    ('trente deux', 32),
                    ('trente-deux', 32),
                    ('trente trois', 33),
                    ('trente-trois', 33),
                    ('trente quatre', 34),
                    ('trente-quatre', 34),
                    ('trente cinq', 35),
                    ('trente-cinq', 35),
                    ('trente six', 36),
                    ('trente-six', 36),
                    ('trente sept', 37),
                    ('trente-sept', 37),
                    ('trente huit', 38),
                    ('trente-huit', 38),
                    ('trente neuf', 39),
                    ('trente-neuf', 39),
                    ('quarante', 40),
                    ('quarante et un', 41),
                    ('quarante-et-un', 41),
                    ('quarante deux', 42),
                    ('quarante-duex', 42),
                    ('quarante trois', 43),
                    ('quarante-trois', 43),
                    ('quarante quatre', 44),
                    ('quarante-quatre', 44),
                    ('quarante cinq', 45),
                    ('quarante-cinq', 45),
                    ('quarante six', 46),
                    ('quarante-six', 46),
                    ('quarante sept', 47),
                    ('quarante-sept', 47),
                    ('quarante huit', 48),
                    ('quarante-huit', 48),
                    ('quarante neuf', 49),
                    ('quarante-neuf', 49),
                    ('cinquante', 50),
                    ('cinquante et un', 51),
                    ('cinquante-et-un', 51),
                    ('cinquante deux', 52),
                    ('cinquante-deux', 52),
                    ('cinquante trois', 53),
                    ('cinquante-trois', 53),
                    ('cinquante quatre', 54),
                    ('cinquante-quatre', 54),
                    ('cinquante cinq', 55),
                    ('cinquante-cinq', 55),
                    ('cinquante six', 56),
                    ('cinquante-six', 56),
                    ('cinquante sept', 57),
                    ('cinquante-sept', 57),
                    ('cinquante huit', 58),
                    ('cinquante-huit', 58),
                    ('cinquante neuf', 59),
                    ('cinquante-neuf', 59),
                    ('soixante', 60),
                    ('soixante et un', 61),
                    ('soixante-et-un', 61),
                    ('soixante deux', 62),
                    ('soixante-deux', 62),
                    ('soixante trois', 63),
                    ('soixante-trois', 63),
                    ('soixante quatre', 64),
                    ('soixante-quatre', 64),
                    ('soixante cinq', 65),
                    ('soixante-cinq', 65),
                    ('soixante six', 66),
                    ('soixante-six', 66),
                    ('soixante sept', 67),
                    ('soixante-sept', 67),
                    ('soixante huit', 68),
                    ('soixante-huit', 68),
                    ('soixante neuf', 69),
                    ('soixante-neuf', 69),
                    ('soixante dix', 70),
                    ('soixante-dix', 70),
                    ('soixante et onze', 71),
                    ('soixante-et-onze', 71),
                    ('soixante douze', 72),
                    ('soixante-douze', 72),
                    ('soixante treize', 73),
                    ('soixante-treize', 73),
                    ('soixante quatorze', 74),
                    ('soixante-quatorze', 74),
                    ('soixante quinze', 75),
                    ('soixante-quinze', 75),
                    ('soixante seize', 76),
                    ('soixante-seize', 76),
                    ('soixante dix sept', 77),
                    ('soixante-dix-sept', 77),
                    ('soixante dix huit', 78),
                    ('soixante-dix-huit', 78),
                    ('soixante dix neuf', 79),
                    ('soixante-dix-neuf', 79),
                    ('quatre vingt', 80),
                    ('quatre-vingt', 80),
                    ('quatre vingt un', 81),
                    ('quatre-vingt-un', 81),
                    ('quatre vingt deux', 82),
                    ('quatre-vingt-duex', 82),
                    ('quatre vingt trois', 83),
                    ('quatre-vingt-trois', 83),
                    ('quatre vingt quatre', 84),
                    ('quatre-vingt-quatre', 84),
                    ('quatre vingt cinq', 85),
                    ('quatre-vingt-cinq', 85),
                    ('quatre vingt six', 86),
                    ('quatre-vingt-six', 86),
                    ('quatre vingt sept', 87),
                    ('quatre-vingt-sept', 87),
                    ('quatre vingt huit', 88),
                    ('quatre-vingt-huit', 88),
                    ('quatre vingt neuf', 89),
                    ('quatre-vingt-neuf', 89),
                    ('quatre vingt dix', 90),
                    ('quatre-vingt-dix', 90),
                    ('quatre vingt onze', 91),
                    ('quatre-vingt-onze', 91),
                    ('quatre vingt douze', 92),
                    ('quatre-vingt-douze', 92),
                    ('quatre vingt treize', 93),
                    ('quatre-vingt-treize', 93),
                    ('quatre vingt quatorze', 94),
                    ('quatre-vingt-quatorze', 94),
                    ('quatre vingt quinze', 95),
                    ('quatre-vingt-quinze', 95),
                    ('quatre vingt seize', 96),
                    ('quatre-vingt-seize', 96),
                    ('quatre vingt dix sept', 97),
                    ('quatre-vingt-dix-sept', 97),
                    ('quatre vingt dix huit', 98),
                    ('quatre-vingt-dix-huit', 98),
                    ('quatre vingt dix neuf', 99),
                    ('quatre-vingt-dix-neuf', 99),
                    ('cent', 100)])
    DayOfMonth = dict([('1er', 1),
                       ('2e', 2),
                       ('3e', 3),
                       ('4e', 4),
                       ('5e', 5),
                       ('6e', 6),
                       ('7e', 7),
                       ('8e', 8),
                       ('9e', 9),
                       ('10e', 10),
                       ('11e', 11),
                       ('12e', 12),
                       ('13e', 13),
                       ('14e', 14),
                       ('15e', 15),
                       ('16e', 16),
                       ('17e', 17),
                       ('18e', 18),
                       ('19e', 19),
                       ('20e', 20),
                       ('21e', 21),
                       ('22e', 22),
                       ('23e', 23),
                       ('24e', 24),
                       ('25e', 25),
                       ('26e', 26),
                       ('27e', 27),
                       ('28e', 28),
                       ('29e', 29),
                       ('30e', 30),
                       ('31e', 31)])
    DoubleNumbers = dict([('demi', 0.5),
                          ('quart', 0.25)])
    HolidayNames = dict([('fathers', ['peres', 'p\u00e8res', 'f\u00eatedesp\u00e8res', 'fetedesperes']),
                         ('mothers', ['f\u00eatedesm\u00e8res', 'fetedesmeres']),
                         ('thanksgiving', ['lactiondegrace', 'lactiondegr\u00e2ce', 'jourdethanksgiving', 'thanksgiving']),
                         ('martinlutherking', ['journeemartinlutherking', 'martinlutherkingjr']),
                         ('washingtonsbirthday', ['washingtonsbirthday', 'washingtonbirthday']),
                         ('canberra', ['canberraday']),
                         ('labour', ['fetedetravail', 'travail', 'fetedutravail']),
                         ('columbus', ['columbusday']),
                         ('memorial', ['jourcomm\u00e9moratif', 'jourcommemoratif']),
                         ('yuandan', ['yuandan', 'nouvelanchinois']),
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
                         ('christmas', ['noel', 'no\u00ebl']),
                         ('xmas', ['xmas']),
                         ('newyear', ['nouvellesannees', 'nouvelan']),
                         ('newyearday', ['jourdunouvelan']),
                         ('newyearsday', ['jourdel\'an', 'jourpremierdelannee', 'jourpremierdelann\u00e9e']),
                         ('inaugurationday', ['jourd\'inaugueration', 'inaugueration']),
                         ('groundhougday', ['marmotte']),
                         ('valentinesday', ['lasaint-valentin', 'lasaintvalentin']),
                         ('stpatrickday', ['stpatrickday']),
                         ('aprilfools', ['poissond\'avril']),
                         ('stgeorgeday', ['stgeorgeday']),
                         ('mayday', ['premier-mai', 'ler-mai', '1-mai']),
                         ('cincodemayoday', ['cincodemayo']),
                         ('baptisteday', ['bapteme', 'bapt\u00eame']),
                         ('usindependenceday', ['l\'independanceamericaine', 'lind\u00e9pendanceam\u00e9ricaine']),
                         ('independenceday', ['l\'ind\u00e9pendance', 'lindependance']),
                         ('bastilleday', ['laprisedelabastille', 'bastille']),
                         ('halloweenday', ['halloween']),
                         ('allhallowday', ['allhallowday']),
                         ('allsoulsday', ['allsoulsday']),
                         ('guyfawkesday', ['guyfawkesday']),
                         ('veteransday', ['veteransday']),
                         ('christmaseve', ['reveillondenoel', 'r\u00e9veillondeno\u00ebl', 'veilledenoel', 'veilledeno\u00ebl']),
                         ('newyeareve', ['r\u00e9veillondenouvelan', 'reveillondenouvelan', 'lasaint-sylvestre', 'lasaintsylvestre'])])
    NightRegex = f'\\b(minuit|nuit)\\b'
    WrittenDecades = dict([('', 0)])
    SpecialDecadeCases = dict([('', 0)])
    DefaultLanguageFallback = 'DMY'
    DurationDateRestrictions = []
# pylint: enable=line-too-long
