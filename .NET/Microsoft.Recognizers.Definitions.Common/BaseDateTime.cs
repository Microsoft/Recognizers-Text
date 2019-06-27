//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Base-DateTime.yaml
//     - Language: NULL
//     - ClassName: BaseDateTime
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions
{
    using System;
    using System.Collections.Generic;

    public static class BaseDateTime
    {
      public const string HourRegex = @"(?<hour>2[0-4]|[0-1]?\d)(h)?";
      public const string TwoDigitHourRegex = @"(?<hour>[0-1]\d|2[0-4])(h)?";
      public const string MinuteRegex = @"(?<min>[0-5]?\d)(?!\d)";
      public const string TwoDigitMinuteRegex = @"(?<min>[0-5]\d)(?!\d)";
      public const string DeltaMinuteRegex = @"(?<deltamin>[0-5]?\d)";
      public const string SecondRegex = @"(?<sec>[0-5]?\d)";
      public const string FourDigitYearRegex = @"\b(?<![$])(?<year>((1\d|20)\d{2})|2100)(?!\.0\b)\b";
      public static readonly string IllegalYearRegex = $@"([-])({FourDigitYearRegex})([-])";
      public const string RangeConnectorSymbolRegex = @"(--|-|—|——|~|–)";
      public const string BaseAmDescRegex = @"(am\b|a\s*\.\s*m\s*\.|a[\.]?\s*m\b)";
      public const string BasePmDescRegex = @"(pm\b|p\s*\.\s*m\s*\.|p[\.]?\s*m\b)";
      public const string BaseAmPmDescRegex = @"(ampm)";
      public const string MinYearNum = @"1500";
      public const string MaxYearNum = @"2100";
      public const string MaxTwoDigitYearFutureNum = @"30";
      public const string MinTwoDigitYearPastNum = @"70";
      public static readonly Dictionary<string, int> DayOfMonthDictionary = new Dictionary<string, int>
        {
            { @"01", 1 },
            { @"02", 2 },
            { @"03", 3 },
            { @"04", 4 },
            { @"05", 5 },
            { @"06", 6 },
            { @"07", 7 },
            { @"08", 8 },
            { @"09", 9 },
            { @"1", 1 },
            { @"2", 2 },
            { @"3", 3 },
            { @"4", 4 },
            { @"5", 5 },
            { @"6", 6 },
            { @"7", 7 },
            { @"8", 8 },
            { @"9", 9 },
            { @"10", 10 },
            { @"11", 11 },
            { @"12", 12 },
            { @"13", 13 },
            { @"14", 14 },
            { @"15", 15 },
            { @"16", 16 },
            { @"17", 17 },
            { @"18", 18 },
            { @"19", 19 },
            { @"20", 20 },
            { @"21", 21 },
            { @"22", 22 },
            { @"23", 23 },
            { @"24", 24 },
            { @"25", 25 },
            { @"26", 26 },
            { @"27", 27 },
            { @"28", 28 },
            { @"29", 29 },
            { @"30", 30 },
            { @"31", 31 }
        };
      public static readonly Dictionary<string, string> VariableHolidaysTimexDictionary = new Dictionary<string, string>
        {
            { @"fathers", @"-06-WXX-7-3" },
            { @"mothers", @"-05-WXX-7-2" },
            { @"thanksgiving", @"-11-WXX-4-4" },
            { @"martinlutherking", @"-01-WXX-1-3" },
            { @"washingtonsbirthday", @"-02-WXX-1-3" },
            { @"canberra", @"-03-WXX-1-1" },
            { @"labour", @"-09-WXX-1-1" },
            { @"columbus", @"-10-WXX-1-2" },
            { @"memorial", @"-05-WXX-1-4" }
        };
    }
}