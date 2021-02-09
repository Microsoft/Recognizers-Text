//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Arabic\Arabic-Choice.yaml
//     - Language: Arabic
//     - ClassName: ChoiceDefinitions
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

namespace Microsoft.Recognizers.Definitions.Arabic
{
    using System;
    using System.Collections.Generic;

    public static class ChoiceDefinitions
    {
      public const string LangMarker = @"Ara";
      public const string TokenizerRegex = @"[^\u0621-\u064A0-9]";
      public const string SkinToneRegex = @"(\uD83C\uDFFB|\uD83C\uDFFC|\uD83C\uDFFD|\uD83C\uDFFE|\uD83C\uDFFF)";
      public static readonly string TrueRegex = $@"\b(صحيح|نعم|حسنا|موافق|متأكد|بالتأكيد|أتفق|اتفق|بالطبع|هيا)\b|(\uD83D\uDC4D|\uD83D\uDC4C|\u0001f44c){SkinToneRegex}?";
      public static readonly string FalseRegex = $@"\b(لست متاحا|لا أستطيع|ليس تماما|أختلف|نختلف|اوافق|لست أوافق|لا|ليس صحيح|ليس|ليست|غير موافق)\b|(\uD83D\uDC4E|\u270B|\uD83D\uDD90|\u0001F44E|\u0001F590){SkinToneRegex}?";
    }
}