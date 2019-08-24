# ------------------------------------------------------------------------------
# <auto-generated>
#     This code was generated by a tool.
#     Changes to this file may cause incorrect behavior and will be lost if
#     the code is regenerated.
# </auto-generated>
#
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.
# ------------------------------------------------------------------------------

from .base_date_time import BaseDateTime
# pylint: disable=line-too-long


class PortugueseDateTime:
    TillRegex = f'(?<till>ate|as|às|até|ateh|a|ao|--|-|—|——)(\\s+(o|[aà](s)?))?'
    AndRegex = f'(?<and>e|e\\s*o|--|-|—|——)'
    DayRegex = f'(?<day>01|02|03|04|05|06|07|08|09|1|10|11|12|13|14|15|16|17|18|19|2|20|21|22|23|24|25|26|27|28|29|3|30|31|4|5|6|7|8|9)(?=\\b|t)'
    MonthNumRegex = f'(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)\\b'
    AmDescRegex = f'({BaseDateTime.BaseAmDescRegex})'
    PmDescRegex = f'({BaseDateTime.BasePmDescRegex})'
    AmPmDescRegex = f'({BaseDateTime.BaseAmPmDescRegex})'
    DescRegex = f'(?<desc>({AmDescRegex}|{PmDescRegex}))'
    RangePrefixRegex = f'((desde|de|da|das|entre)\\s+(a(s)?\\s+)?)'
    TwoDigitYearRegex = f'\\b(?<![$])(?<year>([0-27-9]\\d))(?!(\\s*((\\:)|{AmDescRegex}|{PmDescRegex}|\\.\\d)))\\b'
    FullTextYearRegex = f'^[\\*]'
    YearRegex = f'({BaseDateTime.FourDigitYearRegex}|{FullTextYearRegex})'
    RelativeMonthRegex = f'(?<relmonth>([nd]?es[st]e|pr[óo]ximo|passsado|[uú]ltimo)\\s+m[eê]s)\\b'
    MonthRegex = f'(?<month>abr(il)?|ago(sto)?|dez(embro)?|fev(ereiro)?|jan(eiro)?|ju[ln](ho)?|mar([çc]o)?|maio?|nov(embro)?|out(ubro)?|sep?t(embro)?)'
    MonthSuffixRegex = f'(?<msuf>((em|no)\\s+|d[eo]\\s+)?({RelativeMonthRegex}|{MonthRegex}))'
    DateUnitRegex = f'(?<unit>anos?|meses|m[êe]s|semanas?|dias?)\\b'
    PastRegex = f'(?<past>\\b(passad[ao](s)?|[uú]ltim[oa](s)?|anterior(es)?|h[aá]|pr[ée]vi[oa](s)?)\\b)'
    FutureRegex = f'(?<past>\\b(seguinte(s)?|pr[oó]xim[oa](s)?|dentro\\s+de|em|daqui\\s+a)\\b)'
    SimpleCasesRegex = f'\\b((desde\\s+[oa]|desde|d[oa])\\s+)?(dia\\s+)?({DayRegex})\\s*{TillRegex}\\s*(o dia\\s+)?({DayRegex})\\s+{MonthSuffixRegex}((\\s+|\\s*,\\s*){YearRegex})?\\b'
    MonthFrontSimpleCasesRegex = f'\\b{MonthSuffixRegex}\\s+((desde\\s+[oa]|desde|d[oa])\\s+)?(dia\\s+)?({DayRegex})\\s*{TillRegex}\\s*({DayRegex})((\\s+|\\s*,\\s*){YearRegex})?\\b'
    MonthFrontBetweenRegex = f'\\b{MonthSuffixRegex}\\s+((entre|entre\\s+[oa]s?)\\s+)(dias?\\s+)?({DayRegex})\\s*{AndRegex}\\s*({DayRegex})((\\s+|\\s*,\\s*){YearRegex})?\\b'
    DayBetweenRegex = f'\\b((entre|entre\\s+[oa]s?)\\s+)(dia\\s+)?({DayRegex})\\s*{AndRegex}\\s*({DayRegex})\\s+{MonthSuffixRegex}((\\s+|\\s*,\\s*){YearRegex})?\\b'
    OneWordPeriodRegex = f'\\b(((pr[oó]xim[oa]?|[nd]?es[st]e|aquel[ea]|[uú]ltim[oa]?|em)\\s+)?(?<month>abr(il)?|ago(sto)?|dez(embro)?|fev(ereiro)?|jan(eiro)?|ju[ln](ho)?|mar([çc]o)?|maio?|nov(embro)?|out(ubro)?|sep?t(embro)?)|(?<=\\b(de|do|da|o|a)\\s+)?(pr[oó]xim[oa](s)?|[uú]ltim[oa]s?|est(e|a))\\s+(fim de semana|fins de semana|semana|m[êe]s|ano)|fim de semana|fins de semana|(m[êe]s|anos)? [àa] data)\\b'
    MonthWithYearRegex = f'\\b(((pr[oó]xim[oa](s)?|[nd]?es[st]e|aquele|[uú]ltim[oa]?|em)\\s+)?(?<month>abr(il)?|ago(sto)?|dez(embro)?|fev(ereiro)?|jan(eiro)?|ju[ln](ho)?|mar([çc]o)?|maio?|nov(embro)?|out(ubro)?|sep?t(embro)?)\\s+((de|do|da|o|a)\\s+)?({YearRegex}|(?<order>pr[oó]ximo(s)?|[uú]ltimo?|[nd]?es[st]e)\\s+ano))\\b'
    MonthNumWithYearRegex = f'({YearRegex}(\\s*?)[/\\-\\.](\\s*?){MonthNumRegex})|({MonthNumRegex}(\\s*?)[/\\-](\\s*?){YearRegex})'
    WeekOfMonthRegex = f'(?<wom>(a|na\\s+)?(?<cardinal>primeira?|1a|segunda|2a|terceira|3a|[qc]uarta|4a|quinta|5a|[uú]ltima)\\s+semana\\s+{MonthSuffixRegex})'
    WeekOfYearRegex = f'(?<woy>(a|na\\s+)?(?<cardinal>primeira?|1a|segunda|2a|terceira|3a|[qc]uarta|4a|quinta|5a|[uú]ltima?)\\s+semana(\\s+d[oe]?)?\\s+({YearRegex}|(?<order>pr[oó]ximo|[uú]ltimo|[nd]?es[st]e)\\s+ano))'
    FollowedDateUnit = f'^\\s*{DateUnitRegex}'
    NumberCombinedWithDateUnit = f'\\b(?<num>\\d+(\\.\\d*)?){DateUnitRegex}'
    QuarterRegex = f'(n?o\\s+)?(?<cardinal>primeiro|1[oº]|segundo|2[oº]|terceiro|3[oº]|[qc]uarto|4[oº])\\s+trimestre(\\s+d[oe]|\\s*,\\s*)?\\s+({YearRegex}|(?<order>pr[oó]ximo(s)?|[uú]ltimo?|[nd]?es[st]e)\\s+ano)'
    QuarterRegexYearFront = f'({YearRegex}|(?<order>pr[oó]ximo(s)?|[uú]ltimo?|[nd]?es[st]e)\\s+ano)\\s+(n?o\\s+)?(?<cardinal>(primeiro)|1[oº]|segundo|2[oº]|terceiro|3[oº]|[qc]uarto|4[oº])\\s+trimestre'
    AllHalfYearRegex = f'^[.]'
    PrefixDayRegex = f'^[.]'
    SeasonRegex = f'\\b(?<season>(([uú]ltim[oa]|[nd]?es[st][ea]|n?[oa]|(pr[oó]xim[oa]s?|seguinte))\\s+)?(?<seas>primavera|ver[ãa]o|outono|inverno)((\\s+)?(seguinte|((de\\s+|,)?\\s*{YearRegex})|((do\\s+)?(?<order>pr[oó]ximo|[uú]ltimo|[nd]?es[st]e)\\s+ano)))?)\\b'
    WhichWeekRegex = f'\\b(semana)(\\s*)(?<number>5[0-3]|[1-4]\\d|0?[1-9])\\b'
    WeekOfRegex = f'(semana)(\\s*)((do|da|de))'
    MonthOfRegex = f'(mes)(\\s*)((do|da|de))'
    RangeUnitRegex = f'\\b(?<unit>anos?|meses|m[êe]s|semanas?)\\b'
    InConnectorRegex = f'\\b(em)\\b'
    SinceYearSuffixRegex = f'^[.]'
    WithinNextPrefixRegex = f'^[.]'
    CenturySuffixRegex = f'^[.]'
    RelativeRegex = f'^[.]'
    StrictRelativeRegex = f'^[.]'
    FromRegex = f'((desde|de)(\\s*a(s)?)?)$'
    ConnectorAndRegex = f'(e\\s*([àa](s)?)?)$'
    BetweenRegex = f'(entre\\s*([oa](s)?)?)'
    WeekDayRegex = f'\\b(?<weekday>(domingos?|(segunda|ter[çc]a|quarta|quinta|sexta)s?([-\\s+]feiras?)?|s[aá]bados?|(2|3|4|5|6)[aª])\\b|(dom|seg|ter[cç]|qua|qui|sex|sab)\\b(\\.?(?=\\s|,|;|$)))'
    OnRegex = f'(?<=\\b(em|no)\\s+)({DayRegex}s?)\\b'
    RelaxedOnRegex = f'(?<=\\b(em|n[oa]|d[oa])\\s+)(dia\\s+)?((?<day>10|11|12|13|14|15|16|17|18|19|1|20|21|22|23|24|25|26|27|28|29|2|30|31|3|4|5|6|7|8|9)s?)\\b'
    ThisRegex = f'\\b(([nd]?es[st][ea]\\s*){WeekDayRegex})|({WeekDayRegex}\\s*([nd]?es[st]a\\s+semana))\\b'
    LastDateRegex = f'\\b(([uú]ltim[ao])\\s*{WeekDayRegex})|({WeekDayRegex}(\\s+(([nd]?es[st]a|na|da)\\s+([uú]ltima\\s+)?semana)))\\b'
    NextDateRegex = f'\\b(((pr[oó]xim[oa]|seguinte)\\s*){WeekDayRegex})|({WeekDayRegex}((\\s+(pr[oó]xim[oa]|seguinte))|(\\s+(da\\s+)?(semana\\s+seguinte|pr[oó]xima\\s+semana))))\\b'
    SpecialDayRegex = f'\\b((d?o\\s+)?(dia\\s+antes\\s+de\\s+ontem|antes\\s+de\\s+ontem|anteontem)|((d?o\\s+)?(dia\\s+|depois\\s+|dia\\s+depois\\s+)?de\\s+amanh[aã])|(o\\s)?dia\\s+seguinte|(o\\s)?pr[oó]ximo\\s+dia|(o\\s+)?[uú]ltimo\\s+dia|ontem|amanh[ãa]|hoje)|(do\\s+dia$)\\b'
    SpecialDayWithNumRegex = f'^[.]'
    ForTheRegex = f'.^'
    WeekDayAndDayOfMonthRegex = f'.^'
    WeekDayAndDayRegex = f'.^'
    WeekDayOfMonthRegex = f'(?<wom>(n?[ao]\\s+)?(?<cardinal>primeir[ao]|1[ao]|segund[ao]|2[ao]|terceir[ao]|3[ao]|[qc]uart[ao]|4[ao]|quint[ao]|5[ao]|[uú]ltim[ao])\\s+{WeekDayRegex}\\s+{MonthSuffixRegex})'
    RelativeWeekDayRegex = f'^[.]'
    NumberEndingPattern = f'^[.]'
    SpecialDateRegex = f'(?<=\\bno\\s+){DayRegex}\\b'
    OfMonthRegex = f'^\\s*de\\s*{MonthSuffixRegex}'
    MonthEndRegex = f'({MonthRegex}\\s*(o)?\\s*$)'
    WeekDayEnd = f'{WeekDayRegex}\\s*,?\\s*$'
    WeekDayStart = f'^[\\.]'
    DateYearRegex = f'(?<year>{YearRegex}|{TwoDigitYearRegex})'
    DateExtractor1 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}?((\\s*(de)|[/\\\\\\.\\-])\\s*)?{MonthRegex}\\b'
    DateExtractor2 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}\\s*([\\.\\-]|de)?\\s*{MonthRegex}?(\\s*(,|de)\\s*){YearRegex}\\b'
    DateExtractor3 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}(\\s+|\\s*,\\s*|\\s+de\\s+|\\s*-\\s*){MonthRegex}((\\s+|\\s*(,|de)\\s*){YearRegex})?\\b'
    DateExtractor4 = f'\\b{MonthNumRegex}\\s*[/\\\\\\-]\\s*{DayRegex}\\s*[/\\\\\\-]\\s*{DateYearRegex}'
    DateExtractor5 = f'\\b{DayRegex}\\s*[/\\\\\\-\\.]\\s*({MonthNumRegex}|{MonthRegex})\\s*[/\\\\\\-\\.]\\s*{DateYearRegex}'
    DateExtractor6 = f'(?<=\\b(em|no|o)\\s+){MonthNumRegex}[\\-\\.]{DayRegex}\\b'
    DateExtractor7 = f'\\b{MonthNumRegex}\\s*/\\s*{DayRegex}((\\s+|\\s*(,|de)\\s*){DateYearRegex})?\\b'
    DateExtractor8 = f'(?<=\\b(em|no|o)\\s+){DayRegex}[\\\\\\-]{MonthNumRegex}\\b'
    DateExtractor9 = f'\\b{DayRegex}\\s*/\\s*{MonthNumRegex}((\\s+|\\s*(,|de)\\s*){DateYearRegex})?\\b'
    DateExtractor10 = f'\\b{YearRegex}\\s*[/\\\\\\-\\.]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\.]\\s*{DayRegex}'
    DateExtractor11 = f'(?<=\\b(dia)\\s+){DayRegex}'
    HourNumRegex = f'\\b(?<hournum>zero|uma|duas|tr[êe]s|[qc]uatro|cinco|seis|sete|oito|nove|dez|onze|doze)\\b'
    MinuteNumRegex = f'(?<minnum>um|dois|tr[êe]s|[qc]uatro|cinco|seis|sete|oito|nove|dez|onze|doze|treze|catorze|quatorze|quinze|dez[ea]sseis|dez[ea]sete|dezoito|dez[ea]nove|vinte|trinta|[qc]uarenta|cin[qc]uenta)'
    DeltaMinuteNumRegex = f'(?<deltaminnum>um|dois|tr[êe]s|[qc]uatro|cinco|seis|sete|oito|nove|dez|onze|doze|treze|catorze|quatorze|quinze|dez[ea]sseis|dez[ea]sete|dezoito|dez[ea]nove|vinte|trinta|[qc]uarenta|cin[qc]uenta)'
    OclockRegex = f'(?<oclock>em\\s+ponto)'
    PmRegex = f'(?<pm>((pela|de|da|\\b[àa]\\b|na)\\s+(tarde|noite)))|((depois\\s+do|ap[óo]s\\s+o)\\s+(almo[çc]o|meio dia|meio-dia))'
    AmRegex = f'(?<am>(pela|de|da|na)\\s+(manh[ãa]|madrugada))'
    AmTimeRegex = f'(?<am>([dn]?es[st]a|(pela|de|da|na))\\s+(manh[ãa]|madrugada))'
    PmTimeRegex = f'(?<pm>(([dn]?es[st]a|\\b[àa]\\b|(pela|de|da|na))\\s+(tarde|noite)))|((depois\\s+do|ap[óo]s\\s+o)\\s+(almo[çc]o|meio dia|meio-dia))'
    LessThanOneHour = f'(?<lth>((\\s+e\\s+)?(quinze|(um\\s+|dois\\s+|tr[êes]\\s+)?quartos?)|quinze|(\\s*)(um\\s+|dois\\s+|tr[êes]\\s+)?quartos?|(\\s+e\\s+)(meia|trinta)|{BaseDateTime.DeltaMinuteRegex}(\\s+(minuto|minutos|min|mins))|{DeltaMinuteNumRegex}(\\s+(minuto|minutos|min|mins))))'
    TensTimeRegex = f'(?<tens>dez|vinte|trinta|[qc]uarenta|cin[qc]uenta)'
    WrittenTimeRegex = f'(?<writtentime>({HourNumRegex}\\s*((e|menos)\\s+)?({MinuteNumRegex}|({TensTimeRegex}((\\s*e\\s+)?{MinuteNumRegex})?)))|(({MinuteNumRegex}|({TensTimeRegex}((\\s*e\\s+)?{MinuteNumRegex})?))\\s*((para as|pras|antes da|antes das)\\s+)?({HourNumRegex}|{BaseDateTime.HourRegex})))'
    TimePrefix = f'(?<prefix>{LessThanOneHour}(\\s+(passad[ao]s)\\s+(as)?|\\s+depois\\s+(das?|do)|\\s+pras?|\\s+(para|antes)?\\s+([àa]s?))?)'
    TimeSuffix = f'(?<suffix>({LessThanOneHour}\\s+)?({AmRegex}|{PmRegex}|{OclockRegex}))'
    BasicTime = f'(?<basictime>{WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}:{BaseDateTime.MinuteRegex}(:{BaseDateTime.SecondRegex})?|{BaseDateTime.HourRegex})'
    AtRegex = f'\\b(?<=\\b([aà]s?)\\s+)({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\\b'
    ConnectNumRegex = f'({BaseDateTime.HourRegex}(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59)\\s*{DescRegex})'
    TimeRegex1 = f'(\\b{TimePrefix}\\s+)?({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\\s*({DescRegex})'
    TimeRegex2 = f'(\\b{TimePrefix}\\s+)?(t)?{BaseDateTime.HourRegex}(\\s*)?:(\\s*)?{BaseDateTime.MinuteRegex}((\\s*)?:(\\s*)?{BaseDateTime.SecondRegex})?((\\s*{DescRegex})|\\b)'
    TimeRegex3 = f'(\\b{TimePrefix}\\s+)?{BaseDateTime.HourRegex}\\.{BaseDateTime.MinuteRegex}(\\s*{DescRegex})'
    TimeRegex4 = f'\\b(({DescRegex}?)|({BasicTime}?)({DescRegex}?))({TimePrefix}\\s*)({HourNumRegex}|{BaseDateTime.HourRegex})?(\\s+{TensTimeRegex}(\\s+e\\s+)?{MinuteNumRegex}?)?({OclockRegex})?\\b'
    TimeRegex5 = f'\\b({TimePrefix}|{BasicTime}{TimePrefix})\\s+(\\s*{DescRegex})?{BasicTime}?\\s*{TimeSuffix}\\b'
    TimeRegex6 = f'({BasicTime}(\\s*{DescRegex})?\\s+{TimeSuffix}\\b)'
    TimeRegex7 = f'\\b{TimeSuffix}\\s+[àa]s?\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex8 = f'\\b{TimeSuffix}\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex9 = f'\\b(?<writtentime>{HourNumRegex}\\s+({TensTimeRegex}\\s*)?(e\\s+)?{MinuteNumRegex}?)\\b'
    TimeRegex10 = f'(\\b([àa]|ao?)|na|de|da|pela)\\s+(madrugada|manh[ãa]|meio\\s*dia|meia\\s*noite|tarde|noite)'
    TimeRegex11 = f'\\b({WrittenTimeRegex})({DescRegex}?)\\b'
    TimeRegex12 = f'(\\b{TimePrefix}\\s+)?{BaseDateTime.HourRegex}(\\s*h\\s*){BaseDateTime.MinuteRegex}(\\s*{DescRegex})?'
    PrepositionRegex = f'(?<prep>([àa]s?|em|por|pelo|pela|no|na|de|d[oa]?)?$)'
    NowRegex = f'\\b(?<now>((logo|exatamente)\\s+)?agora(\\s+mesmo)?|neste\\s+momento|(assim\\s+que|t[ãa]o\\s+cedo\\s+quanto)\\s+(poss[ií]vel|possas?|possamos)|o\\s+mais\\s+(cedo|r[aá]pido)\\s+poss[íi]vel|recentemente|previamente)\\b'
    SuffixRegex = f'^\\s*((e|a|em|por|pelo|pela|no|na|de)\\s+)?(manh[ãa]|madrugada|meio\\s*dia|tarde|noite)\\b'
    TimeOfDayRegex = f'\\b(?<timeOfDay>manh[ãa]|madrugada|tarde|noite|((depois\\s+do|ap[óo]s\\s+o)\\s+(almo[çc]o|meio dia|meio-dia)))\\b'
    SpecificTimeOfDayRegex = f'\\b(((((a)?\\s+|[nd]?es[st]a|seguinte|pr[oó]xim[oa]|[uú]ltim[oa])\\s+)?{TimeOfDayRegex}))\\b'
    TimeOfTodayAfterRegex = f'^\\s*(,\\s*)?([àa]|em|por|pelo|pela|de|no|na?\\s+)?{SpecificTimeOfDayRegex}'
    TimeOfTodayBeforeRegex = f'({SpecificTimeOfDayRegex}(\\s*,)?(\\s+(a\\s+la(s)?|para))?\\s*)'
    SimpleTimeOfTodayAfterRegex = f'({HourNumRegex}|{BaseDateTime.HourRegex})\\s*(,\\s*)?((en|de(l)?)?\\s+)?{SpecificTimeOfDayRegex}'
    SimpleTimeOfTodayBeforeRegex = f'({SpecificTimeOfDayRegex}(\\s*,)?(\\s+(a\\s+la|para))?\\s*({HourNumRegex}|{BaseDateTime.HourRegex}))'
    SpecificEndOfRegex = f'((no|ao)\\s+)?(fi(m|nal)|t[ée]rmin(o|ar))(\\s+d?o(\\s+dia)?(\\s+de)?)?\\s*$'
    UnspecificEndOfRegex = f'^[.]'
    UnspecificEndOfRangeRegex = f'^[.]'
    UnitRegex = f'(?<unit>anos|ano|meses|m[êe]s|semanas|semana|dias|dia|horas|hora|h|hr|hrs|hs|minutos|minuto|mins|min|segundos|segundo|segs|seg)\\b'
    ConnectorRegex = f'^(,|t|para [ao]|para as|pras|cerca de|cerca das|perto de|perto das|quase)$'
    TimeHourNumRegex = f'(?<hour>vinte e um|vinte e dois|vinte e tr[êe]s|vinte e quatro|zero|um|uma|dois|duas|tr[êe]s|quatro|cinco|seis|sete|oito|nove|dez|onze|doze|treze|quatorze|catorze|quinze|dez[ea]sseis|dez[ea]ssete|dezoito|dez[ea]nove|vinte)'
    PureNumFromTo = f'((desde|de|da|das)\\s+(a(s)?\\s+)?)?({BaseDateTime.HourRegex}|{TimeHourNumRegex})(\\s*(?<leftDesc>{DescRegex}))?\\s*{TillRegex}\\s*({BaseDateTime.HourRegex}|{TimeHourNumRegex})\\s*(?<rightDesc>{PmRegex}|{AmRegex}|{DescRegex})?'
    PureNumBetweenAnd = f'(entre\\s+((a|as)?\\s+)?)({BaseDateTime.HourRegex}|{TimeHourNumRegex})(\\s*(?<leftDesc>{DescRegex}))?\\s*e\\s*(a(s)?\\s+)?({BaseDateTime.HourRegex}|{TimeHourNumRegex})\\s*(?<rightDesc>{PmRegex}|{AmRegex}|{DescRegex})?'
    SpecificTimeFromTo = f'^[.]'
    SpecificTimeBetweenAnd = f'^[.]'
    TimeUnitRegex = f'(?<unit>horas|hora|h|minutos|minuto|mins|min|segundos|segundo|secs|sec)\\b'
    TimeFollowedUnit = f'^\\s*{TimeUnitRegex}'
    TimeNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\,\\d*)?)\\s*{TimeUnitRegex}'
    DateTimePeriodNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\.\\d*)?)\\s*{TimeUnitRegex}'
    PeriodTimeOfDayWithDateRegex = f'\\b((e|[àa]|em|na|no|ao|pel[ao]|de)\\s+)?(?<timeOfDay>manh[ãa]|madrugada|(passado\\s+(o\\s+)?)?meio\\s+dia|tarde|noite)\\b'
    RelativeTimeUnitRegex = f'({PastRegex}|{FutureRegex})\\s+{UnitRegex}|{UnitRegex}\\s+({PastRegex}|{FutureRegex})'
    SuffixAndRegex = f'(?<suffix>\\s*(e)\\s+(?<suffix_num>meia|(um\\s+)?quarto))'
    FollowedUnit = f'^\\s*{UnitRegex}'
    LessThanRegex = f'^[.]'
    MoreThanRegex = f'^[.]'
    DurationNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\,\\d*)?){UnitRegex}'
    AnUnitRegex = f'\\b(um(a)?)\\s+{UnitRegex}'
    DuringRegex = f'^[.]'
    AllRegex = f'\\b(?<all>tod[oa]?\\s+(o|a)\\s+(?<unit>ano|m[êe]s|semana|dia))\\b'
    HalfRegex = f'\\b(?<half>mei[oa]\\s+(?<unit>ano|m[êe]s|semana|dia|hora))\\b'
    ConjunctionRegex = f'^[.]'
    InexactNumberRegex = f'\\b(poucos|pouco|algum|alguns|v[áa]rios)\\b'
    InexactNumberUnitRegex = f'\\b(poucos|pouco|algum|alguns|v[áa]rios)\\s+{UnitRegex}'
    HolidayRegex1 = f'\\b(?<holiday>sexta-feira santa|sexta-feira da paix[ãa]o|quarta-feira de cinzas|carnaval|dia (de|de los) presidentes?|ano novo chin[eê]s|ano novo|v[ée]spera de ano novo|natal|v[ée]spera de natal|dia de a[cç][ãa]o de gra[çc]as|a[cç][ãa]o de gra[çc]as|yuandan|halloween|dia das bruxas|p[áa]scoa)(\\s+(d[eo]?\\s+)?({YearRegex}|(?<order>(pr[oó]xim[oa]?|[nd]?es[st][ea]|[uú]ltim[oa]?|em))\\s+ano))?\\b'
    HolidayRegex2 = f'\\b(?<holiday>(dia( d[eoa]s?)? )?(martin luther king|todos os santos|trabalho|s[ãa]o (patr[íi]cio|francisco|jorge|jo[ãa]o)|independ[êe]ncia|trabalhador|trabalho))(\\s+(d[eo]?\\s+)?({YearRegex}|(?<order>(pr[oó]xim[oa]?|[nd]?es[st][ea]|[uú]ltim[oa]?|em))\\s+ano))?\\b'
    HolidayRegex3 = f'\\b(?<holiday>(dia( d[eoa]s?)? )(trabalhador|trabalhadores|trabalho|m[ãa]es?|pais?|mulher(es)?|crian[çc]as?|marmota|professor|professores))(\\s+(d[eo]?\\s+)?({YearRegex}|(?<order>(pr[oó]xim[oa]?|[nd]?es[st][ea]|[uú]ltim[oa]?|em))\\s+ano))?\\b'
    BeforeRegex = f'(antes(\\s+(de|dos?|das?)?)?)'
    AfterRegex = f'((depois|ap[óo]s)(\\s*(de|d?os?|d?as?)?)?)'
    SinceRegex = f'(desde(\\s+(as?|o))?)'
    AroundRegex = f'^[.]'
    PeriodicRegex = f'\\b(?<periodic>di[áa]ri[ao]|diariamente|mensalmente|semanalmente|quinzenalmente|anualmente)\\b'
    EachExpression = f'cada|tod[oa]s?\\s*([oa]s)?'
    EachUnitRegex = f'(?<each>({EachExpression})\\s*{UnitRegex})'
    EachPrefixRegex = f'(?<each>({EachExpression})\\s*$)'
    EachDayRegex = f'\\s*({EachExpression})\\s*dias\\s*\\b'
    BeforeEachDayRegex = f'({EachExpression})\\s*dias(\\s+(as|ao))?\\s*\\b'
    SetEachRegex = f'(?<each>({EachExpression})\\s*)'
    LaterEarlyPeriodRegex = f'^[.]'
    WeekWithWeekDayRangeRegex = f'^[.]'
    GeneralEndingRegex = f'^[.]'
    MiddlePauseRegex = f'^[.]'
    PrefixArticleRegex = f'^[\\.]'
    OrRegex = f'^[.]'
    YearPlusNumberRegex = f'^[.]'
    NumberAsTimeRegex = f'^[.]'
    TimeBeforeAfterRegex = f'^[.]'
    DateNumberConnectorRegex = f'^[.]'
    ComplexDatePeriodRegex = f'^[.]'
    AgoRegex = f'\\b(antes|atr[áa]s|no passado)\\b'
    LaterRegex = f'\\b(depois d[eoa]s?|ap[óo]s (as)?|desde (as|o)|desde|no futuro|mais tarde)\\b'
    Tomorrow = 'amanh[ãa]'
    UnitMap = dict([("anos", "Y"),
                    ("ano", "Y"),
                    ("meses", "MON"),
                    ("mes", "MON"),
                    ("mês", "MON"),
                    ("semanas", "W"),
                    ("semana", "W"),
                    ("dias", "D"),
                    ("dia", "D"),
                    ("horas", "H"),
                    ("hora", "H"),
                    ("hrs", "H"),
                    ("hr", "H"),
                    ("h", "H"),
                    ("minutos", "M"),
                    ("minuto", "M"),
                    ("mins", "M"),
                    ("min", "M"),
                    ("segundos", "S"),
                    ("segundo", "S"),
                    ("segs", "S"),
                    ("seg", "S")])
    UnitValueMap = dict([("anos", 31536000),
                         ("ano", 31536000),
                         ("meses", 2592000),
                         ("mes", 2592000),
                         ("mês", 2592000),
                         ("semanas", 604800),
                         ("semana", 604800),
                         ("dias", 86400),
                         ("dia", 86400),
                         ("horas", 3600),
                         ("hora", 3600),
                         ("hrs", 3600),
                         ("hr", 3600),
                         ("h", 3600),
                         ("minutos", 60),
                         ("minuto", 60),
                         ("mins", 60),
                         ("min", 60),
                         ("segundos", 1),
                         ("segundo", 1),
                         ("segs", 1),
                         ("seg", 1)])
    SpecialYearPrefixesMap = dict([("", "")])
    SeasonMap = dict([("primavera", "SP"),
                      ("verao", "SU"),
                      ("verão", "SU"),
                      ("outono", "FA"),
                      ("inverno", "WI")])
    SeasonValueMap = dict([("SP", 3),
                           ("SU", 6),
                           ("FA", 9),
                           ("WI", 12)])
    CardinalMap = dict([("primeiro", 1),
                        ("primeira", 1),
                        ("1o", 1),
                        ("1a", 1),
                        ("segundo", 2),
                        ("segunda", 2),
                        ("2o", 2),
                        ("2a", 2),
                        ("terceiro", 3),
                        ("terceira", 3),
                        ("3o", 3),
                        ("3a", 3),
                        ("cuarto", 4),
                        ("quarto", 4),
                        ("cuarta", 4),
                        ("quarta", 4),
                        ("4o", 4),
                        ("4a", 4),
                        ("quinto", 5),
                        ("quinta", 5),
                        ("5o", 5),
                        ("5a", 5)])
    DayOfWeek = dict([("segunda-feira", 1),
                      ("segundas-feiras", 1),
                      ("segunda feira", 1),
                      ("segundas feiras", 1),
                      ("segunda", 1),
                      ("segundas", 1),
                      ("terça-feira", 2),
                      ("terças-feiras", 2),
                      ("terça feira", 2),
                      ("terças feiras", 2),
                      ("terça", 2),
                      ("terças", 2),
                      ("terca-feira", 2),
                      ("tercas-feiras", 2),
                      ("terca feira", 2),
                      ("tercas feiras", 2),
                      ("terca", 2),
                      ("tercas", 2),
                      ("quarta-feira", 3),
                      ("quartas-feiras", 3),
                      ("quarta feira", 3),
                      ("quartas feiras", 3),
                      ("quarta", 3),
                      ("quartas", 3),
                      ("quinta-feira", 4),
                      ("quintas-feiras", 4),
                      ("quinta feira", 4),
                      ("quintas feiras", 4),
                      ("quinta", 4),
                      ("quintas", 4),
                      ("sexta-feira", 5),
                      ("sextas-feiras", 5),
                      ("sexta feira", 5),
                      ("sextas feiras", 5),
                      ("sexta", 5),
                      ("sextas", 5),
                      ("sabado", 6),
                      ("sabados", 6),
                      ("sábado", 6),
                      ("sábados", 6),
                      ("domingo", 0),
                      ("domingos", 0),
                      ("seg", 1),
                      ("seg.", 1),
                      ("2a", 1),
                      ("ter", 2),
                      ("ter.", 2),
                      ("3a", 2),
                      ("qua", 3),
                      ("qua.", 3),
                      ("4a", 3),
                      ("qui", 4),
                      ("qui.", 4),
                      ("5a", 4),
                      ("sex", 5),
                      ("sex.", 5),
                      ("6a", 5),
                      ("sab", 6),
                      ("sab.", 6),
                      ("dom", 0),
                      ("dom.", 0)])
    MonthOfYear = dict([("janeiro", 1),
                        ("fevereiro", 2),
                        ("março", 3),
                        ("marco", 3),
                        ("abril", 4),
                        ("maio", 5),
                        ("junho", 6),
                        ("julho", 7),
                        ("agosto", 8),
                        ("septembro", 9),
                        ("setembro", 9),
                        ("outubro", 10),
                        ("novembro", 11),
                        ("dezembro", 12),
                        ("jan", 1),
                        ("fev", 2),
                        ("mar", 3),
                        ("abr", 4),
                        ("mai", 5),
                        ("jun", 6),
                        ("jul", 7),
                        ("ago", 8),
                        ("sept", 9),
                        ("set", 9),
                        ("out", 10),
                        ("nov", 11),
                        ("dez", 12),
                        ("1", 1),
                        ("2", 2),
                        ("3", 3),
                        ("4", 4),
                        ("5", 5),
                        ("6", 6),
                        ("7", 7),
                        ("8", 8),
                        ("9", 9),
                        ("10", 10),
                        ("11", 11),
                        ("12", 12),
                        ("01", 1),
                        ("02", 2),
                        ("03", 3),
                        ("04", 4),
                        ("05", 5),
                        ("06", 6),
                        ("07", 7),
                        ("08", 8),
                        ("09", 9)])
    Numbers = dict([("zero", 0),
                    ("um", 1),
                    ("uma", 1),
                    ("dois", 2),
                    ("tres", 3),
                    ("três", 3),
                    ("quatro", 4),
                    ("cinco", 5),
                    ("seis", 6),
                    ("sete", 7),
                    ("oito", 8),
                    ("nove", 9),
                    ("dez", 10),
                    ("onze", 11),
                    ("doze", 12),
                    ("dezena", 12),
                    ("dezenas", 12),
                    ("treze", 13),
                    ("catorze", 14),
                    ("quatorze", 14),
                    ("quinze", 15),
                    ("dezesseis", 16),
                    ("dezasseis", 16),
                    ("dezessete", 17),
                    ("dezassete", 17),
                    ("dezoito", 18),
                    ("dezenove", 19),
                    ("dezanove", 19),
                    ("vinte", 20),
                    ("vinte e um", 21),
                    ("vinte e uma", 21),
                    ("vinte e dois", 22),
                    ("vinte e duas", 22),
                    ("vinte e tres", 23),
                    ("vinte e três", 23),
                    ("vinte e quatro", 24),
                    ("vinte e cinco", 25),
                    ("vinte e seis", 26),
                    ("vinte e sete", 27),
                    ("vinte e oito", 28),
                    ("vinte e nove", 29),
                    ("trinta", 30)])
    HolidayNames = dict([("pai", ["diadopai", "diadospais"]),
                         ("mae", ["diadamae", "diadasmaes"]),
                         ("acaodegracas", ["diadegracas", "diadeacaodegracas", "acaodegracas"]),
                         ("trabalho", ["diadotrabalho", "diadotrabalhador", "diadostrabalhadores"]),
                         ("pascoa", ["diadepascoa", "pascoa"]),
                         ("natal", ["natal", "diadenatal"]),
                         ("vesperadenatal", ["vesperadenatal"]),
                         ("anonovo", ["anonovo", "diadeanonovo", "diadoanonovo"]),
                         ("vesperadeanonovo", ["vesperadeanonovo", "vesperadoanonovo"]),
                         ("yuandan", ["yuandan"]),
                         ("todosossantos", ["todosossantos"]),
                         ("professor", ["diadoprofessor", "diadosprofessores"]),
                         ("crianca", ["diadacrianca", "diadascriancas"]),
                         ("mulher", ["diadamulher"])])
    VariableHolidaysTimexDictionary = dict([("pai", "-06-WXX-7-3"),
                                            ("mae", "-05-WXX-7-2"),
                                            ("acaodegracas", "-11-WXX-4-4"),
                                            ("trabalho", "-05-WXX-1-1"),
                                            ("memoria", "-03-WXX-2-4")])
    DoubleNumbers = dict([("metade", 0.5),
                          ("quarto", 0.25)])
    DateTokenPrefix = 'em '
    TimeTokenPrefix = 'as '
    TokenBeforeDate = 'o '
    TokenBeforeTime = 'as '
    UpcomingPrefixRegex = f'.^'
    NextPrefixRegex = f'(pr[oó]xim[oa]|seguinte|{UpcomingPrefixRegex})\\b'
    PastPrefixRegex = f'.^'
    PreviousPrefixRegex = f'([uú]ltim[oa]|{PastPrefixRegex})\\b'
    ThisPrefixRegex = f'([nd]?es[st][ea])\\b'
    RelativeDayRegex = f'^[\\.]'
    RestOfDateRegex = f'^[\\.]'
    RelativeDurationUnitRegex = f'^[\\.]'
    ReferenceDatePeriodRegex = f'^[.]'
    FromToRegex = f'\\b(from).+(to)\\b.+'
    SingleAmbiguousMonthRegex = f'^(the\\s+)?(may|march)$'
    UnspecificDatePeriodRegex = f'^[.]'
    PrepositionSuffixRegex = f'\\b(on|in|at|around|from|to)$'
    RestOfDateTimeRegex = f'^[\\.]'
    SetWeekDayRegex = f'^[\\.]'
    NightRegex = f'\\b(meia noite|noite|de noite)\\b'
    CommonDatePrefixRegex = f'\\b(dia)\\s+$'
    DurationUnitRegex = f'^[\\.]'
    DurationConnectorRegex = f'^[.]'
    CenturyRegex = f'^[.]'
    DecadeRegex = f'^[.]'
    DecadeWithCenturyRegex = f'^[.]'
    RelativeDecadeRegex = f'^[.]'
    YearSuffix = f'(,?\\s*({YearRegex}|{FullTextYearRegex}))'
    SuffixAfterRegex = f'^[.]'
    YearPeriodRegex = f'^[.]'
    FutureSuffixRegex = f'^[.]'
    WrittenDecades = dict([("", 0)])
    SpecialDecadeCases = dict([("", 0)])
    DefaultLanguageFallback = 'DMY'
    DurationDateRestrictions = []
    AmbiguityFiltersDict = dict([("null", "null")])
    EarlyMorningTermList = [r'madrugada']
    MorningTermList = [r'manha', r'manhã']
    AfternoonTermList = [r'passado o meio dia', r'depois do meio dia']
    EveningTermList = [r'tarde']
    NightTermList = [r'noite']
    SameDayTerms = [r'hoje', r'este dia', r'esse dia', r'o dia']
    PlusOneDayTerms = [r'amanha', r'de amanha', r'dia seguinte', r'o dia de amanha', r'proximo dia']
    MinusOneDayTerms = [r'ontem', r'ultimo dia']
    PlusTwoDayTerms = [r'depois de amanha', r'dia depois de amanha']
    MinusTwoDayTerms = [r'anteontem', r'dia antes de ontem']
    MonthTerms = [r'mes', r'meses']
    MonthToDateTerms = [r'mes ate agora', r'mes ate hoje', r'mes ate a data']
    WeekendTerms = [r'fim de semana']
    WeekTerms = [r'semana']
    YearTerms = [r'ano', r'anos']
    YearToDateTerms = [r'ano ate agora', r'ano ate hoje', r'ano ate a data', r'anos ate agora', r'anos ate hoje', r'anos ate a data']
    SpecialCharactersEquivalent = dict([("á", "a"),
                                        ("é", "e"),
                                        ("í", "i"),
                                        ("ó", "o"),
                                        ("ú", "u"),
                                        ("ê", "e"),
                                        ("ô", "o"),
                                        ("ü", "u"),
                                        ("ã", "a"),
                                        ("õ", "o"),
                                        ("ç", "c")])
# pylint: enable=line-too-long
