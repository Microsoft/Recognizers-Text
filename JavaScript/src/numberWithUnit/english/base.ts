import { Culture, CultureInfo } from "../../culture";
import { IExtractor } from "../../number/extractors";
import { NumberMode } from "../../number/models";
import { IParser, AgnosticNumberParserFactory, AgnosticNumberParserType } from "../../number/parsers";
import { EnglishNumberExtractor } from "../../number/english/extractors";
import { EnglishNumberParserConfiguration } from "../../number/english/parserConfiguration";
import { Constants } from "../constants";
import { INumberWithUnitExtractorConfiguration } from "../extractors";
import { BaseNumberWithUnitParserConfiguration } from "../parsers";

export abstract class EnglishNumberWithUnitExtractorConfiguration implements INumberWithUnitExtractorConfiguration {
    abstract readonly suffixList: ReadonlyMap<string, string>;
    abstract readonly prefixList: ReadonlyMap<string, string>;
    abstract readonly ambiguousUnitList: ReadonlyArray<string>;
    readonly abstract extractType: string;

    readonly cultureInfo: CultureInfo;
    readonly unitNumExtractor: IExtractor;
    readonly buildPrefix: string;
    readonly buildSuffix: string;
    readonly connectorToken: string;

    constructor(ci: CultureInfo) {
        this.cultureInfo = ci;
        this.unitNumExtractor = new EnglishNumberExtractor();
        this.buildPrefix = String.raw`(?=(\s|^|\W)|(?!(\s|^|\W))\b)`;
        this.buildSuffix = String.raw`(?=(\s|\W|$))`;
        this.connectorToken = '';
    }
}

export class EnglishNumberWithUnitParserConfiguration extends BaseNumberWithUnitParserConfiguration {
    readonly internalNumberParser: IParser;
    readonly internalNumberExtractor: IExtractor;
    readonly connectorToken: string;

    constructor(ci: CultureInfo) {
        super(ci);

        this.internalNumberExtractor = new EnglishNumberExtractor(NumberMode.Default);
        this.internalNumberParser = AgnosticNumberParserFactory.getParser(AgnosticNumberParserType.Number, new EnglishNumberParserConfiguration());
        this.connectorToken = '';
    }
}