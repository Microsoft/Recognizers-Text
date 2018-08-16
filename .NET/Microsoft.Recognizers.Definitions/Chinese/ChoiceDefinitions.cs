﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\Chinese\Chinese-Choice.yaml
//     - Language: Chinese
//     - ClassName: ChoiceDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.Chinese
{
	using System;
	using System.Collections.Generic;

	public static class ChoiceDefinitions
	{
		public const string LangMarker = "Chs";
		public const string TokenizerRegex = @"[^\w\d\u3040-\u309f\u30a0-\u30ff\uff00-\uff9f\u4e00-\u9faf\u3400-\u4dbf]";
		public const string TrueRegex = @"(好[的啊呀嘞哇]|没问题|可以|中|好|行|同意|是的|是)|(\uD83D\uDC4D|\uD83D\uDC4C)";
		public const string FalseRegex = @"(不行|不好|拒绝|否定|不中|不可以|不是的|不是)|(\uD83D\uDC4E|\u270B|\uD83D\uDD90)";
	}
}
