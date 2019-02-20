//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\English\English-Choice.yaml
//     - Language: English
//     - ClassName: ChoiceDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.English
{
	using System;
	using System.Collections.Generic;

	public static class ChoiceDefinitions
	{
		public const string LangMarker = @"Eng";
		public const string TokenizerRegex = @"[^\w\d]";
		public const string TrueRegex = @"\b(true|yes|yep|y|sure|ok|agree)\b|(\uD83D\uDC4D|\uD83D\uDC4C)";
		public const string FalseRegex = @"\b(false|nope|nop|no|not\s+ok|disagree)\b|(\uD83D\uDC4E|\u270B|\uD83D\uDD90)";
	}
}