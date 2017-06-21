﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Microsoft.Recognizers.Text.DateTime
{
    public interface ITimeExtractorConfiguration
    {
        IEnumerable<Regex> TimeRegexList { get; }
        Regex AtRegex { get; }
        Regex IshRegex { get; }
        Regex UnitRegex { get; }
        IExtractor DurationExtractor { get; }

        bool GetAgoIndex(string text, out int index);
        bool GetLaterIndex(string text, out int index);

    }
}