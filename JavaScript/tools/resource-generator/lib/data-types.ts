export namespace DataTypes {
    export class SimpleRegex {
        def: string;
    }

    export class NestedRegex {
        def: string;
        references: string[];
    }

    export class ParamsRegex {
        def: string;
        params: string[];
    }

    export class Dictionary {
        keyType: string;
        valueType: string;
        entries: Object;
    }

    export class List {
        type: string;
        entries: string[];
    }

    export function getSimpleRegex(data: any) : SimpleRegex {
        var result = new SimpleRegex();
        result.def = data.def_js ? data.def_js : data.def;
        return result;
    }

    export function getNestedRegex(data: any) : NestedRegex {
        var result = new NestedRegex();
        result.def = data.def_js ? data.def_js : data.def;
        result.references = data.references;
        return result;
    }

    export function getParamsRegex(data: any) : ParamsRegex {
        var result = new ParamsRegex();
        result.def = data.def_js ? data.def_js : data.def;
        result.params = data.params;
        return result;
    }

    export function getDictionary(data: any) : Dictionary {
        var result = new Dictionary();
        result.keyType = data.types[0];
        result.valueType = data.types[1];
        result.entries =  data.entries;
        return result;
    }

    export function getList(data: any): List {
        var result = new List();
        data.type = data.types[0];
        result.entries = data.entries;
        return result;
    }

    export function getCharacter(data: any) : string {
        return data;
    }
}