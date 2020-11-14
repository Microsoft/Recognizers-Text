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

from .base_numbers import BaseNumbers
# pylint: disable=line-too-long


class EnglishNumeric:
    LangMarker = 'Eng'
    CompoundNumberLanguage = False
    MultiDecimalSeparatorCulture = True
    RoundNumberIntegerRegex = f'(?:hundred|thousand|million|billion|trillion|lakh|crore)'
    ZeroToNineIntegerRegex = f'(?:three|seven|eight|four|five|zero|nine|one|two|six)'
    TwoToNineIntegerRegex = f'(?:three|seven|eight|four|five|nine|two|six)'
    NegativeNumberTermsRegex = f'(?<negTerm>(minus|negative)\\s+)'
    NegativeNumberSignRegex = f'^{NegativeNumberTermsRegex}.*'
    AnIntRegex = f'(an?)(?=\\s)'
    TenToNineteenIntegerRegex = f'(?:seventeen|thirteen|fourteen|eighteen|nineteen|fifteen|sixteen|eleven|twelve|ten)'
    TensNumberIntegerRegex = f'(?:seventy|twenty|thirty|eighty|ninety|forty|fifty|sixty)'
    SeparaIntRegex = f'(?:(({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\\s+(and\\s+)?|\\s*-\\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex})(\\s+{RoundNumberIntegerRegex})*))|(({AnIntRegex}(\\s+{RoundNumberIntegerRegex})+))'
    AllIntRegex = f'(?:((({TenToNineteenIntegerRegex}|({TensNumberIntegerRegex}(\\s+(and\\s+)?|\\s*-\\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\\s+{RoundNumberIntegerRegex})+)\\s+(and\\s+)?)*{SeparaIntRegex})'
    PlaceHolderPureNumber = f'\\b'
    PlaceHolderDefault = f'\\D|\\b'

    def NumbersWithPlaceHolder(placeholder):
        return f'(((?<!\\d+(\\s*(K|k|MM?|mil|G|T|B|b))?\\s*)-\\s*)|(?<=\\b))\\d+(?!([\\.,]\\d+[a-zA-Z]))(?={placeholder})'
    IndianNumberingSystemRegex = f'(?<=\\b)((?:\\d{{1,2}},(?:\\d{{2}},)*\\d{{3}})(?=\\b))'
    NumbersWithSuffix = f'(((?<!\\d+(\\s*{BaseNumbers.NumberMultiplierRegex})?\\s*)-\\s*)|(?<=\\b))\\d+\\s*{BaseNumbers.NumberMultiplierRegex}(?=\\b)'
    RoundNumberIntegerRegexWithLocks = f'(?<=\\b)\\d+\\s+{RoundNumberIntegerRegex}(?=\\b)'
    NumbersWithDozenSuffix = f'(((?<!\\d+(\\s*{BaseNumbers.NumberMultiplierRegex})?\\s*)-\\s*)|(?<=\\b))\\d+\\s+dozen(s)?(?=\\b)'
    AllIntRegexWithLocks = f'((?<=\\b){AllIntRegex}(?=\\b))'
    AllIntRegexWithDozenSuffixLocks = f'(?<=\\b)(((half\\s+)?a\\s+dozen)|({AllIntRegex}\\s+dozen(s)?))(?=\\b)'
    RoundNumberOrdinalRegex = f'(?:hundredth|thousandth|millionth|billionth|trillionth)'
    NumberOrdinalRegex = f'(?:first|second|third|fourth|fifth|sixth|seventh|eighth|ninth|tenth|eleventh|twelfth|thirteenth|fourteenth|fifteenth|sixteenth|seventeenth|eighteenth|nineteenth|twentieth|thirtieth|fortieth|fiftieth|sixtieth|seventieth|eightieth|ninetieth)'
    RelativeOrdinalRegex = f'(?<relativeOrdinal>(next|previous|current)\\s+one|(the\\s+second|next)\\s+to\\s+last|the\\s+one\\s+before\\s+the\\s+last(\\s+one)?|the\\s+last\\s+but\\s+one|(ante)?penultimate|last|next|previous|current)'
    BasicOrdinalRegex = f'({NumberOrdinalRegex}|{RelativeOrdinalRegex})'
    SuffixBasicOrdinalRegex = f'(?:(((({TensNumberIntegerRegex}(\\s+(and\\s+)?|\\s*-\\s*){ZeroToNineIntegerRegex})|{TensNumberIntegerRegex}|{ZeroToNineIntegerRegex}|{AnIntRegex})(\\s+{RoundNumberIntegerRegex})+)\\s+(and\\s+)?)*({TensNumberIntegerRegex}(\\s+|\\s*-\\s*))?{BasicOrdinalRegex})'
    SuffixRoundNumberOrdinalRegex = f'(?:({AllIntRegex}\\s+){RoundNumberOrdinalRegex})'
    AllOrdinalRegex = f'(?:{SuffixBasicOrdinalRegex}|{SuffixRoundNumberOrdinalRegex})'
    OrdinalSuffixRegex = f'(?<=\\b)(?:(\\d*(1st|2nd|3rd|[4-90]th))|(1[1-2]th))(?=\\b)'
    OrdinalNumericRegex = f'(?<=\\b)(?:\\d{{1,3}}(\\s*,\\s*\\d{{3}})*\\s*th)(?=\\b)'
    OrdinalRoundNumberRegex = f'(?<!an?\\s+){RoundNumberOrdinalRegex}'
    OrdinalEnglishRegex = f'(?<=\\b){AllOrdinalRegex}(?=\\b)'
    FractionNotationWithSpacesRegex = f'(((?<=\\W|^)-\\s*)|(?<=\\b))\\d+\\s+\\d+[/]\\d+(?=(\\b[^/]|$))'
    FractionNotationRegex = f'{BaseNumbers.FractionNotationRegex}'
    RoundMultiplierRegex = f'\\b\\s*((of\\s+)?a\\s+)?(?<multiplier>{RoundNumberIntegerRegex})$'
    FractionNounRegex = f'(?<=\\b)({AllIntRegex}\\s+(and\\s+)?)?(({AllIntRegex})(\\s+|\\s*-\\s*)((({AllOrdinalRegex})|({RoundNumberOrdinalRegex}))s|halves|quarters)((\\s+of\\s+a)?\\s+{RoundNumberIntegerRegex})?|(half(\\s+a)?|quarter(\\s+of\\s+a)?)\\s+{RoundNumberIntegerRegex})(?=\\b)'
    FractionNounWithArticleRegex = f'(?<=\\b)((({AllIntRegex}\\s+(and\\s+)?)?(an?|one)(\\s+|\\s*-\\s*)(?!\\bfirst\\b|\\bsecond\\b)(({AllOrdinalRegex})|({RoundNumberOrdinalRegex})|(half|quarter)(((\\s+of)?\\s+a)?\\s+{RoundNumberIntegerRegex})?))|(half))(?=\\b)'
    FractionPrepositionRegex = f'(?<!{BaseNumbers.CommonCurrencySymbol}\\s*)(?<=\\b)(?<numerator>({AllIntRegex})|((?<![\\.,])\\d+))\\s+(over|(?<ambiguousSeparator>in|out\\s+of))\\s+(?<denominator>({AllIntRegex})|(\\d+)(?![\\.,]))(?=\\b)'
    FractionPrepositionWithinPercentModeRegex = f'(?<!{BaseNumbers.CommonCurrencySymbol}\\s*)(?<=\\b)(?<numerator>({AllIntRegex})|((?<![\\.,])\\d+))\\s+over\\s+(?<denominator>({AllIntRegex})|(\\d+)(?![\\.,]))(?=\\b)'
    AllPointRegex = f'((\\s+{ZeroToNineIntegerRegex})+|(\\s+{SeparaIntRegex}))'
    AllFloatRegex = f'{AllIntRegex}(\\s+point){AllPointRegex}'
    DoubleWithMultiplierRegex = f'(((?<!\\d+(\\s*{BaseNumbers.NumberMultiplierRegex})?\\s*)-\\s*)|((?<=\\b)(?<!\\d+[\\.,])))\\d+[\\.,]\\d+\\s*{BaseNumbers.NumberMultiplierRegex}(?=\\b)'
    DoubleExponentialNotationRegex = f'(((?<!\\d+(\\s*{BaseNumbers.NumberMultiplierRegex})?\\s*)-\\s*)|((?<=\\b)(?<!\\d+[\\.,])))(\\d+([\\.,]\\d+)?)e([+-]*[1-9]\\d*)(?=\\b)'
    DoubleCaretExponentialNotationRegex = f'(((?<!\\d+(\\s*{BaseNumbers.NumberMultiplierRegex})?\\s*)-\\s*)|((?<=\\b)(?<!\\d+[\\.,])))(\\d+([\\.,]\\d+)?)\\^([+-]*[1-9]\\d*)(?=\\b)'

    def DoubleDecimalPointRegex(placeholder):
        return f'(((?<!\\d+(\\s*(K|k|MM?|mil|G|T|B|b))?\\s*)-\\s*)|((?<=\\b)(?<!\\d+[\\.,])))\\d+[\\.,]\\d+(?!([\\.,]\\d+))(?={placeholder})'
    DoubleIndianDecimalPointRegex = f'(?<=\\b)((?:\\d{{1,2}},(?:\\d{{2}},)*\\d{{3}})(?:\\.\\d{{2}})(?=\\b))'

    def DoubleWithoutIntegralRegex(placeholder):
        return f'(?<=\\s|^)(?<!(\\d+))[\\.,]\\d+(?!([\\.,]\\d+))(?={placeholder})'
    DoubleWithRoundNumber = f'(((?<!\\d+(\\s*{BaseNumbers.NumberMultiplierRegex})?\\s*)-\\s*)|((?<=\\b)(?<!\\d+[\\.,])))\\d+[\\.,]\\d+\\s+{RoundNumberIntegerRegex}(?=\\b)'
    DoubleAllFloatRegex = f'((?<=\\b){AllFloatRegex}(?=\\b))'
    ConnectorRegex = f'(?<spacer>and)'
    NumberWithSuffixPercentage = f'(?<!%)({BaseNumbers.NumberReplaceToken})(\\s*)(%(?!{BaseNumbers.NumberReplaceToken})|(per\\s*cents?|percentage|cents?)\\b)'
    FractionNumberWithSuffixPercentage = f'(({BaseNumbers.FractionNumberReplaceToken})\\s+of)'
    NumberWithPrefixPercentage = f'(per\\s*cents?\\s+of)(\\s*)({BaseNumbers.NumberReplaceToken})'
    NumberWithPrepositionPercentage = f'({BaseNumbers.NumberReplaceToken})\\s*(in|out\\s+of)\\s*({BaseNumbers.NumberReplaceToken})'
    TillRegex = f'((?<!\\bequal\\s+)to|through|--|-|—|——|~|–)'
    MoreRegex = f'(?:(bigger|greater|more|higher|larger)(\\s+than)?|above|over|exceed(ed|ing)?|surpass(ed|ing)?|(?<!<|=)>)'
    LessRegex = f'(?:(less|lower|smaller|fewer)(\\s+than)?|below|under|(?<!>|=)<)'
    EqualRegex = f'(equal(s|ing)?(\\s+(to|than))?|(?<!<|>)=)'
    MoreOrEqualPrefix = f'((no\\s+{LessRegex})|(at\\s+least))'
    MoreOrEqual = f'(?:({MoreRegex}\\s+(or)?\\s+{EqualRegex})|({EqualRegex}\\s+(or)?\\s+{MoreRegex})|{MoreOrEqualPrefix}(\\s+(or)?\\s+{EqualRegex})?|({EqualRegex}\\s+(or)?\\s+)?{MoreOrEqualPrefix}|>\\s*=|≥)'
    MoreOrEqualSuffix = f'((and|or)\\s+(((more|greater|higher|larger|bigger)((?!\\s+than)|(\\s+than(?!((\\s+or\\s+equal\\s+to)?\\s*\\d+)))))|((over|above)(?!\\s+than))))'
    LessOrEqualPrefix = f'((no\\s+{MoreRegex})|(at\\s+most)|(up\\s+to))'
    LessOrEqual = f'(({LessRegex}\\s+(or)?\\s+{EqualRegex})|({EqualRegex}\\s+(or)?\\s+{LessRegex})|{LessOrEqualPrefix}(\\s+(or)?\\s+{EqualRegex})?|({EqualRegex}\\s+(or)?\\s+)?{LessOrEqualPrefix}|<\\s*=|≤)'
    LessOrEqualSuffix = f'((and|or)\\s+(less|lower|smaller|fewer)((?!\\s+than)|(\\s+than(?!(\\s*\\d+)))))'
    NumberSplitMark = f'(?![,.](?!\\d+))(?!\\s*\\b(and\\s+({LessRegex}|{MoreRegex})|but|or|to)\\b)'
    MoreRegexNoNumberSucceed = f'((bigger|greater|more|higher|larger)((?!\\s+than)|\\s+(than(?!(\\s*\\d+))))|(above|over)(?!(\\s*\\d+)))'
    LessRegexNoNumberSucceed = f'((less|lower|smaller|fewer)((?!\\s+than)|\\s+(than(?!(\\s*\\d+))))|(below|under)(?!(\\s*\\d+)))'
    EqualRegexNoNumberSucceed = f'(equal(s|ing)?((?!\\s+(to|than))|(\\s+(to|than)(?!(\\s*\\d+)))))'
    OneNumberRangeMoreRegex1 = f'({MoreOrEqual}|{MoreRegex})\\s*(the\\s+)?(?<number1>({NumberSplitMark}.)+)'
    OneNumberRangeMoreRegex1LB = f'(?<!no\\s+){OneNumberRangeMoreRegex1}'
    OneNumberRangeMoreRegex2 = f'(?<number1>({NumberSplitMark}.)+)\\s*{MoreOrEqualSuffix}'
    OneNumberRangeMoreSeparateRegex = f'({EqualRegex}\\s+(?<number1>({NumberSplitMark}.)+)(\\s+or\\s+){MoreRegexNoNumberSucceed})|({MoreRegex}\\s+(?<number1>({NumberSplitMark}.)+)(\\s+or\\s+){EqualRegexNoNumberSucceed})'
    OneNumberRangeLessRegex1 = f'({LessOrEqual}|{LessRegex})\\s*(the\\s+)?(?<number2>({NumberSplitMark}.)+)'
    OneNumberRangeLessRegex1LB = f'(?<!no\\s+){OneNumberRangeLessRegex1}'
    OneNumberRangeLessRegex2 = f'(?<number2>({NumberSplitMark}.)+)\\s*{LessOrEqualSuffix}'
    OneNumberRangeLessSeparateRegex = f'({EqualRegex}\\s+(?<number1>({NumberSplitMark}.)+)(\\s+or\\s+){LessRegexNoNumberSucceed})|({LessRegex}\\s+(?<number1>({NumberSplitMark}.)+)(\\s+or\\s+){EqualRegexNoNumberSucceed})'
    OneNumberRangeEqualRegex = f'(?<!\\bthan\\s+or\\s+){EqualRegex}\\s*(the\\s+)?(?<number1>({NumberSplitMark}.)+)'
    TwoNumberRangeRegex1 = f'between\\s*(the\\s+)?(?<number1>({NumberSplitMark}.)+)\\s*and\\s*(the\\s+)?(?<number2>({NumberSplitMark}.)+)'
    TwoNumberRangeRegex2 = f'({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})\\s*(and|but|,)\\s*({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})'
    TwoNumberRangeRegex3 = f'({OneNumberRangeLessRegex1}|{OneNumberRangeLessRegex2})\\s*(and|but|,)\\s*({OneNumberRangeMoreRegex1}|{OneNumberRangeMoreRegex2})'
    TwoNumberRangeRegex4 = f'(from\\s+)?(?<number1>({NumberSplitMark}(?!\\bfrom\\b).)+)\\s*{TillRegex}\\s*(the\\s+)?(?<number2>({NumberSplitMark}.)+)'
    AmbiguousFractionConnectorsRegex = f'(\\bin\\b)'
    DecimalSeparatorChar = '.'
    FractionMarkerToken = 'over'
    NonDecimalSeparatorChar = ','
    HalfADozenText = 'six'
    WordSeparatorToken = 'and'
    WrittenDecimalSeparatorTexts = [r'point']
    WrittenGroupSeparatorTexts = [r'punto']
    WrittenIntegerSeparatorTexts = [r'and']
    WrittenFractionSeparatorTexts = [r'and']
    HalfADozenRegex = f'half\\s+a\\s+dozen'
    DigitalNumberRegex = f'((?<=\\b)(hundred|thousand|[mb]illion|trillion|lakh|crore|dozen(s)?)(?=\\b))|((?<=(\\d|\\b)){BaseNumbers.MultiplierLookupRegex}(?=\\b))'
    CardinalNumberMap = dict([("a", 1),
                              ("zero", 0),
                              ("an", 1),
                              ("one", 1),
                              ("two", 2),
                              ("three", 3),
                              ("four", 4),
                              ("five", 5),
                              ("six", 6),
                              ("seven", 7),
                              ("eight", 8),
                              ("nine", 9),
                              ("ten", 10),
                              ("eleven", 11),
                              ("twelve", 12),
                              ("dozen", 12),
                              ("dozens", 12),
                              ("thirteen", 13),
                              ("fourteen", 14),
                              ("fifteen", 15),
                              ("sixteen", 16),
                              ("seventeen", 17),
                              ("eighteen", 18),
                              ("nineteen", 19),
                              ("twenty", 20),
                              ("thirty", 30),
                              ("forty", 40),
                              ("fifty", 50),
                              ("sixty", 60),
                              ("seventy", 70),
                              ("eighty", 80),
                              ("ninety", 90),
                              ("hundred", 100),
                              ("thousand", 1000),
                              ("million", 1000000),
                              ("billion", 1000000000),
                              ("trillion", 1000000000000),
                              ("lakh", 100000),
                              ("crore", 10000000)])
    OrdinalNumberMap = dict([("first", 1),
                             ("second", 2),
                             ("secondary", 2),
                             ("half", 2),
                             ("third", 3),
                             ("fourth", 4),
                             ("quarter", 4),
                             ("fifth", 5),
                             ("sixth", 6),
                             ("seventh", 7),
                             ("eighth", 8),
                             ("ninth", 9),
                             ("tenth", 10),
                             ("eleventh", 11),
                             ("twelfth", 12),
                             ("thirteenth", 13),
                             ("fourteenth", 14),
                             ("fifteenth", 15),
                             ("sixteenth", 16),
                             ("seventeenth", 17),
                             ("eighteenth", 18),
                             ("nineteenth", 19),
                             ("twentieth", 20),
                             ("thirtieth", 30),
                             ("fortieth", 40),
                             ("fiftieth", 50),
                             ("sixtieth", 60),
                             ("seventieth", 70),
                             ("eightieth", 80),
                             ("ninetieth", 90),
                             ("hundredth", 100),
                             ("thousandth", 1000),
                             ("millionth", 1000000),
                             ("billionth", 1000000000),
                             ("trillionth", 1000000000000),
                             ("firsts", 1),
                             ("halves", 2),
                             ("thirds", 3),
                             ("fourths", 4),
                             ("quarters", 4),
                             ("fifths", 5),
                             ("sixths", 6),
                             ("sevenths", 7),
                             ("eighths", 8),
                             ("ninths", 9),
                             ("tenths", 10),
                             ("elevenths", 11),
                             ("twelfths", 12),
                             ("thirteenths", 13),
                             ("fourteenths", 14),
                             ("fifteenths", 15),
                             ("sixteenths", 16),
                             ("seventeenths", 17),
                             ("eighteenths", 18),
                             ("nineteenths", 19),
                             ("twentieths", 20),
                             ("thirtieths", 30),
                             ("fortieths", 40),
                             ("fiftieths", 50),
                             ("sixtieths", 60),
                             ("seventieths", 70),
                             ("eightieths", 80),
                             ("ninetieths", 90),
                             ("hundredths", 100),
                             ("thousandths", 1000),
                             ("millionths", 1000000),
                             ("billionths", 1000000000),
                             ("trillionths", 1000000000000)])
    RoundNumberMap = dict([("hundred", 100),
                           ("thousand", 1000),
                           ("million", 1000000),
                           ("billion", 1000000000),
                           ("trillion", 1000000000000),
                           ("lakh", 100000),
                           ("crore", 10000000),
                           ("hundredth", 100),
                           ("thousandth", 1000),
                           ("millionth", 1000000),
                           ("billionth", 1000000000),
                           ("trillionth", 1000000000000),
                           ("hundredths", 100),
                           ("thousandths", 1000),
                           ("millionths", 1000000),
                           ("billionths", 1000000000),
                           ("trillionths", 1000000000000),
                           ("dozen", 12),
                           ("dozens", 12),
                           ("k", 1000),
                           ("m", 1000000),
                           ("mm", 1000000),
                           ("mil", 1000000),
                           ("g", 1000000000),
                           ("b", 1000000000),
                           ("t", 1000000000000)])
    AmbiguityFiltersDict = dict([("\\bone\\b", "\\b(the|this|that|which)\\s+(one)\\b")])
    RelativeReferenceOffsetMap = dict([("last", "0"),
                                       ("next one", "1"),
                                       ("current", "0"),
                                       ("current one", "0"),
                                       ("previous one", "-1"),
                                       ("the second to last", "-1"),
                                       ("the one before the last one", "-1"),
                                       ("the one before the last", "-1"),
                                       ("next to last", "-1"),
                                       ("penultimate", "-1"),
                                       ("the last but one", "-1"),
                                       ("antepenultimate", "-2"),
                                       ("next", "1"),
                                       ("previous", "-1")])
    RelativeReferenceRelativeToMap = dict([("last", "end"),
                                           ("next one", "current"),
                                           ("previous one", "current"),
                                           ("current", "current"),
                                           ("current one", "current"),
                                           ("the second to last", "end"),
                                           ("the one before the last one", "end"),
                                           ("the one before the last", "end"),
                                           ("next to last", "end"),
                                           ("penultimate", "end"),
                                           ("the last but one", "end"),
                                           ("antepenultimate", "end"),
                                           ("next", "current"),
                                           ("previous", "current")])
# pylint: enable=line-too-long
