﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\Base-Numbers.yaml
//     - Language: NULL
//     - ClassName: BaseNumbers
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions
{
	using System;
	using System.Collections.Generic;

	public static class BaseNumbers
	{
		public const string NumberReplaceToken = "@builtin.num";
		public const string FractionNumberReplaceToken = "@builtin.num.fraction";
		public static readonly Func<string, string, string> IntegerRegexDefinition = (placeholder, thousandsmark) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!(\d+\.|\d+,))))\d{{1,3}}({thousandsmark}\d{{3}})+(?={placeholder})";
		public static readonly Func<string, string, string, string> DoubleRegexDefinition = (placeholder, thousandsmark, decimalmark) => $@"(((?<!\d+\s*)-\s*)|((?<=\b)(?<!\d+\.|\d+,)))\d{{1,3}}({thousandsmark}\d{{3}})+{decimalmark}\d+(?={placeholder})";
		public const string PlaceHolderDefault = "\\D|\\b";
		public const string NumberMultiplierRegex = @"(K|k|M|G|T|B|b)";
		public const string MultiplierLookupRegex = @"(k|m|t|g|b)";
		public const string CurrencyRegex = @"(((?<=\W|^)-\s*)|(?<=\b))\d+\s*(b|m|t|g)(?=\b)";
	}
}