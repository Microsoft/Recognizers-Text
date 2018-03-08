﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\Japanese\Japanese-Choice.yaml
//     - Language: Japanese
//     - ClassName: ChoiceDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.Japanese
{
	using System;
	using System.Collections.Generic;

	public static class ChoiceDefinitions
	{
		public const string LangMarker = "Jpn";
		public const string TokenizerRegex = @"[^\w\d\u3040-\u309f\u30a0-\u30ff\uff00-\uff9f\u4e00-\u9faf\u3400-\u4dbf]";
		public const string TrueRegex = @"(はい|そうです|そう|よい)|(\uD83D\uDC4D|\uD83D\uDC4C)";
		public const string FalseRegex = @"(いいえ|ではありません|ではない|じゃない|じゃありません)|(\uD83D\uDC4E|\u270B|\uD83D\uDD90)";
	}
}
