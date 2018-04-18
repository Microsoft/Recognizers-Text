﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\Japanese\Japanese-Numbers.yaml
//     - Language: Japanese
//     - ClassName: NumbersDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.Japanese
{
	using System;
	using System.Collections.Generic;

	public static class NumbersDefinitions
	{
		public const string LangMarker = "";
		public const char DecimalSeparatorChar = '.';
		public const string FractionMarkerToken = "";
		public const char NonDecimalSeparatorChar = ' ';
		public const string HalfADozenText = "";
		public const string WordSeparatorToken = "";
		public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
		{
			{ "k", 1000 },
			{ "m", 1000000 },
			{ "g", 1000000000 },
			{ "t", 1000000000000 }
		};
		public static readonly Dictionary<char, long> RoundNumberMapChar = new Dictionary<char, long>
		{
			{ '十', 10 },
			{ '百', 100 },
			{ '千', 1000 },
			{ '万', 10000 },
			{ '億', 100000000 },
			{ '兆', 1000000000000 }
		};
		public static readonly Dictionary<char, double> ZeroToNineMap = new Dictionary<char, double>
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
			{ '0', 0 },
			{ '1', 1 },
			{ '2', 2 },
			{ '3', 3 },
			{ '4', 4 },
			{ '5', 5 },
			{ '6', 6 },
			{ '7', 7 },
			{ '8', 8 },
			{ '9', 9 },
			{ '半', 0.5 }
		};
		public static readonly Dictionary<char, char> FullToHalfMap = new Dictionary<char, char>
		{
			{ '０', '0' },
			{ '１', '1' },
			{ '２', '2' },
			{ '３', '3' },
			{ '４', '4' },
			{ '５', '5' },
			{ '６', '6' },
			{ '７', '7' },
			{ '８', '8' },
			{ '９', '9' },
			{ '／', '/' },
			{ '－', '-' },
			{ '，', '\'' },
			{ 'Ｇ', 'G' },
			{ 'Ｍ', 'M' },
			{ 'Ｔ', 'T' },
			{ 'Ｋ', 'K' },
			{ 'ｋ', 'k' },
			{ '．', '.' }
		};
		public static readonly Dictionary<string, string> UnitMap = new Dictionary<string, string>
		{
			{ "万万", "億" },
			{ "億万", "兆" },
			{ "万億", "兆" }
		};
		public static readonly IList<char> RoundDirectList = new List<char>
		{
			'万',
			'億',
			'兆'
		};
		public const string DigitalNumberRegex = @"((?<=(\d|\b))(k|t|m|g)(?=\b))";
		public const string ZeroToNineFullHalfRegex = @"[\d１２３４５６７８９０]";
		public static readonly string DigitNumRegex = $@"{ZeroToNineFullHalfRegex}+";
		public const string DozenRegex = @".*ダース$";
		public const string PercentageRegex = @".+(?=パ\s*ー\s*セ\s*ン\s*ト)|.*(?=[％%])";
		public static readonly string DoubleAndRoundRegex = $@"{ZeroToNineFullHalfRegex}+(\.{ZeroToNineFullHalfRegex}+)?\s*[万億]{{1,2}}(\s*(以上))?";
		public const string FracSplitRegex = @"は|分\s*の";
		public const string ZeroToNineIntegerRegex = @"[一二三四五六七八九]";
		public const string NegativeNumberTermsRegex = @"マ\s*イ\s*ナ\s*ス";
		public const string NegativeNumberTermsRegexNum = @"(?<!(\d+\s*)|[-－])[-－]";
		public static readonly string NegativeNumberSignRegex = $@"^{NegativeNumberTermsRegex}.*|^{NegativeNumberTermsRegexNum}.*";
		public static readonly string SpeGetNumberRegex = $@"{ZeroToNineFullHalfRegex}|{ZeroToNineIntegerRegex}|[半対]";
		public const string PairRegex = ".*[対膳]$";
		public const string RoundNumberIntegerRegex = @"[十百千万億兆]";
		public const string WhiteListRegex = @"(。|，|、|（|）|”｜国|週間|時間|時|匹|\s|$)";
		public static readonly string NotSingleRegex = $@"(({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex}|[十])\s*{RoundNumberIntegerRegex}){{1,2}}\s*(\s*[以上]?)";
		public static readonly string SingleRegex = $@"(?<!{ZeroToNineIntegerRegex}){ZeroToNineIntegerRegex}(?={WhiteListRegex})";
		public static readonly string AllIntRegex = $@"(({ZeroToNineIntegerRegex}|{ZeroToNineFullHalfRegex}|[十百千])\s*{RoundNumberIntegerRegex}*){{1,2}}\s*(\s*[以上]?)";
		public static readonly string NumbersSpecialsChars = $@"(({NegativeNumberTermsRegexNum}|{NegativeNumberTermsRegex})\s*)?{ZeroToNineFullHalfRegex}+";
		public static readonly string NumbersSpecialsCharsWithSuffix = $@"{NegativeNumberTermsRegexNum}?{ZeroToNineFullHalfRegex}+\s*(K|k|M|G|T|Ｍ|Ｋ|ｋ|Ｇ|Ｔ)";
		public static readonly string DottedNumbersSpecialsChar = $@"{NegativeNumberTermsRegexNum}?{ZeroToNineFullHalfRegex}{{1,3}}([,，、]{ZeroToNineFullHalfRegex}{{3}})+";
		public static readonly string NumbersWithHalfDozen = $@"半({RoundNumberIntegerRegex}|(ダース))";
		public static readonly string NumbersWithDozen = $@"{AllIntRegex}(ダース)(?!{AllIntRegex})";
		public const string PointRegexStr = @"[\.．]";
		public static readonly string AllFloatRegex = $@"{NegativeNumberTermsRegex}?{AllIntRegex}\s*{PointRegexStr}\s*[一二三四五六七八九](\s*{ZeroToNineIntegerRegex})*";
		public static readonly string NumbersWithAllowListRegex = $@"(?<!({AllIntRegex}*|{AllFloatRegex})*パーセント){NegativeNumberTermsRegex}?({NotSingleRegex})";
		public static readonly string NumbersAggressiveRegex = $@"(?<!({AllIntRegex}*|{AllFloatRegex})*パーセント){NegativeNumberTermsRegex}?({{NotSingleRegex}})";
		public static readonly string PointRegex = $@"{PointRegexStr}";
		public static readonly string DoubleSpecialsChars = $@"(?<!({ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}*))({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+(?!{ZeroToNineFullHalfRegex}*[\.．]{ZeroToNineFullHalfRegex}+)";
		public static readonly string DoubleSpecialsCharsWithNegatives = $@"(?<!({ZeroToNineFullHalfRegex}+|\.\.|．．))({NegativeNumberTermsRegexNum}\s*)?[\.．]{ZeroToNineFullHalfRegex}+(?!{ZeroToNineFullHalfRegex}*([\.．]{ZeroToNineFullHalfRegex}+))";
		public static readonly string SimpleDoubleSpecialsChars = $@"({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+[\.．]{ZeroToNineFullHalfRegex}+";
		public static readonly string DoubleWithMultiplierRegex = $@"({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*(K|k|M|G|T|Ｍ|Ｋ|ｋ|Ｇ|Ｔ)";
		public static readonly string DoubleWithThousandsRegex = $@"{NegativeNumberTermsRegex}?{ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?\s*[万亿萬億]{{1,2}}\s*(以上)*";
		public static readonly string DoubleAllFloatRegex = $@"(?<!(({AllIntRegex}[.]*)|{AllFloatRegex})*){AllFloatRegex}(?!{ZeroToNineIntegerRegex}*\s*パーセント)";
		public static readonly string DoubleExponentialNotationRegex = $@"(?<!{ZeroToNineFullHalfRegex}+[\.．])({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?e(([-－+＋]*[1-9１２３４５６７８９]{ZeroToNineFullHalfRegex}*)|[0０](?!{ZeroToNineFullHalfRegex}+))";
		public static readonly string DoubleScientificNotationRegex = $@"(?<!{ZeroToNineFullHalfRegex}+[\.．])({NegativeNumberTermsRegexNum}\s*)?({ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?)\^([-－+＋]*[1-9１２３４５６７８９]{ZeroToNineFullHalfRegex}*)";
		public static readonly string OrdinalRegex = $@"(第|だい){AllIntRegex}";
		public static readonly string OrdinalNumbersRegex = $@"(第|だい){ZeroToNineFullHalfRegex}+";
		public static readonly string AllFractionNumber = $@"{NegativeNumberTermsRegex}{{0,1}}(({ZeroToNineFullHalfRegex}+|{AllIntRegex})\s*[はと]{{0,1}}\s*)?{NegativeNumberTermsRegex}{{0,1}}({ZeroToNineFullHalfRegex}+|{AllIntRegex})\s*分\s*の\s*{NegativeNumberTermsRegex}{{0,1}}({ZeroToNineFullHalfRegex}+|{AllIntRegex})";
		public static readonly string FractionNotationSpecialsCharsRegex = $@"({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+\s+{ZeroToNineFullHalfRegex}+[/／]{ZeroToNineFullHalfRegex}+";
		public static readonly string FractionNotationRegex = $@"({NegativeNumberTermsRegexNum}\s*)?{ZeroToNineFullHalfRegex}+[/／]{ZeroToNineFullHalfRegex}+";
		public static readonly string PercentagePointRegex = $@"(?<!{AllIntRegex})({AllFloatRegex}|{AllIntRegex})\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string SimplePercentageRegex = $@"({AllFloatRegex}|{{AllIntRegex|{ZeroToNineIntegerRegex}|[百])\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string NumbersPercentagePointRegex = $@"({ZeroToNineFullHalfRegex}|{{ZeroToNineFullRegex}})+([\.．]({ZeroToNineFullHalfRegex}|{{ZeroToNineFullRegex}})+)?\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string NumbersPercentageWithSeparatorRegex = $@"({ZeroToNineFullHalfRegex}{{1,3}}[,，、]{ZeroToNineFullHalfRegex}{{3}})+([\.．]{ZeroToNineFullHalfRegex}+)*\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string NumbersPercentageWithMultiplierRegex = $@"(?<!{ZeroToNineIntegerRegex}){ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*(K|k|M|G|T|Ｍ|Ｋ|ｋ|Ｇ|Ｔ)\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string FractionPercentagePointRegex = $@"(?<!({ZeroToNineFullHalfRegex}+[\.．])){ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+(?!([\.．]{ZeroToNineFullHalfRegex}+))\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string FractionPercentageWithSeparatorRegex = $@"{ZeroToNineFullHalfRegex}{{1,3}}([,，、]{ZeroToNineFullHalfRegex}{{3}})+[\.．]{ZeroToNineFullHalfRegex}+\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string FractionPercentageWithMultiplierRegex = $@"{ZeroToNineFullHalfRegex}+[\.．]{ZeroToNineFullHalfRegex}+\s*(K|k|M|G|T|Ｍ|Ｋ|ｋ|Ｇ|Ｔ)\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string SimpleNumbersPercentageRegex = $@"(?<!{ZeroToNineIntegerRegex}){ZeroToNineFullHalfRegex}+\s*パ\s*ー\s*セ\s*ン\s*ト(?!([\.．]{ZeroToNineFullHalfRegex}+))";
		public static readonly string SimpleNumbersPercentageWithMultiplierRegex = $@"(?<!{ZeroToNineIntegerRegex}){ZeroToNineFullHalfRegex}+\s*(K|k|M|G|T|Ｍ|Ｋ|ｋ|Ｇ|Ｔ)\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string SimpleNumbersPercentagePointRegex = $@"(?!{ZeroToNineIntegerRegex}){ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string IntegerPercentageRegex = $@"{ZeroToNineFullHalfRegex}+\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string IntegerPercentageWithMultiplierRegex = $@"{ZeroToNineFullHalfRegex}+\s*(K|k|M|G|T|Ｍ|Ｋ|ｋ|Ｇ|Ｔ)\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string NumbersFractionPercentageRegex = $@"{ZeroToNineFullHalfRegex}{{1,3}}([,，]{ZeroToNineFullHalfRegex}{{3}})+\s*パ\s*ー\s*セ\s*ン\s*ト";
		public static readonly string SimpleIntegerPercentageRegex = $@"{NegativeNumberTermsRegexNum}?{ZeroToNineFullHalfRegex}+([\.．]{ZeroToNineFullHalfRegex}+)?(\s*)[％%]";
		public static readonly string NumbersFoldsPercentageRegex = $@"{ZeroToNineFullHalfRegex}(([\.．]?|\s*){ZeroToNineFullHalfRegex})?\s*[の]*\s*割引";
		public static readonly string FoldsPercentageRegex = $@"{ZeroToNineIntegerRegex}(\s*[.]?\s*{ZeroToNineIntegerRegex})?\s*[の]\s*割引";
		public static readonly string SimpleFoldsPercentageRegex = $@"{ZeroToNineFullHalfRegex}\s*割(\s*(半|{ZeroToNineFullHalfRegex}))?";
		public static readonly string SpecialsPercentageRegex = $@"({ZeroToNineIntegerRegex}|[十])\s*割(\s*(半|{ZeroToNineIntegerRegex}))?";
		public static readonly string NumbersSpecialsPercentageRegex = $@"({ZeroToNineFullHalfRegex}[\.．]{ZeroToNineFullHalfRegex}|[1１][0０])\s*割";
		public static readonly string SimpleSpecialsPercentageRegex = $@"{ZeroToNineIntegerRegex}\s*[.]\s*{ZeroToNineIntegerRegex}\s*割";
		public const string SpecialsFoldsPercentageRegex = @"半\s*分|(?<=ダース)";
		public const string TillRegex = @"(--|-|—|——|~)";
		public const string MoreRegex = @"(大なり|より大きい|より高い|>)";
		public const string LessRegex = @"(小なり|より小さい|<)";
		public const string EqualRegex = @"(等しい|イコール|=)";
		public static readonly string MoreOrEqual = $@"大なりイコール|小さくない";
		public const string MoreOrEqualSuffix = @"より(大なりイコール|小さくない)";
		public static readonly string LessOrEqual = $@"小なりイコール|小さくない";
		public const string LessOrEqualSuffix = @"より(小なりイコール|小さくない)";
		public static readonly string OneNumberRangeMoreRegex1 = $@"({MoreOrEqual}|{MoreRegex})\s*(?<number1>((?!(((，|、)(?!\d+))|((,|、)(?!\d+))|。)).)+)";
		public const string OneNumberRangeMoreRegex2 = @"(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(より)?(大なり)";
		public const string OneNumberRangeMoreRegex3 = @"(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(以上)(?![万億]{1,2})";
		public static readonly string OneNumberRangeLessRegex1 = $@"({LessOrEqual}|{LessRegex})\s*(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)";
		public const string OneNumberRangeLessRegex2 = @"比\s*(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(より)?(小なり)";
		public const string OneNumberRangeLessRegex3 = @"(?<number2>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)\s*(以下)";
		public static readonly string OneNumberRangeEqualRegex = $@"{EqualRegex}\s*(?<number1>((?!((，(?!\d+))|(,(?!\d+))|。)).)+)";
	}
}