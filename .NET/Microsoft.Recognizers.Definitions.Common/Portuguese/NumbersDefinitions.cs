//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Portuguese\Portuguese-Numbers.yaml
//     - Language: Portuguese
//     - ClassName: NumbersDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.Portuguese
{
	using System;
	using System.Collections.Generic;

	public static class NumbersDefinitions
	{
		public const string LangMarker = @"Por";
		public const string HundredsNumberIntegerRegex = @"(quatrocent[ao]s|trezent[ao]s|seiscent[ao]s|setecent[ao]s|oitocent[ao]s|novecent[ao]s|duzent[ao]s|quinhent[ao]s|cem|(?<!por\s+)(cento))";
		public const string RoundNumberIntegerRegex = @"(mil|milh[ãa]o|milh[õo]es|bilh[ãa]o|bilh[õo]es|trilh[ãa]o|trilh[õo]es|qua[td]rilh[ãa]o|qua[td]rilh[õo]es|quintilh[ãa]o|quintilh[õo]es)";
		public const string ZeroToNineIntegerRegex = @"(quatro|cinco|sete|nove|zero|tr[êe]s|seis|oito|dois|duas|um|uma)";
		public const string TenToNineteenIntegerRegex = @"(dez[ea]sseis|dez[ea]ssete|dez[ea]nove|dezoito|quatorze|catorze|quinze|treze|d[ée]z|onze|doze)";
		public const string TensNumberIntegerRegex = @"(cinquenta|quarenta|trinta|sessenta|setenta|oitenta|noventa|vinte)";
		public const string DigitsNumberRegex = @"\d|\d{1,3}(\.\d{3})";
		public static readonly string BelowHundredsRegex = $@"(({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\s+e\s+{ZeroToNineIntegerRegex})?))|{ZeroToNineIntegerRegex})";
		public static readonly string BelowThousandsRegex = $@"({HundredsNumberIntegerRegex}(\s+e\s+{BelowHundredsRegex})?|{BelowHundredsRegex})";
		public static readonly string SupportThousandsRegex = $@"(({BelowThousandsRegex}|{BelowHundredsRegex})\s+{RoundNumberIntegerRegex}(\s+{RoundNumberIntegerRegex})?)";
		public const string NegativeNumberTermsRegex = @"^[.]";
		public static readonly string NegativeNumberSignRegex = $@"^({NegativeNumberTermsRegex}\s+).*";
		public static readonly string SeparaIntRegex = $@"({SupportThousandsRegex}(\s+{SupportThousandsRegex})*(\s+{BelowThousandsRegex})?|{BelowThousandsRegex})";
		public static readonly string AllIntRegex = $@"({SeparaIntRegex}|mil(\s+{BelowThousandsRegex})?)";
		public static readonly string AllPointRegex = $@"((\s+{ZeroToNineIntegerRegex})+|(\s+{AllIntRegex}))";
		public static readonly string SpecialFractionInteger = $@"((({AllIntRegex})i?({ZeroToNineIntegerRegex})|({AllIntRegex}))\s+a?v[oa]s?)";
		public const string PlaceHolderDefault = @"\D|\b";
		public const string PlaceHolderPureNumber = @"\b";
		public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
		public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((meia)?\s+(d[úu]zia))|({AllIntRegex}\s+(e|com)\s+)?({AllIntRegex}\s+(d[úu]zia(s)?|dezena(s)?)))(?=\b)";
		public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+(?!(,\d+[a-zA-Z]))(?={placeholder})";
		public static readonly string NumbersWithSuffix = $@"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
		public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)({DigitsNumberRegex})+\s+{RoundNumberIntegerRegex}(?=\b)";
		public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+dezena(s)?(?=\b)";
		public const string NumbersWithDozen2Suffix = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+d[úu]zia(s)(?=\b)";
		public const string SimpleRoundOrdinalRegex = @"(mil[eé]sim[oa]|milion[eé]sim[oa]|bilion[eé]sim[oa]|trilion[eé]sim[oa]|quatrilion[eé]sim[oa]|quintilion[eé]sim[oa])";
		public const string OneToNineOrdinalRegex = @"(primeir[oa]|segund[oa]|terceir[oa]|quart[oa]|quint[oa]|sext[oa]|s[eé]tim[oa]|oitav[oa]|non[oa])";
		public const string TensOrdinalRegex = @"(nonag[eé]sim[oa]|octog[eé]sim[oa]|setuag[eé]sim[oa]|septuag[eé]sim[oa]|sexag[eé]sim[oa]|quinquag[eé]sim[oa]|quadrag[eé]sim[oa]|trig[eé]sim[oa]|vig[eé]sim[oa]|d[eé]cim[oa])";
		public const string HundredOrdinalRegex = @"(cent[eé]sim[oa]|ducent[eé]sim[oa]|tricent[eé]sim[oa]|cuadringent[eé]sim[oa]|quingent[eé]sim[oa]|sexcent[eé]sim[oa]|septingent[eé]sim[oa]|octingent[eé]sim[oa]|noningent[eé]sim[oa])";
		public const string SpecialUnderHundredOrdinalRegex = @"(und[eé]cim[oa]|duod[eé]cimo)";
		public static readonly string UnderHundredOrdinalRegex = $@"((({TensOrdinalRegex}(\s)?)?{OneToNineOrdinalRegex})|{TensOrdinalRegex}|{SpecialUnderHundredOrdinalRegex})";
		public static readonly string UnderThousandOrdinalRegex = $@"((({HundredOrdinalRegex}(\s)?)?{UnderHundredOrdinalRegex})|{HundredOrdinalRegex})";
		public static readonly string OverThousandOrdinalRegex = $@"(({AllIntRegex})([eé]sim[oa]))";
		public static readonly string ComplexOrdinalRegex = $@"(({OverThousandOrdinalRegex}(\s)?)?{UnderThousandOrdinalRegex}|{OverThousandOrdinalRegex})";
		public static readonly string SuffixRoundOrdinalRegex = $@"(({AllIntRegex})({SimpleRoundOrdinalRegex}))";
		public static readonly string ComplexRoundOrdinalRegex = $@"((({SuffixRoundOrdinalRegex}(\s)?)?{ComplexOrdinalRegex})|{SuffixRoundOrdinalRegex})";
		public static readonly string AllOrdinalRegex = $@"{ComplexOrdinalRegex}|{SimpleRoundOrdinalRegex}|{ComplexRoundOrdinalRegex}";
		public const string OrdinalSuffixRegex = @"(?<=\b)(\d*(1[oaº]|2[oaº]|3[oaº]|4[oaº]|5[oaº]|6[oaº]|7[oaº]|8[oaº]|9[oaº]|0[oaº]|1.º|2.º|3.º|4.º|5.º|6.º|7.º|8.º|9.º))(?=\b)";
		public static readonly string OrdinalEnglishRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
		public const string FractionNotationRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+[/]\d+(?=(\b[^/]|$))";
		public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
		public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex}\s+((e|com)\s+)?)?({AllIntRegex})(\s+((e|com)\s)?)((({AllOrdinalRegex})s?|({SpecialFractionInteger})|({SuffixRoundOrdinalRegex})s?)|mei[oa]?|ter[çc]o?)(?=\b)";
		public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)({AllIntRegex}\s+(e\s+)?)?(um|um[as])(\s+)(({AllOrdinalRegex})|({SuffixRoundOrdinalRegex})|(e\s+)?mei[oa]?)(?=\b)";
		public static readonly string FractionPrepositionRegex = $@"(?<=\b)(?<numerator>({AllIntRegex})|((?<!\.)\d+))\s+sobre\s+(?<denominator>({AllIntRegex})|((\d+)(?!\.)))(?=\b)";
		public static readonly string AllFloatRegex = $@"{AllIntRegex}(\s+(vírgula|virgula|e|ponto)){AllPointRegex}";
		public static readonly string DoubleWithMultiplierRegex = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\,)))\d+,\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
		public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))(\d+(,\d+)?)e([+-]*[1-9]\d*)(?=\b)";
		public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))(\d+(,\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
		public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+,)))\d+,\d+(?!(,\d+))(?={placeholder})";
		public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+)),\d+(?!(,\d+))(?={placeholder})";
		public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\,)))\d+,\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
		public static readonly string NumberWithSuffixPercentage = $@"(?<!%)({BaseNumbers.NumberReplaceToken})(\s*)(%(?!{BaseNumbers.NumberReplaceToken})|(por cento|pontos percentuais)\b)";
		public const string AmbiguousFractionConnectorsRegex = @"^[.]";
		public const char DecimalSeparatorChar = ',';
		public const string FractionMarkerToken = @"sobre";
		public const char NonDecimalSeparatorChar = '.';
		public const string HalfADozenText = @"seis";
		public const string WordSeparatorToken = @"e";
		public static readonly string[] WrittenDecimalSeparatorTexts = { @"virgula", @"vírgula" };
		public static readonly string[] WrittenGroupSeparatorTexts = { @"ponto" };
		public static readonly string[] WrittenIntegerSeparatorTexts = { @"e" };
		public static readonly string[] WrittenFractionSeparatorTexts = { @"com" };
		public static readonly string[] WrittenFractionSuffix = { @"avo", @"ava" };
		public const char PluralSuffix = 's';
		public const string HalfADozenRegex = @"meia\s+d[uú]zia";
		public static readonly string DigitalNumberRegex = $@"((?<=\b)(mil|cem|milh[oõ]es|milh[aã]o|bilh[oõ]es|bilh[aã]o|trilh[oõ]es|trilh[aã]o|milhares|centena|centenas|dezena|dezenas?)(?=\b))|((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
		public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
		{
			{ @"zero", 0 },
			{ @"hum", 1 },
			{ @"um", 1 },
			{ @"uma", 1 },
			{ @"dois", 2 },
			{ @"duas", 2 },
			{ @"meia", 2 },
			{ @"meio", 2 },
			{ @"tres", 3 },
			{ @"três", 3 },
			{ @"quatro", 4 },
			{ @"cinco", 5 },
			{ @"seis", 6 },
			{ @"sete", 7 },
			{ @"oito", 8 },
			{ @"nove", 9 },
			{ @"dez", 10 },
			{ @"dezena", 10 },
			{ @"déz", 10 },
			{ @"onze", 11 },
			{ @"doze", 12 },
			{ @"dúzia", 12 },
			{ @"duzia", 12 },
			{ @"dúzias", 12 },
			{ @"duzias", 12 },
			{ @"treze", 13 },
			{ @"catorze", 14 },
			{ @"quatorze", 14 },
			{ @"quinze", 15 },
			{ @"dezesseis", 16 },
			{ @"dezasseis", 16 },
			{ @"dezessete", 17 },
			{ @"dezassete", 17 },
			{ @"dezoito", 18 },
			{ @"dezenove", 19 },
			{ @"dezanove", 19 },
			{ @"vinte", 20 },
			{ @"trinta", 30 },
			{ @"quarenta", 40 },
			{ @"cinquenta", 50 },
			{ @"cincoenta", 50 },
			{ @"sessenta", 60 },
			{ @"setenta", 70 },
			{ @"oitenta", 80 },
			{ @"noventa", 90 },
			{ @"cem", 100 },
			{ @"cento", 100 },
			{ @"duzentos", 200 },
			{ @"duzentas", 200 },
			{ @"trezentos", 300 },
			{ @"trezentas", 300 },
			{ @"quatrocentos", 400 },
			{ @"quatrocentas", 400 },
			{ @"quinhentos", 500 },
			{ @"quinhentas", 500 },
			{ @"seiscentos", 600 },
			{ @"seiscentas", 600 },
			{ @"setecentos", 700 },
			{ @"setecentas", 700 },
			{ @"oitocentos", 800 },
			{ @"oitocentas", 800 },
			{ @"novecentos", 900 },
			{ @"novecentas", 900 },
			{ @"mil", 1000 },
			{ @"milhão", 1000000 },
			{ @"milhao", 1000000 },
			{ @"milhões", 1000000 },
			{ @"milhoes", 1000000 },
			{ @"bilhão", 1000000000 },
			{ @"bilhao", 1000000000 },
			{ @"bilhões", 1000000000 },
			{ @"bilhoes", 1000000000 },
			{ @"trilhão", 1000000000000 },
			{ @"trilhao", 1000000000000 },
			{ @"trilhões", 1000000000000 },
			{ @"trilhoes", 1000000000000 }
		};
		public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
		{
			{ @"primeiro", 1 },
			{ @"primeira", 1 },
			{ @"segundo", 2 },
			{ @"segunda", 2 },
			{ @"terceiro", 3 },
			{ @"terceira", 3 },
			{ @"quarto", 4 },
			{ @"quarta", 4 },
			{ @"quinto", 5 },
			{ @"quinta", 5 },
			{ @"sexto", 6 },
			{ @"sexta", 6 },
			{ @"sétimo", 7 },
			{ @"setimo", 7 },
			{ @"sétima", 7 },
			{ @"setima", 7 },
			{ @"oitavo", 8 },
			{ @"oitava", 8 },
			{ @"nono", 9 },
			{ @"nona", 9 },
			{ @"décimo", 10 },
			{ @"decimo", 10 },
			{ @"décima", 10 },
			{ @"decima", 10 },
			{ @"undécimo", 11 },
			{ @"undecimo", 11 },
			{ @"undécima", 11 },
			{ @"undecima", 11 },
			{ @"duodécimo", 11 },
			{ @"duodecimo", 11 },
			{ @"duodécima", 11 },
			{ @"duodecima", 11 },
			{ @"vigésimo", 20 },
			{ @"vigesimo", 20 },
			{ @"vigésima", 20 },
			{ @"vigesima", 20 },
			{ @"trigésimo", 30 },
			{ @"trigesimo", 30 },
			{ @"trigésima", 30 },
			{ @"trigesima", 30 },
			{ @"quadragésimo", 40 },
			{ @"quadragesimo", 40 },
			{ @"quadragésima", 40 },
			{ @"quadragesima", 40 },
			{ @"quinquagésimo", 50 },
			{ @"quinquagesimo", 50 },
			{ @"quinquagésima", 50 },
			{ @"quinquagesima", 50 },
			{ @"sexagésimo", 60 },
			{ @"sexagesimo", 60 },
			{ @"sexagésima", 60 },
			{ @"sexagesima", 60 },
			{ @"septuagésimo", 70 },
			{ @"septuagesimo", 70 },
			{ @"septuagésima", 70 },
			{ @"septuagesima", 70 },
			{ @"setuagésimo", 70 },
			{ @"setuagesimo", 70 },
			{ @"setuagésima", 70 },
			{ @"setuagesima", 70 },
			{ @"octogésimo", 80 },
			{ @"octogesimo", 80 },
			{ @"octogésima", 80 },
			{ @"octogesima", 80 },
			{ @"nonagésimo", 90 },
			{ @"nonagesimo", 90 },
			{ @"nonagésima", 90 },
			{ @"nonagesima", 90 },
			{ @"centesimo", 100 },
			{ @"centésimo", 100 },
			{ @"centesima", 100 },
			{ @"centésima", 100 },
			{ @"ducentésimo", 200 },
			{ @"ducentesimo", 200 },
			{ @"ducentésima", 200 },
			{ @"ducentesima", 200 },
			{ @"tricentésimo", 300 },
			{ @"tricentesimo", 300 },
			{ @"tricentésima", 300 },
			{ @"tricentesima", 300 },
			{ @"trecentésimo", 300 },
			{ @"trecentesimo", 300 },
			{ @"trecentésima", 300 },
			{ @"trecentesima", 300 },
			{ @"quadringentésimo", 400 },
			{ @"quadringentesimo", 400 },
			{ @"quadringentésima", 400 },
			{ @"quadringentesima", 400 },
			{ @"quingentésimo", 500 },
			{ @"quingentesimo", 500 },
			{ @"quingentésima", 500 },
			{ @"quingentesima", 500 },
			{ @"sexcentésimo", 600 },
			{ @"sexcentesimo", 600 },
			{ @"sexcentésima", 600 },
			{ @"sexcentesima", 600 },
			{ @"seiscentésimo", 600 },
			{ @"seiscentesimo", 600 },
			{ @"seiscentésima", 600 },
			{ @"seiscentesima", 600 },
			{ @"septingentésimo", 700 },
			{ @"septingentesimo", 700 },
			{ @"septingentésima", 700 },
			{ @"septingentesima", 700 },
			{ @"setingentésimo", 700 },
			{ @"setingentesimo", 700 },
			{ @"setingentésima", 700 },
			{ @"setingentesima", 700 },
			{ @"octingentésimo", 800 },
			{ @"octingentesimo", 800 },
			{ @"octingentésima", 800 },
			{ @"octingentesima", 800 },
			{ @"noningentésimo", 900 },
			{ @"noningentesimo", 900 },
			{ @"noningentésima", 900 },
			{ @"noningentesima", 900 },
			{ @"nongentésimo", 900 },
			{ @"nongentesimo", 900 },
			{ @"nongentésima", 900 },
			{ @"nongentesima", 900 },
			{ @"milésimo", 1000 },
			{ @"milesimo", 1000 },
			{ @"milésima", 1000 },
			{ @"milesima", 1000 },
			{ @"milionésimo", 1000000 },
			{ @"milionesimo", 1000000 },
			{ @"milionésima", 1000000 },
			{ @"milionesima", 1000000 },
			{ @"bilionésimo", 1000000000 },
			{ @"bilionesimo", 1000000000 },
			{ @"bilionésima", 1000000000 },
			{ @"bilionesima", 1000000000 }
		};
		public static readonly Dictionary<string, long> PrefixCardinalMap = new Dictionary<string, long>
		{
			{ @"hum", 1 },
			{ @"dois", 2 },
			{ @"tres", 3 },
			{ @"três", 3 },
			{ @"quatro", 4 },
			{ @"cinco", 5 },
			{ @"seis", 6 },
			{ @"sete", 7 },
			{ @"oito", 8 },
			{ @"nove", 9 },
			{ @"dez", 10 },
			{ @"onze", 11 },
			{ @"doze", 12 },
			{ @"treze", 13 },
			{ @"catorze", 14 },
			{ @"quatorze", 14 },
			{ @"quinze", 15 },
			{ @"dezesseis", 16 },
			{ @"dezasseis", 16 },
			{ @"dezessete", 17 },
			{ @"dezassete", 17 },
			{ @"dezoito", 18 },
			{ @"dezenove", 19 },
			{ @"dezanove", 19 },
			{ @"vinte", 20 },
			{ @"trinta", 30 },
			{ @"quarenta", 40 },
			{ @"cinquenta", 50 },
			{ @"cincoenta", 50 },
			{ @"sessenta", 60 },
			{ @"setenta", 70 },
			{ @"oitenta", 80 },
			{ @"noventa", 90 },
			{ @"cem", 100 },
			{ @"duzentos", 200 },
			{ @"trezentos", 300 },
			{ @"quatrocentos", 400 },
			{ @"quinhentos", 500 },
			{ @"seiscentos", 600 },
			{ @"setecentos", 700 },
			{ @"oitocentos", 800 },
			{ @"novecentos", 900 }
		};
		public static readonly Dictionary<string, long> SuffixOrdinalMap = new Dictionary<string, long>
		{
			{ @"milesimo", 1000 },
			{ @"milionesimo", 1000000 },
			{ @"bilionesimo", 1000000000 },
			{ @"trilionesimo", 1000000000000 }
		};
		public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
		{
			{ @"mil", 1000 },
			{ @"milesimo", 1000 },
			{ @"milhão", 1000000 },
			{ @"milhao", 1000000 },
			{ @"milhões", 1000000 },
			{ @"milhoes", 1000000 },
			{ @"milionésimo", 1000000 },
			{ @"milionesimo", 1000000 },
			{ @"bilhão", 1000000000 },
			{ @"bilhao", 1000000000 },
			{ @"bilhões", 1000000000 },
			{ @"bilhoes", 1000000000 },
			{ @"bilionésimo", 1000000000 },
			{ @"bilionesimo", 1000000000 },
			{ @"trilhão", 1000000000000 },
			{ @"trilhao", 1000000000000 },
			{ @"trilhões", 1000000000000 },
			{ @"trilhoes", 1000000000000 },
			{ @"trilionésimo", 1000000000000 },
			{ @"trilionesimo", 1000000000000 },
			{ @"dezena", 10 },
			{ @"dezenas", 10 },
			{ @"dúzia", 12 },
			{ @"duzia", 12 },
			{ @"dúzias", 12 },
			{ @"duzias", 12 },
			{ @"k", 1000 },
			{ @"m", 1000000 },
			{ @"g", 1000000000 },
			{ @"b", 1000000000 },
			{ @"t", 1000000000000 }
		};
		public static readonly Dictionary<string, string> RelativeReferenceMap = new Dictionary<string, string>
		{
			{ @"", @"" }
		};
	}
}