//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Spanish\Spanish-Numbers.yaml
//     - Language: Spanish
//     - ClassName: NumbersDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Spanish
{
    using System;
    using System.Collections.Generic;

    public static class NumbersDefinitions
    {
      public const string LangMarker = @"Spa";
      public const bool CompoundNumberLanguage = false;
      public const bool MultiDecimalSeparatorCulture = true;
      public const string HundredsNumberIntegerRegex = @"(cuatrocient[ao]s|trescient[ao]s|seiscient[ao]s|setecient[ao]s|ochocient[ao]s|novecient[ao]s|doscient[ao]s|quinient[ao]s|(?<!por\s+)(cien(to)?))";
      public const string RoundNumberIntegerRegex = @"(mil millones|millones|mill[oó]n|mil|billones|bill[oó]n|trillones|trill[oó]n|cuatrillones|cuatrill[oó]n|quintillones|quintill[oó]n|sextillones|sextill[oó]n|septillones|septill[oó]n)";
      public const string ZeroToNineIntegerRegex = @"(cuatro|cinco|siete|nueve|cero|tres|seis|ocho|dos|un[ao]?)";
      public const string TenToNineteenIntegerRegex = @"(diecisiete|diecinueve|diecis[eé]is|dieciocho|catorce|quince|trece|diez|once|doce)";
      public const string TwentiesIntegerRegex = @"(veinticuatro|veinticinco|veintisiete|veintinueve|veintitr[eé]s|veintis[eé]is|veintiocho|veintid[oó]s|ventiun[ao]|veinti[uú]n[oa]?|veinte)";
      public const string TensNumberIntegerRegex = @"(cincuenta|cuarenta|treinta|sesenta|setenta|ochenta|noventa)";
      public const string NegativeNumberTermsRegex = @"(?<negTerm>(?<!(al|lo)\s+)menos\s+)";
      public static readonly string NegativeNumberSignRegex = $@"^{NegativeNumberTermsRegex}.*";
      public const string DigitsNumberRegex = @"\d|\d{1,3}(\.\d{3})";
      public static readonly string BelowHundredsRegex = $@"(({TenToNineteenIntegerRegex}|{TwentiesIntegerRegex}|({TensNumberIntegerRegex}(\s+y\s+{ZeroToNineIntegerRegex})?))|{ZeroToNineIntegerRegex})";
      public static readonly string BelowThousandsRegex = $@"({HundredsNumberIntegerRegex}(\s+{BelowHundredsRegex})?|{BelowHundredsRegex})";
      public static readonly string SupportThousandsRegex = $@"(({BelowThousandsRegex}|{BelowHundredsRegex})\s+{RoundNumberIntegerRegex}(\s+{RoundNumberIntegerRegex})?)";
      public static readonly string SeparaIntRegex = $@"({SupportThousandsRegex}(\s+{SupportThousandsRegex})*(\s+{BelowThousandsRegex})?|{BelowThousandsRegex})";
      public static readonly string AllIntRegex = $@"({SeparaIntRegex}|mil(\s+{BelowThousandsRegex})?)";
      public const string PlaceHolderPureNumber = @"\b";
      public const string PlaceHolderDefault = @"\D|\b";
      public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+(?!([\.,]\d+[a-zA-Z]))(?={placeholder})";
      public static readonly string NumbersWithSuffix = $@"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)({DigitsNumberRegex})+\s+{RoundNumberIntegerRegex}(?=\b)";
      public const string NumbersWithDozenSuffix = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+docenas?(?=\b)";
      public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
      public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((media\s+)?\s+docena)|({AllIntRegex}\s+(y|con)\s+)?({AllIntRegex}\s+docenas?))(?=\b)";
      public const string SimpleRoundOrdinalRegex = @"(mil[eé]simo|millon[eé]sim[oa]|billon[eé]sim[oa]|trillon[eé]sim[oa]|cuatrillon[eé]sim[oa]|quintillon[eé]sim[oa]|sextillon[eé]sim[oa]|septillon[eé]sim[oa])";
      public const string OneToNineOrdinalRegex = @"(primer[oa]?|segund[oa]|tercer[oa]?|cuart[oa]|quint[oa]|sext[oa]|s[eé]ptim[oa]|octav[oa]|noven[oa])";
      public const string TensOrdinalRegex = @"(nonag[eé]sim[oa]|octog[eé]sim[oa]|septuag[eé]sim[oa]|sexag[eé]sim[oa]|quincuag[eé]sim[oa]|cuadrag[eé]sim[oa]|trig[eé]sim[oa]|vig[eé]sim[oa]|d[eé]cim[oa])";
      public const string HundredOrdinalRegex = @"(cent[eé]sim[oa]|ducent[eé]sim[oa]|tricent[eé]sim[oa]|cuadringent[eé]sim[oa]|quingent[eé]sim[oa]|sexcent[eé]sim[oa]|septingent[eé]sim[oa]|octingent[eé]sim[oa]|noningent[eé]sim[oa])";
      public const string SpecialUnderHundredOrdinalRegex = @"(und[eé]cim[oa]|duod[eé]cim[oa]|decimoctav[oa])";
      public static readonly string UnderHundredOrdinalRegex = $@"({SpecialUnderHundredOrdinalRegex}|(({TensOrdinalRegex}(\s)?)?{OneToNineOrdinalRegex})|{TensOrdinalRegex})";
      public static readonly string UnderThousandOrdinalRegex = $@"((({HundredOrdinalRegex}(\s)?)?{UnderHundredOrdinalRegex})|{HundredOrdinalRegex})";
      public static readonly string OverThousandOrdinalRegex = $@"(({AllIntRegex})([eé]sim[oa]))";
      public static readonly string ComplexOrdinalRegex = $@"(({OverThousandOrdinalRegex}(\s)?)?{UnderThousandOrdinalRegex}|{OverThousandOrdinalRegex})";
      public static readonly string SufixRoundOrdinalRegex = $@"(({AllIntRegex})({SimpleRoundOrdinalRegex}))";
      public static readonly string ComplexRoundOrdinalRegex = $@"((({SufixRoundOrdinalRegex}(\s)?)?{ComplexOrdinalRegex})|{SufixRoundOrdinalRegex})";
      public static readonly string AllOrdinalRegex = $@"{ComplexOrdinalRegex}|{SimpleRoundOrdinalRegex}|{ComplexRoundOrdinalRegex}";
      public const string OrdinalSuffixRegex = @"(?<=\b)(\d*((1(er|r[oa])|2d[oa]|3r[oa]|4t[oa]|5t[oa]|6t[oa]|7m[oa]|8v[oa]|9n[oa]|0m[oa]|11[vm][oa]|12[vm][oa])|\d\.?[º°ª]))(?=\b)";
      public static readonly string OrdinalNounRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
      public static readonly string SpecialFractionInteger = $@"((({AllIntRegex})i?({ZeroToNineIntegerRegex})|({AllIntRegex}))a?v[oa]s?)";
      public static readonly string FractionNotationRegex = $@"{BaseNumbers.FractionNotationRegex}";
      public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
      public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+((y|con)\s+)?)?({AllIntRegex})(\s+((y|con)\s)?)((({AllOrdinalRegex})s?|({SpecialFractionInteger})|({SufixRoundOrdinalRegex})s?)|medi[oa]s?|tercios?)(?=\b)";
      public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)({AllIntRegex}\s+(y\s+)?)?(un|un[oa])(\s+)(({AllOrdinalRegex})|({SufixRoundOrdinalRegex})|(y\s+)?medi[oa]s?)(?=\b)";
      public static readonly string FractionPrepositionRegex = $@"(?<!{BaseNumbers.CommonCurrencySymbol}\s*)(?<=\b)(?<numerator>({AllIntRegex})|((?<!\.)\d+))\s+sobre\s+(?<denominator>({AllIntRegex})|((\d+)(?!\.)))(?=\b)";
      public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{AllIntRegex}))";
      public static readonly string AllFloatRegex = $@"{AllIntRegex}(\s+(coma|con)){AllPointRegex}";
      public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[\.,])))\d+[\.,]\d+(?!([\.,]\d+))(?={placeholder})";
      public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+))[\.,]\d+(?!([\.,]\d+))(?={placeholder})";
      public static readonly string DoubleWithMultiplierRegex = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\[\.,])))\d+[\.,]\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\[\.,])))\d+[\.,]\d+\s+{RoundNumberIntegerRegex}(?=\b)";
      public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
      public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[\.,])))(\d+([\.,]\d+)?)e([+-]*[1-9]\d*)(?=\b)";
      public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+[\.,])))(\d+([\.,]\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
      public static readonly string NumberWithPrefixPercentage = $@"(?<!%)({BaseNumbers.NumberReplaceToken})(\s*)(%(?!{BaseNumbers.NumberReplaceToken})|por\s+cien(to)?\b)";
      public const string TillRegex = @"(\ba\b|hasta|--|-|—|——|~|–)";
      public const string MoreRegex = @"(más\s+(alt[oa]s?|grandes)\s+que|(m[áa]s|mayor(es)?|superior(es)?|por\s+encima)\b((\s+(que|del?|al?))|(?=\s+o\b))|(?<!<|=)>)";
      public const string LessRegex = @"((meno(s|r(es)?)|inferior(es)?|por\s+debajo)((\s+(que|del?|al?)|(?=\s+o\b)))|más\s+baj[oa]\s+que|(?<!>|=)<)";
      public const string EqualRegex = @"((igual(es)?|equivalente(s)?|equivalen?)(\s+(al?|que|del?))?|(?<!<|>)=)";
      public static readonly string MoreOrEqualPrefix = $@"((no\s+{LessRegex})|(por\s+lo\s+menos|como\s+m[íi]nimo|al\s+menos))";
      public static readonly string MoreOrEqual = $@"(({MoreRegex}\s+(o)?\s+{EqualRegex})|({EqualRegex}\s+(o|y)\s+{MoreRegex})|{MoreOrEqualPrefix}(\s+(o)\s+{EqualRegex})?|({EqualRegex}\s+(o)\s+)?{MoreOrEqualPrefix}|>\s*=)";
      public const string MoreOrEqualSuffix = @"((\b(y|o)\b\s+(m[áa]s|mayor(es)?|superior(es)?)((?!\s+(alt[oa]|baj[oa]|que|del?|al?))|(\s+(que|del?|al?)(?!(\s*\d+)))))|como\s+m[íi]nimo|por\s+lo\s+menos|al\s+menos)\b";
      public static readonly string LessOrEqualPrefix = $@"((no\s+{MoreRegex})|(como\s+(m[aá]ximo|mucho)))";
      public static readonly string LessOrEqual = $@"(({LessRegex}\s+(o)?\s+{EqualRegex})|({EqualRegex}\s+(o)?\s+{LessRegex})|{LessOrEqualPrefix}(\s+(o)?\s+{EqualRegex})?|({EqualRegex}\s+(o)?\s+)?{LessOrEqualPrefix}|<\s*=)";
      public const string LessOrEqualSuffix = @"((\b(y|o)\b\s+(meno(s|r(es)?|inferior(es)?))((?!\s+(alt[oa]|baj[oa]|que|del?|al?))|(\s+(que|del?|al?)(?!(\s*\d+)))))|como\s+m[áa]ximo)\b";
      public static readonly string NumberSplitMark = $@"(?![,.](?!\d+))(?!\s*\b(((y|e)\s+)?({LessRegex}|{MoreRegex}|{EqualRegex}|no|de)|pero|o|a)\b)";
      public const string MoreRegexNoNumberSucceed = @"(\b(m[áa]s|mayor(es)?|superior(es)?)((?!\s+(que|del?|al?))|\s+((que|del?)(?!(\s*\d+))))|(por encima)(?!(\s*\d+)))\b";
      public const string LessRegexNoNumberSucceed = @"(\b(meno(s|r(es)?)|inferior(es)?)((?!\s+(que|del?|al?))|\s+((que|del?|al?)(?!(\s*\d+))))|(por debajo)(?!(\s*\d+)))\b";
      public const string EqualRegexNoNumberSucceed = @"(\b(igual(es)?|equivalentes?|equivalen?)((?!\s+(al?|que|del?))|(\s+(al?|que|del?)(?!(\s*\d+)))))\b";
      public static readonly string OneNumberRangeMoreRegex1 = $@"({MoreOrEqual}|{MoreRegex})\s*((el|las?|los)\s+)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeMoreRegex1LB = $@"(?<!no\s+){OneNumberRangeMoreRegex1}";
      public static readonly string OneNumberRangeMoreRegex2 = $@"(?<number1>({NumberSplitMark}.)+)\s*{MoreOrEqualSuffix}";
      public static readonly string OneNumberRangeMoreSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+o\s+){MoreRegexNoNumberSucceed})|({MoreRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+o\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeLessRegex1 = $@"({LessOrEqual}|{LessRegex})\s*((el|las?|los)\s+)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeLessRegex1LB = $@"(?<!no\s+){OneNumberRangeLessRegex1}";
      public static readonly string OneNumberRangeLessRegex2 = $@"(?<number2>({NumberSplitMark}.)+)\s*{LessOrEqualSuffix}";
      public static readonly string OneNumberRangeLessSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+o\s+){LessRegexNoNumberSucceed})|({LessRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+o\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeEqualRegex = $@"{EqualRegex}\s*((el|las?|los)\s+)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex1 = $@"\bentre\s*((el|las?|los)\s+)?(?<number1>({NumberSplitMark}.)+)\s*y\s*((el|las?|los)\s+)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex2 = $@"({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})\s*(\by\b|\be\b|pero|,)\s*({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})";
      public static readonly string TwoNumberRangeRegex3 = $@"({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})\s*(\by\b|\be\b|pero|,)\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})";
      public static readonly string TwoNumberRangeRegex4 = $@"(\bde(sde)?\s+)?(\b(el|las?|los)\s+)?\b(?!\s+)(?<number1>({NumberSplitMark}(?!\b(entre|de(sde)?|es)\b).)+)\b\s*{TillRegex}\s*((el|las?|los)\s+)?\b(?!\s+)(?<number2>({NumberSplitMark}.)+)\b";
      public const string AmbiguousFractionConnectorsRegex = @"(\b(en|de)\b)";
      public const char DecimalSeparatorChar = ',';
      public const string FractionMarkerToken = @"sobre";
      public const char NonDecimalSeparatorChar = '.';
      public const string HalfADozenText = @"seis";
      public const string WordSeparatorToken = @"y";
      public static readonly string[] WrittenDecimalSeparatorTexts = { @"coma", @"con" };
      public static readonly string[] WrittenGroupSeparatorTexts = { @"punto" };
      public static readonly string[] WrittenIntegerSeparatorTexts = { @"y" };
      public static readonly string[] WrittenFractionSeparatorTexts = { @"con" };
      public const string HalfADozenRegex = @"media\s+docena";
      public static readonly string DigitalNumberRegex = $@"((?<=\b)(mil(l[oó]n(es)?)?|bill[oó]n(es)?|trill[oó]n(es)?|docenas?)(?=\b))|((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
      public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
        {
            { @"cero", 0 },
            { @"un", 1 },
            { @"una", 1 },
            { @"uno", 1 },
            { @"dos", 2 },
            { @"tres", 3 },
            { @"cuatro", 4 },
            { @"cinco", 5 },
            { @"seis", 6 },
            { @"siete", 7 },
            { @"ocho", 8 },
            { @"nueve", 9 },
            { @"diez", 10 },
            { @"once", 11 },
            { @"doce", 12 },
            { @"docena", 12 },
            { @"docenas", 12 },
            { @"trece", 13 },
            { @"catorce", 14 },
            { @"quince", 15 },
            { @"dieciseis", 16 },
            { @"dieciséis", 16 },
            { @"diecisiete", 17 },
            { @"dieciocho", 18 },
            { @"diecinueve", 19 },
            { @"veinte", 20 },
            { @"ventiuna", 21 },
            { @"ventiuno", 21 },
            { @"veintiun", 21 },
            { @"veintiún", 21 },
            { @"veintiuno", 21 },
            { @"veintiuna", 21 },
            { @"veintidos", 22 },
            { @"veintidós", 22 },
            { @"veintitres", 23 },
            { @"veintitrés", 23 },
            { @"veinticuatro", 24 },
            { @"veinticinco", 25 },
            { @"veintiseis", 26 },
            { @"veintiséis", 26 },
            { @"veintisiete", 27 },
            { @"veintiocho", 28 },
            { @"veintinueve", 29 },
            { @"treinta", 30 },
            { @"cuarenta", 40 },
            { @"cincuenta", 50 },
            { @"sesenta", 60 },
            { @"setenta", 70 },
            { @"ochenta", 80 },
            { @"noventa", 90 },
            { @"cien", 100 },
            { @"ciento", 100 },
            { @"doscientas", 200 },
            { @"doscientos", 200 },
            { @"trescientas", 300 },
            { @"trescientos", 300 },
            { @"cuatrocientas", 400 },
            { @"cuatrocientos", 400 },
            { @"quinientas", 500 },
            { @"quinientos", 500 },
            { @"seiscientas", 600 },
            { @"seiscientos", 600 },
            { @"setecientas", 700 },
            { @"setecientos", 700 },
            { @"ochocientas", 800 },
            { @"ochocientos", 800 },
            { @"novecientas", 900 },
            { @"novecientos", 900 },
            { @"mil", 1000 },
            { @"millon", 1000000 },
            { @"millón", 1000000 },
            { @"millones", 1000000 },
            { @"billon", 1000000000000 },
            { @"billón", 1000000000000 },
            { @"billones", 1000000000000 },
            { @"trillon", 1000000000000000000 },
            { @"trillón", 1000000000000000000 },
            { @"trillones", 1000000000000000000 }
        };
      public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
        {
            { @"primero", 1 },
            { @"primera", 1 },
            { @"primer", 1 },
            { @"segundo", 2 },
            { @"segunda", 2 },
            { @"medio", 2 },
            { @"media", 2 },
            { @"tercero", 3 },
            { @"tercera", 3 },
            { @"tercer", 3 },
            { @"tercio", 3 },
            { @"cuarto", 4 },
            { @"cuarta", 4 },
            { @"quinto", 5 },
            { @"quinta", 5 },
            { @"sexto", 6 },
            { @"sexta", 6 },
            { @"septimo", 7 },
            { @"septima", 7 },
            { @"séptimo", 7 },
            { @"séptima", 7 },
            { @"octavo", 8 },
            { @"octava", 8 },
            { @"noveno", 9 },
            { @"novena", 9 },
            { @"decimo", 10 },
            { @"décimo", 10 },
            { @"decima", 10 },
            { @"décima", 10 },
            { @"undecimo", 11 },
            { @"undecima", 11 },
            { @"undécimo", 11 },
            { @"undécima", 11 },
            { @"duodecimo", 12 },
            { @"duodecima", 12 },
            { @"duodécimo", 12 },
            { @"duodécima", 12 },
            { @"decimotercero", 13 },
            { @"decimotercera", 13 },
            { @"decimocuarto", 14 },
            { @"decimocuarta", 14 },
            { @"decimoquinto", 15 },
            { @"decimoquinta", 15 },
            { @"decimosexto", 16 },
            { @"decimosexta", 16 },
            { @"decimoseptimo", 17 },
            { @"decimoseptima", 17 },
            { @"decimoctavo", 18 },
            { @"decimoctava", 18 },
            { @"decimonoveno", 19 },
            { @"decimonovena", 19 },
            { @"vigesimo", 20 },
            { @"vigesima", 20 },
            { @"vigésimo", 20 },
            { @"vigésima", 20 },
            { @"trigesimo", 30 },
            { @"trigesima", 30 },
            { @"trigésimo", 30 },
            { @"trigésima", 30 },
            { @"cuadragesimo", 40 },
            { @"cuadragesima", 40 },
            { @"cuadragésimo", 40 },
            { @"cuadragésima", 40 },
            { @"quincuagesimo", 50 },
            { @"quincuagesima", 50 },
            { @"quincuagésimo", 50 },
            { @"quincuagésima", 50 },
            { @"sexagesimo", 60 },
            { @"sexagesima", 60 },
            { @"sexagésimo", 60 },
            { @"sexagésima", 60 },
            { @"septuagesimo", 70 },
            { @"septuagesima", 70 },
            { @"septuagésimo", 70 },
            { @"septuagésima", 70 },
            { @"octogesimo", 80 },
            { @"octogesima", 80 },
            { @"octogésimo", 80 },
            { @"octogésima", 80 },
            { @"nonagesimo", 90 },
            { @"nonagesima", 90 },
            { @"nonagésimo", 90 },
            { @"nonagésima", 90 },
            { @"centesimo", 100 },
            { @"centesima", 100 },
            { @"centésimo", 100 },
            { @"centésima", 100 },
            { @"ducentesimo", 200 },
            { @"ducentesima", 200 },
            { @"ducentésimo", 200 },
            { @"ducentésima", 200 },
            { @"tricentesimo", 300 },
            { @"tricentesima", 300 },
            { @"tricentésimo", 300 },
            { @"tricentésima", 300 },
            { @"cuadringentesimo", 400 },
            { @"cuadringentesima", 400 },
            { @"cuadringentésimo", 400 },
            { @"cuadringentésima", 400 },
            { @"quingentesimo", 500 },
            { @"quingentesima", 500 },
            { @"quingentésimo", 500 },
            { @"quingentésima", 500 },
            { @"sexcentesimo", 600 },
            { @"sexcentesima", 600 },
            { @"sexcentésimo", 600 },
            { @"sexcentésima", 600 },
            { @"septingentesimo", 700 },
            { @"septingentesima", 700 },
            { @"septingentésimo", 700 },
            { @"septingentésima", 700 },
            { @"octingentesimo", 800 },
            { @"octingentesima", 800 },
            { @"octingentésimo", 800 },
            { @"octingentésima", 800 },
            { @"noningentesimo", 900 },
            { @"noningentesima", 900 },
            { @"noningentésimo", 900 },
            { @"noningentésima", 900 },
            { @"milesimo", 1000 },
            { @"milesima", 1000 },
            { @"milésimo", 1000 },
            { @"milésima", 1000 },
            { @"millonesimo", 1000000 },
            { @"millonesima", 1000000 },
            { @"millonésimo", 1000000 },
            { @"millonésima", 1000000 },
            { @"billonesimo", 1000000000000 },
            { @"billonesima", 1000000000000 },
            { @"billonésimo", 1000000000000 },
            { @"billonésima", 1000000000000 }
        };
      public static readonly Dictionary<string, long> PrefixCardinalMap = new Dictionary<string, long>
        {
            { @"dos", 2 },
            { @"tres", 3 },
            { @"cuatro", 4 },
            { @"cinco", 5 },
            { @"seis", 6 },
            { @"siete", 7 },
            { @"ocho", 8 },
            { @"nueve", 9 },
            { @"diez", 10 },
            { @"once", 11 },
            { @"doce", 12 },
            { @"trece", 13 },
            { @"catorce", 14 },
            { @"quince", 15 },
            { @"dieciseis", 16 },
            { @"dieciséis", 16 },
            { @"diecisiete", 17 },
            { @"dieciocho", 18 },
            { @"diecinueve", 19 },
            { @"veinte", 20 },
            { @"ventiuna", 21 },
            { @"veintiun", 21 },
            { @"veintiún", 21 },
            { @"veintidos", 22 },
            { @"veintitres", 23 },
            { @"veinticuatro", 24 },
            { @"veinticinco", 25 },
            { @"veintiseis", 26 },
            { @"veintisiete", 27 },
            { @"veintiocho", 28 },
            { @"veintinueve", 29 },
            { @"treinta", 30 },
            { @"cuarenta", 40 },
            { @"cincuenta", 50 },
            { @"sesenta", 60 },
            { @"setenta", 70 },
            { @"ochenta", 80 },
            { @"noventa", 90 },
            { @"cien", 100 },
            { @"doscientos", 200 },
            { @"trescientos", 300 },
            { @"cuatrocientos", 400 },
            { @"quinientos", 500 },
            { @"seiscientos", 600 },
            { @"setecientos", 700 },
            { @"ochocientos", 800 },
            { @"novecientos", 900 }
        };
      public static readonly Dictionary<string, long> SuffixOrdinalMap = new Dictionary<string, long>
        {
            { @"milesimo", 1000 },
            { @"millonesimo", 1000000 },
            { @"billonesimo", 1000000000000 }
        };
      public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
        {
            { @"mil", 1000 },
            { @"milesimo", 1000 },
            { @"millon", 1000000 },
            { @"millón", 1000000 },
            { @"millones", 1000000 },
            { @"millonesimo", 1000000 },
            { @"billon", 1000000000000 },
            { @"billón", 1000000000000 },
            { @"billones", 1000000000000 },
            { @"billonesimo", 1000000000000 },
            { @"trillon", 1000000000000000000 },
            { @"trillón", 1000000000000000000 },
            { @"trillones", 1000000000000000000 },
            { @"trillonesimo", 1000000000000000000 },
            { @"docena", 12 },
            { @"docenas", 12 },
            { @"k", 1000 },
            { @"m", 1000000 },
            { @"g", 1000000000 },
            { @"b", 1000000000 },
            { @"t", 1000000000000 }
        };
      public static readonly Dictionary<string, string> AmbiguityFiltersDict = new Dictionary<string, string>
        {
            { @"^[.]", @"" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceOffsetMap = new Dictionary<string, string>
        {
            { @"", @"" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceRelativeToMap = new Dictionary<string, string>
        {
            { @"", @"" }
        };
    }
}