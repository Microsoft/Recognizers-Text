﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\Dutch\Dutch-Numbers.yaml
//     - Language: Dutch
//     - ClassName: NumbersDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.Dutch
{
	using System;
	using System.Collections.Generic;

	public static class NumbersDefinitions
	{
		public const string LangMarker = "Nl";
		public const string RoundNumberIntegerRegex = @"(honderd|duizend|miljoen|miljard|biljoen)";
		public const string ZeroToNineIntegerRegex = @"(drie|zeven|acht|vier|vijf|nul|negen|een|één|twee|zes)";
		public const string NegativeNumberTermsRegex = @"((min|negatief)\s+)";
		public static readonly string NegativeNumberSignRegex = $@"^{NegativeNumberTermsRegex}.*";
		public const string AnIntRegex = @"(een|één)(?=\s)";
		public const string TenToNineteenIntegerRegex = @"(zeventien|dertien|veertien|achttien|negentien|vijftien|zestien|elf|twaalf|tien)";
		public const string TensNumberIntegerRegex = @"(zeventig|twintig|dertig|tachtig|negentig|veertig|vijftig|zestig)";
		public static readonly string SeparaIntRegex = $@"((({TenToNineteenIntegerRegex}|({ZeroToNineIntegerRegex}(en|ën){TensNumberIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex})(\s*{RoundNumberIntegerRegex})*))|{RoundNumberIntegerRegex}|(({AnIntRegex}?(\s*{RoundNumberIntegerRegex})+))";
		public static readonly string AllIntRegex = $@"(((({TenToNineteenIntegerRegex}|({ZeroToNineIntegerRegex}(en|ën){TensNumberIntegerRegex})|{TensNumberIntegerRegex}|({ZeroToNineIntegerRegex}|{AnIntRegex}))?(\s*{RoundNumberIntegerRegex}))\s*(en\s*)?)*{SeparaIntRegex})";
		public const string PlaceHolderPureNumber = @"\b";
		public const string PlaceHolderDefault = @"\D|\b";
		public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+(?!(\,\d+[a-zA-Z]))(?={placeholder})";
		public const string NumbersWithSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s*(K|k|M|T|G)(?=\b)";
		public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)\d+\s*{RoundNumberIntegerRegex}(?=\b)";
		public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+dozijn(en)?(?=\b)";
		public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
		public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((een\s+)?half\s+dozijn)|({AllIntRegex}\s+dozijn(en)?))(?=\b)";
		public const string RoundNumberOrdinalRegex = @"(honderdste|duizendste|miljoenste|miljardste|biljoenste)";
		public const string BasicOrdinalRegex = @"(eerste|tweede|derde|vierde|vijfde|zesde|zevende|achtste|negende|tiende|elfde|twaalfde|dertiende|veertiende|vijftiende|zestiende|zeventiende|achttiende|negentiende|twintigste|dertigste|veertigste|vijftigste|zestigste|zeventigste|tachtigste|negentigste)";
		public static readonly string SuffixBasicOrdinalRegex = $@"((((({ZeroToNineIntegerRegex}(en|ën){TensNumberIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\s+{RoundNumberIntegerRegex})+)\s+(en\s+)?)*({TensNumberIntegerRegex}(\s+|\s*-\s*|\s*/\s*))?{BasicOrdinalRegex})";
		public static readonly string SuffixRoundNumberOrdinalRegex = $@"(({AllIntRegex}\s+){RoundNumberOrdinalRegex})";
		public static readonly string AllOrdinalRegex = $@"({SuffixBasicOrdinalRegex}|{SuffixRoundNumberOrdinalRegex})";
		public const string OrdinalSuffixRegex = @"(?<=\b)((\d*(1e|2e|3e|4e|5e|6e|7e|8e|9e|0e))|(1ste|2de|3de|4de|5de|6de|7de|8ste|9de|0de)|([0-9]*1[0-9]de)|([0-9]*[2-9][0-9]ste)|([0-9]*[0](1ste|2de|3de|4de|5de|6de|7de|8ste|9de|0de)))(?=\b)";
		public const string OrdinalNumericRegex = @"(?<=\b)(\d{1,3}(\s*.\s*\d{3})*\s*e)(?=\b)";
		public static readonly string OrdinalRoundNumberRegex = $@"(?<!(één|een)\s+){RoundNumberOrdinalRegex}";
		public static readonly string OrdinalDutchRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
		public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
		public const string FractionNotationRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+[/]\d+(?=(\b[^/]|$))";
		public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+(en\s+)?)?({AllIntRegex})(\s+|\s*-\s*|\s*/\s*)((({AllOrdinalRegex})|({RoundNumberOrdinalRegex}))n?|halven|vierdes)(?=\b)";
		public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)({AllIntRegex}\s+(en\s)?)?(een)(\s+|\s*-\s*|\s*/\s*)(({AllOrdinalRegex})|({RoundNumberOrdinalRegex})|half|halve|kwart)(?=\b)";
		public static readonly string FractionPrepositionRegex = $@"(?<=\b)(?<numerator>({AllIntRegex})|((?<!,)\d+))\s+(op|op\s+de|van\s+de|uit|uit\s+de)\s+(?<denominator>({AllIntRegex})|(\d+)(?!,))(?=\b)";
		public static readonly string FractionPrepositionWithinPercentModeRegex = $@"(?<=\b)(?<numerator>({AllIntRegex})|((?<!,)\d+))\s+over\s+(?<denominator>({AllIntRegex})|(\d+)(?!,))(?=\b)";
		public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{SeparaIntRegex}))";
		public static readonly string AllFloatRegex = $@"{AllIntRegex}(\s+komma){AllPointRegex}";
		public const string DoubleWithMultiplierRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))\d+,\d+\s*(K|k|M|G|T|B|b)(?=\b)";
		public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))(\d+(,\d+)?)e([+-]*[1-9]\d*)(?=\b)";
		public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))(\d+(,\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
		public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))\d+,\d+(?!(,\d+))(?={placeholder})";
		public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+)),\d+(?!(,\d+))(?={placeholder})";
		public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))\d+,\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
		public const string CurrencyRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*(B|b|m|t|g)(?=\b)";
		public static readonly string NumberWithSuffixPercentage = $@"({BaseNumbers.NumberReplaceToken})(\s*)(%|procent|percentage)";
		public static readonly string FractionNumberWithSuffixPercentage = $@"(({BaseNumbers.FractionNumberReplaceToken})\s+of)";
		public static readonly string NumberWithPrefixPercentage = $@"(percentage van|procent van|procenten van)(\s*)({BaseNumbers.NumberReplaceToken})";
		public static readonly string NumberWithPrepositionPercentage = $@"({BaseNumbers.NumberReplaceToken})\s*(in|out\s+of)\s*({BaseNumbers.NumberReplaceToken})";
		public const string TillRegex = @"(tot|--|-|—|——|~)";
		public const string MoreRegex = @"((groter|hoger|meer)(\s+dan|\s+als)?|boven|over|>)";
		public const string LessRegex = @"((minder|lager|kleiner)(\s+dan|\s+als)?|beneden|onder|<)";
		public const string EqualRegex = @"(gelijk(\s+(aan|als))?|=)";
		public static readonly string MoreOrEqual = $@"(({MoreRegex}\s+of\s+{EqualRegex})|minstens|niet\s+{LessRegex}|>\s*=)";
		public const string MoreOrEqualSuffix = @"(en|of)\s+(meer|groter|hoger|grotere)(?!\s+dan|?!\s+als)";
		public static readonly string LessOrEqual = $@"(({LessRegex}\s+of\s+{EqualRegex})|maximum|niet\s+{MoreRegex}|<\s*=)";
		public const string LessOrEqualSuffix = @"(en|of)\s+(minder|lager|kleiner)(?!\s+dan|?!\s+als)";
		public const string NumberSplitMark = @"(?![,.](?!\d+))";
		public const string MoreRegexNoNumberSucceed = @"((groter|hoger|meer)((?!\s+dan|?!\s+als)|\s+(dan(?!(\s*\d+))))|(boven|over)(?!(\s*\d+)))";
		public const string LessRegexNoNumberSucceed = @"((minder|lager|kleiner)((?!\s+dan|?!\s+als)|\s+(dan(?!(\s*\d+))))|(beneden|onder)(?!(\s*\d+)))";
		public const string EqualRegexNoNumberSucceed = @"(gelijk?((?!\s+(aan|tot))|(\s+(aan|tot)(?!(\s*\d+)))))";
		public static readonly string OneNumberRangeMoreRegex1 = $@"({MoreOrEqual}|{MoreRegex})\s*(de\s+)?(?<number1>((?!((\.(?!\d+))|(,(?!\d+)))).)+)";
		public static readonly string OneNumberRangeMoreRegex2 = $@"(?<number1>((?!((\.(?!\d+))|(,(?!\d+)))).)+)\s*{MoreOrEqualSuffix}";
		public static readonly string OneNumberRangeMoreSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+of\s+){MoreRegexNoNumberSucceed})|({MoreRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+of\s+){EqualRegexNoNumberSucceed})";
		public static readonly string OneNumberRangeLessRegex1 = $@"({LessOrEqual}|{LessRegex})\s*(de\s+)?(?<number2>((?!((\.(?!\d+))|(,(?!\d+)))).)+)";
		public static readonly string OneNumberRangeLessRegex2 = $@"(?<number2>((?!((\.(?!\d+))|(,(?!\d+)))).)+)\s*{LessOrEqualSuffix}";
		public static readonly string OneNumberRangeLessSeparateRegex = $@"({EqualRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+of\s+){LessRegexNoNumberSucceed})|({LessRegex}\s+(?<number1>({NumberSplitMark}.)+)(\s+of\s+){EqualRegexNoNumberSucceed})";
		public static readonly string OneNumberRangeEqualRegex = $@"{EqualRegex}\s*(the\s+)?(?<number1>((?!((\.(?!\d+))|(,(?!\d+)))).)+)";
		public static readonly string TwoNumberRangeRegex1 = $@"tussen\s*(de\s+)?(?<number1>((?!((\.(?!\d+))|(,(?!\d+)))).)+)\s*en\s*(de\s+)?(?<number2>((?!((\.(?!\d+))|(,(?!\d+)))).)+)";
		public static readonly string TwoNumberRangeRegex2 = $@"({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})\s*(en|maar|,)\s*({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})";
		public static readonly string TwoNumberRangeRegex3 = $@"({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})\s*(en|maar|,)\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})";
		public static readonly string TwoNumberRangeRegex4 = $@"(van\s+)?(?<number1>((?!((\.(?!\d+))|(,(?!\d+))|\van\b)).)+)\s*{TillRegex}\s*(de\s+)?(?<number2>((?!((\.(?!\d+))|(,(?!\d+)))).)+)";
		public const string AmbiguousFractionConnectorsRegex = @"^[.]";
		public const char DecimalSeparatorChar = ',';
		public const string FractionMarkerToken = "van de";
		public const char NonDecimalSeparatorChar = '.';
		public const string HalfADozenText = "zes";
		public const string WordSeparatorToken = "en";
		public static readonly string[] WrittenDecimalSeparatorTexts = { "komma" };
		public static readonly string[] WrittenGroupSeparatorTexts = { "punt" };
		public static readonly string[] WrittenIntegerSeparatorTexts = { "en" };
		public static readonly string[] WrittenFractionSeparatorTexts = { "uit", "van de", "op de", "en" };
		public const string HalfADozenRegex = @"(een\s+)?half\s+dozijn";
		public const string GrossRegex = @"(een\s+)?gros";
		public const string DigitalNumberRegex = @"((?<=\b)(honderd|duizend|miljoen|miljard|biljoen|dozijn?)(?=\b))|((?<=(\d|\b))(k|t|m|g|b)(?=\b))";
		public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
		{
			{ "nul", 0 },
			{ "een", 1 },
			{ "één", 1 },
			{ "twee", 2 },
			{ "drie", 3 },
			{ "vier", 4 },
			{ "vijf", 5 },
			{ "zes", 6 },
			{ "zeven", 7 },
			{ "acht", 8 },
			{ "negen", 9 },
			{ "tien", 10 },
			{ "elf", 11 },
			{ "twaalf", 12 },
			{ "dozijn", 12 },
			{ "dertien", 13 },
			{ "veertien", 14 },
			{ "vijftien", 15 },
			{ "zestien", 16 },
			{ "zeventien", 17 },
			{ "achttien", 18 },
			{ "negentien", 19 },
			{ "twintig", 20 },
			{ "dertig", 30 },
			{ "veertig", 40 },
			{ "vijftig", 50 },
			{ "zestig", 60 },
			{ "zeventig", 70 },
			{ "tachtig", 80 },
			{ "negentig", 90 },
			{ "honderd", 100 },
			{ "gros", 144 },
			{ "duizend", 1000 },
			{ "miljoen", 1000000 },
			{ "miljard", 1000000000 },
			{ "biljoen", 1000000000000 }
		};
		public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
		{
			{ "nulde", 0 },
			{ "eerste", 1 },
			{ "tweede", 2 },
			{ "secundair", 2 },
			{ "half", 2 },
			{ "halve", 2 },
			{ "derde", 3 },
			{ "vierde", 4 },
			{ "kwart", 4 },
			{ "vijfde", 5 },
			{ "zesde", 6 },
			{ "zevende", 7 },
			{ "achtste", 8 },
			{ "negende", 9 },
			{ "tiende", 10 },
			{ "elfde", 11 },
			{ "twaalfde", 12 },
			{ "dertiende", 13 },
			{ "veertiende", 14 },
			{ "vijftiende", 15 },
			{ "zestiende", 16 },
			{ "zeventiende", 17 },
			{ "achttiende", 18 },
			{ "negentiende", 19 },
			{ "twintigste", 20 },
			{ "dertigste", 30 },
			{ "veertigste", 40 },
			{ "vijftigste", 50 },
			{ "zestigste", 60 },
			{ "zeventigste", 70 },
			{ "tachtigste", 80 },
			{ "negentigste", 90 },
			{ "honderdste", 100 },
			{ "duizendste", 1000 },
			{ "miljoenste", 1000000 },
			{ "miljardste", 1000000000 },
			{ "biljoenste", 1000000000000 },
			{ "biljardste", 1000000000000000 },
			{ "triljoenste", 1000000000000000000 }
		};
		public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
		{
			{ "honderd", 100 },
			{ "duizend", 1000 },
			{ "miljoen", 1000000 },
			{ "miljard", 1000000000 },
			{ "biljoen", 1000000000000 },
			{ "biljard", 1000000000000000 },
			{ "triljard", 1000000000000000000 },
			{ "honderdste", 100 },
			{ "duizendste", 1000 },
			{ "miljoenste", 1000000 },
			{ "miljardste", 1000000000 },
			{ "biljoenste", 1000000000000 },
			{ "biljardste", 1000000000000000 },
			{ "triljoenste", 1000000000000000000 },
			{ "honderdsten", 100 },
			{ "duizendsten", 1000 },
			{ "miljoensten", 1000000 },
			{ "miljardsten", 1000000000 },
			{ "biljoensten", 1000000000000 },
			{ "dozijn", 12 },
			{ "gros", 144 },
			{ "k", 1000 },
			{ "m", 1000000 },
			{ "g", 1000000000 },
			{ "b", 1000000000 },
			{ "t", 1000000000000 }
		};
	}
}