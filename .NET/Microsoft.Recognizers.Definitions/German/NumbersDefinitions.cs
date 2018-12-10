﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\German\German-Numbers.yaml
//     - Language: German
//     - ClassName: NumbersDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.German
{
	using System;
	using System.Collections.Generic;

	public static class NumbersDefinitions
	{
		public const string LangMarker = "Ger";
		public const string ZeroToNineIntegerRegex = @"(drei|sieben|acht|vier|fuenf|fünf|null|neun|eins|ein|eine|einer|einen|zwei|zwo|sechs)";
		public const string RoundNumberIntegerRegex = @"(hundert|einhundert|tausend|(\s*million\s*)|(\s*millionen\s*)|(\s*mio\s*)|(\s*milliarde\s*)|(\s*milliarden\s*)|(\s*mrd\s*)|(\s*billion\s*)|(\s*billionen\s*))";
		public const string AnIntRegex = @"(eine|ein)(?=\s)";
		public const string TenToNineteenIntegerRegex = @"(siebzehn|dreizehn|vierzehn|achtzehn|neunzehn|fuenfzehn|sechzehn|elf|zwoelf|zwölf|zehn)";
		public const string TensNumberIntegerRegex = @"(siebzig|zwanzig|dreißig|achtzig|neunzig|vierzig|fuenfzig|fünfzig|sechzig)";
		public const string NegativeNumberTermsRegex = @"^[.]";
		public static readonly string NegativeNumberSignRegex = $@"^({NegativeNumberTermsRegex}\s+).*";
		public static readonly string SeparaIntRegex = $@"((({TenToNineteenIntegerRegex}|({ZeroToNineIntegerRegex}und{TensNumberIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex})(\s*{RoundNumberIntegerRegex})*))|(({AnIntRegex}(\s*{RoundNumberIntegerRegex})+))";
		public static readonly string AllIntRegex = $@"(((({TenToNineteenIntegerRegex}|({ZeroToNineIntegerRegex}und{TensNumberIntegerRegex})|{TensNumberIntegerRegex}|({ZeroToNineIntegerRegex}|{AnIntRegex}))?(\s*{RoundNumberIntegerRegex})))*{SeparaIntRegex})";
		public const string PlaceHolderPureNumber = @"\b";
		public const string PlaceHolderDefault = @"\D|\b";
		public static readonly Func<string, string> NumbersWithPlaceHolder = (placeholder) => $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+(?!(\,\d+[a-zA-Z]))(?={placeholder})";
		public static readonly string NumbersWithSuffix = $@"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
		public static readonly string RoundNumberIntegerRegexWithLocks = $@"(?<=\b)\d+\s*{RoundNumberIntegerRegex}(?=\b)";
		public const string NumbersWithDozenSuffix = @"(((?<!\d+\s*)-\s*)|(?<=\b))\d+\s+dutzend(e)?(?=\b)";
		public static readonly string AllIntRegexWithLocks = $@"((?<=\b){AllIntRegex}(?=\b))";
		public static readonly string AllIntRegexWithDozenSuffixLocks = $@"(?<=\b)(((ein\s+)?halbes\s+dutzend)|({AllIntRegex}\s+dutzend(e)?))(?=\b)";
		public const string RoundNumberOrdinalRegex = @"(hundertst(er|es|en|el|e)?|tausendst(er|es|en|el|e)?|millionst(er|es|en|el|e)?|milliardst(er|es|en|el|e)?|billionst(er|es|en|el|e)?)";
		public const string BasicOrdinalRegex = @"(zuerst|erst(er|es|en|e)|zweit(er|es|en|e)?|dritt(er|es|en|el|e)?|viert(er|es|en|el|e)?|fünft(er|es|en|el|e)?|fuenft(er|es|en|el|e)?|sechst(er|es|en|el|e)?|siebt(er|es|en|el|e)?|acht(er|es|en|el|e)?|neunt(er|es|en|el|e)?|zehnt(er|es|en|el|e)?|elft(er|es|en|el|e)?|zwölft(er|es|en|el|e)?|zwoelft(er|es|en|el|e)?|dreizehnt(er|es|en|el|e)?|vierzehnt(er|es|en|el|e)?|fünfzehnt(er|es|en|el|e)?|fuenfzehnt(er|es|en|el|e)?|sechzehnt(er|es|en|el|e)?|siebzehnt(er|es|en|el|e)?|achtzehnt(er|es|en|el|e)?|neunzehnt(er|es|en|el|e)?|zwanzigst(er|es|en|el|e)?|dreißigst(er|es|en|el|e)?|vierziegt(er|es|en|el|e)?|fünfzigst(er|es|en|el|e)?|fuenfzigst(er|es|en|el|e)?|sechzigst(er|es|en|el|e)?|siebzigst(er|es|en|el|e)?|achtzigst(er|es|en|el|e)?|neunzigst(er|es|en|el|e)?)";
		public static readonly string SuffixBasicOrdinalRegex = $@"({BasicOrdinalRegex}|({ZeroToNineIntegerRegex}(und|\s){BasicOrdinalRegex}))";
		public static readonly string SuffixRoundNumberOrdinalRegex = $@"(({AllIntRegex}\s*){RoundNumberOrdinalRegex})";
		public static readonly string AllOrdinalRegex = $@"(({AllIntRegex}\s*)*{SuffixBasicOrdinalRegex}|{SuffixRoundNumberOrdinalRegex})";
		public const string OrdinalSuffixRegex = @"(?<=\b)((\d*(1|2|3|4|5|6|7|8|9|0))|(11|12))(?=\b)";
		public const string OrdinalNumericRegex = @"(?<=\b)(\d{1,3}(\s*,\s*\d+)*\s*th)(?=\b)";
		public static readonly string OrdinalRoundNumberRegex = $@"(?<!(ein|eine)\s+){RoundNumberOrdinalRegex}";
		public static readonly string OrdinalGermanRegex = $@"(?<=\b){AllOrdinalRegex}(?=\b)";
		public const string FractionNotationWithSpacesRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s+\d+[/]\d+(?=(\b[^/]|$))";
		public const string FractionNotationRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+[/]\d+(?=(\b[^/]|$))";
		public static readonly string FractionNounRegex = $@"(?<=\b)({AllIntRegex})(\s*|\s*-\s*)((({AllOrdinalRegex})|({RoundNumberOrdinalRegex}))|halb(er|e|es)?|hälfte)(?=\b)";
		public static readonly string FractionNounWithArticleRegex = $@"(?<=\b)({AllIntRegex}\s+(und\s+)?)?(ein|eine)(\s+|\s*-\s*)(({AllOrdinalRegex})|({RoundNumberOrdinalRegex})|halb(er|e|es)?|hälfte)(?=\b)";
		public static readonly string FractionPrepositionRegex = $@"(?<=\b)(?<numerator>({AllIntRegex})|((?<!\.)\d+))\s+over\s+(?<denominator>({AllIntRegex})|(\d+)(?!\.))(?=\b)";
		public static readonly string AllPointRegex = $@"((\s*{ZeroToNineIntegerRegex})+|(\s*{SeparaIntRegex}))";
		public static readonly string AllFloatRegex = $@"({AllIntRegex}(\s*komma\s*){AllPointRegex})";
		public static readonly string DoubleWithMultiplierRegex = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))\d+\.\d+\s*{BaseNumbers.NumberMultiplierRegex}(?=\b)";
		public const string DoubleExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))(\d+(\.\d+)?)e([+-]*[1-9]\d*)(?=\b)";
		public const string DoubleCaretExponentialNotationRegex = @"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.)))(\d+(\.\d+)?)\^([+-]*[1-9]\d*)(?=\b)";
		public static readonly Func<string, string> DoubleDecimalPointRegex = (placeholder) => $@"((\d{{1,3}})(\.\d{{3}})*(\,\d+)?)(?={placeholder})";
		public static readonly Func<string, string> DoubleWithoutIntegralRegex = (placeholder) => $@"(?<=\s|^)(?<!(\d+))\.\d+(?!(\.\d+))(?={placeholder})";
		public static readonly string DoubleWithRoundNumber = $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\,)))\d+\,\d+\s+{RoundNumberIntegerRegex}(?=\b)";
		public static readonly string DoubleAllFloatRegex = $@"((?<=\b){AllFloatRegex}(?=\b))";
		public static readonly string NumberWithSuffixPercentage = $@"(?<!%)({BaseNumbers.NumberReplaceToken})(\s*)(%(?!{BaseNumbers.NumberReplaceToken})|prozent\b)";
		public static readonly string NumberWithPrefixPercentage = $@"(Prozent)(\s*)({BaseNumbers.NumberReplaceToken})";
		public const string AmbiguousFractionConnectorsRegex = @"^[.]";
		public const char DecimalSeparatorChar = ',';
		public const string FractionMarkerToken = "over";
		public const char NonDecimalSeparatorChar = '.';
		public const string HalfADozenText = "sechs";
		public const string WordSeparatorToken = "und";
		public static readonly string[] WrittenDecimalSeparatorTexts = { "komma" };
		public static readonly string[] WrittenGroupSeparatorTexts = { "punkt" };
		public static readonly string[] WrittenIntegerSeparatorTexts = { "und" };
		public static readonly string[] WrittenFractionSeparatorTexts = { "durch" };
		public const string HalfADozenRegex = @"ein\s+halbes\s+dutzend";
		public static readonly string DigitalNumberRegex = $@"((?<=\b)(hundert|tausend|million(en)?|mio|milliarde(n)?|mrd|billion(en)?|dutzend(e)?)(?=\b))|((?<=(\d|\b)){BaseNumbers.MultiplierLookupRegex}(?=\b))";
		public static readonly Dictionary<string, long> CardinalNumberMap = new Dictionary<string, long>
		{
			{ "ein", 1 },
			{ "null", 0 },
			{ "eine", 1 },
			{ "eins", 1 },
			{ "einer", 1 },
			{ "einen", 1 },
			{ "zwei", 2 },
			{ "zwo", 2 },
			{ "drei", 3 },
			{ "vier", 4 },
			{ "fünf", 5 },
			{ "fuenf", 5 },
			{ "sechs", 6 },
			{ "sieben", 7 },
			{ "acht", 8 },
			{ "neun", 9 },
			{ "zehn", 10 },
			{ "elf", 11 },
			{ "zwölf", 12 },
			{ "zwoelf", 12 },
			{ "dutzend", 12 },
			{ "dreizehn", 13 },
			{ "vierzehn", 14 },
			{ "fünfzehn", 15 },
			{ "fuenfzehn", 15 },
			{ "sechzehn", 16 },
			{ "siebzehn", 17 },
			{ "achtzehn", 18 },
			{ "neunzehn", 19 },
			{ "zwanzig", 20 },
			{ "dreißig", 30 },
			{ "vierzig", 40 },
			{ "fünfzig", 50 },
			{ "fuenfzig", 50 },
			{ "sechzig", 60 },
			{ "siebzig", 70 },
			{ "achtzig", 80 },
			{ "neunzig", 90 },
			{ "hundert", 100 },
			{ "tausend", 1000 },
			{ "million", 1000000 },
			{ "mio", 1000000 },
			{ "millionen", 1000000 },
			{ "milliard", 100000000 },
			{ "milliarde", 1000000000 },
			{ "mrd", 1000000000 },
			{ "milliarden", 1000000000 },
			{ "billion", 1000000000000 },
			{ "billionen", 1000000000000 }
		};
		public static readonly Dictionary<string, long> OrdinalNumberMap = new Dictionary<string, long>
		{
			{ "zuerst", 1 },
			{ "erst", 1 },
			{ "erster", 1 },
			{ "erste", 1 },
			{ "erstes", 1 },
			{ "ersten", 1 },
			{ "zweit", 2 },
			{ "zweiter", 2 },
			{ "zweite", 2 },
			{ "zweites", 2 },
			{ "zweiten", 2 },
			{ "halb", 2 },
			{ "halbe", 2 },
			{ "halbes", 2 },
			{ "hälfte", 2 },
			{ "haelfte", 2 },
			{ "dritt", 3 },
			{ "dritter", 3 },
			{ "dritte", 3 },
			{ "drittes", 3 },
			{ "dritten", 3 },
			{ "drittel", 3 },
			{ "viert", 4 },
			{ "vierter", 4 },
			{ "vierte", 4 },
			{ "viertes", 4 },
			{ "vierten", 4 },
			{ "viertel", 4 },
			{ "fünft", 5 },
			{ "fünfter", 5 },
			{ "fünfte", 5 },
			{ "fünftes", 5 },
			{ "fünften", 5 },
			{ "fuenft", 5 },
			{ "fuenfter", 5 },
			{ "fuenfte", 5 },
			{ "fuenftes", 5 },
			{ "fuenften", 5 },
			{ "fünftel", 5 },
			{ "fuenftel", 5 },
			{ "sechst", 6 },
			{ "sechster", 6 },
			{ "sechste", 6 },
			{ "sechstes", 6 },
			{ "sechsten", 6 },
			{ "sechstel", 6 },
			{ "siebt", 7 },
			{ "siebter", 7 },
			{ "siebte", 7 },
			{ "siebtes", 7 },
			{ "siebten", 7 },
			{ "siebtel", 7 },
			{ "acht", 8 },
			{ "achter", 8 },
			{ "achte", 8 },
			{ "achtes", 8 },
			{ "achten", 8 },
			{ "achtel", 8 },
			{ "neunt", 9 },
			{ "neunter", 9 },
			{ "neunte", 9 },
			{ "neuntes", 9 },
			{ "neunten", 9 },
			{ "neuntel", 9 },
			{ "zehnt", 10 },
			{ "zehnter", 10 },
			{ "zehnte", 10 },
			{ "zehntes", 10 },
			{ "zehnten", 10 },
			{ "zehntel", 10 },
			{ "elft", 11 },
			{ "elfter", 11 },
			{ "elfte", 11 },
			{ "elftes", 11 },
			{ "elften", 11 },
			{ "elftel", 11 },
			{ "zwölft", 12 },
			{ "zwölfter", 12 },
			{ "zwölfte", 12 },
			{ "zwölftes", 12 },
			{ "zwölften", 12 },
			{ "zwoelft", 12 },
			{ "zwoelfter", 12 },
			{ "zwoelfte", 12 },
			{ "zwoelftes", 12 },
			{ "zwoelften", 12 },
			{ "zwölftel", 12 },
			{ "zwoelftel", 12 },
			{ "dreizehnt", 13 },
			{ "dreizehnter", 13 },
			{ "dreizehnte", 13 },
			{ "dreizehntes", 13 },
			{ "dreizehnten", 13 },
			{ "dreizehntel", 13 },
			{ "vierzehnt", 14 },
			{ "vierzehnter", 14 },
			{ "vierzehnte", 14 },
			{ "vierzehntes", 14 },
			{ "vierzehnten", 14 },
			{ "vierzehntel", 14 },
			{ "fünfzehnt", 15 },
			{ "fünfzehnter", 15 },
			{ "fünfzehnte", 15 },
			{ "fünfzehntes", 15 },
			{ "fünfzehnten", 15 },
			{ "fünfzehntel", 15 },
			{ "fuenfzehnt", 15 },
			{ "fuenfzehnter", 15 },
			{ "fuenfzehnte", 15 },
			{ "fuenfzehntes", 15 },
			{ "fuenfzehnten", 15 },
			{ "fuenfzehntel", 15 },
			{ "sechzehnt", 16 },
			{ "sechzehnter", 16 },
			{ "sechzehnte", 16 },
			{ "sechzehntes", 16 },
			{ "sechzehnten", 16 },
			{ "sechzehntel", 16 },
			{ "siebzehnt", 17 },
			{ "siebzehnter", 17 },
			{ "siebzehnte", 17 },
			{ "siebzehntes", 17 },
			{ "siebzehnten", 17 },
			{ "siebzehntel", 17 },
			{ "achtzehnt", 18 },
			{ "achtzehnter", 18 },
			{ "achtzehnte", 18 },
			{ "achtzehntes", 18 },
			{ "achtzehnten", 18 },
			{ "achtzehntel", 18 },
			{ "neunzehnt", 19 },
			{ "neunzehnter", 19 },
			{ "neunzehnte", 19 },
			{ "neunzehntes", 19 },
			{ "neunzehnten", 19 },
			{ "neunzehntel", 19 },
			{ "zwanzigst", 20 },
			{ "zwanzigster", 20 },
			{ "zwanzigste", 20 },
			{ "zwanzigstes", 20 },
			{ "zwanzigsten", 20 },
			{ "zwangtigstel", 20 },
			{ "dreißigst", 30 },
			{ "dreißigster", 30 },
			{ "dreißigste", 30 },
			{ "dreißigstes", 30 },
			{ "dreißigsten", 30 },
			{ "dreißigstel", 30 },
			{ "vierzigst", 40 },
			{ "vierzigster", 40 },
			{ "vierzigste", 40 },
			{ "vierzigstes", 40 },
			{ "vierzigsten", 40 },
			{ "vierzigstel", 40 },
			{ "fünfzigst", 50 },
			{ "fünfzigster", 50 },
			{ "fünfzigste", 50 },
			{ "fünfzigsten", 50 },
			{ "fünfzigstes", 50 },
			{ "fünfzigstel", 50 },
			{ "fuenfzigst", 50 },
			{ "fuenfzigster", 50 },
			{ "fuenfzigste", 50 },
			{ "fuenfzigstes", 50 },
			{ "fuenfzigsten", 50 },
			{ "fuenfzigstel", 50 },
			{ "sechzigst", 60 },
			{ "sechzigster", 60 },
			{ "sechzigste", 60 },
			{ "sechzigstes", 60 },
			{ "sechzigsten", 60 },
			{ "sechzigstel", 60 },
			{ "siebzigst", 70 },
			{ "siebzigster", 70 },
			{ "siebzigste", 70 },
			{ "siebzigstes", 70 },
			{ "siebzigsten", 70 },
			{ "siebzigstel", 70 },
			{ "achtzigst", 80 },
			{ "achtzigster", 80 },
			{ "achtzigste", 80 },
			{ "achtzigstes", 80 },
			{ "achtzigsten", 80 },
			{ "achtzigstel", 80 },
			{ "neunzigst", 90 },
			{ "neunzigster", 90 },
			{ "neunzigste", 90 },
			{ "neunzigstes", 90 },
			{ "neunzigsten", 90 },
			{ "neunzigstel", 90 },
			{ "hundertst", 100 },
			{ "hundertster", 100 },
			{ "hundertste", 100 },
			{ "hundertstes", 100 },
			{ "hundertsten", 100 },
			{ "hundertstel", 100 },
			{ "tausendst", 1000 },
			{ "tausendster", 1000 },
			{ "tausendste", 1000 },
			{ "tausendstes", 1000 },
			{ "tausendsten", 1000 },
			{ "tausendstel", 1000 },
			{ "millionst", 1000000 },
			{ "millionster", 1000000 },
			{ "millionste", 1000000 },
			{ "millionstes", 1000000 },
			{ "millionsten", 1000000 },
			{ "millionstel", 1000000 },
			{ "milliardster", 1000000000 },
			{ "milliardste", 1000000000 },
			{ "milliardstes", 1000000000 },
			{ "milliardsten", 1000000000 },
			{ "milliardstel", 1000000000 },
			{ "billionster", 1000000000000 },
			{ "billionste", 1000000000000 },
			{ "billionstes", 1000000000000 },
			{ "billionsten", 1000000000000 },
			{ "billionstel", 1000000000000 }
		};
		public static readonly Dictionary<string, long> RoundNumberMap = new Dictionary<string, long>
		{
			{ "hundert", 100 },
			{ "tausend", 1000 },
			{ "million", 1000000 },
			{ "millionen", 1000000 },
			{ "mio", 1000000 },
			{ "milliard", 1000000000 },
			{ "milliarde", 1000000000 },
			{ "milliarden", 1000000000 },
			{ "mrd", 1000000000 },
			{ "billion", 1000000000000 },
			{ "billionen", 1000000000000 },
			{ "hundertstel", 100 },
			{ "tausendstel", 1000 },
			{ "millionstel", 1000000 },
			{ "milliardstel", 1000000000 },
			{ "billionstel", 1000000000000 },
			{ "hundredths", 100 },
			{ "dutzend", 12 },
			{ "dutzende", 12 },
			{ "k", 1000 },
			{ "m", 1000000 },
			{ "g", 1000000000 },
			{ "b", 1000000000 },
			{ "t", 1000000000000 }
		};
	}
}