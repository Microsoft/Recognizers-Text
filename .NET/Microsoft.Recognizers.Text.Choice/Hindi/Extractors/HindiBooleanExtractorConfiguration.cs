﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.Hindi;

namespace Microsoft.Recognizers.Text.Choice.Hindi
{
    public class HindiBooleanExtractorConfiguration : IBooleanExtractorConfiguration
    {
        public static readonly Regex TrueRegex =
            new Regex(ChoiceDefinitions.TrueRegex, RegexOptions.Singleline);

        public static readonly Regex FalseRegex =
            new Regex(ChoiceDefinitions.FalseRegex, RegexOptions.Singleline);

        public static readonly Regex TokenRegex =
            new Regex(ChoiceDefinitions.TokenizerRegex, RegexOptions.Singleline);

        public static readonly IDictionary<Regex, string> MapRegexes = new Dictionary<Regex, string>()
        {
            { TrueRegex, Constants.SYS_BOOLEAN_TRUE },
            { FalseRegex, Constants.SYS_BOOLEAN_FALSE },
        };

        public HindiBooleanExtractorConfiguration(bool onlyTopMatch = true)
        {
            this.OnlyTopMatch = onlyTopMatch;
        }

        Regex IBooleanExtractorConfiguration.TrueRegex => TrueRegex;

        Regex IBooleanExtractorConfiguration.FalseRegex => FalseRegex;

        IDictionary<Regex, string> IChoiceExtractorConfiguration.MapRegexes => MapRegexes;

        Regex IChoiceExtractorConfiguration.TokenRegex => TokenRegex;

        public bool AllowPartialMatch => false;

        public int MaxDistance => 2;

        public bool OnlyTopMatch { get; }
    }
}