﻿using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Microsoft.Recognizers.Text.DateTime
{
    public class BaseDurationExtractor : IExtractor
    {
        public static readonly string ExtractorName = Constants.SYS_DATETIME_DURATION;

        private readonly IDurationExtractorConfiguration config;

        public BaseDurationExtractor(IDurationExtractorConfiguration config)
        {
            this.config = config;
        }

        public List<ExtractResult> Extract(string text)
        {
            var tokens = new List<Token>();
            tokens.AddRange(NumberWithUnit(text));
            tokens.AddRange(NumberWithUnitAndSuffix(text, NumberWithUnit(text)));
            tokens.AddRange(ImplicitDuration(text));
            tokens.AddRange(MergeUnit(tokens, text));

            return Token.MergeAllTokens(tokens, text, ExtractorName);
        }
        
        // handle cases look like: {number} {unit}? and {an|a} {half|quarter} {unit}?
        // define the part "and {an|a} {half|quarter}" as Suffix
        private List<Token> NumberWithUnitAndSuffix(string text, List<Token> ers)
        {
            var ret = new List<Token>();
            foreach (var er in ers)
            {
                var afterStr = text.Substring(er.Start + er.Length);
                var match = this.config.SuffixAndRegex.Match(afterStr);
                if (match.Success && match.Index == 0)
                {
                    ret.Add(new Token(er.Start, (er.Start + er.Length) + match.Length));
                }
            }
            return ret;
        }

        // simple cases made by a number followed an unit
        private List<Token> NumberWithUnit(string text)
        {
            var ret = new List<Token>();
            var ers = this.config.CardinalExtractor.Extract(text);
            foreach (var er in ers)
            {
                var afterStr = text.Substring(er.Start + er.Length ?? 0);
                var match = this.config.FollowedUnit.Match(afterStr);
                if (match.Success && match.Index == 0)
                {
                    ret.Add(new Token(er.Start ?? 0, (er.Start + er.Length ?? 0) + match.Length));
                }
            }

            // handle "3hrs"
            var matches = this.config.NumberCombinedWithUnit.Matches(text);
            foreach (Match match in matches)
            {
                ret.Add(new Token(match.Index, match.Index + match.Length));
            }

            // handle "an hour"
            matches = this.config.AnUnitRegex.Matches(text);
            foreach (Match match in matches)
            {
                ret.Add(new Token(match.Index, match.Index + match.Length));
            }

            return ret;
        }

        // handle cases that don't contain nubmer
        private List<Token> ImplicitDuration(string text)
        {
            var ret = new List<Token>();
            // handle "all day", "all year"
            ret.AddRange(GetTokenFromRegex(config.AllRegex, text));

            // handle "half day", "half year"
            ret.AddRange(GetTokenFromRegex(config.HalfRegex, text));

            return ret;
        }

        // merge two Duration Unit with conjunction
        private List<Token> MergeUnit(List<Token>  tokens, string text)
        {
            var ret = new List<Token>();
            foreach (Token tokenLeft in tokens)
            {
                foreach (Token tokenRight in tokens)
                {
                    // keep token1 in front of token2
                    if (!(tokenLeft.End < tokenRight.Start))
                    {
                        continue;
                    }

                    var conjuncStr = text.Substring(tokenLeft.End, tokenRight.Start - tokenLeft.End - 1);
                    var matches = this.config.ConjunctionRegex.Matches(text);

                    foreach (Match match in matches)
                    {
                        // check if valid
                        var matchStart = match.Index;
                        var matchEnd = match.Index + match.Length;
                        var gapLeft = "";
                        var gapRight = "";
                        if (matchStart - tokenLeft.End - 1 > 0)
                            gapLeft = text.Substring(tokenLeft.End + 1, matchStart - tokenLeft.End - 1);
                        if (tokenRight.Start - matchEnd - 1 > 0)
                            gapRight = text.Substring(matchEnd + 1, tokenRight.Start - matchEnd - 1);
                        if (!string.IsNullOrEmpty(gapLeft) || !string.IsNullOrEmpty(gapRight))
                        {
                            continue;
                        }

                        if (tokenLeft.End <= match.Index && match.Index + match.Length <= tokenRight.Start)
                        {
                            ret.Add(new Token(tokenLeft.Start, tokenRight.End));
                        }
                    }
                }
            }
            return ret;
        }

        private List<Token> GetTokenFromRegex(Regex regex, string text)
        {
            var ret = new List<Token>();
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                ret.Add(new Token(match.Index, match.Index + match.Length));
            }
            return ret;
        } 
    }
}
