//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Arabic\Arabic-Numbers.yaml
//     - Language: Arabic
//     - ClassName: NumbersDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Arabic
{
    using System;
    using System.Collections.Generic;

    public static class NumbersDefinitions
    {
      public const string LangMarker = @"Ara";
      public const bool CompoundNumberLanguage = false;
      public const bool MultiDecimalSeparatorCulture = true;
      public const string RoundNumberIntegerRegex = @"(?:مائتان|مائة|مائة|مائتين|ثلاثمائه|أربعة مئة|خمسمائة|ستمائة|سبعمائة|ثمان مائة|تسعمائة|تريليون|ترليون|آلاف|تريليونين|تريليونات|مليار|ملياري|مليارات|مليون|مليونان|ملايين|ملايين|ألف|مليونين|ألفين|مئة|الف|ومائتين|الفين|بألفين|مئتان|الآف)";
      public const string ZeroToNineIntegerRegex = @"(وخمسة|بإثنان|وواحد|واحد|وأربعة|واثنان|اثنان|وثلاثة|ثلاثة|واربعة|أربعة|خمسة|وستة|ستة|وسبعة|سبعة|وثمانية|ثمانية|ثمانٍ|وتسعة|تسع|أحد|اثني|ثلاث|صفر|سبع|(?<!درَ)ست|اربع|السادس|الثامنة|تسعة|اثنين|واحدُ|وإثنين|وواحدُ|الواحد:?)";
      public const string TwoToNineIntegerRegex = @"(?:ثلاث|ثلاثة|سبعة|ثمان|ثمانية|أربع|أربعة|خمسة|تسعة|اثنان|اثنتان|اثنين|اثتنين|اثنتان|ست|ستة)";
      public const string NegativeNumberTermsRegex = @"(?<negTerm>(سالب|ناقص)(\s+)?)";
      public static readonly string NegativeNumberSignRegex = $@"^{NegativeNumberTermsRegex}.*";
      public const string AnIntRegex = @"(واحد|أحد)(?=\s)";
      public const string TenToNineteenIntegerRegex = @"(?:((ثلاث|ثلاثة|سبعة|ثمان|ثمانية|اثنا|أربع|أربعة|خمسة|تسعة|اثنان|اثنان|اثنين|اثتنين|اثنتان|ستة|أحد|أربعة|إحدى|اثني)\s(عشر|عشرة)))";
      public const string TensNumberIntegerRegex = @"(و\s*)?(عشرة|عشرون|ثلاثون|أربعون|خمسون|ستون|سبعون|ثمانون|تسعين|وعشرين|وثلاثين|وأربعين|وخمسين|وستين|سبعين|ثمانين|تسعين|عشرون|ثلاثون|أربعون|خمسون|ستون|سبعون|ثمانون|تسعون|عشرين|ثلاثين|أربعين|خمسين|ستين|سبعين|ثمانين|تسعون|العشرون:?)";
      public static readonly string SeparaIntRegex = $@"(?:((({RoundNumberIntegerRegex}\s{RoundNumberIntegerRegex})|{TenToNineteenIntegerRegex}|({ZeroToNineIntegerRegex}(((و)?)\s+(و)?|\s*-\s*){TensNumberIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{RoundNumberIntegerRegex})(\s+{RoundNumberIntegerRegex})*))|(((\s+{RoundNumberIntegerRegex})+))";
      public static readonly string AllIntRegex = $@"(?:({SeparaIntRegex})((\s+(و)?)({SeparaIntRegex})(\s+{RoundNumberIntegerRegex})?)*|((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\s+(و)?|\s*-\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex})?(\s+{RoundNumberIntegerRegex})+)\s+(و)?)*{SeparaIntRegex})";
      public const string PlaceHolderPureNumber = @"\b";
      public const string PlaceHolderDefault = @"\D|\b";
      public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)([-]\s*)?)|(?<=\b))\d+(?!([\.،,]\d+[\u0621-\u064A]))(?={placeholder})";
      public static readonly string NumbersWithSuffix = $@"(((?<!\d+\s*)([-]\s*)?)|(?<=\b))\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)(\d+\s*({RoundNumberIntegerRegex})(\s|و\s|\sو))?\d+(\s|و\s|\sو)+{RoundNumberIntegerRegex}((\s*و\s*)+\d+)?(?=\b)";
      public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)([-]\s*)?)|(?<=\b))(\d+\s+)?(دستة|دستات|دست|دزينة|دزينات|دزينتين)(?=\b)";
      public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
      public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((نصف\s+)(دزينة|دستة|دستات|دست|دزينات|دزينتين))|({AllIntRegex}(و)?\s+((و)?))(دزينة|دستة|دستات|دست|دزينات|دزينتين))(?=\b)";
      public static readonly string RoundNumberOrdinalRegex = $@"(?:((من|على)\s+)({RoundNumberIntegerRegex}))";
      public const string NumberOrdinalRegex = @"(اخماس|ثلثان|واحد جزء من|أجزاء من|المئتيان|مائتي|الحاديه عشر|سابعًا|خامسا|ثانيا|أول|الأول|الثاني|الثالث|الرابع|الخامس|السابع|الثامن|التاسع|الأولى|الثانية|الثالثة|الرابعة|الخامسة|السادسة|السابعة|التاسعة|السادس عشر|السابعة عشرة|السادسة عشرة|الثالثة عشرة|الحادية عشرة|السابع عشر|سادس عشر|الخامس عشر|الحادية عَشْرةَ|الثانيَ عَشَر|الثانيةَ عَشْرةَ|الثالثَ عَشَرَ|الثالثةَ عَشْرةَ|الرابعَ عَشَرَ|الرابعةَ عَشْرةَ|الخامِسَ عَشَرَ|الخامسةَ عَشْرةَ|السادِسَ عَشَرَ|السادسةَ عَشْرةَ|السابعَ عَشَرَ|السابعةَ عَشْرةَ|الثامنَ عَشَرَ|الثامنةَ عَشْرةَ|التاسعَ عَشَرَ|التاسعةَ عَشْرةَ|الحادِيَ عَشَرَ|الحادي عشر|الثاني عشر|الثالث عشر|الرابع عشر|الثامن عشر|التاسع عشر|الثانية عشرة|الرابعة عشرة|الخامسة عشرة|الثامنة عشرة|التاسعة عشرة|العاشر|العاشرة|عشرون|العشرين|الثلاثين|الثلاثون|الرابعة والأربعون|الرابع والأربعون|خمسون|الخمسون|الستين|ستون|والستين|سبعون|السبعون|والسبعون|ثامن عشر|الثامن عشر|الرابع والأربعين|الثامنة والثمانون|الثامن|والثمانين|وثلثان|ثمن|أثمان|التاسع والتسعون|التاسعة والتسعون|اثمان|خمس|أخماس|وثلاثون|ثلثان|الأخماس|اخماس|ثلثان|واحد جزء من|العشرون|التريليون|الواحد والعشرون|الخامسة والعشرون:?)";
      public const string RelativeOrdinalRegex = @"(?<relativeOrdinal>(الواحد\s)?((السابق|السابقة|الثانية الى|((الذي)\s*(قبل|قبلا)\s*)?(الأخير)|قبل|بعد|سبق|سبقت|التالي|الحالي|الذي|اخر)(\s))?((تالي|الحالي|السابقة|سابق|قادم|التالي|((الذي)\s*(قبل|قبلا)\s*)?(الأخير)|آخر|أخير|حالي|اخر|الاخير|الأولى)(ة)?)|(الاخر|الاول|الأول|اول|الأولى|((الذي)\s*(قبل|قبلا)\s*)?(الأخير)|السابق|التالي|أخر))";
      public static readonly string BasicOrdinalRegex = $@"({NumberOrdinalRegex}|{RelativeOrdinalRegex})";
      public static readonly string SuffixBasicOrdinalRegex = $@"(?:(((({TensNumberIntegerRegex}(\s+(و)?|\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|({RoundNumberIntegerRegex}|المئة(\s+(و)?)))((\s+{RoundNumberIntegerRegex}|المئة)+|({BasicOrdinalRegex})))\s+(و)?)*({TensNumberIntegerRegex}(\s+|\s*))?{BasicOrdinalRegex}|({TensNumberIntegerRegex}))";
      public static readonly string SuffixRoundNumberOrdinalRegex = $@"(?:({AllIntRegex}\s+){RoundNumberOrdinalRegex})";
      public static readonly string AllOrdinalRegex = $@"(?:{SuffixBasicOrdinalRegex}|{SuffixRoundNumberOrdinalRegex})";
      public const string OrdinalNumericRegex = @"(?<=\b)(?:\d{1,3}(\s*,\s*\d{3})*\s*th)(?=\b)";
      public static readonly string OrdinalRoundNumberRegex = $@"({RoundNumberOrdinalRegex})";
      public static readonly string OrdinalEnglishRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
      public const string FractionNotationWithSpacesRegex = @"(((?<={?[\u0600-\u06ff]}|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
      public const string FractionNotationWithSpacesRegex2 = @"(((?<={?[\u0600-\u06ff]}|^)-\s*)|(?<![/-])(?<=\b))\d+[/]\d+(?=(\b[^/]|$))(\s*\d+)";
      public const string FractionNotationRegex = @"(((?<={?[\u0600-\u06ff]}|^)-\s*)|(?<![/-])(?<=\b))\d+[/]\d+(?=(\b[^/]|$))";
      public const string ArabicBuiltInFraction = @"(ثلثان|ربع|خمس|عشرونات|ثلاثون|خُمسَين:?)";
      public const string FractionOrdinalPrefix = @"(الوزن|المحتوى:?)";
      public static readonly string FractionNounRegex = $@"(?<=\b){ArabicBuiltInFraction}|{AllIntRegex}\s(و\s|و){ArabicBuiltInFraction}|(({AllIntRegex}\s(و\s|و)?)?({AllIntRegex})(\s+|\s*)(({AllOrdinalRegex})|({RoundNumberOrdinalRegex})|أرباع|وربع|ارباع|واحد وربع|نصف|ربع|أنصاف|ربعين|أرباع|ارباع))(?=\b)";
      public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)((({AllIntRegex}(\s|(\s*-\s*)|و\s+)?)(({AllOrdinalRegex})|{NumberOrdinalRegex}|نصف|وربع|ربع|ونصف))|(الربع|النصف|نصف|))(?=\b)";
      public static readonly string FractionPrepositionRegex = $@"(?<!{BaseNumbers.CommonCurrencySymbol}\s*)(?<=\b)(?<numerator>({AllIntRegex})|((?<![\.,])\d+))\s+(فوق|على|في|جزء|من|أجزاء من|اجزاء من|جزء من)\s+(?<denominator>({AllIntRegex})|(\d+)(?![\.,]))(?=\b)";
      public static readonly string FractionPrepositionWithinPercentModeRegex = $@"(?<!{BaseNumbers.CommonCurrencySymbol}\s*)(?<=\b)(?<numerator>({AllIntRegex})|((?<![\.,])\d+))\s+على\s+(?<denominator>({AllIntRegex})|(\d+)(?![\.,]))(?=\b)";
      public static readonly string FractionWithOrdinalPrefix = $@"({AllOrdinalRegex})(?=\s*({FractionOrdinalPrefix}))";
      public static readonly string FractionWithPartOfPrefix = $@"((جزء من)\s+)({AllIntRegexWithLocks})";
      public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
      public static readonly string AllFloatRegex = $@"{AllIntRegex}(\s+(نقطة|جزء|جزء من)){AllPointRegex}";
      public static readonly string DoubleWithMultiplierRegex = $@"(((?<!\d+\s*)([-]\s*)?)|((?<=\b)(?<!\d+[\.,])))\d+[\.,]\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
      public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)([-]\s*)?)|((?<=\b)(?<!\d+[\.,])))(\d+([\.,]\d+)?)e([+-]*[\u0660-\u0669]\d*)(?=\b)";
      public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)([-]\s*)?)|((?<=\b)(?<!\d+[\.,])))(\d+([\.,]\d+)?)[+-]*\^[+-]*((\d+([\.,]))?\d+)(?=\b)";
      public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)([-]\s*)?)|((?<=\b)(?<!\d+[\.,])))((?<!\d.)(\d+[\.,]\d+))(?!([\.,]\d+))(?={placeholder})";
      public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+))[\.,]\d+(?!([\.,]\d+))(?={placeholder})";
      public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)([-]\s*)?)|((?<=\b)(?<!\d+[\.,])))\d+[\.,]\d+\s+{RoundNumberIntegerRegex}(?=\b)";
      public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
      public const string ConnectorRegex = @"(?<spacer>و)";
      public static readonly string NumberWithSuffixPercentage = $@"((?<!(٪|%))({BaseNumbers.NumberReplaceToken})(\s*)((٪|%)(?!{BaseNumbers.NumberReplaceToken})|(بالمائة|في المئة|بالمئة)))";
      public static readonly string FractionNumberWithSuffixPercentage = $@"(({BaseNumbers.FractionNumberReplaceToken})\s+(من|في المئة))";
      public static readonly string NumberWithPrefixPercentage = $@"(نسبة|بالمائة)(\s*)({BaseNumbers.NumberReplaceToken})";
      public static readonly string NumberWithPrepositionPercentage = $@"({BaseNumbers.NumberReplaceToken})\s*(في|خارج\s+من)\s*({BaseNumbers.NumberReplaceToken})";
      public const string TillRegex = @"(الى|إلى|خلال|--|-|—|——|~|–)";
      public const string MoreRegex = @"(?:(اكثر|فوق|أكبر|أعظم|أطول|يتجاوز|تفوق|أعلى|أكثر)|(?<!<|=)>)";
      public const string LessRegex = @"(?:(أقل|اقل|اصغر|أصغر|أخفض|ادنى)(\s*من)?|تحت|(?<!>|=)<)";
      public const string EqualRegex = @"(يساوي|(?<!<|>)=)";
      public static readonly string MoreOrEqualPrefix = $@"(((ليس|لا)\s+{LessRegex})|(على\s+الأقل))";
      public static readonly string MoreOrEqual = $@"(?:(({MoreRegex}(\s+من)?)\s+(أو|او)?\s+{EqualRegex})|(({MoreOrEqualPrefix}|(تفوق))(\s+(أو|او)?\s+{EqualRegex})?)|(({EqualRegex}\s+(أو|او)?\s+)?({MoreOrEqualPrefix}|تفوق))|>\s*=)";
      public const string MoreOrEqualSuffix = @"((أو|او)\s+(((أكبر|أعظم|أطول|فوق|اكثر|اكثر|اكبر|أكثر)((?!\s+من)|(\s+من(?!(\s*\d+)))))|((فوق|أكبر|أطول|اكثر)(?!\s+من))))";
      public static readonly string LessOrEqualPrefix = $@"((ليس\s+{MoreRegex})|(at\s+most)|(بحد أقصى)|(يصل الى))";
      public static readonly string LessOrEqual = $@"(((لا\s*)?{LessRegex}\s+(أو|او)?\s+{EqualRegex})|({EqualRegex}\s+(أو|او)?\s+(((أقل|اقل|أدنى|اصغر|أصغر|ادنى)(\s+من))|تحت|(?<!>|=)<))|({LessOrEqualPrefix}(\s+(أو|او)?\s+{EqualRegex})?)|(({EqualRegex}\s+(أو|او)?\s+)?{LessOrEqualPrefix})|<\s*=)";
      public const string LessOrEqualSuffix = @"((أ|ا)?و\s+(أقل)((?!\s+من)|(\s+من(?!(\s*\d+)))))";
      public const string NumberSplitMark = @"(?![.،](?!\d+))";
      public const string MoreRegexNoNumberSucceed = @"((أكبر|أعظم|أطول|فوق|اكثر)((?!\s+من)|\s+(من(?!(\s*\d+))))|(فوق|أكبر|أعظم)(?!(\s*\d+)))";
      public const string LessRegexNoNumberSucceed = @"((أقل|أصغر)((?!\s+من)|\s+(من(?!(\s*\d+))))|(تحت|اقل|أقل|أصغر)(?!((\s*\d+)|\s*من)))";
      public const string EqualRegexNoNumberSucceed = @"((يساوي)(?!(\s*\d+)))";
      public static readonly string OneNumberRangeMoreRegex1 = $@"({MoreOrEqual})\s*(ال)?(?<number1>({NumberSplitMark}.)+)|({EqualRegex}\s*(أو|او)?\s+({MoreRegex}))(\s+(من))\s*(?<number1>({NumberSplitMark}.)+)|({EqualRegex}\s+(أو|او)?\s+({MoreRegex}))\s*(?<number1>({NumberSplitMark}.)+)|({MoreRegex})(\s+(من))\s*(?<number1>({NumberSplitMark}.)+)|({MoreRegex})\s*(?<number1>({NumberSplitMark}.)+)";
      public static readonly string OneNumberRangeMoreRegex3 = $@"(?<number1>({NumberSplitMark}.)+)\s*(و|أو)\s*({MoreRegex})";
      public static readonly string OneNumberRangeMoreRegex2 = $@"(?<number1>({NumberSplitMark}.)+)\s*{MoreOrEqualSuffix}";
      public static readonly string OneNumberRangeMoreSeparateRegex = $@"({MoreRegex}\s*(من)\s+(?<number1>({NumberSplitMark}.)+)\s+(أو|او)\s+{EqualRegexNoNumberSucceed})|({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+(أو|او)\s+){MoreRegexNoNumberSucceed})|({MoreRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+(أو|او)\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeLessRegex1 = $@"(({LessOrEqual})\s*(ال)?(?<number2>({NumberSplitMark}.)+))|(لا\s*)?((((أقل|اقل|أدنى|اصغر|أصغر|ادنى)(\s+من))|تحت|(?<!>|=)<))\s*(ال)?(?<number2>({NumberSplitMark}.)+)|(لا\s*)?(({LessRegex})\s*(ال)?(?<number2>({NumberSplitMark}.)+))";
      public static readonly string OneNumberRangeLessRegex2 = $@"(?<number2>({NumberSplitMark}.)+)\s*{LessOrEqualSuffix}";
      public static readonly string OneNumberRangeLessSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)\s*(أو|او)\s+{LessRegexNoNumberSucceed})|(((((أقل|اقل|أدنى|اصغر|أصغر|ادنى)(\s+من))|تحت|(?<!>|=)<))\s+(?<number1>({NumberSplitMark}.)+)(\s+(أو|او)\s+){EqualRegexNoNumberSucceed})";
      public static readonly string OneNumberRangeEqualRegex = $@"{EqualRegex}\s*(ال)?(?<number1>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex1 = $@"بين\s*(ال)?(?<number1>({NumberSplitMark}.)+)\s*و\s*(ال)?(?<number2>({NumberSplitMark}.)+)";
      public static readonly string TwoNumberRangeRegex2 = $@"({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})\s*(،)?\s*((أ|ا)?و|لكن|,)\s*({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})";
      public static readonly string TwoNumberRangeRegex3 = $@"({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})\s*(،)?\s*((أ|ا)?و|لكن|,)\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})";
      public static readonly string TwoNumberRangeRegex4 = $@"((من\s)(?<number1>({NumberSplitMark}(?!\bمن\b).)+)\s*{TillRegex}\s*(ال\s+)?(?<number2>({NumberSplitMark}.)+))|((من\s)?(?<number1>({NumberSplitMark}(?!\bمن\b).)+)\s*{TillRegex}\s*(ال\s+)?(?<number2>({NumberSplitMark}.)+))";
      public const string AmbiguousFractionConnectorsRegex = @"(\bمن|بين|من|بين\b)";
      public const char DecimalSeparatorChar = ',';
      public const string FractionMarkerToken = @"أكثر";
      public const char NonDecimalSeparatorChar = '،';
      public const string HalfADozenText = @"ستة";
      public const string WordSeparatorToken = @"و";
      public static readonly string[] WrittenDecimalSeparatorTexts = { @"نقطة | فاصلة" };
      public static readonly string[] WrittenGroupSeparatorTexts = { @"punto" };
      public static readonly string[] WrittenIntegerSeparatorTexts = { @"و" };
      public static readonly string[] WrittenFractionSeparatorTexts = { @"و" };
      public const string HalfADozenRegex = @"نصف?\sدستة";
      public static readonly string DigitalNumberRegex = $@"((?<=\b)(مائة|مائتان|دست|دستات|ألف|ألفين|مائتين|ألفين|ثلاثمائة|أربعمائة|خمسمائة|ستمائة|سبعمائة|تسعمائة|ثمانمائة|مليون|مليار|ترليون)(?=\b))|((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
      public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
        {
            { @"واحد", 1 },
            { @"صفر", 0 },
            { @"اثنان", 2 },
            { @"اثنين", 2 },
            { @"ثلاث", 3 },
            { @"ثلاثة", 3 },
            { @"أربعة", 4 },
            { @"خمسة", 5 },
            { @"ستة", 6 },
            { @"سبعة", 7 },
            { @"ثمانية", 8 },
            { @"تسعة", 9 },
            { @"عشرة", 10 },
            { @"إحدى عشر", 11 },
            { @"اثنى عشر", 12 },
            { @"دستة", 12 },
            { @"دستات", 12 },
            { @"ثلاثة عشر", 13 },
            { @"أربعة عشر", 14 },
            { @"خمسة عشر", 15 },
            { @"ستة عشر", 16 },
            { @"سبعة عشر", 17 },
            { @"ثمانية عشر", 18 },
            { @"تسعة عشر", 19 },
            { @"عشرون", 20 },
            { @"ثلاثون", 30 },
            { @"وثلاثون", 30 },
            { @"أربعون", 40 },
            { @"خمسون", 50 },
            { @"ستون", 60 },
            { @"سبعون", 70 },
            { @"ثمانون", 80 },
            { @"تسعون", 90 },
            { @"مائة", 100 },
            { @"مائتين", 200 },
            { @"مائتان", 200 },
            { @"ثلاثمائة", 300 },
            { @"أربعمائة", 400 },
            { @"خمسمائة", 500 },
            { @"ستمائة", 600 },
            { @"سبعمائة", 700 },
            { @"ثمانمائة", 800 },
            { @"تسعمائة", 900 },
            { @"ألف", 1000 },
            { @"آلاف", 1000 },
            { @"ألفين", 2000 },
            { @"المليون", 1000000 },
            { @"مليون", 1000000 },
            { @"مليار", 1000000000 },
            { @"المليار", 1000000000 },
            { @"تريليون", 1000000000000 },
            { @"التريليون", 1000000000000 },
            { @"الواحد", 1 },
            { @"الصفر", 0 },
            { @"الاثنان", 2 },
            { @"الاثنين", 2 },
            { @"الثلاثة", 3 },
            { @"الأربعة", 4 },
            { @"الخمسة", 5 },
            { @"الستة", 6 },
            { @"السبعة", 7 },
            { @"الثمانية", 8 },
            { @"التسعة", 9 },
            { @"العشرة", 10 },
            { @"الإحدى عشر", 11 },
            { @"الاثنى عشر", 12 },
            { @"الدستة", 12 },
            { @"الدستات", 12 },
            { @"الثلاثة عشر", 13 },
            { @"الأربعة عشر", 14 },
            { @"الخمسة عشر", 15 },
            { @"الستة عشر", 16 },
            { @"السبعة عشر", 17 },
            { @"الثمانية عشر", 18 },
            { @"التسعة عشر", 19 },
            { @"العشرون", 20 },
            { @"الثلاثون", 30 },
            { @"الأربعون", 40 },
            { @"الخمسون", 50 },
            { @"الستون", 60 },
            { @"السبعون", 70 },
            { @"الثمانون", 80 },
            { @"التسعون", 90 },
            { @"المائة", 100 },
            { @"المائتين", 200 },
            { @"المائتان", 200 },
            { @"الثلاثمائة", 300 },
            { @"الأربعمائة", 400 },
            { @"الخمسمائة", 500 },
            { @"الستمائة", 600 },
            { @"السبعمائة", 700 },
            { @"الثمانمائة", 800 },
            { @"التسعمائة", 900 },
            { @"الألف", 1000 },
            { @"الآلاف", 1000 },
            { @"الألفين", 2000 }
        };
      public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
        {
            { @"أول", 1 },
            { @"أولى", 1 },
            { @"الأول", 1 },
            { @"الأولى", 1 },
            { @"ثاني", 2 },
            { @"ثانية", 2 },
            { @"الثاني", 2 },
            { @"الثانية", 2 },
            { @"ثان", 2 },
            { @"النصف", 2 },
            { @"نصف", 2 },
            { @"ثلث", 3 },
            { @"الثالث", 3 },
            { @"الثالثة", 3 },
            { @"ثالث", 3 },
            { @"ثالثة", 3 },
            { @"الربع", 4 },
            { @"ربع", 4 },
            { @"الرابع", 4 },
            { @"الرابعة", 4 },
            { @"رابع", 4 },
            { @"رابعة", 4 },
            { @"خمس", 5 },
            { @"الخامس", 5 },
            { @"الخامسة", 5 },
            { @"خامس", 5 },
            { @"خامسة", 5 },
            { @"سدس", 6 },
            { @"السادس", 6 },
            { @"السادسة", 6 },
            { @"سادس", 6 },
            { @"سادسة", 6 },
            { @"سبع", 7 },
            { @"السابع", 7 },
            { @"السابعة", 7 },
            { @"سابع", 7 },
            { @"سابعة", 7 },
            { @"ثمن", 8 },
            { @"الثامن", 8 },
            { @"الثامنة", 8 },
            { @"ثامن", 8 },
            { @"ثامنة", 8 },
            { @"تسع", 9 },
            { @"التاسع", 9 },
            { @"التاسعة", 10 },
            { @"تاسع", 9 },
            { @"تاسعة", 9 },
            { @"واحد من عشرة", 10 },
            { @"واحد من إحدى عشر", 11 },
            { @"الحادية عشرة", 11 },
            { @"الحادي عشر", 11 },
            { @"إحدى عشرة", 11 },
            { @"واحد من إثنى عشر", 12 },
            { @"الثانية عشرة", 12 },
            { @"اثنا عشر", 12 },
            { @"واحد من ثلاثة عشر", 13 },
            { @"الثالثة عشرة", 13 },
            { @"واحد من أربعة عشر", 14 },
            { @"الرابعة عشرة", 14 },
            { @"واحد من خمسة عشر", 15 },
            { @"الخامسة عشرة", 15 },
            { @"واحد من ستة عشر", 16 },
            { @"السادسة عشرة", 16 },
            { @"واحد من سبعة عشر", 17 },
            { @"السابعة عشرة", 17 },
            { @"واحد من ثمانية عشر", 18 },
            { @"الثامنة عشرة", 18 },
            { @"واحد من تسعة عشر", 19 },
            { @"واحد من عشرين", 20 },
            { @"العشرون", 20 },
            { @"العشرين", 20 },
            { @"واحد من ثلاثين", 30 },
            { @"الثلاثون", 30 },
            { @"الثلاثين", 30 },
            { @"واحد من أربعين", 40 },
            { @"الأربعون", 40 },
            { @"الأربعين", 40 },
            { @"واحد من خمسين", 50 },
            { @"الخمسون", 50 },
            { @"الخمسين", 50 },
            { @"واحد من ستين", 60 },
            { @"الستون", 60 },
            { @"الستين", 60 },
            { @"واحد من سبعين", 70 },
            { @"السبعون", 70 },
            { @"السبعين", 70 },
            { @"واحد من ثمانين", 80 },
            { @"الثمانون", 80 },
            { @"الثمانين", 80 },
            { @"واحد من تسعين", 90 },
            { @"التسعون", 90 },
            { @"التسعين", 90 },
            { @"واحد من مائة", 100 },
            { @"المائة", 100 },
            { @"المائتان", 200 },
            { @"المائتين", 200 },
            { @"الثلاثمائة", 300 },
            { @"الأربعمائة", 400 },
            { @"الخمسمائة", 500 },
            { @"الستمائة", 600 },
            { @"السبعمائة", 700 },
            { @"الثمانمائة", 800 },
            { @"التسعمائة", 100 },
            { @"الألف", 1000 },
            { @"واحد من ألف", 1000 },
            { @"واحد من مليون", 1000000 },
            { @"المليون", 1000000 },
            { @"واحد من مليار", 1000000000 },
            { @"المليار", 1000000000 },
            { @"واحد من تريليون", 1000000000000 },
            { @"التريليون", 1000000000000 },
            { @"أوائل", 1 },
            { @"أنصاف", 2 },
            { @"أثلاث", 3 },
            { @"أرباع", 4 },
            { @"أخماس", 5 },
            { @"أسداس", 6 },
            { @"أسباع", 7 },
            { @"أثمان", 8 },
            { @"أتساع", 9 },
            { @"أعشار", 10 },
            { @"عشرينات", 20 },
            { @"ثلاثينات", 30 },
            { @"أربعينات", 40 },
            { @"خمسينات", 50 },
            { @"ستينات", 60 },
            { @"سبعينات", 70 },
            { @"ثمانينات", 80 },
            { @"تسعينات", 90 },
            { @"مئات", 100 },
            { @"ألوف", 1000 },
            { @"ملايين", 1000000 },
            { @"مليارات", 1000000000 },
            { @"تريليون", 1000000000000 }
        };
      public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
        {
            { @"ترليون", 1000000000000 },
            { @"مائة", 100 },
            { @"ألف", 1000 },
            { @"مليون", 1000000 },
            { @"مليار", 1000000000 },
            { @"تريليون", 1000000000000 },
            { @"مائتين", 200 },
            { @"مائتان", 200 },
            { @"ثلاثمائة", 300 },
            { @"أربعمائة", 400 },
            { @"خمسمائة", 500 },
            { @"ستمائة", 600 },
            { @"سبعمائة", 700 },
            { @"ثمانمائة", 800 },
            { @"تسعمائة", 900 },
            { @"ألفين", 2000 },
            { @"دستة", 12 },
            { @"دستات", 12 },
            { @"المائة", 100 },
            { @"الألف", 1000 },
            { @"المليون", 1000000 },
            { @"المليار", 1000000000 },
            { @"التريليون", 1000000000000 },
            { @"المائتين", 200 },
            { @"المائتان", 200 },
            { @"الثلاثمائة", 300 },
            { @"الأربعمائة", 400 },
            { @"الخمسمائة", 500 },
            { @"الستمائة", 600 },
            { @"السبعمائة", 700 },
            { @"الثمانمائة", 800 },
            { @"التسعمائة", 900 },
            { @"الألفين", 2000 },
            { @"الدستة", 12 },
            { @"الدستات", 12 }
        };
      public static readonly Dictionary<string, string> AmbiguityFiltersDict = new Dictionary<string, string>
        {
            { @"\bواحد\b", @"\b(الذي|هذا|ذلك|ذاك|أي)\s+(واحد)\b" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceOffsetMap = new Dictionary<string, string>
        {
            { @"الاخر", @"0" },
            { @"آخر", @"0" },
            { @"اخر", @"0" },
            { @"الأخيرة", @"0" },
            { @"الأخير", @"0" },
            { @"سبقت الأخيرة", @"-1" },
            { @"سبقت الأخير", @"-1" },
            { @"قبل الأخير", @"-1" },
            { @"قبل الأخيرة", @"-1" },
            { @"القبل الأخير", @"-1" },
            { @"قبلا الأخي", @"-1" },
            { @"التالي", @"1" },
            { @"قادم", @"1" },
            { @"قادمة", @"1" },
            { @"القادم", @"1" },
            { @"القادمة", @"1" },
            { @"السابقة", @"-1" },
            { @"الحالي", @"0" },
            { @"الحالية", @"0" },
            { @"قبل الاخير", @"-1" },
            { @"الواحد قبل الاخير", @"-1" },
            { @"الثانية الى الاخير", @"-1" },
            { @"الذي قبلا الأخير", @"-1" },
            { @"الذي قبل الأخير", @"-1" },
            { @"الذي قبلا الأخي", @"-1" },
            { @"السابق", @"-1" },
            { @"أخر", @"0" },
            { @"الاخير", @"0" },
            { @"اول", @"1" },
            { @"الاول", @"1" },
            { @"التالية", @"-1" }
        };
      public static readonly Dictionary<string, string> RelativeReferenceRelativeToMap = new Dictionary<string, string>
        {
            { @"اول", @"current" },
            { @"التالية", @"current" },
            { @"الاول", @"current" },
            { @"الاخر", @"end" },
            { @"الاخير", @"end" },
            { @"أخر", @"end" },
            { @"آخر", @"end" },
            { @"اخر", @"end" },
            { @"الأخيرة", @"end" },
            { @"الأخير", @"end" },
            { @"سبقت الأخيرة", @"current" },
            { @"سبقت الأخير", @"current" },
            { @"قبل الأخير", @"end" },
            { @"قبل الأخيرة", @"current" },
            { @"القبل الأخير", @"current" },
            { @"الذي قبلا الأخي", @"end" },
            { @"التالي", @"current" },
            { @"قادم", @"current" },
            { @"قادمة", @"current" },
            { @"القادم", @"current" },
            { @"القادمة", @"current" },
            { @"السابقة", @"current" },
            { @"الحالي", @"current" },
            { @"قبلا الأخي", @"current" },
            { @"الحالية", @"end" },
            { @"قبل الاخير", @"end" },
            { @"الواحد قبل الاخير", @"end" },
            { @"الذي قبل الأخير", @"end" },
            { @"الذي قبلا الأخير", @"end" },
            { @"الثانية الى الاخير", @"end" },
            { @"السابق", @"current" }
        };
    }
}