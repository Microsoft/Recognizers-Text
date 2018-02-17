﻿using System;

namespace Microsoft.Recognizers.Text.Sequence
{
    class BaseIPParser : BaseSequenceParser
    {
        public override ParseResult Parse(ExtractResult extResult)
        {
            var result = new ParseResult
            {
                Start = extResult.Start,
                Length = extResult.Length,
                Text = extResult.Text,
                Type = extResult.Type,
                ResolutionStr = DropLeadingZeros(extResult.Text)
            };

            return result;
        }

        private string DropLeadingZeros(string text)
        {
            var result = "";
            var number = "";
            for(var i = 0; i < text.Length; i++)
            {
                var c = text[i];
                if (c == '.' || c == ':')
                {
                    if (number != "")
                    {
                        number = number == "0" ? number : number.TrimStart('0');
                        number = number == "" ? "0" : number;
                        result += number;
                    }
                    result += text[i];
                    number = "";
                }
                else
                {
                    number += c.ToString();
                    if (i == text.Length - 1)
                    {
                        number = number == "0" ? number : number.TrimStart('0');
                        number = number == "" ? "0" : number;
                        result += number;
                    }
                }
            }

            return result;
        }
    }
}
