﻿using System.Collections.Generic;

using Microsoft.Recognizers.Text.Number.Extractors;
using Microsoft.Recognizers.Text.Number.Parsers;

namespace Microsoft.Recognizers.Text.NumberWithUnit
{
    public class AgeModel : AbstractNumberWithUnitModel
    {
        public AgeModel(Dictionary<IExtractor, IParser> extractorParserDic) : base(extractorParserDic)
        {
        }

        public override string ModelTypeName => "age";
    }
}