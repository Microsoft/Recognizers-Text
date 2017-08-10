import { Constants } from "./constants";
import { CommonNumeric } from "../resources/numericCommon";
import { EnglishNumeric } from "../resources/numericEnglish";
import * as XRegExp from 'xregexp';
import { Match, RegExpUtility } from "../utilities";
import { ArabicType } from "./models";
import * as _ from "lodash";

export interface IExtractor {
    extract(input: string): Array<ExtractResult>
}

export class ExtractResult {
    start: number;
    length: number;
    text: string;
    type: string;
    data?: any;
}

export interface RegExpValue {
    regExp: RegExp;
    value: string;
}

export abstract class BaseNumberExtractor implements IExtractor {

    regexes: Array<RegExpValue>;

    protected extractType: string = "";

    extract(source: string): Array<ExtractResult> {
        if (!source || source.trim().length === 0) {
            return [];
        }

        let result = new Array<ExtractResult>();
        let matchSource = new Map<Match, string>();
        let matched = new Array<boolean>(source.length);
        for (let i = 0; i < source.length; i++) {
            matched[i] = false;
        }

        let collections = this.regexes
            .map(o => ({ matches: RegExpUtility.getMatches(o.regExp, source), value: o.value }))
            .filter(o => o.matches && o.matches.length);

        collections.forEach(collection => {
            collection.matches.forEach(m => {
                for (let j = 0; j < m.length; j++) {
                    matched[m.index + j] = true;
                }

                // Keep Source Data for extra information
                matchSource.set(m, collection.value);
            });
        });

        let last = -1;
        for (let i = 0; i < source.length; i++) {
            if (matched[i]) {
                if (i + 1 === source.length || !matched[i + 1]) {
                    let start = last + 1;
                    let length = i - last;
                    let substr = source.substring(start, start + length);
                    let srcMatch = Array.from(matchSource.keys()).find(m => m.index === start && m.length === length);
                    if (srcMatch) {
                        result.push({
                            start: start,
                            length: length,
                            text: substr,
                            type: this.extractType,
                            data: matchSource.has(srcMatch) ? matchSource.get(srcMatch) : null
                        });
                    }
                }
            }
            else {
                last = i;
            }
        }

        return result;
    }

    protected generateArabicNumberRegex(type: ArabicType, placeholder: string = "\D|\b"): RegExp {

        let integerTemplate = CommonNumeric.IntegerTemplateRegex + `(?=${placeholder})`;
        let doubleTemplate = CommonNumeric.DoubleTemplateRegex + `(?=${placeholder})`;

        switch (type) {
            case ArabicType.IntegerNumComma:
                return XRegExp(integerTemplate.replace('{0}', _.escapeRegExp(',')), "gis");
            case ArabicType.IntegerNumDot:
                return XRegExp(integerTemplate.replace('{0}', _.escapeRegExp('.')), "gis");
            case ArabicType.IntegerNumBlank:
                return XRegExp(integerTemplate.replace('{0}', ' '), "gis");
            case ArabicType.IntegerNumQuote:
                return XRegExp(integerTemplate.replace('{0}', _.escapeRegExp("'")), "gis");
            case ArabicType.DoubleNumCommaDot:
                return XRegExp(doubleTemplate.replace('{0}', ",").replace('{1}', _.escapeRegExp(".")), "gis");
            case ArabicType.DoubleNumDotComma:
                return XRegExp(doubleTemplate.replace('{0}', _.escapeRegExp(".")).replace('{1}', ","), "gis");
            case ArabicType.DoubleNumBlankComma:
                return XRegExp(doubleTemplate.replace('{0}', ' ').replace('{1}', ","), "gis");
            case ArabicType.DoubleNumBlankDot:
                return XRegExp(doubleTemplate.replace('{0}',' ').replace('{1}', _.escapeRegExp(".")), "gis");
            case ArabicType.DoubleNumCommaCdot:
                return XRegExp(doubleTemplate.replace('{0}', ",").replace('{1}', "·"), "gis");
            case ArabicType.DoubleNumQuoteComma:
                return XRegExp(doubleTemplate.replace('{0}', _.escapeRegExp("'")).replace('{1}', ","), "gis");
        }

        return null;
    }
}

export abstract class BasePercentageExtractor implements IExtractor {
    regexes: Array<RegExp>;

    protected static readonly numExtType: string = Constants.SYS_NUM;

    protected extractType: string = Constants.SYS_NUM_PERCENTAGE;

    private readonly numberExtractor: BaseNumberExtractor;

    constructor(numberExtractor: BaseNumberExtractor) {
        this.numberExtractor = numberExtractor;
        this.regexes = this.initRegexes();
    }

    protected abstract initRegexes(): Array<RegExp>;

    extract(source: string): ExtractResult[] {
        let originSource = source;
        let positionMap: Map<number, number>;
        let numExtResults: Array<ExtractResult>;

        // preprocess the source sentence via extracting and replacing the numbers in it
        let preprocess = this.preprocessStrWithNumberExtracted(originSource);
        source = preprocess.source;
        positionMap = preprocess.positionMap;
        numExtResults = preprocess.numExtResults;

        let allMatches = this.regexes.map(rx => RegExpUtility.getMatches(rx, source));

        let matched = new Array<boolean>(source.length);
        for (let i = 0; i < source.length; i++) {
            matched[i] = false;
        }

        for (let i = 0; i < allMatches.length; i++) {
            allMatches[i].forEach(match => {
                for (let j = 0; j < match.length; j++) {
                    matched[j + match.index] = true;
                }
            });
        }

        let result = new Array<ExtractResult>();
        let last = -1;
        // get index of each matched results
        for (let i = 0; i < source.length; i++) {
            if (matched[i]) {
                if (i + 1 === source.length || matched[i + 1] === false) {
                    let start = last + 1;
                    let length = i - last;
                    let substr = source.substring(start, start + length);
                    let er: ExtractResult = {
                        start: start,
                        length: length,
                        text: substr,
                        type: this.extractType
                    } as ExtractResult;
                    result.push(er);
                }
            }
            else {
                last = i;
            }
        }

        // post-processing, restoring the extracted numbers
        this.postProcessing(result, originSource, positionMap, numExtResults);

        return result;
    }

    // get the number extractor results and convert the extracted numbers to @sys.num, so that the regexes can work
    private preprocessStrWithNumberExtracted(str: string): {
        source: string,
        positionMap: Map<number, number>,
        numExtResults: Array<ExtractResult>
    } {
        let positionMap = new Map<number, number>();

        let numExtResults = this.numberExtractor.extract(str);
        let replaceText = CommonNumeric.NumberReplaceToken;

        let match = new Array<number>(str.length);
        let strParts = new Array<Array<number>>();
        let start: number;
        let end: number;
        for (let i = 0; i < str.length; i++) {
            match[i] = -1;
        }

        for (let i = 0; i < numExtResults.length; i++) {
            let extraction = numExtResults[i];
            let subtext = extraction.text;
            start = extraction.start;
            end = extraction.length + start;
            for (let j = start; j < end; j++) {
                if (match[j] === -1) {
                    match[j] = i;
                }
            }
        }

        start = 0;
        for (let i = 1; i < str.length; i++) {
            if (match[i] !== match[i - 1]) {
                strParts.push([start, i - 1]);
                start = i;
            }
        }
        strParts.push([start, str.length - 1]);

        let ret = "";
        let index = 0;
        strParts.forEach(strPart => {
            start = strPart[0];
            end = strPart[1];
            let type = match[start];
            if (type === -1) {
                ret += str.substring(start, end + 1);
                for (let i = start; i <= end; i++) {
                    positionMap.set(index++, i);
                }
            }
            else {
                let originalText = str.substring(start, end + 1);
                ret += replaceText;
                for (let i = 0; i < replaceText.length; i++) {
                    positionMap.set(index++, start);
                }
            }
        });


        positionMap.set(index++, str.length);

        return {
            numExtResults: numExtResults,
            source: ret,
            positionMap: positionMap
        };
    }

    // replace the @sys.num to the real patterns, directly modifies the ExtractResult
    private postProcessing(results: Array<ExtractResult>, originSource: string, positionMap: Map<number, number>, numExtResults: Array<ExtractResult>): void {
        let replaceText = CommonNumeric.NumberReplaceToken;
        for (let i = 0; i < results.length; i++) {
            let start = results[i].start;
            let end = start + results[i].length;
            let str = results[i].text;
            if (positionMap.has(start) && positionMap.has(end)) {
                let originStart = positionMap.get(start);
                let originLenth = positionMap.get(end) - originStart;
                results[i].start = originStart;
                results[i].length = originLenth;
                results[i].text = originSource.substring(originStart, originStart + originLenth);
                let numStart = str.indexOf(replaceText);
                if (numStart !== -1) {
                    let numOriginStart = start + numStart;
                    if (positionMap.has(numStart)) {
                        let dataKey = originSource.substring(positionMap.get(numOriginStart), positionMap.get(numOriginStart + replaceText.length));

                        for (let j = i; j < numExtResults.length; j++) {
                            if (results[i].start === numExtResults[j].start && results[i].text.includes(numExtResults[j].text)) {
                                results[i].data = [dataKey, numExtResults[j]];
                                break;
                            }
                        }
                    }
                }
            }
        }
    }

    // read the rules
    protected buildRegexes(regexStrs: Array<string>, ignoreCase: boolean = true): Array<RegExp> {
        return regexStrs.map(regexStr => {
            let options = "gs";
            if (ignoreCase) {
                options += "i";
            }

            return XRegExp(regexStr, options);
        });
    }
}