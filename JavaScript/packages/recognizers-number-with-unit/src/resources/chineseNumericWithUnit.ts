// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// ------------------------------------------------------------------------------

import { BaseNumbers } from "./baseNumbers";
export namespace ChineseNumericWithUnit {
    export const AgeAmbiguousValues = [ "岁" ];
    export const AgeSuffixList: ReadonlyMap<string, string> = new Map<string, string>([["Year", "岁|周岁"],["Month", "个月大|月大"],["Week", "周大"],["Day", "天大"]]);
    export const BuildPrefix = ``;
    export const BuildSuffix = ``;
    export const ConnectorToken = ``;
    export const CurrencySuffixList: ReadonlyMap<string, string> = new Map<string, string>([["Afghan afghani", "阿富汗尼"],["Pul", "普尔"],["Euro", "欧元"],["Cent", "美分"],["Albanian lek", "阿尔巴尼亚列克|列克"],["Angolan kwanza", "安哥拉宽扎|宽扎"],["Armenian dram", "亚美尼亚德拉姆"],["Aruban florin", "阿鲁巴弗罗林|阿鲁巴币"],["Bangladeshi taka", "塔卡|孟加拉塔卡"],["Paisa", "派萨|帕萨"],["Bhutanese ngultrum", "不丹努尔特鲁姆|不丹努扎姆|努扎姆"],["Chetrum", "切特鲁姆"],["Bolivian boliviano", "玻利维亚诺|玻利维亚币"],["Bosnia and Herzegovina convertible mark", "波斯尼亚和黑塞哥维那可兑换马克|波赫可兑换马克"],["Botswana pula", "博茨瓦纳普拉|普拉"],["Thebe", "thebe"],["Brazilian real", "巴西雷亚尔"],["Bulgarian lev", "保加利亚列弗|保加利亚列瓦"],["Stotinka", "斯托丁卡"],["Cambodian riel", "瑞尔"],["Cape Verdean escudo", "佛得角埃斯库多|维德角埃斯库多"],["Croatian kuna", "克罗地亚库纳|克罗地亚库那|克罗埃西亚库纳"],["Lipa", "利巴"],["Eritrean nakfa", "厄立特里亚纳克法"],["Ethiopian birr", "埃塞俄比亚比尔|埃塞俄比亚元"],["Gambian dalasi", "冈比亚达拉西|甘比亚达拉西"],["Butut", "布达|布图"],["Georgian lari", "格鲁吉亚拉里"],["Tetri", "特特里|泰特里"],["Ghanaian cedi", "塞地|加纳塞地"],["Pesewa", "比塞瓦"],["Guatemalan quetzal", "瓜地马拉格查尔"],["Haitian gourde", "海地古德"],["Honduran lempira", "洪都拉斯伦皮拉"],["Hungarian forint", "匈牙利福林|匈牙利货币|匈牙利福林币"],["Iranian rial", "伊朗里亚尔|伊朗莱尔"],["Yemeni rial", "叶门莱尔|叶门里亚尔"],["Israeli new shekel", "₪|ils|以色列币|以色列新克尔|谢克尔"],["Japanese yen", "日元|日本元|日币|日圆"],["Sen", "日本銭"],["Kazakhstani tenge", "哈萨克斯坦坚戈"],["Kenyan shilling", "肯尼亚先令"],["North Korean won", "朝鲜圆|朝鲜元"],["South Korean won", "韩元|韩圆"],["Korean won", "₩"],["Kyrgyzstani som", "吉尔吉斯斯坦索姆"],["Lao kip", "基普|老挝基普|老挝币"],["Att", "att"],["Lesotho loti", "莱索托洛提|莱索托马洛蒂"],["South African rand", "南非兰特"],["Macedonian denar", "马其顿代纳尔|马其顿币|代纳尔"],["Deni", "第尼"],["Malagasy ariary", "马达加斯加阿里亚里"],["Iraimbilanja", "伊莱姆比拉贾"],["Malawian kwacha", "马拉威克瓦查"],["Tambala", "坦巴拉"],["Malaysian ringgit", "马来西亚币|马币|马来西亚林吉特"],["Mauritanian ouguiya", "毛里塔尼亚乌吉亚"],["Khoums", "库姆斯"],["Mozambican metical", "莫桑比克梅蒂卡尔|梅蒂卡尔"],["Burmese kyat", "缅甸元|缅元"],["Pya", "缅分"],["Nigerian naira", "尼日利亚奈拉|尼日利亚币|奈拉"],["Kobo", "考包"],["Turkish lira", "土耳其里拉"],["Kuruş", "库鲁"],["Omani rial", "阿曼里亚尔|阿曼莱尔"],["Panamanian balboa", "巴拿马巴波亚"],["Centesimo", "意大利分|乌拉圭分|巴拿马分"],["Papua New Guinean kina", "基那"],["Toea", "托亚|托伊"],["Peruvian sol", "秘鲁索尔"],["Polish złoty", "波兰币|波兰兹罗提|兹罗提"],["Grosz", "格罗希"],["Qatari riyal", "卡达里亚尔"],["Saudi riyal", "沙特里亚尔"],["Riyal", "里亚尔"],["Dirham", "迪拉姆"],["Halala", "哈拉"],["Samoan tālā", "萨摩亚塔拉"],["Sierra Leonean leone", "塞拉利昂利昂|利昂"],["Peseta", "比塞塔|西班牙比塞塔|西班牙币"],["Swazi lilangeni", "斯威士兰里兰吉尼|兰吉尼"],["Tajikistani somoni", "塔吉克斯坦索莫尼"],["Thai baht", "泰铢|泰元"],["Satang", "萨当"],["Tongan paʻanga", "汤加潘加|潘加"],["Ukrainian hryvnia", "乌克兰格里夫纳|格里夫纳"],["Vanuatu vatu", "瓦努阿图瓦图"],["Vietnamese dong", "越南盾"],["Indonesian rupiah", "印度尼西亚盾"],["Netherlands guilder", "荷兰盾|荷属安的列斯盾|列斯盾"],["Surinam florin", "苏里南盾"],["Guilder", "盾"],["Zambian kwacha", "赞比亚克瓦查"],["Moroccan dirham", "摩洛哥迪拉姆"],["United Arab Emirates dirham", "阿联酋迪拉姆"],["Azerbaijani manat", "阿塞拜疆马纳特"],["Turkmenistan manat", "土库曼马纳特"],["Manat", "马纳特"],["Somali shilling", "索马里先令|索马利先令"],["Somaliland shilling", "索马里兰先令"],["Tanzanian shilling", "坦桑尼亚先令"],["Ugandan shilling", "乌干达先令"],["Romanian leu", "罗马尼亚列伊"],["Moldovan leu", "摩尔多瓦列伊"],["Leu", "列伊"],["Ban", "巴尼"],["Nepalese rupee", "尼泊尔卢比"],["Pakistani rupee", "巴基斯坦卢比"],["Indian rupee", "印度卢比"],["Seychellois rupee", "塞舌尔卢比"],["Mauritian rupee", "毛里求斯卢比"],["Maldivian rufiyaa", "马尔代夫卢比"],["Sri Lankan rupee", "斯里兰卡卢比"],["Rupee", "卢比"],["Czech koruna", "捷克克朗"],["Danish krone", "丹麦克朗|丹麦克郎"],["Norwegian krone", "挪威克朗"],["Faroese króna", "法罗克朗"],["Icelandic króna", "冰岛克朗"],["Swedish krona", "瑞典克朗"],["Krone", "克朗"],["Øre", "奥依拉|奥拉|埃利"],["West African CFA franc", "非共体法郎"],["Central African CFA franc", "中非法郎|中非金融合作法郎"],["Comorian franc", "科摩罗法郎"],["Congolese franc", "刚果法郎"],["Burundian franc", "布隆迪法郎"],["Djiboutian franc", "吉布提法郎"],["CFP franc", "太平洋法郎"],["Guinean franc", "几内亚法郎"],["Swiss franc", "瑞士法郎"],["Rwandan franc", "卢旺达法郎"],["Belgian franc", "比利时法郎"],["Rappen", "瑞士分|瑞士生丁"],["Franc", "法郎"],["Centime", "生丁|仙士"],["Russian ruble", "俄国卢布|俄罗斯卢布"],["Transnistrian ruble", "德涅斯特卢布"],["Belarusian ruble", "白俄罗斯卢布"],["Kopek", "戈比"],["Ruble", "卢布"],["Algerian dinar", "阿尔及利亚第纳尔"],["Bahraini dinar", "巴林第纳尔"],["Iraqi dinar", "伊拉克第纳尔"],["Jordanian dinar", "约旦第纳尔"],["Kuwaiti dinar", "科威特第纳尔|科威特币"],["Libyan dinar", "利比亚第纳尔"],["Serbian dinar", "塞尔维亚第纳尔|塞尔维亚币"],["Tunisian dinar", "突尼斯第纳尔"],["Dinar", "第纳尔"],["Fils", "费尔"],["Para", "帕拉"],["Millime", "米利姆"],["Argentine peso", "阿根廷比索"],["Chilean peso", "智利比索"],["Colombian peso", "哥伦比亚比索"],["Cuban peso", "古巴比索"],["Dominican peso", "多米尼加比索"],["Mexican peso", "墨西哥比索"],["Philippine peso", "菲律宾比索"],["Uruguayan peso", "乌拉圭比索"],["Peso", "比索"],["Centavo", "仙|菲辅币"],["Alderney pound", "奥尔德尼镑"],["British pound", "英镑"],["Guernsey pound", "根西镑"],["Saint Helena pound", "圣赫勒拿镑"],["Egyptian pound", "埃及镑"],["Falkland Islands pound", "福克兰镑"],["Gibraltar pound", "直布罗陀镑"],["Manx pound", "马恩岛镑"],["Jersey pound", "泽西岛镑"],["Lebanese pound", "黎巴嫩镑"],["South Sudanese pound", "南苏丹镑"],["Sudanese pound", "苏丹镑"],["Syrian pound", "叙利亚镑"],["Pence", "便士"],["Shilling", "先令"],["United States dollar", "美元|美金|美圆"],["East Caribbean dollar", "东加勒比元"],["Australian dollar", "澳大利亚元|澳元"],["Bahamian dollar", "巴哈马元"],["Barbadian dollar", "巴巴多斯元"],["Belize dollar", "伯利兹元"],["Bermudian dollar", "百慕大元"],["Brunei dollar", "文莱元"],["Singapore dollar", "新加坡元|新元"],["Canadian dollar", "加元|加拿大元"],["Cayman Islands dollar", "开曼岛元"],["New Zealand dollar", "新西兰元|纽元"],["Cook Islands dollar", "库克群岛元"],["Fijian dollar", "斐济元|斐币"],["Guyanese dollar", "圭亚那元"],["Hong Kong dollar", "蚊|港元|港圆|港币"],["Macau Pataca", "澳门币|澳门元"],["New Taiwan dollar", "箍|新台币|台币"],["Jamaican dollar", "牙买加元"],["Kiribati dollar", "吉里巴斯元"],["Liberian dollar", "利比里亚元"],["Namibian dollar", "纳米比亚元"],["Surinamese dollar", "苏里南元"],["Trinidad and Tobago dollar", "特立尼达多巴哥元"],["Tuvaluan dollar", "吐瓦鲁元"],["Chinese yuan", "人民币|人民币元|元人民币|块钱|块|元|圆"],["Fen", "分钱|分"],["Jiao", "毛钱|毛|角钱|角"],["Finnish markka", "芬兰马克"],["Penni", "盆尼"]]);
    export const CurrencyNameToIsoCodeMap: ReadonlyMap<string, string> = new Map<string, string>([["Afghan afghani", "AFN"],["Euro", "EUR"],["Albanian lek", "ALL"],["Angolan kwanza", "AOA"],["Armenian dram", "AMD"],["Aruban florin", "AWG"],["Bangladeshi taka", "BDT"],["Bhutanese ngultrum", "BTN"],["Bolivian boliviano", "BOB"],["Bosnia and Herzegovina convertible mark", "BAM"],["Botswana pula", "BWP"],["Brazilian real", "BRL"],["Bulgarian lev", "BGN"],["Cambodian riel", "KHR"],["Cape Verdean escudo", "CVE"],["Costa Rican colón", "CRC"],["Croatian kuna", "HRK"],["Czech koruna", "CZK"],["Eritrean nakfa", "ERN"],["Ethiopian birr", "ETB"],["Gambian dalasi", "GMD"],["Georgian lari", "GEL"],["Ghanaian cedi", "GHS"],["Guatemalan quetzal", "GTQ"],["Haitian gourde", "HTG"],["Honduran lempira", "HNL"],["Hungarian forint", "HUF"],["Iranian rial", "IRR"],["Yemeni rial", "YER"],["Israeli new shekel", "ILS"],["Japanese yen", "JPY"],["Kazakhstani tenge", "KZT"],["Kenyan shilling", "KES"],["North Korean won", "KPW"],["South Korean won", "KRW"],["Kyrgyzstani som", "KGS"],["Lao kip", "LAK"],["Lesotho loti", "LSL"],["South African rand", "ZAR"],["Macanese pataca", "MOP"],["Macedonian denar", "MKD"],["Malagasy ariary", "MGA"],["Malawian kwacha", "MWK"],["Malaysian ringgit", "MYR"],["Mauritanian ouguiya", "MRO"],["Mongolian tögrög", "MNT"],["Mozambican metical", "MZN"],["Burmese kyat", "MMK"],["Nicaraguan córdoba", "NIO"],["Nigerian naira", "NGN"],["Turkish lira", "TRY"],["Omani rial", "OMR"],["Panamanian balboa", "PAB"],["Papua New Guinean kina", "PGK"],["Paraguayan guaraní", "PYG"],["Peruvian sol", "PEN"],["Polish złoty", "PLN"],["Qatari riyal", "QAR"],["Saudi riyal", "SAR"],["Samoan tālā", "WST"],["São Tomé and Príncipe dobra", "STD"],["Sierra Leonean leone", "SLL"],["Swazi lilangeni", "SZL"],["Tajikistani somoni", "TJS"],["Thai baht", "THB"],["Ukrainian hryvnia", "UAH"],["Vanuatu vatu", "VUV"],["Venezuelan bolívar", "VEF"],["Zambian kwacha", "ZMW"],["Moroccan dirham", "MAD"],["United Arab Emirates dirham", "AED"],["Azerbaijani manat", "AZN"],["Turkmenistan manat", "TMT"],["Somali shilling", "SOS"],["Tanzanian shilling", "TZS"],["Ugandan shilling", "UGX"],["Romanian leu", "RON"],["Moldovan leu", "MDL"],["Nepalese rupee", "NPR"],["Pakistani rupee", "PKR"],["Indian rupee", "INR"],["Seychellois rupee", "SCR"],["Mauritian rupee", "MUR"],["Maldivian rufiyaa", "MVR"],["Sri Lankan rupee", "LKR"],["Indonesian rupiah", "IDR"],["Danish krone", "DKK"],["Norwegian krone", "NOK"],["Icelandic króna", "ISK"],["Swedish krona", "SEK"],["West African CFA franc", "XOF"],["Central African CFA franc", "XAF"],["Comorian franc", "KMF"],["Congolese franc", "CDF"],["Burundian franc", "BIF"],["Djiboutian franc", "DJF"],["CFP franc", "XPF"],["Guinean franc", "GNF"],["Swiss franc", "CHF"],["Rwandan franc", "RWF"],["Russian ruble", "RUB"],["Transnistrian ruble", "PRB"],["Belarusian ruble", "BYN"],["Algerian dinar", "DZD"],["Bahraini dinar", "BHD"],["Iraqi dinar", "IQD"],["Jordanian dinar", "JOD"],["Kuwaiti dinar", "KWD"],["Libyan dinar", "LYD"],["Serbian dinar", "RSD"],["Tunisian dinar", "TND"],["Argentine peso", "ARS"],["Chilean peso", "CLP"],["Colombian peso", "COP"],["Cuban convertible peso", "CUC"],["Cuban peso", "CUP"],["Dominican peso", "DOP"],["Mexican peso", "MXN"],["Uruguayan peso", "UYU"],["British pound", "GBP"],["Saint Helena pound", "SHP"],["Egyptian pound", "EGP"],["Falkland Islands pound", "FKP"],["Gibraltar pound", "GIP"],["Manx pound", "IMP"],["Jersey pound", "JEP"],["Lebanese pound", "LBP"],["South Sudanese pound", "SSP"],["Sudanese pound", "SDG"],["Syrian pound", "SYP"],["United States dollar", "USD"],["Australian dollar", "AUD"],["Bahamian dollar", "BSD"],["Barbadian dollar", "BBD"],["Belize dollar", "BZD"],["Bermudian dollar", "BMD"],["Brunei dollar", "BND"],["Singapore dollar", "SGD"],["Canadian dollar", "CAD"],["Cayman Islands dollar", "KYD"],["New Zealand dollar", "NZD"],["Fijian dollar", "FJD"],["Guyanese dollar", "GYD"],["Hong Kong dollar", "HKD"],["Jamaican dollar", "JMD"],["Liberian dollar", "LRD"],["Namibian dollar", "NAD"],["Solomon Islands dollar", "SBD"],["Surinamese dollar", "SRD"],["New Taiwan dollar", "TWD"],["Trinidad and Tobago dollar", "TTD"],["Tuvaluan dollar", "TVD"],["Chinese yuan", "CNY"],["Rial", "__RI"],["Shiling", "__S"],["Som", "__SO"],["Dirham", "__DR"],["Dinar", "_DN"],["Dollar", "__D"],["Manat", "__MA"],["Rupee", "__R"],["Krone", "__K"],["Krona", "__K"],["Crown", "__K"],["Frank", "__F"],["Mark", "__M"],["Ruble", "__RB"],["Peso", "__PE"],["Pound", "__P"],["Tristan da Cunha pound", "_TP"],["South Georgia and the South Sandwich Islands pound", "_SP"],["Somaliland shilling", "_SS"],["Pitcairn Islands dollar", "_PND"],["Palauan dollar", "_PD"],["Niue dollar", "_NID"],["Nauruan dollar", "_ND"],["Micronesian dollar", "_MD"],["Kiribati dollar", "_KID"],["Guernsey pound", "_GGP"],["Faroese króna", "_FOK"],["Cook Islands dollar", "_CKD"],["British Virgin Islands dollar", "_BD"],["Ascension pound", "_AP"],["Alderney pound", "_ALP"],["Abkhazian apsar", "_AA"]]);
    export const FractionalUnitNameToCodeMap: ReadonlyMap<string, string> = new Map<string, string>([["Jiao", "JIAO"],["Kopek", "KOPEK"],["Pul", "PUL"],["Cent", "CENT"],["Qindarkë", "QINDARKE"],["Penny", "PENNY"],["Santeem", "SANTEEM"],["Cêntimo", "CENTIMO"],["Centavo", "CENTAVO"],["Luma", "LUMA"],["Qəpik", "QƏPIK"],["Fils", "FILS"],["Poisha", "POISHA"],["Kapyeyka", "KAPYEYKA"],["Centime", "CENTIME"],["Chetrum", "CHETRUM"],["Paisa", "PAISA"],["Fening", "FENING"],["Thebe", "THEBE"],["Sen", "SEN"],["Stotinka", "STOTINKA"],["Fen", "FEN"],["Céntimo", "CENTIMO"],["Lipa", "LIPA"],["Haléř", "HALER"],["Øre", "ØRE"],["Piastre", "PIASTRE"],["Santim", "SANTIM"],["Oyra", "OYRA"],["Butut", "BUTUT"],["Tetri", "TETRI"],["Pesewa", "PESEWA"],["Fillér", "FILLER"],["Eyrir", "EYRIR"],["Dinar", "DINAR"],["Agora", "AGORA"],["Tïın", "TIIN"],["Chon", "CHON"],["Jeon", "JEON"],["Tyiyn", "TYIYN"],["Att", "ATT"],["Sente", "SENTE"],["Dirham", "DIRHAM"],["Rappen", "RAPPEN"],["Avo", "AVO"],["Deni", "DENI"],["Iraimbilanja", "IRAIMBILANJA"],["Tambala", "TAMBALA"],["Laari", "LAARI"],["Khoums", "KHOUMS"],["Ban", "BAN"],["Möngö", "MONGO"],["Pya", "PYA"],["Kobo", "KOBO"],["Kuruş", "KURUS"],["Baisa", "BAISA"],["Centésimo", "CENTESIMO"],["Toea", "TOEA"],["Sentimo", "SENTIMO"],["Grosz", "GROSZ"],["Sene", "SENE"],["Halala", "HALALA"],["Para", "PARA"],["Öre", "ORE"],["Diram", "DIRAM"],["Satang", "SATANG"],["Seniti", "SENITI"],["Millime", "MILLIME"],["Tennesi", "TENNESI"],["Kopiyka", "KOPIYKA"],["Tiyin", "TIYIN"],["Hào", "HAO"],["Ngwee", "NGWEE"]]);
    export const CompoundUnitConnectorRegex = `(?<spacer>又|再)`;
    export const CurrencyPrefixList: ReadonlyMap<string, string> = new Map<string, string>([["Dollar", "$"],["United States dollar", "us$"],["British Virgin Islands dollar", "bvi$"],["Brunei dollar", "b$"],["Sen", "sen"],["Singapore dollar", "s$"],["Canadian dollar", "can$|c$|c $"],["Cayman Islands dollar", "ci$"],["New Zealand dollar", "nz$|nz $"],["Guyanese dollar", "gy$|gy $|g$|g $"],["Hong Kong dollar", "hk$|hkd|hk $"],["Jamaican dollar", "j$"],["Namibian dollar", "nad|n$|n $"],["Solomon Islands dollar", "si$|si $"],["New Taiwan dollar", "nt$|nt $"],["Samoan tālā", "ws$"],["Chinese yuan", "￥"],["Japanese yen", "¥"],["Turkish lira", "₺"],["Euro", "€"],["Pound", "£"],["Costa Rican colón", "₡"]]);
    export const CurrencyAmbiguousValues = [ "元","仙","分","圆","块","毛","盾","箍","蚊","角" ];
    export const DimensionSuffixList: ReadonlyMap<string, string> = new Map<string, string>([["Meter", "米|公尺|m"],["Kilometer", "千米|公里|km"],["Decimeter", "分米|公寸|dm"],["Centimeter", "釐米|厘米|公分|cm"],["Micrometer", "毫米|公釐|mm"],["Microns", "微米"],["Picometer", "皮米"],["Nanometer", "纳米"],["Li", "里|市里"],["Zhang", "丈"],["Chi", "市尺|尺"],["Cun", "市寸|寸"],["Fen", "市分|分"],["Hao", "毫"],["Mile", "英里"],["Inch", "英寸"],["Foot", "呎|英尺"],["Yard", "码"],["Knot", "海里"],["Light year", "光年"],["Meter per second", "米每秒|米/秒|m/s"],["Kilometer per hour", "公里每小时|千米每小时|公里/小时|千米/小时|km/h"],["Kilometer per minute", "公里每分钟|千米每分钟|公里/分钟|千米/分钟|km/min"],["Kilometer per second", "公里每秒|千米每秒|公里/秒|千米/秒|km/s"],["Mile per hour", "英里每小时|英里/小时"],["Foot per second", "英尺每小时|英尺/小时"],["Foot per minute", "英尺每分钟|英尺/分钟"],["Yard per minute", "码每分|码/分"],["Yard per second", "码每秒|码/秒"],["Square centimetre", "平方厘米"],["Square decimeter", "平方分米"],["Square meter", "平方米"],["Square kilometer", "平方公里"],["Acre", "英亩|公亩"],["Hectare", "公顷"],["Mu", "亩|市亩"],["Liter", "公升|升|l"],["Milliliter", "毫升|ml"],["Cubic meter", "立方米"],["Cubic decimeter", "立方分米"],["Cubic millimeter", "立方毫米"],["Cubic feet", "立方英尺"],["Gallon", "加仑"],["Pint", "品脱"],["Dou", "市斗|斗"],["Dan", "市石|石"],["Kilogram", "千克|公斤|kg"],["Jin", "市斤|斤"],["Milligram", "毫克|mg"],["Barrel", "桶"],["Pot", "罐"],["Gram", "克|g"],["Ton", "公吨|吨|t"],["Pound", "磅"],["Ounce", "盎司"],["Bit", "比特|位|b"],["Byte", "字节|byte"],["Kilobyte", "千字节|kb"],["Megabyte", "兆字节|mb"],["Gigabyte", "十亿字节|千兆字节|gb"],["Terabyte", "万亿字节|兆兆字节|tb"],["Petabyte", "千兆兆|千万亿字节|pb"],["Byte", "字节|byte|Byte"],["Kilobyte", "千字节|kB|KB"],["Megabyte", "兆字节|mB|MB"],["Gigabyte", "十亿字节|千兆字节|gB|GB"],["Terabyte", "万亿字节|兆兆字节|tB|TB"],["Petabyte", "千兆兆字节|千万亿字节|pB|PB"],["Watt", "瓦|瓦特|w"],["Kilowatt", "千瓦|千瓦特|kw"],["Megawatt", "兆瓦|兆瓦特"],["Terawatt", "万亿瓦|兆兆瓦"],["Hertz", "赫|赫兹|Hz"],["Kilohertz", "千赫|千赫兹|kHz"],["Megahertz", "兆赫|兆赫兹|mHz"],["Gigahertz", "十亿赫兹|千兆赫兹|十亿赫|千兆赫|gHz"],["Calorie", "卡|卡路里|大卡|cal"],["Kilocalorie", "千卡|千卡路里|千大卡|kcal"],["Joule", "焦|焦耳|j"],["Kilojoule", "千焦|千焦耳|kj"]]);
    export const DimensionAmbiguousValues = [ "丈","位","克","分","升","寸","尺","斗","斤","桶","毫","石","码","磅","米","罐","里","m","km","dm","cm","mm","l","ml","kg","mg","g","t","b","byte","kb","mb","gb","tb","pb" ];
    export const AmbiguityFiltersDict: ReadonlyMap<string, string> = new Map<string, string>([["五角", "五角大楼"],["普尔", "标准普尔"]]);
    export const TemperatureSuffixList: ReadonlyMap<string, string> = new Map<string, string>([["F", "华氏温度|华氏度|°f"],["K", "开尔文温度|开氏度|凯氏度|K|k"],["R", "兰氏温度|°r"],["C", "摄氏温度|摄氏度|°c"],["Degree", "度"]]);
    export const TemperaturePrefixList: ReadonlyMap<string, string> = new Map<string, string>([["F", "华氏温度|华氏"],["K", "开氏温度|开氏"],["R", "兰氏温度|兰氏"],["C", "摄氏温度|摄氏"]]);
    export const TemperatureAmbiguousValues = [ "度","k" ];
    export const HalfUnitRegex = `半`;
}
