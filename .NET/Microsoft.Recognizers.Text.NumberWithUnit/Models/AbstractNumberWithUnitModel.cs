﻿using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Recognizers.Text.Number;
using Microsoft.Recognizers.Text.Utilities;

namespace Microsoft.Recognizers.Text.NumberWithUnit
{
    public abstract class AbstractNumberWithUnitModel : IModel
    {
        protected AbstractNumberWithUnitModel(Dictionary<IExtractor, IParser> extractorParserDic)
        {
            this.ExtractorParserDic = extractorParserDic;
        }

        public abstract string ModelTypeName { get; }

        protected Dictionary<IExtractor, IParser> ExtractorParserDic { get; }

        public List<ModelResult> Parse(string query)
        {

            // Preprocess the query
            query = FormatUtility.Preprocess(query, false);

            List<ModelResult> extractionResults = new List<ModelResult>();

            try
            {

                foreach (var p in ExtractorParserDic)
                {
                    var extractor = p.Key;
                    var parser = p.Value;

                    var extractedResults = extractor.Extract(query);

                    var parsedResults = new List<ParseResult>();

                    foreach (var result in extractedResults)
                    {
                        parsedResults.Add(parser.Parse(result));
                    }

                    var modelResults = parsedResults.Select(o => new ModelResult
                    {
                        Start = o.Start.Value,
                        End = o.Start.Value + o.Length.Value - 1,
                        Resolution = (o.Value is UnitValue) ?
                            new SortedDictionary<string, object>
                            {
                                {ResolutionKey.Value, ((UnitValue)o.Value).Number},
                                {ResolutionKey.Unit, ((UnitValue)o.Value).Unit}
                            }
                            : new SortedDictionary<string, object>
                            {
                                {ResolutionKey.Value, (string)o.Value}
                            },
                        Text = o.Text,
                        TypeName = ModelTypeName
                    }).ToList();

                    foreach (var result in modelResults)
                    {
                        bool bAdd = true;

                        foreach (var extractionResult in extractionResults)
                        {
                            if (extractionResult.Start == result.Start && extractionResult.End == result.End)
                            {
                                bAdd = false;
                            }
                        }

                        if (bAdd)
                        {
                            extractionResults.Add(result);
                        }
                    }
                }

            }
            catch (Exception)
            {
                // Nothing to do. Exceptions in parse should not break users of recognizers.
                // No result.
            }

            return extractionResults;
        }

        public enum CompositeEntityType
        {
            Age,
            Currency,
            Dimension,
            Temperature
        }
    }
}