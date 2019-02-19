//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Portuguese\Portuguese-Choice.yaml
//     - Language: Portuguese
//     - ClassName: ChoiceDefinitions
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions.Portuguese
{
	using System;
	using System.Collections.Generic;

	public static class ChoiceDefinitions
	{
		public const string LangMarker = @"Por";
		public const string TokenizerRegex = @"[^\w\d\u00E0-\u00FC]";
		public const string TrueRegex = @"\b(verdade|verdadeir[oa]|sim|isso|claro|ok)\b|(\uD83D\uDC4D|\uD83D\uDC4C)";
		public const string FalseRegex = @"\b(falso|n[aã]o|incorreto|nada disso)\b|(\uD83D\uDC4E|\u270B|\uD83D\uDD90)";
	}
}