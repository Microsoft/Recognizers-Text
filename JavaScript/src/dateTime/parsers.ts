import { EnglishTimeExtractorConfiguration } from "./english/extractorConfiguration";
import { IParser, ParseResult } from "../number/parsers";
import { ExtractResult, IExtractor } from "../number/extractors";
import { IDateTimeUtilityConfiguration } from "./utilities"
import { BaseDateTime } from "../resources/baseDateTime";
import { Constants, TimeTypeConstants } from "./constants";
import { FormatUtil, DateTimeResolutionResult, DateUtils, MatchingUtil } from "./utilities";
import { RegExpUtility, Match, isNullOrEmpty } from "../utilities";

export class DateTimeParseResult extends ParseResult {
    // TimexStr is only used in extractors related with date and time
    // It will output the TIMEX representation of a time string.
    timexStr: string
}

export interface IDateTimeParser extends IParser {
    parse(extResult: ExtractResult, referenceDate?: Date): DateTimeParseResult | null;
}

export interface ICommonDateTimeParserConfiguration {
    cardinalExtractor: IExtractor;
    integerExtractor: IExtractor;
    ordinalExtractor: IExtractor;
    numberParser: IParser;
    dateExtractor: IExtractor;
    timeExtractor: IExtractor;
    dateTimeExtractor: IExtractor;
    durationExtractor: IExtractor;
    datePeriodExtractor: IExtractor;
    timePeriodExtractor: IExtractor;
    dateTimePeriodExtractor: IExtractor;
    dateParser: IDateTimeParser;
    timeParser: IDateTimeParser;
    dateTimeParser: IDateTimeParser;
    durationParser: IDateTimeParser;
    datePeriodParser: IDateTimeParser;
    timePeriodParser: IDateTimeParser;
    dateTimePeriodParser: IDateTimeParser;
    monthOfYear: ReadonlyMap<string, number>;
    numbers: ReadonlyMap<string, number>;
    unitValueMap: ReadonlyMap<string, number>;
    seasonMap: ReadonlyMap<string, string>;
    unitMap: ReadonlyMap<string, string>;
    cardinalMap: ReadonlyMap<string, number>;
    dayOfMonth: ReadonlyMap<string, number>;
    dayOfWeek: ReadonlyMap<string, number>;
    doubleNumbers: ReadonlyMap<string, number>;
    utilityConfiguration: IDateTimeUtilityConfiguration;
}

export abstract class BaseDateParserConfiguration implements ICommonDateTimeParserConfiguration {
    cardinalExtractor: IExtractor;
    integerExtractor: IExtractor;
    ordinalExtractor: IExtractor;
    numberParser: IParser;
    dateExtractor: IExtractor;
    timeExtractor: IExtractor;
    dateTimeExtractor: IExtractor;
    durationExtractor: IExtractor;
    datePeriodExtractor: IExtractor;
    timePeriodExtractor: IExtractor;
    dateTimePeriodExtractor: IExtractor;
    dateParser: IDateTimeParser;
    timeParser: IDateTimeParser;
    dateTimeParser: IDateTimeParser;
    durationParser: IDateTimeParser;
    datePeriodParser: IDateTimeParser;
    timePeriodParser: IDateTimeParser;
    dateTimePeriodParser: IDateTimeParser;
    monthOfYear: ReadonlyMap<string, number>;
    numbers: ReadonlyMap<string, number>;
    unitValueMap: ReadonlyMap<string, number>;
    seasonMap: ReadonlyMap<string, string>;
    unitMap: ReadonlyMap<string, string>;
    cardinalMap: ReadonlyMap<string, number>;
    dayOfMonth: ReadonlyMap<string, number>;
    dayOfWeek: ReadonlyMap<string, number>;
    doubleNumbers: ReadonlyMap<string, number>;
    utilityConfiguration: IDateTimeUtilityConfiguration;

    constructor() {
        this.dayOfMonth = BaseDateTime.DayOfMonthDictionary;
    }
}

export interface ITimeParserConfiguration {
    timeTokenPrefix: string;
    atRegex: RegExp
    timeRegexes: RegExp[];
    numbers: ReadonlyMap<string, number>;
    adjustByPrefix(prefix: string, adjust: { hour: number, min: number, hasMin: boolean });
    adjustBySuffix(suffix: string, adjust: { hour: number, min: number, hasMin: boolean, hasAm: boolean, hasPm: boolean });
}

export interface IDateParserConfiguration {
    ordinalExtractor: IExtractor
    integerExtractor: IExtractor
    cardinalExtractor: IExtractor
    durationExtractor: IExtractor
    numberParser: IParser
    monthOfYear: ReadonlyMap<string, number>
    dayOfMonth: ReadonlyMap<string, number>
    dayOfWeek: ReadonlyMap<string, number>
    unitMap: ReadonlyMap<string, string>
    cardinalMap: ReadonlyMap<string, number>
    dateRegex: RegExp[]
    onRegex: RegExp
    specialDayRegex: RegExp
    nextRegex: RegExp
    unitRegex: RegExp
    monthRegex: RegExp
    strictWeekDay: RegExp
    lastRegex: RegExp
    thisRegex: RegExp
    weekDayOfMonthRegex: RegExp
    utilityConfiguration: IDateTimeUtilityConfiguration
    dateTokenPrefix: string
    getSwiftDay(source: string): number
    getSwiftMonth(source: string): number
    isCardinalLast(source: string): boolean
}

export class BaseTimeParser implements IDateTimeParser {
    readonly ParserName = Constants.SYS_DATETIME_TIME; //"Time";
    readonly config: ITimeParserConfiguration;

    constructor(configuration: ITimeParserConfiguration) {
        this.config = configuration;
    }

    public parse(er: ExtractResult, referenceTime?: Date): DateTimeParseResult | null {
        if (!referenceTime) referenceTime = new Date();
        let value = null;
        if (er.type == this.ParserName) {
            let innerResult = this.internalParse(er.text, referenceTime);
            if (innerResult.success) {
                innerResult.futureResolution = new Map<string, string>(
                    [
                        [TimeTypeConstants.TIME, FormatUtil.formatTime(innerResult.futureValue)]
                    ]);

                innerResult.pastResolution = new Map<string, string>(
                    [
                        [TimeTypeConstants.TIME, FormatUtil.formatTime(innerResult.pastValue)]
                    ]);

                value = innerResult;
            }
        }

        let ret = new DateTimeParseResult(er);
        ret.value = value,
            ret.timexStr = value == null ? "" : value.timex,
            ret.resolutionStr = ""

        return ret;
    }

    internalParse(text: string, referenceTime: Date): DateTimeResolutionResult {
        let innerResult = this.parseBasicRegexMatch(text, referenceTime);
        return innerResult;
    }

    // parse basic patterns in TimeRegexList
    private parseBasicRegexMatch(text: string, referenceTime: Date): DateTimeResolutionResult {
        let trimedText = text.trim().toLowerCase();
        let offset = 0;

        let matches = RegExpUtility.getMatches(this.config.atRegex, trimedText);
        if (matches.length == 0) {
            matches = RegExpUtility.getMatches(this.config.atRegex, this.config.timeTokenPrefix + trimedText);
            offset = this.config.timeTokenPrefix.length;
        }

        if (matches.length > 0 && matches[0].index == offset && matches[0].length == trimedText.length) {
            return this.match2Time(matches[0], referenceTime);
        }

        for (let regex of this.config.timeRegexes) {
            offset = 0;
            matches = RegExpUtility.getMatches(regex, trimedText);

            if (matches.length && matches[0].index == offset && matches[0].length == trimedText.length) {
                return this.match2Time(matches[0], referenceTime);
            }
        }

        return new DateTimeResolutionResult();
    }

    private match2Time(match: Match, referenceTime: Date): DateTimeResolutionResult {
        let ret = new DateTimeResolutionResult();
        let hour = 0,
            min = 0,
            second = 0,
            day = referenceTime.getDate(),
            month = referenceTime.getMonth(),
            year = referenceTime.getFullYear();
        let hasMin = false, hasSec = false, hasAm = false, hasPm = false, hasMid = false;

        let engTimeStr = match.groups["engtime"] ? match.groups["engtime"].value : null;
        if (engTimeStr) {
            // get hour
            let hourStr = match.groups["hournum"].value ? match.groups["hournum"].value.toLowerCase() : null;
            hour = this.config.numbers.get(hourStr);

            // get minute
            let minStr = match.groups["minnum"] ? match.groups["minnum"].value : null;
            let tensStr = match.groups["tens"] ? match.groups["tens"].value : null;

            if (minStr) {
                min = this.config.numbers.get(minStr);
                if (tensStr) {
                    min += this.config.numbers.get(tensStr) || 0;
                }
                hasMin = true;
            }
        }
        else if (match.groups["mid"]) {
            hasMid = true;
            if (match.groups["midnight"]) {
                hour = 0;
                min = 0;
                second = 0;
            }
            else if (match.groups["midmorning"]) {
                hour = 10;
                min = 0;
                second = 0;
            }
            else if (match.groups["midafternoon"]) {
                hour = 14;
                min = 0;
                second = 0;
            }
            else if (match.groups["midday"]) {
                hour = 12;
                min = 0;
                second = 0;
            }
        }
        else {
            // get hour
            let hourStr = match.groups["hour"] ? match.groups["hour"].value : null;
            if (!hourStr) {
                hourStr = match.groups["hournum"] ? match.groups["hournum"].value.toLowerCase() : null;
                hour = this.config.numbers.get(hourStr);
                if (!hour) {
                    return ret;
                }
            }
            else {
                hour = parseInt(hourStr);
            }

            // get minute
            let minStr = match.groups["min"] ? match.groups["min"].value.toLowerCase() : null;
            if (!minStr) {
                minStr = match.groups["minnum"] ? match.groups["minnum"].value : null;
                if (minStr) {
                    min = this.config.numbers.get(minStr);
                    hasMin = true;
                }

                let tensStr = match.groups["tens"] ? match.groups["tens"].value : null;
                if (tensStr) {
                    min += this.config.numbers.get(tensStr);
                    hasMin = true;
                }
            }
            else {
                min = parseInt(minStr);
                hasMin = true;
            }

            // get second
            let secStr = match.groups["sec"] ? match.groups["sec"].value.toLowerCase() : null;
            if (secStr) {
                second = parseInt(secStr);
                hasSec = true;
            }
        }

        //adjust by desc string
        let descStr = match.groups["desc"] ? match.groups["desc"].value.toLowerCase() : null;
        if (descStr) {
            if (descStr.toLowerCase().startsWith("a")) {
                if (hour >= 12) {
                    hour -= 12;
                }
                hasAm = true;
            }
            else if (descStr.toLowerCase().startsWith("p")) {
                if (hour < 12) {
                    hour += 12;
                }
                hasPm = true;
            }
        }

        // adjust min by prefix
        let timePrefix = match.groups["prefix"] ? match.groups["prefix"].value.toLowerCase() : null;
        if (timePrefix) {
            let adjust = { hour: hour, min: min, hasMin: hasMin };
            this.config.adjustByPrefix(timePrefix, adjust);
            hour = adjust.hour; min = adjust.min; hasMin = adjust.hasMin;
        }

        // adjust hour by suffix
        let timeSuffix = match.groups["suffix"] ? match.groups["suffix"].value.toLowerCase() : null;
        if (timeSuffix) {
            let adjust = { hour: hour, min: min, hasMin: hasMin, hasAm: hasAm, hasPm: hasPm };
            this.config.adjustBySuffix(timeSuffix, adjust);
            hour = adjust.hour; min = adjust.min; hasMin = adjust.hasMin; hasAm = adjust.hasAm; hasPm = adjust.hasPm;
        }

        if (hour == 24) {
            hour = 0;
        }

        ret.timex = "T" + FormatUtil.toString(hour, 2);
        if (hasMin) {
            ret.timex += ":" + FormatUtil.toString(min, 2);
        }

        if (hasSec) {
            ret.timex += ":" + FormatUtil.toString(second, 2);
        }

        if (hour <= 12 && !hasPm && !hasAm) {
            ret.comment = "ampm";
        }

        ret.futureValue = ret.pastValue = new Date(year, month, day, hour, min, second);
        ret.success = true;

        return ret;
    }
}

export interface ITimePeriodParserConfiguration {
    timeExtractor: IExtractor;
    timeParser: IDateTimeParser;
    pureNumberFromToRegex: RegExp;
    pureNumberBetweenAndRegex: RegExp;
    timeOfDayRegex: RegExp;
    numbers: ReadonlyMap<string, number>;
    utilityConfiguration: IDateTimeUtilityConfiguration;
    getMatchedTimexRange(text: string): {
        matched: boolean, timex: string, beginHour: number, endHour: number, endMin: number
    };
}

export class BaseTimePeriodParser implements IDateTimeParser {
    public static readonly ParserName = Constants.SYS_DATETIME_TIMEPERIOD; //"TimePeriod";

    private readonly config: ITimePeriodParserConfiguration;

    constructor(configuration: ITimePeriodParserConfiguration) {
        this.config = configuration;
    }

    public parse(er: ExtractResult, refTime?: Date): DateTimeParseResult {
        let referenceTime = refTime || new Date();
        let value = null;
        if (er.type == BaseTimePeriodParser.ParserName) {
            let innerResult = this.parseSimpleCases(er.text, referenceTime);
            if (!innerResult.success) {
                innerResult = this.mergeTwoTimePoints(er.text, referenceTime);
            }

            if (!innerResult.success) {
                innerResult = this.parseNight(er.text, referenceTime);
            }

            if (innerResult.success) {
                innerResult.futureResolution = new Map<string, string>(
                    [
                        [
                            TimeTypeConstants.START_TIME,
                            FormatUtil.formatTime(innerResult.futureValue.item1)
                        ],
                        [
                            TimeTypeConstants.END_TIME,
                            FormatUtil.formatTime(innerResult.futureValue.item2)
                        ]
                    ]);

                innerResult.pastResolution = new Map<string, string>(
                    [
                        [
                            TimeTypeConstants.START_TIME,
                            FormatUtil.formatTime(innerResult.pastValue.item1)
                        ],
                        [
                            TimeTypeConstants.END_TIME,
                            FormatUtil.formatTime(innerResult.pastValue.item2)
                        ]
                    ]);

                value = innerResult;
            }
        }

        let ret = new DateTimeParseResult(er);
        ret.value = value;
        ret.timexStr = value == null ? "" : value.timex;
        ret.resolutionStr = "";

        return ret;
    }

    private parseSimpleCases(text: string, referenceTime: Date): DateTimeResolutionResult {
        let ret = new DateTimeResolutionResult();
        let year = referenceTime.getFullYear(), month = referenceTime.getMonth(), day = referenceTime.getDate();
        let trimedText = text.trim().toLowerCase();

        let matches = RegExpUtility.getMatches(this.config.pureNumberFromToRegex, trimedText);
        if (!matches.length) {
            matches = RegExpUtility.getMatches(this.config.pureNumberBetweenAndRegex, trimedText);
        }

        if (matches.length && matches[0].index == 0) {
            // this "from .. to .." pattern is valid if followed by a Date OR "pm"
            let isValid = false;

            // get hours
            let hourGroup = matches[0].groups["hour"];
            let hourStr = hourGroup.captures[0];

            let beginHour = this.config.numbers.get(hourStr);
            if (!beginHour) {
                beginHour = parseInt(hourStr);
            }

            hourStr = hourGroup.captures[1];

            let endHour = this.config.numbers.get(hourStr);
            if (!endHour) {
                endHour = parseInt(hourStr);
            }

            // parse "pm" 
            let leftDesc = matches[0].groups["leftDesc"];
            let rightDesc = matches[0].groups["rightDesc"];
            let pmStr = matches[0].groups["pm"];
            let amStr = matches[0].groups["am"];
            let descStr = matches[0].groups["desc"];
            // The "ampm" only occurs in time, don't have to consider it here
            if (!leftDesc) {
                let rightAmValid = (rightDesc) &&
                    RegExpUtility.getMatches(this.config.utilityConfiguration.amDescRegex, rightDesc.value.toLowerCase()).length;
                let rightPmValid = (rightDesc) &&
                    RegExpUtility.getMatches(this.config.utilityConfiguration.pmDescRegex, rightDesc.value.toLowerCase()).length;
                if (amStr || rightAmValid) {

                    if (beginHour >= 12) {
                        beginHour -= 12;
                    }
                    if (endHour >= 12) {
                        endHour -= 12;
                    }
                    isValid = true;
                }
                else if (pmStr || rightPmValid) {
                    if (beginHour < 12) {
                        beginHour += 12;
                    }
                    if (endHour < 12) {
                        endHour += 12;
                    }
                    isValid = true;
                }
            }

            if (isValid) {
                let beginStr = "T" + FormatUtil.toString(beginHour, 2);
                let endStr = "T" + FormatUtil.toString(endHour, 2);

                ret.timex = `(${beginStr},${endStr},PT${endHour - beginHour}H)`;

                ret.futureValue = ret.pastValue = {
                    item1: new Date(year, month, day, beginHour, 0, 0),
                    item2: new Date(year, month, day, endHour, 0, 0)
                };

                ret.success = true;

                return ret;
            }
        }
        return ret;
    }

    private mergeTwoTimePoints(text: string, referenceTime: Date): DateTimeResolutionResult {
        let ret = new DateTimeResolutionResult();
        let ers = this.config.timeExtractor.extract(text);
        let pr1: DateTimeParseResult = null;
        let pr2: DateTimeParseResult = null;
        if (ers.length != 2) {
            return ret;
        }

        pr1 = this.config.timeParser.parse(ers[0], referenceTime);
        pr2 = this.config.timeParser.parse(ers[1], referenceTime);

        if (pr1.value == null || pr2.value == null) {
            return ret;
        }

        let beginTime: Date = pr1.value.futureValue;
        let endTime: Date = pr2.value.futureValue;

        ret.timex = `(${pr1.timexStr},${pr2.timexStr},PT${new Date(endTime.getTime() - beginTime.getTime()).getUTCHours()}H)`;
        ret.futureValue = ret.pastValue = { item1: beginTime, item2: endTime };
        ret.success = true;

        let ampmStr1 = pr1.value.comment;
        let ampmStr2 = pr2.value.comment;
        if (ampmStr1 && ampmStr1.endsWith("ampm") && ampmStr2 && ampmStr2.endsWith("ampm")) {
            ret.comment = "ampm";
        }

        return ret;
    }

    // parse "morning", "afternoon", "night"
    private parseNight(text: string, referenceTime: Date): DateTimeResolutionResult {
        let day = referenceTime.getDate(),
            month = referenceTime.getMonth(),
            year = referenceTime.getFullYear();
        let ret = new DateTimeResolutionResult();

        // extract early/late prefix from text
        let matches = RegExpUtility.getMatches(this.config.timeOfDayRegex, text);
        let hasEarly = false, hasLate = false;
        if (matches.length) {
            if (matches[0].groups["early"]) {
                let early = matches[0].groups["early"].value;
                text = text.replace(early, "");
                hasEarly = true;
                ret.comment = "early";
            }
            if (!hasEarly && matches[0].groups["late"] && matches[0].groups["late"].value) {
                let late = matches[0].groups["late"].value;
                text = text.replace(late, "");
                hasLate = true;
                ret.comment = "late";
            }
        }

        let timexRange = this.config.getMatchedTimexRange(text);
        if (!timexRange.matched) {
            return new DateTimeResolutionResult();
        }

        // modify time period if "early" or "late" is existed
        if (hasEarly) {
            timexRange.endHour = timexRange.beginHour + 2;
            // handling case: night end with 23:59
            if (timexRange.endMin == 59) {
                timexRange.endMin = 0;
            }
        }
        else if (hasLate) {
            timexRange.beginHour = timexRange.beginHour + 2;
        }

        ret.timex = timexRange.timex;

        ret.futureValue = ret.pastValue = {
            item1: new Date(year, month, day, timexRange.beginHour, 0, 0),
            item2: new Date(year, month, day, timexRange.endHour, timexRange.endMin, timexRange.endMin)
        };

        ret.success = true;

        return ret;
    }
}

export class BaseDateParser implements IDateTimeParser {
    private readonly parserName = Constants.SYS_DATETIME_DATE;

    private readonly config: IDateParserConfiguration;

    constructor(config: IDateParserConfiguration) {
        this.config = config;
    }

    parse(extractorResult: ExtractResult, referenceDate?: Date): DateTimeParseResult | null {
        if (!referenceDate) referenceDate = new Date();
        let resultValue;
        if (extractorResult.type === this.parserName) {
            let source = extractorResult.text.toLowerCase();
            let innerResult = this.parseBasicRegexMatch(source, referenceDate);
            if (!innerResult.success) {
                innerResult = this.parseImplicitDate(source, referenceDate);
            }
            if (!innerResult.success) {
                innerResult = this.parseWeekdayOfMonth(source, referenceDate);
            }
            if (!innerResult.success) {
                innerResult = this.parseNumberWithMonth(source, referenceDate);
            }
            if (!innerResult.success) {
                innerResult = this.parserDurationWithAgoAndLater(source, referenceDate);
            }
            if (innerResult.success) {
                innerResult.futureResolution = new Map<string, string>()
                    .set(TimeTypeConstants.DATE, FormatUtil.formatDate(innerResult.futureValue));
                innerResult.pastResolution = new Map<string, string>()
                    .set(TimeTypeConstants.DATE, FormatUtil.formatDate(innerResult.pastValue));
                resultValue = innerResult;
            }
        }
        let result = new DateTimeParseResult(extractorResult);
        result.value = resultValue;
        result.timexStr = resultValue ? resultValue.timex : '';
        result.resolutionStr = '';

        return result;
    }

    private parseBasicRegexMatch(source: string, referenceDate: Date): DateTimeResolutionResult {
        let trimmerSource = source.trim();
        let result = new DateTimeResolutionResult();
        this.config.dateRegex.some(regex => {
            let offset = 0;
            let match = RegExpUtility.getMatches(regex, trimmerSource).pop();
            if (!match) {
                match = RegExpUtility.getMatches(regex, this.config.dateTokenPrefix + trimmerSource).pop();
                offset = this.config.dateTokenPrefix.length;
            }
            if (match && match.index === offset && match.length === trimmerSource.length) {
                result = this.matchToDate(match, referenceDate);
                return true;
            }
        });
        return result;
    }

    private parseImplicitDate(source: string, referenceDate: Date): DateTimeResolutionResult {
        let trimedSource = source.trim();
        let result = new DateTimeResolutionResult();
        // handle "on 12"
        let match = RegExpUtility.getMatches(this.config.onRegex, this.config.dateTokenPrefix + trimedSource).pop();
        if (match && match.index === this.config.dateTokenPrefix.length && match.length === trimedSource.length) {
            let day = 0;
            let month = referenceDate.getMonth();
            let year = referenceDate.getFullYear();
            let dayStr = match.groups['day'].value;
            day = this.config.dayOfMonth.get(dayStr);
            result.timex = FormatUtil.luisDate(-1, -1, day);
            let futureDate = new Date(year, month + 1, day);
            let pastDate = new Date(year, month - 1, day);
            let guessedDate = new Date(year, month, day);
            if (guessedDate) {
                if (guessedDate >= referenceDate) {
                    futureDate = guessedDate;
                }
                if (guessedDate < referenceDate) {
                    pastDate = guessedDate;
                }
            }
            result.futureValue = futureDate;
            result.pastValue = pastDate;
            result.success = true;
            return result;
        }

        // handle "today", "the day before yesterday"
        match = RegExpUtility.getMatches(this.config.specialDayRegex, trimedSource).pop();
        if (match && match.index === 0 && match.length === trimedSource.length) {
            let swift = this.config.getSwiftDay(match.value);
            let value = new Date(referenceDate.getFullYear(), referenceDate.getMonth(), referenceDate.getDate() + swift);
            result.timex = FormatUtil.luisDateFromDate(value);
            result.futureValue = value;
            result.pastValue = value;
            result.success = true;
            return result;
        }

        // handle "next Sunday"
        match = RegExpUtility.getMatches(this.config.nextRegex, trimedSource).pop();
        if (match && match.index === 0 && match.length === trimedSource.length) {
            let weekdayStr = match.groups['weekday'].value;
            let value = DateUtils.next(referenceDate, this.config.dayOfWeek.get(weekdayStr));

            result.timex = FormatUtil.luisDateFromDate(value);
            result.futureValue = value;
            result.pastValue = value;
            result.success = true;
            return result;
        }

        // handle "this Friday"
        match = RegExpUtility.getMatches(this.config.thisRegex, trimedSource).pop();
        if (match && match.index === 0 && match.length === trimedSource.length) {
            let weekdayStr = match.groups['weekday'].value;
            let value = DateUtils.this(referenceDate, this.config.dayOfWeek.get(weekdayStr));

            result.timex = FormatUtil.luisDateFromDate(value);
            result.futureValue = value;
            result.pastValue = value;
            result.success = true;
            return result;
        }

        // handle "last Friday", "last mon"
        match = RegExpUtility.getMatches(this.config.lastRegex, trimedSource).pop();
        if (match && match.index === 0 && match.length === trimedSource.length) {
            let weekdayStr = match.groups['weekday'].value;
            let value = DateUtils.last(referenceDate, this.config.dayOfWeek.get(weekdayStr));

            result.timex = FormatUtil.luisDateFromDate(value);
            result.futureValue = value;
            result.pastValue = value;
            result.success = true;
            return result;
        }

        // handle "Friday"
        match = RegExpUtility.getMatches(this.config.strictWeekDay, trimedSource).pop();
        if (match && match.index === 0 && match.length === trimedSource.length) {
            let weekdayStr = match.groups['weekday'].value;
            let weekday = this.config.dayOfWeek.get(weekdayStr);
            let value = DateUtils.this(referenceDate, this.config.dayOfWeek.get(weekdayStr));

            if (weekday === 0) weekday = 7;
            if (weekday < referenceDate.getDay()) value = DateUtils.next(referenceDate, weekday);
            result.timex = 'XXXX-WXX-' + weekday;
            let futureDate = new Date(value);
            let pastDate = new Date(value);
            if (futureDate < referenceDate) futureDate.setDate(value.getDate() + 7);
            if (pastDate >= referenceDate) pastDate.setDate(value.getDate() - 7);

            result.futureValue = futureDate;
            result.pastValue = pastDate;
            result.success = true;
            return result;
        }
        return result;
    }

    private parseNumberWithMonth(source: string, referenceDate: Date): DateTimeResolutionResult {
        let trimedSource = source.trim();
        let result = new DateTimeResolutionResult();
        let match = RegExpUtility.getMatches(this.config.monthRegex, trimedSource).pop();
        if (!match) return result;
        let er = this.config.ordinalExtractor.extract(trimedSource);
        if (!er || er.length === 0) {
            er = this.config.integerExtractor.extract(trimedSource);
        }
        if (!er || er.length === 0) return result;

        let year = referenceDate.getFullYear();
        let month = this.config.monthOfYear.get(match.value.trim());
        let day = Number.parseInt(this.config.numberParser.parse(er[0]).value);

        result.timex = FormatUtil.luisDate(-1, month, day);
        let futureDate = new Date(year, month, day);
        let pastDate = new Date(year, month, day);
        if (futureDate < referenceDate) futureDate.setFullYear(year + 1);
        if (pastDate >= referenceDate) pastDate.setFullYear(year - 1);
        
        result.futureValue = futureDate;
        result.pastValue = pastDate;
        result.success = true;
        return result;
    }

    private parserDurationWithAgoAndLater(source: string, referenceDate: Date): DateTimeResolutionResult {
        return parserDurationWithAgoAndLater(
            source, 
            referenceDate, 
            this.config.durationExtractor, 
            this.config.cardinalExtractor, 
            this.config.numberParser, 
            this.config.unitMap, 
            this.config.unitRegex, 
            this.config.utilityConfiguration, 
            AgoLaterMode.Date
        );
    }

    private parseWeekdayOfMonth(source: string, referenceDate: Date): DateTimeResolutionResult {
        let trimedSource = source.trim();
        let result = new DateTimeResolutionResult();
        let match = RegExpUtility.getMatches(this.config.weekDayOfMonthRegex, trimedSource).pop();
        if (!match) return result;
        let cardinalStr = match.groups['cardinal'] ? match.groups['cardinal'].value : '';
        let weekdayStr = match.groups['weekday'] ? match.groups['weekday'].value : '';
        let monthStr = match.groups['month'] ? match.groups['month'].value : '';
        let noYear = false;
        let cardinal = this.config.isCardinalLast(cardinalStr) ? 5 : this.config.cardinalMap.get(cardinalStr);
        let weekday = this.config.dayOfWeek.get(weekdayStr);
        let month = referenceDate.getMonth();
        let year = referenceDate.getFullYear();
        if (isNullOrEmpty(monthStr)) {
            let swift = this.config.getSwiftMonth(trimedSource);
            let temp = new Date(referenceDate);
            temp.setMonth(referenceDate.getMonth() + swift);
            month = temp.getMonth();
            year = temp.getFullYear();
        } else {
            month = this.config.monthOfYear.get(monthStr) - 1;
            noYear = true;
        }
        let value = this.computeDate(cardinal, weekday, month, year);
        if (value.getMonth() !== month) {
            cardinal -= 1;
            value.setDate(value.getDate() - 7);
        }
        let futureDate = value;
        let pastDate = value;
        if (noYear && futureDate < referenceDate) {
            futureDate = this.computeDate(cardinal, weekday, month, year + 1);
            if (futureDate.getMonth() !== month) futureDate.setDate(futureDate.getDate() - 7);
        }
        if (noYear && pastDate >= referenceDate) {
            pastDate = this.computeDate(cardinal, weekday, month, year - 1);
            if (pastDate.getMonth() !== month)pastDate.setDate(pastDate.getDate() - 7);
        }
        result.timex = '';
        result.futureValue = futureDate;
        result.pastValue = pastDate;
        result.success = true;
        return result;
    }

    private matchToDate(match: Match, referenceDate: Date): DateTimeResolutionResult {
        let result = new DateTimeResolutionResult();
        let yearStr = match.groups['year'] ? match.groups['year'].value : '';
        let monthStr = match.groups['month'] ? match.groups['month'].value : '';
        let dayStr = match.groups['day'] ? match.groups['day'].value : '';
        let month = 0;
        let day = 0;
        let year = 0;
        if (this.config.monthOfYear.has(monthStr) && this.config.dayOfMonth.has(dayStr)) {
            month = this.config.monthOfYear.get(monthStr);
            day = this.config.dayOfMonth.get(dayStr);
            if (!isNullOrEmpty(yearStr)) {
                year = Number.parseInt(yearStr);
                if (year < 100 && year >= 90) year += 1900;
                else if (year < 100 && year < 20) year += 2000;
            }
        }
        let noYear = false;
        if (year === 0) {
            year = referenceDate.getFullYear();
            result.timex = FormatUtil.luisDate(-1, month, day);
            noYear = true;
        } else {
            result.timex = FormatUtil.luisDate(year, month, day);
        }
        let futureDate = new Date(year, month, day);
        let pastDate = new Date(year, month, day);
        if (noYear && futureDate < referenceDate) {
            futureDate = new Date(year + 1, month, day);
        }
        if (noYear && pastDate >= referenceDate) {
            futureDate = new Date(year - 1, month, day);
        }
        result.futureValue = futureDate;
        result.pastValue = pastDate;
        result.success = true;
        return result;
    }

    private computeDate(cardinal: number, weekday: number, month: number, year: number) {
        let firstDay = new Date(year, month, 1);
        let firstWeekday = DateUtils.this(firstDay, weekday);
        if (weekday === 0) weekday = 7;
        if (weekday < firstDay.getDay()) firstWeekday = DateUtils.next(firstDay, weekday);
        firstWeekday.setDate(firstWeekday.getDate() + (7 * (cardinal - 1)));
        return firstWeekday;
    }
}

enum AgoLaterMode {
    Date, DateTime
}

function parserDurationWithAgoAndLater(source: string, referenceDate: Date, durationExtractor: IExtractor, cardinalExtractor: IExtractor, numberParser: IParser, unitMap: ReadonlyMap<string, string>, unitRegex: RegExp, utilityConfiguration: IDateTimeUtilityConfiguration, mode: AgoLaterMode): DateTimeResolutionResult {
    let result = new DateTimeResolutionResult();
    let duration = durationExtractor.extract(source).pop();
    if (!duration) return result;
    let match = RegExpUtility.getMatches(unitRegex, source).pop();
    if (!match) return result;
    let afterStr = source.substr(duration.start + duration.length);
    let beforeStr = source.substr(0, duration.start);
    let numberStr = source.substr(duration.start, match.index - duration.start);
    let srcUnit = match.groups['unit'].value;
    let er = cardinalExtractor.extract(numberStr).pop();
    if (!er) return result;
    return getAgoLaterResult(numberParser, er, unitMap, srcUnit, afterStr, beforeStr, referenceDate, utilityConfiguration, mode);
}

function getAgoLaterResult(numberParser: IParser, er: ExtractResult, unitMap: ReadonlyMap<string, string>, srcUnit: string, afterStr: string, beforeStr: string, referenceDate: Date, utilityConfiguration: IDateTimeUtilityConfiguration, mode: AgoLaterMode) {
    let result = new DateTimeResolutionResult();
    let pr = numberParser.parse(er);
    let num = Number.parseInt(pr.resolutionStr);
    let unitStr = unitMap.get(srcUnit);
    if (!unitStr) return result;
    let numStr = num.toString();
    let containsAgo = MatchingUtil.containsAgoLaterIndex(afterStr, utilityConfiguration.agoRegex);
    let containsLaterOrIn = MatchingUtil.containsAgoLaterIndex(afterStr, utilityConfiguration.laterRegex) || MatchingUtil.containsInIndex(beforeStr, utilityConfiguration.inConnectorRegex);
    if (containsAgo) {
        return getDateResult(unitStr, num, referenceDate, false, mode);
    }
    if (containsLaterOrIn) {
        return getDateResult(unitStr, num, referenceDate, true, mode);
    }
    return result;
}

function getDateResult(unitStr: string, num: number, referenceDate: Date, isFuture: boolean, mode: AgoLaterMode): DateTimeResolutionResult {
    let value = new Date(referenceDate);
    let result = new DateTimeResolutionResult();
    let swift = isFuture ? 1 : -1;
    switch (unitStr) {
        case 'D': value.setDate(referenceDate.getDate() + (num * swift)); break;
        case 'W': value.setDate(referenceDate.getDate() + (num * swift * 7)); break;
        case 'MON': value.setMonth(referenceDate.getMonth() + (num * swift)); break;
        case 'Y': value.setFullYear(referenceDate.getFullYear() + (num * swift)); break;
        case 'H': value.setHours(referenceDate.getHours() + (num * swift)); break;
        case 'M': value.setMinutes(referenceDate.getMinutes() + (num * swift)); break;
        case 'S': value.setSeconds(referenceDate.getSeconds() + (num * swift)); break;
        default: return result;
    }
    result.timex = mode === AgoLaterMode.Date ? FormatUtil.luisDateFromDate(value) : FormatUtil.luisTimeFromDate(value);
    result.futureValue = value;
    result.pastValue = value;
    result.success = true;
    return result;
}