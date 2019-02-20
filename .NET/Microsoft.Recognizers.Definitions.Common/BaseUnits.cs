//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//     
//     Generation parameters:
//     - DataFilename: Patterns\Base-Units.yaml
//     - Language: NULL
//     - ClassName: BaseUnits
// </auto-generated>
//------------------------------------------------------------------------------
namespace Microsoft.Recognizers.Definitions
{
	using System;
	using System.Collections.Generic;

	public static class BaseUnits
	{
		public const string HourRegex = @"(?<hour>00|01|02|03|04|05|06|07|08|09|0|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|1|2|3|4|5|6|7|8|9)(h)?";
		public const string MinuteRegex = @"(?<min>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)(?!\d)";
		public const string SecondRegex = @"(?<sec>00|01|02|03|04|05|06|07|08|09|10|11|12|13|14|15|16|17|18|19|20|21|22|23|24|25|26|27|28|29|30|31|32|33|34|35|36|37|38|39|40|41|42|43|44|45|46|47|48|49|50|51|52|53|54|55|56|57|58|59|0|1|2|3|4|5|6|7|8|9)";
		public static readonly string PmNonUnitRegex = $@"({HourRegex}\s*:\s*{MinuteRegex}(\s*:\s*{SecondRegex})?\s*pm)";
		public const string AmbiguousTimeTerm = @"pm";
		public const string AmbiguousUnitNumberMultiplierRegex = @"(\s[Kk])";
	}
}