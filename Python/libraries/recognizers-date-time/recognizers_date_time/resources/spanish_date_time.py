# ------------------------------------------------------------------------------
# <auto-generated>
#     This code was generated by a tool.
#     Changes to this file may cause incorrect behavior and will be lost if
#     the code is regenerated.
# </auto-generated>
# ------------------------------------------------------------------------------

from .base_date_time import BaseDateTime
# pylint: disable=line-too-long
class SpanishDateTime:
    TillRegex = f'(?<till>hasta|al|a|--|-|—|——)(\\s+(el|la(s)?))?'
    AndRegex = f'(?<and>y|y\\s*el|--|-|—|——)'
    DayRegex = f'(?<day>01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|1|20|21|22|23|24|25|26|27|28|29|2|30|31|3|4|5|6|7|8|9)(?=\\b|t)'
    MonthNumRegex = f'(?<month>01|02|03|04|05|06|07|08|09|10|11|12|1|2|3|4|5|6|7|8|9)\\b'
    YearRegex = f'(?<year>((1[5-9]|20)\\d{{2}})|[0-27-9]\\d)'
    FullYearRegex = f'\\b(?<year>19\\d{{2}}|20\\d{{2}})\\b'
    RelativeMonthRegex = f'(?<relmonth>(este|pr[oó]ximo|[uú]ltimo)\\s+mes)\\b'
    MonthRegex = f'(?<month>Abril|Abr|Agosto|Ago|Diciembre|Dic|Febrero|Feb|Enero|Ene|Julio|Jul|Junio|Jun|Marzo|Mar|Mayo|May|Noviembre|Nov|Octubre|Oct|Septiembre|Setiembre|Sept|Set)'
    MonthSuffixRegex = f'(?<msuf>(en\\s+|del\\s+|de\\s+)?({RelativeMonthRegex}|{MonthRegex}))'
    DateUnitRegex = f'(?<unit>años|año|meses|mes|semanas|semana|d[ií]a(s)?)\\b'
    PastRegex = f'(?<past>\\b(pasad(a|o)(s)?|[uú]ltim[oa](s)?|anterior(es)?|previo(s)?)\\b)'
    FutureRegex = f'(?<past>\\b(siguiente(s)?|pr[oó]xim[oa](s)?|dentro\\s+de|en)\\b)'
    SimpleCasesRegex = f'\\b((desde\\s+el|desde|del)\\s+)?({DayRegex})\\s*{TillRegex}\\s*({DayRegex})\\s+{MonthSuffixRegex}((\\s+|\\s*,\\s*){FullYearRegex})?\\b'
    MonthFrontSimpleCasesRegex = f'\\b{MonthSuffixRegex}\\s+((desde\\s+el|desde|del)\\s+)?({DayRegex})\\s*{TillRegex}\\s*({DayRegex})((\\s+|\\s*,\\s*){FullYearRegex})?\\b'
    MonthFrontBetweenRegex = f'\\b{MonthSuffixRegex}\\s+((entre|entre\\s+el)\\s+)({DayRegex})\\s*{AndRegex}\\s*({DayRegex})((\\s+|\\s*,\\s*){FullYearRegex})?\\b'
    DayBetweenRegex = f'\\b((entre|entre\\s+el)\\s+)({DayRegex})\\s*{AndRegex}\\s*({DayRegex})\\s+{MonthSuffixRegex}((\\s+|\\s*,\\s*){FullYearRegex})?\\b'
    OneWordPeriodRegex = f'\\b(((pr[oó]xim[oa]?|est[ea]|[uú]ltim[oa]?|en)\\s+)?(?<month>Abril|Abr|Agosto|Ago|Diciembre|Dic|Enero|Ene|Febrero|Feb|Julio|Jul|Junio|Jun|Marzo|Mar|Mayo|May|Noviembre|Nov|Octubre|Oct|Septiembre|Setiembre|Sept|Set)|(?<=\\b(del|de la|el|la)\\s+)?(pr[oó]xim[oa](s)?|[uú]ltim[oa]?|est(e|a))\\s+(fin de semana|semana|mes|año)|fin de semana|(mes|años)? a la fecha)\\b'
    MonthWithYearRegex = f'\\b(((pr[oó]xim[oa](s)?|este|esta|[uú]ltim[oa]?|en)\\s+)?(?<month>Abril|Abr|Agosto|Ago|Diciembre|Dic|Enero|Ene|Febrero|Feb|Julio|Jul|Junio|Jun|Marzo|Mar|Mayo|May|Noviembre|Nov|Octubre|Oct|Septiembre|Setiembre|Sept|Set)\\s+((de|del|de la)\\s+)?({FullYearRegex}|(?<order>pr[oó]ximo(s)?|[uú]ltimo?|este)\\s+año))\\b'
    MonthNumWithYearRegex = f'({FullYearRegex}(\\s*?)[/\\-\\.](\\s*?){MonthNumRegex})|({MonthNumRegex}(\\s*?)[/\\-](\\s*?){FullYearRegex})'
    WeekOfMonthRegex = f'(?<wom>(la\\s+)?(?<cardinal>primera?|1ra|segunda|2da|tercera?|3ra|cuarta|4ta|quinta|5ta|[uú]ltima)\\s+semana\\s+{MonthSuffixRegex})'
    WeekOfYearRegex = f'(?<woy>(la\\s+)?(?<cardinal>primera?|1ra|segunda|2da|tercera?|3ra|cuarta|4ta|quinta|5ta|[uú]ltima?)\\s+semana(\\s+del?)?\\s+({FullYearRegex}|(?<order>pr[oó]ximo|[uú]ltimo|este)\\s+año))'
    FollowedDateUnit = f'^\\s*{DateUnitRegex}'
    NumberCombinedWithDateUnit = f'\\b(?<num>\\d+(\\.\\d*)?){DateUnitRegex}'
    QuarterRegex = f'(el\\s+)?(?<cardinal>primer|1er|segundo|2do|tercer|3ro|cuarto|4to)\\s+cuatrimestre(\\s+de|\\s*,\\s*)?\\s+({FullYearRegex}|(?<order>pr[oó]ximo(s)?|[uú]ltimo?|este)\\s+año)'
    QuarterRegexYearFront = f'({FullYearRegex}|(?<order>pr[oó]ximo(s)?|[uú]ltimo?|este)\\s+año)\\s+(el\\s+)?(?<cardinal>(primer|primero)|1er|segundo|2do|(tercer|terceo)|3ro|cuarto|4to)\\s+cuatrimestre'
    AllHalfYearRegex = f'^[.]'
    PrefixDayRegex = f'^[.]'
    CenturySuffixRegex = f'^[.]'
    SeasonRegex = f'\\b(?<season>(([uú]ltim[oa]|est[ea]|el|la|(pr[oó]xim[oa]s?|siguiente))\\s+)?(?<seas>primavera|verano|otoño|invierno)((\\s+del?|\\s*,\\s*)?\\s+({FullYearRegex}|(?<order>pr[oó]ximo|[uú]ltimo|este)\\s+año))?)\\b'
    WhichWeekRegex = f'(semana)(\\s*)(?<number>\\d\\d|\\d|0\\d)'
    WeekOfRegex = f'(semana)(\\s*)((do|da|de))'
    MonthOfRegex = f'(mes)(\\s*)((do|da|de))'
    RangeUnitRegex = f'\\b(?<unit>años|año|meses|mes|semanas|semana)\\b'
    InConnectorRegex = f'\\b(in)\\b'
    WithinNextPrefixRegex = f'^[.]'
    FromRegex = f'((desde|de)(\\s*la(s)?)?)$'
    ConnectorAndRegex = f'(y\\s*(la(s)?)?)$'
    BetweenRegex = f'(entre\\s*(la(s)?)?)'
    WeekDayRegex = f'\\b(?<weekday>Domingos?|Lunes|Martes|Mi[eé]rcoles|Jueves|Viernes|S[aá]bados?|Lu|Ma|Mi|Ju|Vi|Sa|Do)\\b'
    OnRegex = f'(?<=\\ben\\s+)({DayRegex}s?)\\b'
    RelaxedOnRegex = f'(?<=\\b(en|el|del)\\s+)((?<day>10|11|12|13|14|15|16|17|18|19|1st|20|21|22|23|24|25|26|27|28|29|2|30|31|3|4|5|6|7|8|9)s?)\\b'
    ThisRegex = f'\\b((este\\s*){WeekDayRegex})|({WeekDayRegex}\\s*((de\\s+)?esta\\s+semana))\\b'
    LastDateRegex = f'\\b(([uú]ltimo)\\s*{WeekDayRegex})|({WeekDayRegex}(\\s+((de\\s+)?(esta|la)\\s+([uú]ltima\\s+)?semana)))\\b'
    NextDateRegex = f'\\b(((pr[oó]ximo|siguiente)\\s*){WeekDayRegex})|({WeekDayRegex}(\\s+(de\\s+)?(la\\s+)?(pr[oó]xima|siguiente)(\\s*semana)))\\b'
    SpecialDayRegex = f'\\b((el\\s+)?(d[ií]a\\s+antes\\s+de\\s+ayer|anteayer)|((el\\s+)?d[ií]a\\s+(despu[eé]s\\s+)?de\\s+mañana|pasado\\s+mañana)|(el\\s)?d[ií]a siguiente|(el\\s)?pr[oó]ximo\\s+d[ií]a|(el\\s+)?[uú]ltimo d[ií]a|(d)?el d[ií]a|ayer|mañana|hoy)\\b'
    SpecialDayWithNumRegex = f'^[.]'
    ForTheRegex = f'^[.]'
    WeekDayAndDayOfMonthRegex = f'^[.]'
    WeekDayOfMonthRegex = f'(?<wom>(el\\s+)?(?<cardinal>primer|1er|segundo|2do|tercer|3er|cuarto|4to|quinto|5to|[uú]ltimo)\\s+{WeekDayRegex}\\s+{MonthSuffixRegex})'
    RelativeWeekDayRegex = f'^[.]'
    NumberEndingPattern = f'^[.]'
    SpecialDateRegex = f'(?<=\\b(en)\\s+el\\s+){DayRegex}\\b'
    OfMonthRegex = f'^\\s*de\\s*{MonthSuffixRegex}'
    MonthEndRegex = f'({MonthRegex}\\s*(el)?\\s*$)'
    WeekDayEnd = f'{WeekDayRegex}\\s*,?\\s*$'
    DateExtractor1 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}?((\\s*(de)|[/\\\\\\.\\-])\\s*)?{MonthRegex}\\b'
    DateExtractor2 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}\\s*([\\.\\-]|de)?\\s*{MonthRegex}?(\\s*,\\s*|\\s*(del?)\\s*){YearRegex}\\b'
    DateExtractor3 = f'\\b({WeekDayRegex}(\\s+|\\s*,\\s*))?{DayRegex}(\\s+|\\s*,\\s*|\\s+de\\s+|\\s*-\\s*){MonthRegex}((\\s+|\\s*,\\s*){YearRegex})?\\b'
    DateExtractor4 = f'\\b{MonthNumRegex}\\s*[/\\\\\\-]\\s*{DayRegex}\\s*[/\\\\\\-]\\s*{YearRegex}'
    DateExtractor5 = f'\\b{DayRegex}\\s*[/\\\\\\-\\.]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\.]\\s*{YearRegex}'
    DateExtractor6 = f'(?<=\\b(en|el)\\s+){MonthNumRegex}[\\-\\.]{DayRegex}\\b'
    DateExtractor7 = f'\\b{MonthNumRegex}\\s*/\\s*{DayRegex}((\\s+|\\s*,\\s*|\\s+de\\s+){YearRegex})?\\b'
    DateExtractor8 = f'(?<=\\b(en|el)\\s+){DayRegex}[\\\\\\-]{MonthNumRegex}\\b'
    DateExtractor9 = f'\\b{DayRegex}\\s*/\\s*{MonthNumRegex}((\\s+|\\s*,\\s*|\\s+de\\s+){YearRegex})?\\b'
    DateExtractor10 = f'\\b{YearRegex}\\s*[/\\\\\\-\\.]\\s*{MonthNumRegex}\\s*[/\\\\\\-\\.]\\s*{DayRegex}'
    HourNumRegex = f'\\b(?<hournum>cero|una|dos|tres|cuatro|cinco|seis|siete|ocho|nueve|diez|once|doce)\\b'
    DescRegex = f'(?<desc>pm\\b|am\\b|p\\.m\\.|a\\.m\\.)'
    AmDescRegex = f'(am\\b|a\\.m\\.|a m\\b|a\\. m\\.\\b|a\\.m\\b|a\\. m\\b)'
    PmDescRegex = f'(pm\\b|p\\.m\\.|p\\b|p m\\b|p\\. m\\.\\b|p\\.m\\b|p\\. m\\b)'
    AmPmDescRegex = f'(ampm)'
    MinuteNumRegex = f'(?<minnum>un|dos|tres|cuatro|cinco|seis|siete|ocho|nueve|diez|once|doce|trece|catorce|quince|dieciseis|diecisiete|dieciocho|diecinueve|veinte|treinta|cuarenta|cincuenta)'
    DeltaMinuteNumRegex = f'(?<deltaminnum>un|dos|tres|cuatro|cinco|seis|siete|ocho|nueve|diez|once|doce|trece|catorce|quince|dieciseis|diecisiete|dieciocho|diecinueve|veinte|treinta|cuarenta|cincuenta)'
    OclockRegex = f'(?<oclock>en\\s+punto)'
    PmRegex = f'(?<pm>((por|de|a|en)\\s+la)\\s+(tarde|noche))'
    AmRegex = f'(?<am>((por|de|a|en)\\s+la)\\s+(mañana|madrugada))'
    AmTimeRegex = f'(?<am>(esta|(por|de|a|en)\\s+la)\\s+(mañana|madrugada))'
    PmTimeRegex = f'(?<pm>(esta|(por|de|a|en)\\s+la)\\s+(tarde|noche))'
    LessThanOneHour = f'(?<lth>((\\s+y\\s+)?cuarto|(\\s*)menos cuarto|(\\s+y\\s+)media|{BaseDateTime.DeltaMinuteRegex}(\\s+(minuto|minutos|min|mins))|{DeltaMinuteNumRegex}(\\s+(minuto|minutos|min|mins))))'
    TensTimeRegex = f'(?<tens>diez|veint(i|e)|treinta|cuarenta|cincuenta)'
    WrittenTimeRegex = f'(?<writtentime>{HourNumRegex}\\s*((y|menos)\\s+)?({MinuteNumRegex}|({TensTimeRegex}((\\s*y\\s+)?{MinuteNumRegex})?)))'
    TimePrefix = f'(?<prefix>{LessThanOneHour}(\\s+(pasad[ao]s)\\s+(de\\s+las|las)?|\\s+(para|antes\\s+de)?\\s+(las?))?)'
    TimeSuffix = f'(?<suffix>({LessThanOneHour}\\s+)?({AmRegex}|{PmRegex}|{OclockRegex}))'
    BasicTime = f'(?<basictime>{WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex}:{BaseDateTime.MinuteRegex}(:{BaseDateTime.SecondRegex})?|{BaseDateTime.HourRegex})'
    AtRegex = f'\\b(?<=\\b(a las?)\\s+)({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\\b'
    ConnectNumRegex = f'({BaseDateTime.HourRegex}(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59)\\s*{DescRegex})'
    TimeRegex1 = f'(\\b{TimePrefix}\\s+)?({WrittenTimeRegex}|{HourNumRegex}|{BaseDateTime.HourRegex})\\s*({DescRegex})'
    TimeRegex2 = f'(\\b{TimePrefix}\\s+)?(T)?{BaseDateTime.HourRegex}(\\s*)?:(\\s*)?{BaseDateTime.MinuteRegex}((\\s*)?:(\\s*)?{BaseDateTime.SecondRegex})?((\\s*{DescRegex})|\\b)'
    TimeRegex3 = f'(\\b{TimePrefix}\\s+)?{BaseDateTime.HourRegex}\\.{BaseDateTime.MinuteRegex}(\\s*{DescRegex})'
    TimeRegex4 = f'\\b(({DescRegex}?)|({BasicTime}?)({DescRegex}?))({TimePrefix}\\s*)({HourNumRegex}|{BaseDateTime.HourRegex})?(\\s+{TensTimeRegex}(\\s+y\\s+)?{MinuteNumRegex}?)?({OclockRegex})?\\b'
    TimeRegex5 = f'\\b({TimePrefix}|{BasicTime}{TimePrefix})\\s+(\\s*{DescRegex})?{BasicTime}?\\s*{TimeSuffix}\\b'
    TimeRegex6 = f'({BasicTime}(\\s*{DescRegex})?\\s+{TimeSuffix}\\b)'
    TimeRegex7 = f'\\b{TimeSuffix}\\s+a\\s+las\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex8 = f'\\b{TimeSuffix}\\s+{BasicTime}((\\s*{DescRegex})|\\b)'
    TimeRegex9 = f'\\b(?<writtentime>{HourNumRegex}\\s+({TensTimeRegex}\\s*)?(y\\s+)?{MinuteNumRegex}?)\\b'
    TimeRegex10 = f'(a\\s+la|al)\\s+(madrugada|mañana|medio\\s*d[ií]a|tarde|noche)'
    TimeRegex11 = f'\\b({WrittenTimeRegex})({DescRegex}?)\\b'
    TimeRegex12 = f'(\\b{TimePrefix}\\s+)?{BaseDateTime.HourRegex}(\\s*h\\s*){BaseDateTime.MinuteRegex}(\\s*{DescRegex})?'
    PrepositionRegex = f'(?<prep>(a(l)?|en|de(l)?)?(\\s*(la(s)?|el|los))?$)'
    NowRegex = f'\\b(?<now>(justo\\s+)?ahora(\\s+mismo)?|en\\s+este\\s+momento|tan\\s+pronto\\s+como\\s+sea\\s+posible|tan\\s+pronto\\s+como\\s+(pueda|puedas|podamos|puedan)|lo\\s+m[aá]s\\s+pronto\\s+posible|recientemente|previamente)\\b'
    SuffixRegex = f'^\\s*(((y|a|en|por)\\s+la|al)\\s+)?(mañana|madrugada|medio\\s*d[ií]a|tarde|noche)\\b'
    TimeOfDayRegex = f'\\b(?<timeOfDay>mañana|madrugada|(pasado\\s+(el\\s+)?)?medio\\s?d[ií]a|tarde|noche|anoche)\\b'
    SpecificTimeOfDayRegex = f'\\b(((((a)?\\s+la|esta|siguiente|pr[oó]xim[oa]|[uú]ltim[oa])\\s+)?{TimeOfDayRegex}))\\b'
    TimeOfTodayAfterRegex = f'^\\s*(,\\s*)?(en|de(l)?\\s+)?{SpecificTimeOfDayRegex}'
    TimeOfTodayBeforeRegex = f'({SpecificTimeOfDayRegex}(\\s*,)?(\\s+(a\\s+la(s)?|para))?\\s*)'
    SimpleTimeOfTodayAfterRegex = f'({HourNumRegex}|{BaseDateTime.HourRegex})\\s*(,\\s*)?((en|de(l)?)?\\s+)?{SpecificTimeOfDayRegex}'
    SimpleTimeOfTodayBeforeRegex = f'({SpecificTimeOfDayRegex}(\\s*,)?(\\s+(a\\s+la|para))?\\s*({HourNumRegex}|{BaseDateTime.HourRegex}))'
    TheEndOfRegex = f'((a|e)l\\s+)?fin(alizar|al)?(\\s+(el|de(l)?)(\\s+d[ií]a)?(\\s+de)?)?\\s*$'
    UnitRegex = f'(?<unit>años|año|meses|mes|semanas|semana|d[ií]as|d[ií]a|horas|hora|h|hr|hrs|hs|minutos|minuto|mins|min|segundos|segundo|segs|seg)\\b'
    ConnectorRegex = f'^(,|t|para la|para las|cerca de la|cerca de las)$'
    TimeHourNumRegex = f'(?<hour>veintiuno|veintidos|veintitres|veinticuatro|cero|uno|dos|tres|cuatro|cinco|seis|siete|ocho|nueve|diez|once|doce|trece|catorce|quince|diecis([eé])is|diecisiete|dieciocho|diecinueve|veinte)'
    PureNumFromTo = f'((desde|de)\\s+(la(s)?\\s+)?)?({BaseDateTime.HourRegex}|{TimeHourNumRegex})(\\s*(?<leftDesc>{DescRegex}))?\\s*{TillRegex}\\s*({BaseDateTime.HourRegex}|{TimeHourNumRegex})\\s*(?<rightDesc>{PmRegex}|{AmRegex}|{DescRegex})?'
    PureNumBetweenAnd = f'(entre\\s+(la(s)?\\s+)?)({BaseDateTime.HourRegex}|{TimeHourNumRegex})(\\s*(?<leftDesc>{DescRegex}))?\\s*y\\s*(la(s)?\\s+)?({BaseDateTime.HourRegex}|{TimeHourNumRegex})\\s*(?<rightDesc>{PmRegex}|{AmRegex}|{DescRegex})?'
    SpecificTimeFromTo = f'^[.]'
    SpecificTimeBetweenAnd = f'^[.]'
    TimeUnitRegex = f'(?<unit>horas|hora|h|minutos|minuto|mins|min|segundos|segundo|secs|sec)\\b'
    TimeFollowedUnit = f'^\\s*{TimeUnitRegex}'
    TimeNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\,\\d*)?)\\s*{TimeUnitRegex}'
    DateTimePeriodNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\.\\d*)?)\\s*{TimeUnitRegex}'
    PeriodTimeOfDayWithDateRegex = f'\\b(((y|a|en|por)\\s+la|al)\\s+)?(?<timeOfDay>mañana|madrugada|(pasado\\s+(el\\s+)?)?medio\\s?d[ií]a|tarde|noche|anoche)\\b'
    RelativeTimeUnitRegex = f'({PastRegex}|{FutureRegex})\\s+{UnitRegex}'
    LessThanRegex = f'^[.]'
    MoreThanRegex = f'^[.]'
    SuffixAndRegex = f'(?<suffix>\\s*(y)\\s+((un|uno|una)\\s+)?(?<suffix_num>media|cuarto))'
    FollowedUnit = f'^\\s*{UnitRegex}'
    DurationNumberCombinedWithUnit = f'\\b(?<num>\\d+(\\,\\d*)?){UnitRegex}'
    AnUnitRegex = f'\\b(un(a)?)\\s+{UnitRegex}'
    DuringRegex = f'^[.]'
    AllRegex = f'\\b(?<all>tod[oa]?\\s+(el|la)\\s+(?<unit>año|mes|semana|d[ií]a))\\b'
    HalfRegex = f'\\b(?<half>medi[oa]\\s+(?<unit>ano|mes|semana|d[íi]a|hora))\\b'
    ConjunctionRegex = f'^[.]'
    InexactNumberRegex = f'\\b(pocos|poco|algo|varios)\\b'
    InexactNumberUnitRegex = f'\\b(pocos|poco|algo|varios)\\s+{UnitRegex}'
    HolidayRegex1 = f'\\b(?<holiday>viernes santo|mi[eé]rcoles de ceniza|martes de carnaval|d[ií]a (de|de los) presidentes?|clebraci[oó]n de mao|año nuevo chino|año nuevo|noche vieja|(festividad de )?los mayos|d[ií]a de los inocentes|navidad|noche buena|d[ií]a de acci[oó]n de gracias|acci[oó]n de gracias|yuandan|halloween|noches de brujas|pascuas)(\\s+(del?\\s+)?({FullYearRegex}|(?<order>(pr[oó]xim[oa]?|est[ea]|[uú]ltim[oa]?|en))\\s+año))?\\b'
    HolidayRegex2 = f'\\b(?<holiday>(d[ií]a( del?( la)?)? )?(martin luther king|todos los santos|blanco|san patricio|san valent[ií]n|san jorge|cinco de mayo|independencia|raza|trabajador))(\\s+(del?\\s+)?({FullYearRegex}|(?<order>(pr[oó]xim[oa]?|est[ea]|[uú]ltim[oa]?|en))\\s+año))?\\b'
    HolidayRegex3 = f'\\b(?<holiday>(d[ií]a( del?( las?)?)? )(trabajador|madres?|padres?|[aá]rbol|mujer(es)?|solteros?|niños?|marmota|san valent[ií]n|maestro))(\\s+(del?\\s+)?({FullYearRegex}|(?<order>(pr[oó]xim[oa]?|est[ea]|[uú]ltim[oa]?|en))\\s+año))?\\b'
    BeforeRegex = f'(antes(\\s+del?(\\s+las?)?)?)'
    AfterRegex = f'(despues(\\s*del?(\\s+las?)?)?)'
    SinceRegex = f'(desde(\\s+(las?|el))?)'
    AroundRegex = f'^[.]'
    PeriodicRegex = f'\\b(?<periodic>a\\s*diario|diariamente|mensualmente|semanalmente|quincenalmente|anualmente)\\b'
    EachExpression = f'cada|tod[oa]s\\s*(l[oa]s)?'
    EachUnitRegex = f'(?<each>({EachExpression})\\s*{UnitRegex})'
    EachPrefixRegex = f'(?<each>({EachExpression})\\s*$)'
    EachDayRegex = f'\\s*({EachExpression})\\s*d[ií]as\\s*\\b'
    BeforeEachDayRegex = f'({EachExpression})\\s*d[ií]as(\\s+a\\s+las?)?\\s*\\b'
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
    CenturyRegex = f'^[.]'
    DecadeRegex = f'^[.]'
    DecadeWithCenturyRegex = f'^[.]'
    RelativeDecadeRegex = f'^[.]'
    ComplexDatePeriodRegex = f'^[.]'
    FullTextYearRegex = f'^[\\*]'
    YearSuffix = f'(,?\\s*({YearRegex}|{FullTextYearRegex}))'
    AgoRegex = f'\\b(antes)\\b'
    LaterRegex = f'\\b(despu[eé]s|desde ahora)\\b'
    Tomorrow = 'mañana'
    UnitMap = dict([('años', 'Y'),
                    ('año', 'Y'),
                    ('meses', 'MON'),
                    ('mes', 'MON'),
                    ('semanas', 'W'),
                    ('semana', 'W'),
                    ('dias', 'D'),
                    ('dia', 'D'),
                    ('días', 'D'),
                    ('día', 'D'),
                    ('horas', 'H'),
                    ('hora', 'H'),
                    ('hrs', 'H'),
                    ('hr', 'H'),
                    ('h', 'H'),
                    ('minutos', 'M'),
                    ('minuto', 'M'),
                    ('mins', 'M'),
                    ('min', 'M'),
                    ('segundos', 'S'),
                    ('segundo', 'S'),
                    ('segs', 'S'),
                    ('seg', 'S')])
    UnitValueMap = dict([('años', 31536000),
                         ('año', 31536000),
                         ('meses', 2592000),
                         ('mes', 2592000),
                         ('semanas', 604800),
                         ('semana', 604800),
                         ('dias', 86400),
                         ('dia', 86400),
                         ('días', 86400),
                         ('día', 86400),
                         ('horas', 3600),
                         ('hora', 3600),
                         ('hrs', 3600),
                         ('hr', 3600),
                         ('h', 3600),
                         ('minutos', 60),
                         ('minuto', 60),
                         ('mins', 60),
                         ('min', 60),
                         ('segundos', 1),
                         ('segundo', 1),
                         ('segs', 1),
                         ('seg', 1)])
    SeasonMap = dict([('primavera', 'SP'),
                      ('verano', 'SU'),
                      ('otoño', 'FA'),
                      ('invierno', 'WI')])
    SeasonValueMap = dict([('SP', 3),
                           ('SU', 6),
                           ('FA', 9),
                           ('WI', 12)])
    CardinalMap = dict([('primer', 1),
                        ('primero', 1),
                        ('primera', 1),
                        ('1er', 1),
                        ('1ro', 1),
                        ('1ra', 1),
                        ('segundo', 2),
                        ('segunda', 2),
                        ('2do', 2),
                        ('2da', 2),
                        ('tercer', 3),
                        ('tercero', 3),
                        ('tercera', 3),
                        ('3er', 3),
                        ('3ro', 3),
                        ('3ra', 3),
                        ('cuarto', 4),
                        ('cuarta', 4),
                        ('4to', 4),
                        ('4ta', 4),
                        ('quinto', 5),
                        ('quinta', 5),
                        ('5to', 5),
                        ('5ta', 5)])
    DayOfWeek = dict([('lunes', 1),
                      ('martes', 2),
                      ('miercoles', 3),
                      ('miércoles', 3),
                      ('jueves', 4),
                      ('viernes', 5),
                      ('sabado', 6),
                      ('domingo', 0),
                      ('lu', 1),
                      ('ma', 2),
                      ('mi', 3),
                      ('ju', 4),
                      ('vi', 5),
                      ('sa', 6),
                      ('do', 0)])
    MonthOfYear = dict([('enero', 1),
                        ('febrero', 2),
                        ('marzo', 3),
                        ('abril', 4),
                        ('mayo', 5),
                        ('junio', 6),
                        ('julio', 7),
                        ('agosto', 8),
                        ('septiembre', 9),
                        ('setiembre', 9),
                        ('octubre', 10),
                        ('noviembre', 11),
                        ('diciembre', 12),
                        ('ene', 1),
                        ('feb', 2),
                        ('mar', 3),
                        ('abr', 4),
                        ('may', 5),
                        ('jun', 6),
                        ('jul', 7),
                        ('ago', 8),
                        ('sept', 9),
                        ('set', 9),
                        ('oct', 10),
                        ('nov', 11),
                        ('dic', 12),
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
    Numbers = dict([('cero', 0),
                    ('un', 1),
                    ('una', 1),
                    ('uno', 1),
                    ('dos', 2),
                    ('tres', 3),
                    ('cuatro', 4),
                    ('cinco', 5),
                    ('seis', 6),
                    ('siete', 7),
                    ('ocho', 8),
                    ('nueve', 9),
                    ('diez', 10),
                    ('once', 11),
                    ('doce', 12),
                    ('docena', 12),
                    ('docenas', 12),
                    ('trece', 13),
                    ('catorce', 14),
                    ('quince', 15),
                    ('dieciseis', 16),
                    ('dieciséis', 16),
                    ('diecisiete', 17),
                    ('dieciocho', 18),
                    ('diecinueve', 19),
                    ('veinte', 20),
                    ('ventiuna', 21),
                    ('ventiuno', 21),
                    ('veintiun', 21),
                    ('veintiún', 21),
                    ('veintiuno', 21),
                    ('veintiuna', 21),
                    ('veintidos', 22),
                    ('veintidós', 22),
                    ('veintitres', 23),
                    ('veintitrés', 23),
                    ('veinticuatro', 24),
                    ('veinticinco', 25),
                    ('veintiseis', 26),
                    ('veintiséis', 26),
                    ('veintisiete', 27),
                    ('veintiocho', 28),
                    ('veintinueve', 29),
                    ('treinta', 30)])
    HolidayNames = dict([('padres', ['diadelpadre']),
                         ('madres', ['diadelamadre']),
                         ('acciondegracias', ['diadegracias', 'diadeacciondegracias', 'acciondegracias']),
                         ('trabajador', ['diadeltrabajador']),
                         ('delaraza', ['diadelaraza', 'diadeladiversidadcultural']),
                         ('memoria', ['diadelamemoria']),
                         ('pascuas', ['diadepascuas', 'pascuas']),
                         ('navidad', ['navidad', 'diadenavidad']),
                         ('nochebuena', ['diadenochebuena', 'nochebuena']),
                         ('añonuevo', ['a\u00f1onuevo', 'diadea\u00f1onuevo']),
                         ('nochevieja', ['nochevieja', 'diadenochevieja']),
                         ('yuandan', ['yuandan']),
                         ('maestro', ['diadelmaestro']),
                         ('todoslossantos', ['todoslossantos']),
                         ('niño', ['diadelni\u00f1o']),
                         ('mujer', ['diadelamujer'])])
    VariableHolidaysTimexDictionary = dict([('padres', '-06-WXX-7-3'),
                                            ('madres', '-05-WXX-7-2'),
                                            ('acciondegracias', '-11-WXX-4-4'),
                                            ('trabajador', '-05-WXX-1-1'),
                                            ('delaraza', '-10-WXX-1-2'),
                                            ('memoria', '-03-WXX-2-4')])
    DoubleNumbers = dict([('mitad', 0.5),
                          ('cuarto', 0.25)])
    DateTokenPrefix = 'en '
    TimeTokenPrefix = 'a las '
    TokenBeforeDate = 'el '
    TokenBeforeTime = 'la '
    NextPrefixRegex = f'(pr[oó]xim[oa]|siguiente)\\b'
    PastPrefixRegex = f'([uú]ltim[oa])\\b'
    ThisPrefixRegex = f'(est[ea])\\b'
    RelativeDayRegex = f'^[\\.]'
    RestOfDateRegex = f'^[\\.]'
    RelativeDurationUnitRegex = f'^[\\.]'
    ReferenceDatePeriodRegex = f'^[.]'
    FromToRegex = f'\\b(from).+(to)\\b.+'
    SingleAmbiguousMonthRegex = f'^(the\\s+)?(may|march)$'
    UnspecificDatePeriodRegex = f'^[.]'
    PrepositionSuffixRegex = f'\\b(on|in|at|around|for|during|since|from|to)$'
    RestOfDateTimeRegex = f'^[\\.]'
    SetWeekDayRegex = f'^[\\.]'
    NightRegex = f'\\b(medionoche|noche)\\b'
    CommonDatePrefixRegex = f'^[\\.]'
    DurationUnitRegex = f'^[\\.]'
    DurationConnectorRegex = f'^[.]'
    YearAfterRegex = f'^[.]'
    YearPeriodRegex = f'^[.]'
    FutureSuffixRegex = f'^[.]'
    WrittenDecades = dict([('', 0)])
    SpecialDecadeCases = dict([('', 0)])
    DefaultLanguageFallback = 'DMY'
    DurationDateRestrictions = []
# pylint: enable=line-too-long
