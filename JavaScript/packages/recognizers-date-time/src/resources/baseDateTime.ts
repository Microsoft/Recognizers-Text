// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

export namespace BaseDateTime {
    export const HourRegex = `(?<hour>00|01|02|03|04|05|06|07|08|09|0|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|1|2|3|4|5|6|7|8|9)(h)?`;
    export const TwoDigitHourRegex = `(?<hour>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24)(h)?`;
    export const MinuteRegex = `(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)(?!\\d)`;
    export const TwoDigitMinuteRegex = `(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59)(?!\\d)`;
    export const DeltaMinuteRegex = `(?<deltamin>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)`;
    export const SecondRegex = `(?<sec>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)`;
    export const FourDigitYearRegex = `\\b(?<![$])(?<year>((1\\d|20)\\d{2})|2100)(?!\\.0\\b)\\b`;
    export const IllegalYearRegex = `([-])(${FourDigitYearRegex})([-])`;
    export const RangeConnectorSymbolRegex = `(--|-|—|——|~|–)`;
    export const BaseAmDescRegex = `(am\\b|a\\s*\\.\\s*m\\s*\\.|a(\\.)?\\s*m\\b)`;
    export const BasePmDescRegex = `(pm\\b|p\\s*\\.\\s*m\\s*\\.|p(\\.)?\\s*m\\b)`;
    export const BaseAmPmDescRegex = `(ampm)`;
    export const MinYearNum = '1500';
    export const MaxYearNum = '2100';
    export const MaxTwoDigitYearFutureNum = '30';
    export const MinTwoDigitYearPastNum = '70';
    export const DayOfMonthDictionary: ReadonlyMap<string, number> = new Map<string, number>([["1", 1],["2", 2],["3", 3],["4", 4],["5", 5],["6", 6],["7", 7],["8", 8],["9", 9],["10", 10],["11", 11],["12", 12],["13", 13],["14", 14],["15", 15],["16", 16],["17", 17],["18", 18],["19", 19],["20", 20],["21", 21],["22", 22],["23", 23],["24", 24],["25", 25],["26", 26],["27", 27],["28", 28],["29", 29],["30", 30],["31", 31],["01", 1],["02", 2],["03", 3],["04", 4],["05", 5],["06", 6],["07", 7],["08", 8],["09", 9]]);
    export const VariableHolidaysTimexDictionary: ReadonlyMap<string, string> = new Map<string, string>([["fathers", "-06-WXX-7-3"],["mothers", "-05-WXX-7-2"],["thanksgiving", "-11-WXX-4-4"],["martinlutherking", "-01-WXX-1-3"],["washingtonsbirthday", "-02-WXX-1-3"],["canberra", "-03-WXX-1-1"],["labour", "-09-WXX-1-1"],["columbus", "-10-WXX-1-2"],["memorial", "-05-WXX-1-4"]]);
}
