//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     Generation parameters:
//     - DataFilename: Patterns\Base-Ip.yaml
//     - Language: NULL
//     - ClassName: BaseIp
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions
{
	using System;
	using System.Collections.Generic;

	public static class BaseIp
	{
		public const string Ipv4Regex = @"\b(1\d{2}|2[0-4]\d|25[0-5]|0?[1-9]\d|0{0,2}\d)((\.(1\d{2}|2[0-4]\d|25[0-5]|0?[1-9]\d|0{0,2}\d)){3})\b";
		public const string BasicIpv6Element = @"([\da-fA-F]{1,4})";
		public static readonly string BasicIpv6Regex = $@"(({BasicIpv6Element}:){{7}}{BasicIpv6Element})";
		public static readonly string Ipv6EllipsisRegex1 = $@"(:(:{BasicIpv6Element}){{1,7}})";
		public static readonly string Ipv6EllipsisRegex2 = $@"(({BasicIpv6Element}:){{1}}((:{BasicIpv6Element}){{1,6}}))";
		public static readonly string Ipv6EllipsisRegex3 = $@"(({BasicIpv6Element}:){{2}}((:{BasicIpv6Element}){{1,5}}))";
		public static readonly string Ipv6EllipsisRegex4 = $@"(({BasicIpv6Element}:){{3}}((:{BasicIpv6Element}){{1,4}}))";
		public static readonly string Ipv6EllipsisRegex5 = $@"(({BasicIpv6Element}:){{4}}((:{BasicIpv6Element}){{1,3}}))";
		public static readonly string Ipv6EllipsisRegex6 = $@"(({BasicIpv6Element}:){{5}}((:{BasicIpv6Element}){{1,2}}))";
		public static readonly string Ipv6EllipsisRegex7 = $@"(({BasicIpv6Element}:){{6}}((:{BasicIpv6Element}){{1}}))";
		public static readonly string Ipv6EllipsisRegex8 = $@"(({BasicIpv6Element}:){{7}}(:))";
		public static readonly string Ipv6EllipsisRegexOther = $@"\B::\B|\B:(:{BasicIpv6Element}){{1,7}}\b|\b({BasicIpv6Element}:){{1,7}}:\B";
		public static readonly string MergedIpv6Regex = $@"({BasicIpv6Regex}|{Ipv6EllipsisRegex1}|{Ipv6EllipsisRegex2}|{Ipv6EllipsisRegex3}|{Ipv6EllipsisRegex4}|{Ipv6EllipsisRegex5}|{Ipv6EllipsisRegex6}|{Ipv6EllipsisRegex7}|{Ipv6EllipsisRegex8})";
		public static readonly string Ipv6Regex = $@"(\b{MergedIpv6Regex}\b)|({Ipv6EllipsisRegexOther})";
	}
}