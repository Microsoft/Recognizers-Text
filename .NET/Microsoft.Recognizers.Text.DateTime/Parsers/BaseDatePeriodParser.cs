﻿using Microsoft.Recognizers.Text.DateTime.Utilities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using DateObject = System.DateTime;

namespace Microsoft.Recognizers.Text.DateTime
{
    public class BaseDatePeriodParser : IDateTimeParser
    {
        public static readonly string ParserName = Constants.SYS_DATETIME_DATEPERIOD; //"DatePeriod";

        private static readonly Calendar Cal = DateTimeFormatInfo.InvariantInfo.Calendar;

        private readonly IDatePeriodParserConfiguration config;

        private static bool InclusiveEndPeriod = false;

        public BaseDatePeriodParser(IDatePeriodParserConfiguration configuration)
        {
            config = configuration;
        }

        public ParseResult Parse(ExtractResult result)
        {
            return this.Parse(result, DateObject.Now);
        }

        public DateTimeParseResult Parse(ExtractResult er, DateObject refDate)
        {
            object value = null;

            if (er.Type.Equals(ParserName))
            {
                var innerResult = ParseBaseDatePeriod(er.Text, refDate);

                if (!innerResult.Success)
                {
                    innerResult = ParseComplexDatePeriod(er.Text, refDate);
                }

                if (innerResult.Success)
                {                                     
                    if (innerResult.Mod == Constants.BEFORE_MOD)
                    {
                        innerResult.FutureResolution = new Dictionary<string, string>
                        {
                            {
                                TimeTypeConstants.END_DATE,
                                DateTimeFormatUtil.FormatDate((DateObject)innerResult.FutureValue)
                            }
                        };

                        innerResult.PastResolution = new Dictionary<string, string>
                        {
                            {
                                TimeTypeConstants.END_DATE,
                                DateTimeFormatUtil.FormatDate((DateObject)innerResult.PastValue)
                            }
                        };
                    }
                    else if (innerResult.Mod == Constants.AFTER_MOD)
                    {
                        innerResult.FutureResolution = new Dictionary<string, string>
                        {
                            {
                                TimeTypeConstants.START_DATE,
                                DateTimeFormatUtil.FormatDate((DateObject)innerResult.FutureValue)
                            }
                        };

                        innerResult.PastResolution = new Dictionary<string, string>
                        {
                            {
                                TimeTypeConstants.START_DATE,
                                DateTimeFormatUtil.FormatDate((DateObject)innerResult.PastValue)
                            }
                        };
                    }
                    else if (innerResult.FutureValue != null && innerResult.PastValue != null)
                    {
                        innerResult.FutureResolution = new Dictionary<string, string>
                        {
                            {
                                TimeTypeConstants.START_DATE,
                                DateTimeFormatUtil.FormatDate(((Tuple<DateObject, DateObject>) innerResult.FutureValue).Item1)
                            },
                            {
                                TimeTypeConstants.END_DATE,
                                DateTimeFormatUtil.FormatDate(((Tuple<DateObject, DateObject>) innerResult.FutureValue).Item2)
                            }
                        };

                        innerResult.PastResolution = new Dictionary<string, string>
                        {
                            {
                                TimeTypeConstants.START_DATE,
                                DateTimeFormatUtil.FormatDate(((Tuple<DateObject, DateObject>) innerResult.PastValue).Item1)
                            },
                            {
                                TimeTypeConstants.END_DATE,
                                DateTimeFormatUtil.FormatDate(((Tuple<DateObject, DateObject>) innerResult.PastValue).Item2)
                            }
                        };
                    }
                    else
                    {
                        innerResult.FutureResolution = innerResult.PastResolution = new Dictionary<string, string>();
                    }

                    value = innerResult;
                }
            }

            var ret = new DateTimeParseResult
            {
                Text = er.Text,
                Start = er.Start,
                Length = er.Length,
                Type = er.Type,
                Data = er.Data,
                Metadata = er.Metadata,
                Value = value,
                TimexStr = value == null ? "" : ((DateTimeResolutionResult)value).Timex,
                ResolutionStr = ""
            };

            return ret;
        }

        // Process case like "from|between START to|and END" where START/END can be daterange or datepoint
        private DateTimeResolutionResult ParseComplexDatePeriod(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var match = this.config.ComplexDatePeriodRegex.Match(text);

            if (match.Success)
            {
                var futureBegin = DateObject.MinValue;
                var futureEnd = DateObject.MinValue;
                var pastBegin = DateObject.MinValue;
                var pastEnd = DateObject.MinValue;
                var isSpecificDate = false;
                var isStartByWeek = false;
                var isEndByWeek = false;
                var dateContext = GetYearContext(match.Groups["start"].Value.Trim(), match.Groups["end"].Value.Trim(), text);

                var startResolution = ParseSingleTimePoint(match.Groups["start"].Value.Trim(), referenceDate, dateContext);

                if (startResolution.Success)
                {
                    futureBegin = (DateObject)startResolution.FutureValue;
                    pastBegin = (DateObject)startResolution.PastValue;
                    isSpecificDate = true;
                }
                else
                {
                    startResolution = ParseBaseDatePeriod(match.Groups["start"].Value.Trim(), referenceDate, dateContext);

                    if (startResolution.Success)
                    {
                        futureBegin = ((Tuple<DateObject, DateObject>)startResolution.FutureValue).Item1;
                        pastBegin = ((Tuple<DateObject, DateObject>)startResolution.PastValue).Item1;

                        if (startResolution.Timex.Contains("-W"))
                        {
                            isStartByWeek = true;
                        }
                    }
                }

                if (startResolution.Success)
                {
                    var endResolution = ParseSingleTimePoint(match.Groups["end"].Value.Trim(), referenceDate, dateContext);

                    if (endResolution.Success)
                    {
                        futureEnd = (DateObject)endResolution.FutureValue;
                        pastEnd = (DateObject)endResolution.PastValue;
                        isSpecificDate = true;
                    }
                    else
                    {
                        endResolution = ParseBaseDatePeriod(match.Groups["end"].Value.Trim(), referenceDate, dateContext);

                        if (endResolution.Success)
                        {
                            futureEnd = ((Tuple<DateObject, DateObject>)endResolution.FutureValue).Item1;
                            pastEnd = ((Tuple<DateObject, DateObject>)endResolution.PastValue).Item1;
                            if (endResolution.Timex.Contains("-W"))
                            {
                                isEndByWeek = true;
                            }
                        }
                    }

                    if (endResolution.Success)
                    {
                        if (futureBegin > futureEnd)
                        {
                            if (dateContext == null || dateContext.IsEmpty())
                            {
                                futureBegin = pastBegin;
                            }
                            else
                            {
                                futureBegin = dateContext.SwiftDateObject(futureBegin, futureEnd);
                            }
                        }

                        if (pastEnd < pastBegin)
                        {
                            if (dateContext == null || dateContext.IsEmpty())
                            {
                                pastEnd = futureEnd;
                            }
                            else
                            {
                                pastBegin = dateContext.SwiftDateObject(pastBegin, pastEnd);
                            }
                        }

                        // If both begin/end are date ranges in "Month", the Timex should be ByMonth
                        // The year period case should already be handled in Basic Cases
                        var datePeriodTimexType = DatePeriodTimexType.ByMonth;

                        if (isSpecificDate)
                        {
                            // If at least one of the begin/end is specific date, the Timex should be    ByDay
                            datePeriodTimexType = DatePeriodTimexType.ByDay;
                        }
                        else if (isStartByWeek && isEndByWeek)
                        {
                            // If both begin/end are date ranges in "Week", the Timex should be ByWeek
                            datePeriodTimexType = DatePeriodTimexType.ByWeek;
                        }

                        ret.Timex = TimexUtility.GenerateDatePeriodTimex(futureBegin, futureEnd, datePeriodTimexType, pastBegin, pastEnd);

                        ret.FutureValue = new Tuple<DateObject, DateObject>(futureBegin, futureEnd);
                        ret.PastValue = new Tuple<DateObject, DateObject>(pastBegin, pastEnd);
                        ret.Success = true;
                    }
                }
            }

            return ret;
        }

        private DateTimeResolutionResult ParseBaseDatePeriod(string text, DateObject referenceDate, DateContext dateContext = null)
        {
            var innerResult = ParseMonthWithYear(text, referenceDate);
            if (!innerResult.Success)
            {
                innerResult = ParseSimpleCases(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseOneWordPeriod(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = MergeTwoTimePoints(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseYear(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseWeekOfMonth(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseWeekOfYear(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseHalfYear(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseQuarter(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseSeason(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseWhichWeek(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseWeekOfDate(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseMonthOfDate(text, referenceDate);
            }

            if (!innerResult.Success)
            {
                innerResult = ParseDecade(text, referenceDate);
            }

            // Cases like "within/less than/more than x weeks from/before/after today"
            if (!innerResult.Success)
            {
                innerResult = ParseDatePointWithAgoAndLater(text, referenceDate);
            }

            // Parse duration should be at the end since it will extract "the last week" from "the last week of July"
            if (!innerResult.Success)
            {
                innerResult = ParseDuration(text, referenceDate);
            }

            // Cases like "21st century"
            if (!innerResult.Success)
            {
                innerResult = ParseOrdinalNumberWithCenturySuffix(text, referenceDate);
            }

            if (innerResult.Success && dateContext != null)
            {
                innerResult = dateContext.ProcessDatePeriodEntityResolution(innerResult);
            }

            return innerResult;
        }

        // Cases like "21st century"
        private DateTimeResolutionResult ParseOrdinalNumberWithCenturySuffix(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var er = this.config.OrdinalExtractor.Extract(text).FirstOrDefault();

            if (er != null && er.Start + er.Length < text.Length)
            {
                var afterString = text.Substring((er.Start + er.Length).Value).Trim();

                // It falls into the cases like "21st century"
                if (this.config.CenturySuffixRegex.Match(afterString).Success)
                {
                    var number = this.config.NumberParser.Parse(er);

                    if (number.Value != null)
                    {
                        // Note that 1st century means from year 0 - 100
                        var startYear = (Convert.ToInt32((double)number.Value) - 1) * Constants.CenturyYearsCount;
                        var startDate = new DateObject(startYear, 1, 1);
                        var endDate = new DateObject(startYear + Constants.CenturyYearsCount, 1, 1);

                        var startLuisStr = DateTimeFormatUtil.LuisDate(startDate);
                        var endLuisStr = DateTimeFormatUtil.LuisDate(endDate);
                        var durationTimex = $"P{Constants.CenturyYearsCount}Y";

                        ret.Timex = $"({startLuisStr},{endLuisStr},{durationTimex})";
                        ret.FutureValue = new Tuple<DateObject, DateObject>(startDate,
                            endDate);
                        ret.PastValue = new Tuple<DateObject, DateObject>(startDate,
                            endDate);
                        ret.Success = true;
                    }
                }
            }

            return ret;
        }

        // Only handle cases like "within/less than/more than x weeks from/before/after today"
        private DateTimeResolutionResult ParseDatePointWithAgoAndLater(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var er = this.config.DateExtractor.Extract(text, referenceDate).FirstOrDefault();

            if (er != null)
            {
                var beforeString = text.Substring(0, (int)er.Start);
                var isAgo = this.config.AgoRegex.Match(er.Text).Success;
                var isLater = this.config.LaterRegex.Match(er.Text).Success;

                if (!string.IsNullOrEmpty(beforeString) && (isAgo || isLater))
                {
                    var isLessThanOrWithIn = false;
                    var isMoreThan = false;

                    // cases like "within 3 days from yesterday/tomorrow" does not make any sense
                    if (er.Text.Contains("today") || er.Text.Contains("now"))
                    {
                        var match = this.config.WithinNextPrefixRegex.Match(beforeString);
                        if (match.Success)
                        {
                            var isNext = !string.IsNullOrEmpty(match.Groups["next"].Value);

                            // cases like "within the next 5 days before today" is not acceptable
                            if (!(isNext && isAgo))
                            {
                                isLessThanOrWithIn = true;
                            }
                        }
                    }

                    isLessThanOrWithIn = isLessThanOrWithIn || this.config.LessThanRegex.Match(beforeString).Success;
                    isMoreThan = this.config.MoreThanRegex.Match(beforeString).Success;

                    var pr = this.config.DateParser.Parse(er, referenceDate);
                    var durationExtractionResult = this.config.DurationExtractor.Extract(er.Text).FirstOrDefault();

                    if (durationExtractionResult != null)
                    {
                        var duration = this.config.DurationParser.Parse(durationExtractionResult);
                        var durationInSeconds = (double)((DateTimeResolutionResult)(duration.Value)).PastValue;

                        if (isLessThanOrWithIn)
                        {
                            DateObject startDate;
                            DateObject endDate;

                            if (isAgo)
                            {
                                startDate = (DateObject)((DateTimeResolutionResult)pr.Value).PastValue;
                                endDate = startDate.AddSeconds(durationInSeconds);
                            }
                            else
                            {
                                endDate = (DateObject)((DateTimeResolutionResult)pr.Value).FutureValue;
                                startDate = endDate.AddSeconds(-durationInSeconds);
                            }

                            if (startDate != DateObject.MinValue)
                            {
                                var startLuisStr = DateTimeFormatUtil.LuisDate(startDate);
                                var endLuisStr = DateTimeFormatUtil.LuisDate(endDate);
                                var durationTimex = ((DateTimeResolutionResult)duration.Value).Timex;

                                ret.Timex = $"({startLuisStr},{endLuisStr},{durationTimex})";
                                ret.FutureValue = new Tuple<DateObject, DateObject>(startDate,
                                    endDate);
                                ret.PastValue = new Tuple<DateObject, DateObject>(startDate,
                                    endDate);
                                ret.Success = true;
                            }
                        }
                        else if (isMoreThan)
                        {
                            ret.Mod = isAgo ? Constants.BEFORE_MOD : Constants.AFTER_MOD;

                            ret.Timex = $"{pr.TimexStr}";
                            ret.FutureValue = (DateObject)((DateTimeResolutionResult)pr.Value).FutureValue;
                            ret.PastValue = (DateObject)((DateTimeResolutionResult)pr.Value).PastValue;
                            ret.Success = true;
                        }
                    }
                }
            }

            return ret;
        }

        private DateTimeResolutionResult ParseSingleTimePoint(string text, DateObject referenceDate, DateContext dateContext = null)
        {
            var ret = new DateTimeResolutionResult();
            var er = this.config.DateExtractor.Extract(text, referenceDate).FirstOrDefault();

            if (er != null)
            {
                var match = this.config.WeekWithWeekDayRangeRegex.Match(text);
                string weekPrefix = null;
                if (match.Success)
                {
                    weekPrefix = match.Groups["week"].ToString();
                }

                if (!string.IsNullOrEmpty(weekPrefix))
                {
                    er.Text = weekPrefix + " " + er.Text;
                }

                var pr = this.config.DateParser.Parse(er, referenceDate);

                if (pr != null)
                {
                    ret.Timex = $"({pr.TimexStr}";
                    ret.FutureValue = (DateObject)((DateTimeResolutionResult)pr.Value).FutureValue;
                    ret.PastValue = (DateObject)((DateTimeResolutionResult)pr.Value).PastValue;
                    ret.Success = true;
                }

                if (dateContext != null)
                {
                    ret = dateContext.ProcessDateEntityResolution(ret);
                }
            }

            return ret;
        }

        private DateTimeResolutionResult ParseSimpleCases(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            int year = referenceDate.Year, month = referenceDate.Month;
            int beginDay, endDay;
            var noYear = true;

            var match = this.config.MonthFrontBetweenRegex.MatchExact(text, trim: true);
            string beginLuisStr, endLuisStr;

            if (!match.Success)
            {
                match = this.config.BetweenRegex.MatchExact(text, trim: true);
            }

            if (!match.Success)
            {
                match = this.config.MonthFrontSimpleCasesRegex.MatchExact(text, trim: true);
            }

            if (!match.Success)
            {
                match = this.config.SimpleCasesRegex.MatchExact(text, trim: true);
            }

            if (match.Success)
            {
                var days = match.Groups["day"];
                beginDay = this.config.DayOfMonth[days.Captures[0].Value.ToLower()];
                endDay = this.config.DayOfMonth[days.Captures[1].Value.ToLower()];

                // parse year
                year = config.DateExtractor.GetYearFromText(match.Match);

                if (year != Constants.InvalidYear)
                {
                    noYear = false;
                }
                else
                {
                    year = referenceDate.Year;
                }

                var monthStr = match.Groups["month"].Value;

                if (!string.IsNullOrEmpty(monthStr))
                {
                    month = this.config.MonthOfYear[monthStr.ToLower()];
                }
                else
                {
                    monthStr = match.Groups["relmonth"].Value.Trim().ToLower();
                    var swiftMonth = this.config.GetSwiftDayOrMonth(monthStr);
                    switch (swiftMonth)
                    {
                        case 1:
                            if (month != 12)
                            {
                                month += 1;
                            }
                            else
                            {
                                month = 1;
                                year += 1;
                            }
                            break;
                        case -1:
                            if (month != 1)
                            {
                                month -= 1;
                            }
                            else
                            {
                                month = 12;
                                year -= 1;
                            }
                            break;
                        default:
                            break;
                    }

                    if (this.config.IsFuture(monthStr))
                    {
                        noYear = false;
                    }
                }
            }
            else
            {
                return ret;
            }

            if (noYear)
            {
                beginLuisStr = DateTimeFormatUtil.LuisDate(-1, month, beginDay);
                endLuisStr = DateTimeFormatUtil.LuisDate(-1, month, endDay);
            }
            else
            {
                beginLuisStr = DateTimeFormatUtil.LuisDate(year, month, beginDay);
                endLuisStr = DateTimeFormatUtil.LuisDate(year, month, endDay);
            }

            int futureYear = year, pastYear = year;
            var startDate = DateObject.MinValue.SafeCreateFromValue(year, month, beginDay);

            if (noYear && startDate < referenceDate)
            {
                futureYear++;
            }

            if (noYear && startDate >= referenceDate)
            {
                pastYear--;
            }

            ret.Timex = $"({beginLuisStr},{endLuisStr},P{endDay - beginDay}D)";
            ret.FutureValue = new Tuple<DateObject, DateObject>(
                DateObject.MinValue.SafeCreateFromValue(futureYear, month, beginDay),
                DateObject.MinValue.SafeCreateFromValue(futureYear, month, endDay));
            ret.PastValue = new Tuple<DateObject, DateObject>(
                DateObject.MinValue.SafeCreateFromValue(pastYear, month, beginDay),
                DateObject.MinValue.SafeCreateFromValue(pastYear, month, endDay));
            ret.Success = true;

            return ret;
        }

        private DateTimeResolutionResult ParseOneWordPeriod(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            int year = referenceDate.Year, month = referenceDate.Month;
            int futureYear = year, pastYear = year;
            var earlyPrefix = false;
            var latePrefix = false;
            var midPrefix = false;
            var isRef = false;

            var earlierPrefix = false;
            var laterPrefix = false;

            var trimmedText = text.Trim().ToLower();
            var match = this.config.OneWordPeriodRegex.MatchExact(trimmedText, trim: true);

            if (!match.Success)
            {
                match = this.config.LaterEarlyPeriodRegex.MatchExact(trimmedText, trim: true);
            }

            // For cases "that week|month|year"
            if (!match.Success)
            {
                match = this.config.ReferenceDatePeriodRegex.MatchExact(trimmedText, trim: true);
                isRef = true;
                ret.Mod = Constants.REF_UNDEF_MOD;
            }

            if (match.Success)
            {
                if (match.Groups["EarlyPrefix"].Success)
                {
                    earlyPrefix = true;
                    trimmedText = match.Groups[Constants.SuffixGroupName].ToString();
                    ret.Mod = Constants.EARLY_MOD;
                }
                else if (match.Groups["LatePrefix"].Success)
                {
                    latePrefix = true;
                    trimmedText = match.Groups[Constants.SuffixGroupName].ToString();
                    ret.Mod = Constants.LATE_MOD;
                }
                else if (match.Groups["MidPrefix"].Success)
                {
                    midPrefix = true;
                    trimmedText = match.Groups[Constants.SuffixGroupName].ToString();
                    ret.Mod = Constants.MID_MOD;
                }

                // Handle the abbreviation of DatePeriod, e.g., 'eoy(end of year)', the behavior of 'eoy' should be the same as 'end of year'
                if (this.config.UnspecificEndOfRangeRegex.IsMatch(match.Value))
                {
                    latePrefix = true;
                    trimmedText = match.Value;
                    ret.Mod = Constants.LATE_MOD;
                }

                if (match.Groups["RelEarly"].Success)
                {
                    earlierPrefix = true;
                    ret.Mod = null;
                }
                else if (match.Groups["RelLate"].Success)
                {
                    laterPrefix = true;
                    ret.Mod = null;
                }

                var monthStr = match.Groups["month"].Value;
                if (this.config.IsYearToDate(trimmedText))
                {
                    ret.Timex = referenceDate.Year.ToString("D4");
                    ret.FutureValue =
                        ret.PastValue =
                            new Tuple<DateObject, DateObject>(DateObject.MinValue.SafeCreateFromValue(referenceDate.Year, 1, 1), referenceDate);
                    ret.Success = true;
                    return ret;
                }

                if (this.config.IsMonthToDate(trimmedText))
                {
                    ret.Timex = referenceDate.Year.ToString("D4") + "-" + referenceDate.Month.ToString("D2");
                    ret.FutureValue =
                        ret.PastValue =
                            new Tuple<DateObject, DateObject>(
                                DateObject.MinValue.SafeCreateFromValue(referenceDate.Year, referenceDate.Month, 1), referenceDate);
                    ret.Success = true;
                    return ret;
                }

                if (!string.IsNullOrEmpty(monthStr))
                {
                    var swift = this.config.GetSwiftYear(trimmedText);

                    month = this.config.MonthOfYear[monthStr.ToLower()];

                    if (swift >= -1)
                    {
                        ret.Timex = (referenceDate.Year + swift).ToString("D4") + "-" + month.ToString("D2");
                        year = year + swift;
                        futureYear = pastYear = year;
                    }
                    else
                    {
                        ret.Timex = "XXXX-" + month.ToString("D2");
                        if (month < referenceDate.Month)
                        {
                            futureYear++;
                        }

                        if (month >= referenceDate.Month)
                        {
                            pastYear--;
                        }
                    }
                }
                else
                {
                    var swift = this.config.GetSwiftDayOrMonth(trimmedText);

                    if (this.config.IsWeekOnly(trimmedText))
                    {
                        var monday = referenceDate.This(DayOfWeek.Monday).AddDays(Constants.WeekDayCount * swift);

                        ret.Timex = isRef ? TimexUtility.GenerateWeekTimex() : TimexUtility.GenerateWeekTimex(monday);
                        var beginDate = referenceDate.This(DayOfWeek.Monday).AddDays(Constants.WeekDayCount * swift);
                        var endDate = InclusiveEndPeriod
                                        ? referenceDate.This(DayOfWeek.Sunday).AddDays(Constants.WeekDayCount * swift)
                                        : referenceDate.This(DayOfWeek.Sunday).AddDays(Constants.WeekDayCount * swift).AddDays(1);

                        if (earlyPrefix)
                        {
                            endDate = InclusiveEndPeriod
                                        ? referenceDate.This(DayOfWeek.Wednesday).AddDays(Constants.WeekDayCount * swift)
                                        : referenceDate.This(DayOfWeek.Wednesday).AddDays(Constants.WeekDayCount * swift).AddDays(1);
                        }
                        else if (midPrefix)
                        {
                            beginDate = referenceDate.This(DayOfWeek.Tuesday).AddDays(Constants.WeekDayCount * swift);
                            endDate = InclusiveEndPeriod
                                        ? referenceDate.This(DayOfWeek.Friday).AddDays(Constants.WeekDayCount * swift)
                                        : referenceDate.This(DayOfWeek.Friday).AddDays(Constants.WeekDayCount * swift).AddDays(1);
                        }
                        else if (latePrefix)
                        {
                            beginDate = referenceDate.This(DayOfWeek.Thursday).AddDays(Constants.WeekDayCount * swift);
                        }

                        if (earlierPrefix && swift == 0)
                        {
                            if (endDate > referenceDate)
                            {
                                endDate = referenceDate;
                            }
                        }
                        else if (laterPrefix && swift == 0)
                        {
                            if (beginDate < referenceDate)
                            {
                                beginDate = referenceDate;
                            }
                        }

                        ret.FutureValue =
                            ret.PastValue =
                                new Tuple<DateObject, DateObject>(beginDate, endDate);

                        ret.Success = true;
                        return ret;
                    }

                    if (this.config.IsWeekend(trimmedText))
                    {
                        var beginDate = referenceDate.This(DayOfWeek.Saturday).AddDays(Constants.WeekDayCount * swift);
                        var endDate = referenceDate.This(DayOfWeek.Sunday).AddDays(Constants.WeekDayCount * swift);

                        ret.Timex = isRef ? TimexUtility.GenerateWeekendTimex() : TimexUtility.GenerateWeekendTimex(beginDate);

                        endDate = InclusiveEndPeriod ? endDate : endDate.AddDays(1);

                        ret.FutureValue =
                            ret.PastValue = new Tuple<DateObject, DateObject>(beginDate, endDate);

                        ret.Success = true;
                        return ret;
                    }

                    if (this.config.IsMonthOnly(trimmedText))
                    {
                        var date = referenceDate.AddMonths(swift);
                        month = date.Month;
                        year = date.Year;
                        ret.Timex = isRef
                            ? TimexUtility.GenerateMonthTimex() :
                                TimexUtility.GenerateMonthTimex(date);
                        futureYear = pastYear = year;
                    }
                    else if (this.config.IsYearOnly(trimmedText))
                    {
                        var date = referenceDate.AddYears(swift);
                        year = date.Year;

                        var beginDate = DateObject.MinValue.SafeCreateFromValue(year, 1, 1);
                        var endDate = InclusiveEndPeriod
                                    ? DateObject.MinValue.SafeCreateFromValue(year, 12, 31)
                                    : DateObject.MinValue.SafeCreateFromValue(year, 12, 31).AddDays(1);
                        if (earlyPrefix)
                        {
                            endDate = InclusiveEndPeriod
                                    ? DateObject.MinValue.SafeCreateFromValue(year, 6, 30)
                                    : DateObject.MinValue.SafeCreateFromValue(year, 6, 30).AddDays(1);
                        }
                        else if (midPrefix)
                        {
                            beginDate = DateObject.MinValue.SafeCreateFromValue(year, 4, 1);
                            endDate = InclusiveEndPeriod
                                    ? DateObject.MinValue.SafeCreateFromValue(year, 9, 30)
                                    : DateObject.MinValue.SafeCreateFromValue(year, 9, 30).AddDays(1);
                        }
                        else if (latePrefix)
                        {
                            beginDate = DateObject.MinValue.SafeCreateFromValue(year, Constants.WeekDayCount, 1);
                        }

                        if (earlierPrefix && swift == 0)
                        {
                            if (endDate > referenceDate)
                            {
                                endDate = referenceDate;
                            }
                        }
                        else if (laterPrefix && swift == 0)
                        {
                            if (beginDate < referenceDate)
                            {
                                beginDate = referenceDate;
                            }
                        }

                        ret.Timex = isRef ? TimexUtility.GenerateYearTimex() : TimexUtility.GenerateYearTimex(date);

                        ret.FutureValue =
                            ret.PastValue =
                                new Tuple<DateObject, DateObject>(beginDate, endDate);

                        ret.Success = true;
                        return ret;
                    }
                }
            }
            else
            {
                return ret;
            }

            // only "month" will come to here
            var futureStart = DateObject.MinValue.SafeCreateFromValue(futureYear, month, 1);
            var futureEnd = InclusiveEndPeriod
                ? DateObject.MinValue.SafeCreateFromValue(futureYear, month, 1).AddMonths(1).AddDays(-1)
                : DateObject.MinValue.SafeCreateFromValue(futureYear, month, 1).AddMonths(1);
            var pastStart = DateObject.MinValue.SafeCreateFromValue(pastYear, month, 1);
            var pastEnd = InclusiveEndPeriod
                ? DateObject.MinValue.SafeCreateFromValue(pastYear, month, 1).AddMonths(1).AddDays(-1)
                : DateObject.MinValue.SafeCreateFromValue(pastYear, month, 1).AddMonths(1);
            if (earlyPrefix)
            {
                futureEnd = InclusiveEndPeriod
                    ? DateObject.MinValue.SafeCreateFromValue(futureYear, month, 15)
                    : DateObject.MinValue.SafeCreateFromValue(futureYear, month, 15).AddDays(1);
                pastEnd = InclusiveEndPeriod
                    ? DateObject.MinValue.SafeCreateFromValue(pastYear, month, 15)
                    : DateObject.MinValue.SafeCreateFromValue(pastYear, month, 15).AddDays(1);
            }
            else if (midPrefix)
            {
                futureStart = DateObject.MinValue.SafeCreateFromValue(futureYear, month, 10);
                pastStart = DateObject.MinValue.SafeCreateFromValue(pastYear, month, 10);
                futureEnd = InclusiveEndPeriod
                    ? DateObject.MinValue.SafeCreateFromValue(futureYear, month, 20)
                    : DateObject.MinValue.SafeCreateFromValue(futureYear, month, 20).AddDays(1);
                pastEnd = InclusiveEndPeriod
                    ? DateObject.MinValue.SafeCreateFromValue(pastYear, month, 20)
                    : DateObject.MinValue.SafeCreateFromValue(pastYear, month, 20).AddDays(1);
            }
            else if (latePrefix)
            {
                futureStart = DateObject.MinValue.SafeCreateFromValue(futureYear, month, 16);
                pastStart = DateObject.MinValue.SafeCreateFromValue(pastYear, month, 16);
            }

            if (earlierPrefix && futureEnd == pastEnd)
            {
                if (futureEnd > referenceDate)
                {
                    futureEnd = pastEnd = referenceDate;
                }
            }
            else if (laterPrefix && futureStart == pastStart)
            {
                if (futureStart < referenceDate)
                {
                    futureStart = pastStart = referenceDate;
                }
            }

            ret.FutureValue = new Tuple<DateObject, DateObject>(futureStart, futureEnd);

            ret.PastValue = new Tuple<DateObject, DateObject>(pastStart, pastEnd);

            ret.Success = true;

            return ret;
        }

        private DateTimeResolutionResult ParseMonthWithYear(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();

            var match = this.config.MonthWithYear.MatchExact(text, trim: true);

            if (!match.Success)
            {
                match = this.config.MonthNumWithYear.MatchExact(text, trim: true);
            }

            if (match.Success)
            {
                var monthStr = match.Groups["month"].Value.ToLower();
                var orderStr = match.Groups["order"].Value.ToLower();

                var month = this.config.MonthOfYear[monthStr.ToLower()];

                var year = config.DateExtractor.GetYearFromText(match.Match);

                if (year == Constants.InvalidYear)
                {
                    var swift = this.config.GetSwiftYear(orderStr);
                    if (swift < -1)
                    {
                        return ret;
                    }
                    year = referenceDate.Year + swift;
                }

                ret.FutureValue = ret.PastValue = new Tuple<DateObject, DateObject>(
                    DateObject.MinValue.SafeCreateFromValue(year, month, 1),
                    InclusiveEndPeriod
                        ? DateObject.MinValue.SafeCreateFromValue(year, month, 1).AddMonths(1).AddDays(-1)
                        : DateObject.MinValue.SafeCreateFromValue(year, month, 1).AddMonths(1));

                ret.Timex = year.ToString("D4") + "-" + month.ToString("D2");

                ret.Success = true;
            }

            return ret;
        }

        private DateTimeResolutionResult ParseYear(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var year = Constants.InvalidYear;

            var match = this.config.YearPeriodRegex.Match(text);
            var matchMonth = this.config.MonthWithYear.Match(text);

            if (match.Success && !matchMonth.Success)
            {
                var beginYear = Constants.InvalidYear;
                var endYear = Constants.InvalidYear;

                var matches = this.config.YearRegex.Matches(text);
                if (matches.Count == 2)
                {
                    // (from|during|in|between)? 2012 (till|to|until|through|-) 2015
                    if (matches[0].Success)
                    {
                        beginYear = ((BaseDateExtractor)this.config.DateExtractor).GetYearFromText(matches[0]);
                        if (!(beginYear >= Constants.MinYearNum && beginYear <= Constants.MaxYearNum))
                        {
                            beginYear = Constants.InvalidYear;
                        }
                    }

                    if (matches[1].Success)
                    {
                        endYear = ((BaseDateExtractor)this.config.DateExtractor).GetYearFromText(matches[1]);
                        if (!(endYear >= Constants.MinYearNum && endYear <= Constants.MaxYearNum))
                        {
                            endYear = Constants.InvalidYear;
                        }
                    }
                }

                if (beginYear != Constants.InvalidYear && endYear != Constants.InvalidYear)
                {
                    var beginDay = DateObject.MinValue.SafeCreateFromValue(beginYear, 1, 1);

                    var endDay = InclusiveEndPeriod
                            ? DateObject.MinValue.SafeCreateFromValue(endYear, 1, 1).AddDays(-1)
                            : DateObject.MinValue.SafeCreateFromValue(endYear, 1, 1);

                    ret.Timex = $"({DateTimeFormatUtil.LuisDate(beginDay)},{DateTimeFormatUtil.LuisDate(endDay)},P{endYear - beginYear}Y)";
                    ret.FutureValue = ret.PastValue = new Tuple<DateObject, DateObject>(beginDay, endDay);
                    ret.Success = true;

                    return ret;
                }
            }
            else
            {
                var exactMatch = this.config.YearRegex.MatchExact(text, trim: true);

                if (exactMatch.Success)
                {
                    year = config.DateExtractor.GetYearFromText(exactMatch.Match);

                    if (!(year >= Constants.MinYearNum && year <= Constants.MaxYearNum))
                    {
                        year = Constants.InvalidYear;
                    }
                }
                else
                {
                    exactMatch = this.config.YearPlusNumberRegex.MatchExact(text, trim: true);

                    if (exactMatch.Success)
                    {
                        year = config.DateExtractor.GetYearFromText(exactMatch.Match);
                    }
                }

                if (year != Constants.InvalidYear)
                {
                    var beginDay = DateObject.MinValue.SafeCreateFromValue(year, 1, 1);

                    var endDay = InclusiveEndPeriod
                            ? DateObject.MinValue.SafeCreateFromValue(year + 1, 1, 1).AddDays(-1)
                            : DateObject.MinValue.SafeCreateFromValue(year + 1, 1, 1);

                    ret.Timex = year.ToString("D4");
                    ret.FutureValue = ret.PastValue = new Tuple<DateObject, DateObject>(beginDay, endDay);
                    ret.Success = true;

                    return ret;
                }
            }

            return ret;
        }

        // parse entities that made up by two time points
        private DateTimeResolutionResult MergeTwoTimePoints(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();

            var er = this.config.DateExtractor.Extract(text, referenceDate);
            if (er.Count < 2)
            {
                er = this.config.DateExtractor.Extract(this.config.TokenBeforeDate + text, referenceDate);
                if (er.Count < 2)
                {
                    return ret;
                }
                er[0].Start -= this.config.TokenBeforeDate.Length;
                er[1].Start -= this.config.TokenBeforeDate.Length;
            }

            var match = this.config.WeekWithWeekDayRangeRegex.Match(text);
            string weekPrefix = null;
            if (match.Success)
            {
                weekPrefix = match.Groups["week"].ToString();
            }

            if (!string.IsNullOrEmpty(weekPrefix))
            {
                er[0].Text = weekPrefix + " " + er[0].Text;
                er[1].Text = weekPrefix + " " + er[1].Text;
            }

            var dateContext = GetYearContext(er[0].Text, er[1].Text, text);

            var pr1 = this.config.DateParser.Parse(er[0], referenceDate);
            var pr2 = this.config.DateParser.Parse(er[1], referenceDate);
            if (pr1.Value == null || pr2.Value == null)
            {
                return ret;
            }

            pr1 = dateContext.ProcessDateEntityParsingResult(pr1);
            pr2 = dateContext.ProcessDateEntityParsingResult(pr2);

            ret.SubDateTimeEntities = new List<object> { pr1, pr2 };

            DateObject futureBegin = (DateObject)((DateTimeResolutionResult)pr1.Value).FutureValue,
                futureEnd = (DateObject)((DateTimeResolutionResult)pr2.Value).FutureValue;

            DateObject pastBegin = (DateObject)((DateTimeResolutionResult)pr1.Value).PastValue,
                pastEnd = (DateObject)((DateTimeResolutionResult)pr2.Value).PastValue;

            if (futureBegin > futureEnd)
            {
                futureBegin = pastBegin;
            }

            if (pastEnd < pastBegin)
            {
                pastEnd = futureEnd;
            }

            ret.Timex = $"({pr1.TimexStr},{pr2.TimexStr},P{(futureEnd - futureBegin).TotalDays}D)";
            ret.FutureValue = new Tuple<DateObject, DateObject>(futureBegin, futureEnd);
            ret.PastValue = new Tuple<DateObject, DateObject>(pastBegin, pastEnd);
            ret.Success = true;

            return ret;
        }

        private DateTimeResolutionResult ParseDuration(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            DateObject beginDate;
            var endDate = beginDate = referenceDate;
            var timex = string.Empty;
            var restNowSunday = false;
            List<DateObject> dateList = null;

            var durationErs = config.DurationExtractor.Extract(text, referenceDate);
            if (durationErs.Count == 1)
            {
                var durationPr = config.DurationParser.Parse(durationErs[0]);
                var beforeStr = text.Substring(0, durationPr.Start ?? 0).Trim().ToLowerInvariant();
                var afterStr = text.Substring((durationPr.Start ?? 0) + (durationPr.Length ?? 0)).Trim().ToLowerInvariant();

                var numbersInSuffix = config.CardinalExtractor.Extract(beforeStr);
                var numbersInDuration = config.CardinalExtractor.Extract(durationErs[0].Text);

                // Handle cases like "2 upcoming days", "5 previous years"
                if (numbersInSuffix.Any() && !numbersInDuration.Any())
                {
                    var numberEr = numbersInSuffix.First();
                    var numberText = numberEr.Text;
                    var durationText = durationErs[0].Text;
                    var combinedText = $"{numberText} {durationText}";
                    var combinedDurationEr = config.DurationExtractor.Extract(combinedText, referenceDate);
                    
                    if (combinedDurationEr.Any())
                    {
                        durationPr = config.DurationParser.Parse(combinedDurationEr.First());
                        var startIndex = numberEr.Start.Value + numberEr.Length.Value;
                        beforeStr = beforeStr.Substring(startIndex).Trim();
                    }
                }

                var mod = string.Empty;

                if (durationPr.Value != null)
                {
                    var durationResult = (DateTimeResolutionResult)durationPr.Value;

                    if (string.IsNullOrEmpty(durationResult.Timex))
                    {
                        return ret;
                    }

                    if (config.PastRegex.IsMatch(beforeStr) || config.PastRegex.IsMatch(afterStr))
                    {
                        GetModAndDate(out beginDate, ref endDate, referenceDate, durationResult.Timex, false, out mod, out dateList);
                    }

                    // Handle the "within two weeks" case which means from today to the end of next two weeks
                    // Cases like "within 3 days before/after today" is not handled here (4th condition)
                    if (config.WithinNextPrefixRegex.IsExactMatch(beforeStr, trim: true) &&
                        DurationParsingUtil.IsDateDuration(durationResult.Timex) && string.IsNullOrEmpty(afterStr))
                    {
                        GetModAndDate(out beginDate, ref endDate, referenceDate, durationResult.Timex, true, out mod, out dateList);

                        // In GetModAndDate, this "future" resolution will add one day to beginDate/endDate,
                        // but for the "within" case it should start from the current day.
                        beginDate = beginDate.AddDays(-1);
                        endDate = endDate.AddDays(-1);
                    }

                    if (config.FutureRegex.IsExactMatch(beforeStr, trim: true))
                    {
                        GetModAndDate(out beginDate, ref endDate, referenceDate, durationResult.Timex, true, out mod, out dateList);
                    }
                    else if (config.FutureRegex.IsMatch(afterStr))
                    {
                        GetModAndDate(out beginDate, ref endDate, referenceDate, durationResult.Timex, true, out mod, out dateList);
                    }

                    if (config.FutureSuffixRegex.IsMatch(afterStr))
                    {
                        GetModAndDate(out beginDate, ref endDate, referenceDate, durationResult.Timex, true, out mod, out dateList);
                    }

                    // Handle the "in two weeks" case which means the second week
                    if (config.InConnectorRegex.IsExactMatch(beforeStr, trim: true) &&
                        !DurationParsingUtil.IsMultipleDuration(durationResult.Timex))
                    {
                        GetModAndDate(out beginDate, ref endDate, referenceDate, durationResult.Timex, true, out mod, out dateList);

                        // Change the duration value and the beginDate
                        var unit = durationResult.Timex.Substring(durationResult.Timex.Length - 1);

                        durationResult.Timex = "P1" + unit;
                        beginDate = DurationParsingUtil.ShiftDateTime(durationResult.Timex, endDate, false);
                    }

                    if (!string.IsNullOrEmpty(mod))
                    {
                        ((DateTimeResolutionResult)durationPr.Value).Mod = mod;
                    }

                    timex = durationResult.Timex;
                    ret.SubDateTimeEntities = new List<object> { durationPr };
                    if (dateList != null)
                    {
                        ret.List = dateList.Cast<object>().ToList();
                    }
                }
            }

            // Parse "rest of"
            var match = this.config.RestOfDateRegex.Match(text);
            if (match.Success)
            {
                var durationStr = match.Groups["duration"].Value;
                var durationUnit = this.config.UnitMap[durationStr];
                switch (durationUnit)
                {
                    case Constants.TimexWeek:
                        var diff = Constants.WeekDayCount - (beginDate.DayOfWeek == 0 ? Constants.WeekDayCount : (int)beginDate.DayOfWeek);
                        endDate = beginDate.AddDays(diff);
                        timex = "P" + diff + Constants.TimexDay;
                        if (diff == 0)
                        {
                            restNowSunday = true;
                        }
                        break;

                    case Constants.TimexMonthFull:
                        endDate = DateObject.MinValue.SafeCreateFromValue(beginDate.Year, beginDate.Month, 1);
                        endDate = endDate.AddMonths(1).AddDays(-1);
                        diff = endDate.Day - beginDate.Day + 1;
                        timex = "P" + diff + Constants.TimexDay;
                        break;

                    case Constants.TimexYear:
                        endDate = DateObject.MinValue.SafeCreateFromValue(beginDate.Year, 12, 1);
                        endDate = endDate.AddMonths(1).AddDays(-1);
                        diff = endDate.DayOfYear - beginDate.DayOfYear + 1;
                        timex = "P" + diff + Constants.TimexDay;
                        break;
                }
            }

            if (!beginDate.Equals(endDate) || restNowSunday)
            {
                endDate = InclusiveEndPeriod ? endDate.AddDays(-1) : endDate;

                ret.Timex =
                    $"({DateTimeFormatUtil.LuisDate(beginDate)},{DateTimeFormatUtil.LuisDate(endDate)},{timex})";
                ret.FutureValue = ret.PastValue = new Tuple<DateObject, DateObject>(beginDate, endDate);
                ret.Success = true;
            }

            return ret;
        }

        // TODO: This method should be refactored as it takes too many parameters and has too many side-effects
        private static void GetModAndDate(out DateObject beginDate, ref DateObject endDate, DateObject referenceDate,
            string timex, bool future, out string mod, out List<DateObject> dateList)
        {
            dateList = null;
            var isBusinessDay = timex.EndsWith(Constants.TimexBusinessDay);
            var businessDayCount = 0;

            if (isBusinessDay)
            {
                businessDayCount = int.Parse(timex.Substring(1, timex.Length - 3));
            }

            if (future)
            {
                mod = Constants.AFTER_MOD;

                // For future the beginDate should add 1 first
                if (isBusinessDay)
                {
                    beginDate = DurationParsingUtil.GetNextBusinessDay(referenceDate);
                    endDate = DurationParsingUtil.GetNthBusinessDay(beginDate, businessDayCount - 1, true, out dateList);
                    endDate = endDate.AddDays(1);
                }
                else
                {
                    beginDate = referenceDate.AddDays(1);
                    endDate = DurationParsingUtil.ShiftDateTime(timex, beginDate, true);
                }

            }
            else
            {
                mod = Constants.BEFORE_MOD;

                if (isBusinessDay)
                {
                    endDate = DurationParsingUtil.GetNextBusinessDay(endDate, false);
                    beginDate = DurationParsingUtil.GetNthBusinessDay(endDate, businessDayCount - 1, false, out dateList);
                    endDate = endDate.AddDays(1);
                }
                else
                {
                    beginDate = DurationParsingUtil.ShiftDateTime(timex, endDate, false);
                }
            }
        }

        // To be consistency, we follow the definition of "week of year":
        // "first week of the month" - it has the month's first Thursday in it
        // "last week of the month" - it has the month's last Thursday in it
        private DateTimeResolutionResult ParseWeekOfMonth(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();

            var trimmedText = text.Trim().ToLowerInvariant();
            var match = this.config.WeekOfMonthRegex.MatchExact(trimmedText, trim: true);

            if (!match.Success)
            {
                return ret;
            }

            var cardinalStr = match.Groups["cardinal"].Value;
            var monthStr = match.Groups["month"].Value;
            var noYear = false;
            int year;

            int month;
            if (string.IsNullOrEmpty(monthStr))
            {
                var swift = this.config.GetSwiftDayOrMonth(trimmedText);

                month = referenceDate.AddMonths(swift).Month;
                year = referenceDate.AddMonths(swift).Year;
            }
            else
            {
                month = this.config.MonthOfYear[monthStr];
                year = referenceDate.Year;
                noYear = true;
            }

            ret = GetWeekOfMonth(cardinalStr, month, year, referenceDate, noYear);

            return ret;
        }

        // We follow the ISO week definition:
        // "first week of the year" - it has the year's first Thursday in it
        // "last week of the year" - it has the year's last Thursday in it
        private DateTimeResolutionResult ParseWeekOfYear(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var trimmedText = text.ToLowerInvariant();
            var match = this.config.WeekOfYearRegex.MatchExact(trimmedText, trim: true);

            if (!match.Success)
            {
                return ret;
            }

            var cardinalStr = match.Groups["cardinal"].Value;
            var orderStr = match.Groups["order"].Value.ToLower();

            var year = config.DateExtractor.GetYearFromText(match.Match);
            if (year == Constants.InvalidYear)
            {
                var swift = this.config.GetSwiftYear(orderStr);
                if (swift < -1)
                {
                    return ret;
                }
                year = referenceDate.Year + swift;
            }

            DateObject targetWeekMonday;

            if (this.config.IsLastCardinal(cardinalStr))
            {
                targetWeekMonday = GetLastThursday(year).This(DayOfWeek.Monday);

                ret.Timex = TimexUtility.GenerateWeekTimex(targetWeekMonday);
            }
            else
            {
                var cardinal = this.config.CardinalMap[cardinalStr];
                targetWeekMonday = GetFirstThursday(year).This(DayOfWeek.Monday)
                    .AddDays(Constants.WeekDayCount * (cardinal - 1));

                var weekTimex = TimexUtility.GenerateWeekTimex(cardinal);
                var yearTimex = DateTimeFormatUtil.LuisDate(year);
                ret.Timex = TimexUtility.CombineYearAndWeekTimex(yearTimex, weekTimex);
            }

            ret.FutureValue = InclusiveEndPeriod
                ? new Tuple<DateObject, DateObject>(targetWeekMonday, targetWeekMonday.AddDays(Constants.WeekDayCount - 1))
                : new Tuple<DateObject, DateObject>(targetWeekMonday, targetWeekMonday.AddDays(Constants.WeekDayCount));

            ret.PastValue = InclusiveEndPeriod
                ? new Tuple<DateObject, DateObject>(targetWeekMonday, targetWeekMonday.AddDays(Constants.WeekDayCount - 1))
                : new Tuple<DateObject, DateObject>(targetWeekMonday, targetWeekMonday.AddDays(Constants.WeekDayCount));

            ret.Success = true;

            return ret;
        }

        private DateTimeResolutionResult ParseHalfYear(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var match = this.config.AllHalfYearRegex.MatchExact(text, trim: true);

            if (!match.Success)
            {
                return ret;
            }

            var cardinalStr = match.Groups["cardinal"].Value.ToLower();
            var orderStr = match.Groups["order"].Value.ToLower();
            var numberStr = match.Groups["number"].Value;

            int year = config.DateExtractor.GetYearFromText(match.Match);

            if (year == Constants.InvalidYear)
            {
                var swift = this.config.GetSwiftYear(orderStr);
                if (swift < -1)
                {
                    return ret;
                }
                year = referenceDate.Year + swift;
            }

            int halfNum;
            if (!string.IsNullOrEmpty(numberStr))
            {
                halfNum = int.Parse(numberStr);
            }
            else
            {
                halfNum = this.config.CardinalMap[cardinalStr];
            }

            var beginDate = DateObject.MinValue.SafeCreateFromValue(year, (halfNum - 1) * Constants.SemesterMonthCount + 1, 1);
            var endDate = DateObject.MinValue.SafeCreateFromValue(year, halfNum * Constants.SemesterMonthCount, 1).AddMonths(1);
            ret.FutureValue = ret.PastValue = new Tuple<DateObject, DateObject>(beginDate, endDate);
            ret.Timex = $"({DateTimeFormatUtil.LuisDate(beginDate)},{DateTimeFormatUtil.LuisDate(endDate)},P6M)";
            ret.Success = true;

            return ret;
        }

        private DateTimeResolutionResult ParseQuarter(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var match = this.config.QuarterRegex.MatchExact(text, trim: true);

            if (!match.Success)
            {
                match = this.config.QuarterRegexYearFront.MatchExact(text, trim: true);
            }

            if (!match.Success)
            {
                return ret;
            }

            var cardinalStr = match.Groups["cardinal"].Value.ToLower();
            var orderStr = match.Groups["order"].Value.ToLower();
            var numberStr = match.Groups["number"].Value;

            bool noSpecificYear = false;
            int year = config.DateExtractor.GetYearFromText(match.Match);

            if (year == Constants.InvalidYear)
            {
                var swift = this.config.GetSwiftYear(orderStr);
                if (swift < -1)
                {
                    swift = 0;
                    noSpecificYear = true;
                }
                year = referenceDate.Year + swift;
            }

            int quarterNum;
            if (!string.IsNullOrEmpty(numberStr))
            {
                quarterNum = int.Parse(numberStr);
            }
            else
            {
                quarterNum = this.config.CardinalMap[cardinalStr];
            }

            var beginDate = DateObject.MinValue.SafeCreateFromValue(year, (quarterNum - 1) * Constants.TrimesterMonthCount + 1, 1);
            var endDate = DateObject.MinValue.SafeCreateFromValue(year, quarterNum * Constants.TrimesterMonthCount, 1).AddMonths(1);

            if (noSpecificYear)
            {
                if (endDate.CompareTo(referenceDate) < 0)
                {
                    ret.PastValue = new Tuple<DateObject, DateObject>(beginDate, endDate);

                    var futureBeginDate = DateObject.MinValue.SafeCreateFromValue(year + 1, (quarterNum - 1) * Constants.TrimesterMonthCount + 1, 1);
                    var futureEndDate = DateObject.MinValue.SafeCreateFromValue(year + 1, quarterNum * Constants.TrimesterMonthCount, 1).AddMonths(1);
                    ret.FutureValue = new Tuple<DateObject, DateObject>(futureBeginDate, futureEndDate);
                }
                else if (endDate.CompareTo(referenceDate) > 0)
                {
                    ret.FutureValue = new Tuple<DateObject, DateObject>(beginDate, endDate);

                    var pastBeginDate = DateObject.MinValue.SafeCreateFromValue(year - 1, (quarterNum - 1) * Constants.TrimesterMonthCount + 1, 1);
                    var pastEndDate = DateObject.MinValue.SafeCreateFromValue(year - 1, quarterNum * Constants.TrimesterMonthCount, 1).AddMonths(1);
                    ret.PastValue = new Tuple<DateObject, DateObject>(pastBeginDate, pastEndDate);
                }
                else
                {
                    ret.FutureValue = ret.PastValue = new Tuple<DateObject, DateObject>(beginDate, endDate);
                }
            }
            else
            {
                ret.FutureValue = ret.PastValue = new Tuple<DateObject, DateObject>(beginDate, endDate);
            }

            ret.Timex = $"({DateTimeFormatUtil.LuisDate(beginDate)},{DateTimeFormatUtil.LuisDate(endDate)},P3M)";
            ret.Success = true;

            return ret;
        }

        private DateTimeResolutionResult ParseSeason(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var match = this.config.SeasonRegex.MatchExact(text, trim: true);

            if (match.Success)
            {
                var seasonStr = this.config.SeasonMap[match.Groups["seas"].Value.ToLowerInvariant()];

                if (match.Groups["EarlyPrefix"].Success)
                {
                    ret.Mod = Constants.EARLY_MOD;
                }
                else if (match.Groups["MidPrefix"].Success)
                {
                    ret.Mod = Constants.MID_MOD;
                }
                else if (match.Groups["LatePrefix"].Success)
                {
                    ret.Mod = Constants.LATE_MOD;
                }

                var year = config.DateExtractor.GetYearFromText(match.Match);
                if (year == Constants.InvalidYear)
                {
                    var swift = this.config.GetSwiftYear(text);
                    if (swift < -1)
                    {
                        ret.Timex = seasonStr;
                        ret.Success = true;
                        return ret;
                    }
                    year = referenceDate.Year + swift;
                }

                var yearStr = year.ToString("D4");
                ret.Timex = yearStr + "-" + seasonStr;

                ret.Success = true;
                return ret;
            }
            return ret;
        }

        private DateTimeResolutionResult ParseWeekOfDate(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var match = config.WeekOfRegex.Match(text);
            var dateErs = config.DateExtractor.Extract(text, referenceDate);

            if (!dateErs.Any())
            {
                // For cases like "week of the 18th"
                dateErs.AddRange(config.CardinalExtractor.Extract(text).Where(o =>
                {
                    o.Type = Constants.SYS_DATETIME_DATE;
                    return !dateErs.Any(er => er.IsOverlap(o));
                }));
            }

            if (match.Success && dateErs.Count == 1)
            {
                var pr = (DateTimeResolutionResult)config.DateParser.Parse(dateErs[0], referenceDate).Value;
                if ((config.Options & DateTimeOptions.CalendarMode) != 0)
                {
                    var monday = ((DateObject)pr.FutureValue).This(DayOfWeek.Monday);
                    ret.Timex = DateTimeFormatUtil.ToIsoWeekTimex(monday);
                }
                else
                {
                    ret.Timex = pr.Timex;
                }
                ret.Comment = Constants.Comment_WeekOf;
                ret.FutureValue = GetWeekRangeFromDate((DateObject)pr.FutureValue);
                ret.PastValue = GetWeekRangeFromDate((DateObject)pr.PastValue);
                ret.Success = true;
            }
            return ret;
        }

        private DateTimeResolutionResult ParseMonthOfDate(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var match = config.MonthOfRegex.Match(text);
            var ex = config.DateExtractor.Extract(text, referenceDate);
            if (match.Success && ex.Count == 1)
            {
                var pr = (DateTimeResolutionResult)config.DateParser.Parse(ex[0], referenceDate).Value;
                ret.Timex = pr.Timex;
                ret.Comment = Constants.Comment_MonthOf;
                ret.FutureValue = GetMonthRangeFromDate((DateObject)pr.FutureValue);
                ret.PastValue = GetMonthRangeFromDate((DateObject)pr.PastValue);
                ret.Success = true;
            }
            return ret;
        }

        private Tuple<DateObject, DateObject> GetWeekRangeFromDate(DateObject date)
        {
            var startDate = date.This(DayOfWeek.Monday);
            var endDate = InclusiveEndPeriod ? startDate.AddDays(Constants.WeekDayCount - 1) : startDate.AddDays(Constants.WeekDayCount);
            return new Tuple<DateObject, DateObject>(startDate, endDate);
        }

        private Tuple<DateObject, DateObject> GetMonthRangeFromDate(DateObject date)
        {
            var startDate = DateObject.MinValue.SafeCreateFromValue(date.Year, date.Month, 1);
            DateObject endDate;
            if (date.Month < 12)
            {
                endDate = DateObject.MinValue.SafeCreateFromValue(date.Year, date.Month + 1, 1);
            }
            else
            {
                endDate = DateObject.MinValue.SafeCreateFromValue(date.Year + 1, 1, 1);
            }
            endDate = InclusiveEndPeriod ? endDate.AddDays(-1) : endDate;
            return new Tuple<DateObject, DateObject>(startDate, endDate);
        }

        private DateTimeResolutionResult ParseWhichWeek(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            var match = this.config.WhichWeekRegex.MatchExact(text, trim: true);

            if (match.Success)
            {
                var num = int.Parse(match.Groups["number"].ToString());
                var year = referenceDate.Year;
                ret.Timex = year.ToString("D4");
                var firstDay = DateObject.MinValue.SafeCreateFromValue(year, 1, 1);
                var firstWeekday = firstDay.This((DayOfWeek)1);
                var value = firstWeekday.AddDays(Constants.WeekDayCount * num);
                var futureDate = value;
                var pastDate = value;
                ret.Timex += "-W" + num.ToString("D2");
                ret.FutureValue = new Tuple<DateObject, DateObject>(futureDate, futureDate.AddDays(Constants.WeekDayCount));
                ret.PastValue = new Tuple<DateObject, DateObject>(pastDate, pastDate.AddDays(Constants.WeekDayCount));
                ret.Success = true;
            }
            return ret;
        }

        private DateTimeResolutionResult GetWeekOfMonth(string cardinalStr, int month, int year, DateObject referenceDate, bool noYear)
        {
            var ret = new DateTimeResolutionResult();
            var targetMonday = GetMondayOfTargetWeek(cardinalStr, month, year);

            var futureDate = targetMonday;
            var pastDate = targetMonday;

            if (noYear && futureDate < referenceDate)
            {
                futureDate = GetMondayOfTargetWeek(cardinalStr, month, year + 1);
            }

            if (noYear && pastDate >= referenceDate)
            {
                pastDate = GetMondayOfTargetWeek(cardinalStr, month, year - 1);
            }

            var monthTimex = DateTimeFormatUtil.LuisDate(year, month);

            if (noYear)
            {
                monthTimex = DateTimeFormatUtil.LuisDate(Constants.InvalidYear, month);
            }

            var cardinal = GetWeekNumberForMonth(cardinalStr);

            // Note that if the cardinalStr equals to "last", the cardinalNumber would be fixed at "5"
            // This may lead to some inconsistancy between Timex and Resolution
            // the StartDate and EndDate of the resolution would always be correct (following ISO week definition)
            // But week number for "last week" might be inconsistancy with the resolution as we only have one Timex, but we may have past and future resolution which may have different week number
            var weekTimex = TimexUtility.GenerateWeekTimex(cardinal);
            ret.Timex = TimexUtility.CombineMonthAndWeekTimex(monthTimex, weekTimex);

            ret.FutureValue = InclusiveEndPeriod
                ? new Tuple<DateObject, DateObject>(futureDate, futureDate.AddDays(Constants.WeekDayCount - 1))
                : new Tuple<DateObject, DateObject>(futureDate, futureDate.AddDays(Constants.WeekDayCount));

            ret.PastValue = InclusiveEndPeriod
                ? new Tuple<DateObject, DateObject>(pastDate, pastDate.AddDays(Constants.WeekDayCount - 1))
                : new Tuple<DateObject, DateObject>(pastDate, pastDate.AddDays(Constants.WeekDayCount));

            ret.Success = true;

            return ret;
        }

        private DateObject GetFirstThursday(int year, int month = Constants.InvalidMonth)
        {
            var targetMonth = month;

            if (month == Constants.InvalidMonth)
            {
                targetMonth = 1;
            }

            var firstDay = DateObject.MinValue.SafeCreateFromValue(year, targetMonth, 1);
            DateObject firstThursday = firstDay.This(DayOfWeek.Thursday);

            // Thursday fall into previous year or previous month
            if (firstThursday.Month != targetMonth)
            {
                firstThursday = firstDay.AddDays(Constants.WeekDayCount);
            }

            return firstThursday;
        }

        private DateObject GetLastThursday(int year, int month = Constants.InvalidMonth)
        {
            var targetMonth = month;

            if (month == Constants.InvalidMonth)
            {
                targetMonth = 12;
            }

            var lastDay = GetLastDay(year, targetMonth);
            DateObject lastThursday = lastDay.This(DayOfWeek.Thursday);

            // Thursday fall into next year or next month
            if (lastThursday.Month != targetMonth)
            {
                lastThursday = lastThursday.AddDays(-Constants.WeekDayCount);
            }

            return lastThursday;
        }

        private DateObject GetLastDay(int year, int month)
        {
            month++;

            if (month == 13)
            {
                year++;
                month = 1;
            }

            var firstDayOfNextMonth = DateObject.MinValue.SafeCreateFromValue(year, month, 1);

            return firstDayOfNextMonth.AddDays(-1);
        }

        private DateObject GetMondayOfTargetWeek(string cardinalStr, int month, int year)
        {
            DateObject result;
            if (config.IsLastCardinal(cardinalStr))
            {
                var lastThursday = GetLastThursday(year, month);
                result = lastThursday.This(DayOfWeek.Monday);
            }
            else
            {
                int cardinal = GetWeekNumberForMonth(cardinalStr);
                var firstThursday = GetFirstThursday(year, month);

                result = firstThursday.This(DayOfWeek.Monday)
                    .AddDays(Constants.WeekDayCount * (cardinal - 1));
            }

            return result;
        }

        private int GetWeekNumberForMonth(string cardinalStr)
        {
            int cardinal;

            if (config.IsLastCardinal(cardinalStr))
            {
                // "last week of month" might not be "5th week of month"
                // Sometimes it can also be "4th week of month" depends on specific year and month
                // But as we only have one Timex, so we use "5" to indicate last week of month
                cardinal = 5;
            }
            else
            {
                cardinal = config.CardinalMap[cardinalStr];
            }

            return cardinal;
        }

        private DateTimeResolutionResult ParseDecade(string text, DateObject referenceDate)
        {
            var ret = new DateTimeResolutionResult();
            int firstTwoNumOfYear = referenceDate.Year / 100;
            int decade;
            int decadeLastYear = 10;
            int swift = 1;
            var inputCentury = false;

            var trimmedText = text.Trim();
            var match = this.config.DecadeWithCenturyRegex.MatchExact(trimmedText, trim: true);
            string beginLuisStr, endLuisStr;

            if (match.Success)
            {
                var decadeStr = match.Groups["decade"].Value.ToLower();
                if (!int.TryParse(decadeStr, out decade))
                {
                    if (this.config.WrittenDecades.ContainsKey(decadeStr))
                    {
                        decade = this.config.WrittenDecades[decadeStr];
                    }
                    else if (this.config.SpecialDecadeCases.ContainsKey(decadeStr))
                    {
                        firstTwoNumOfYear = this.config.SpecialDecadeCases[decadeStr] / 100;
                        decade = this.config.SpecialDecadeCases[decadeStr] % 100;
                        inputCentury = true;
                    }
                }

                var centuryStr = match.Groups["century"].Value.ToLower();
                if (!string.IsNullOrEmpty(centuryStr))
                {
                    if (!int.TryParse(centuryStr, out firstTwoNumOfYear))
                    {
                        if (this.config.Numbers.ContainsKey(centuryStr))
                        {
                            firstTwoNumOfYear = this.config.Numbers[centuryStr];
                        }
                        else
                        {
                            // handle the case like "one/two thousand", "one/two hundred", etc.
                            var er = this.config.IntegerExtractor.Extract(centuryStr);

                            if (er.Count == 0)
                            {
                                return ret;
                            }

                            firstTwoNumOfYear = Convert.ToInt32((double)(this.config.NumberParser.Parse(er[0]).Value ?? 0));
                            if (firstTwoNumOfYear >= 100)
                            {
                                firstTwoNumOfYear = firstTwoNumOfYear / 100;
                            }
                        }
                    }

                    inputCentury = true;
                }
            }
            else
            {
                // handle cases like "the last 2 decades" "the next decade"
                match = this.config.RelativeDecadeRegex.MatchExact(trimmedText, trim: true);

                if (match.Success)
                {
                    inputCentury = true;

                    swift = this.config.GetSwiftDayOrMonth(trimmedText);

                    var numStr = match.Groups["number"].Value.ToLower();
                    var er = this.config.IntegerExtractor.Extract(numStr);
                    if (er.Count == 1)
                    {
                        var swiftNum = Convert.ToInt32((double)(this.config.NumberParser.Parse(er[0]).Value ?? 0));
                        swift = swift * swiftNum;
                    }

                    var beginDecade = (referenceDate.Year % 100) / 10;
                    if (swift < 0)
                    {
                        beginDecade += swift;
                    }
                    else if (swift > 0)
                    {
                        beginDecade += 1;
                    }

                    decade = beginDecade * 10;
                }
                else
                {
                    return ret;
                }
            }

            var beginYear = firstTwoNumOfYear * 100 + decade;
            // swift = 0 correspoding to the/this decade
            var totalLastYear = decadeLastYear * Math.Abs(swift == 0 ? 1 : swift);

            if (inputCentury)
            {
                beginLuisStr = DateTimeFormatUtil.LuisDate(beginYear, 1, 1);
                endLuisStr = DateTimeFormatUtil.LuisDate(beginYear + totalLastYear, 1, 1);
            }
            else
            {
                var beginYearStr = "XX" + decade;
                beginLuisStr = DateTimeFormatUtil.LuisDate(-1, 1, 1);
                beginLuisStr = beginLuisStr.Replace("XXXX", beginYearStr);

                var endYearStr = "XX" + (decade + totalLastYear);
                endLuisStr = DateTimeFormatUtil.LuisDate(-1, 1, 1);
                endLuisStr = endLuisStr.Replace("XXXX", endYearStr);
            }
            ret.Timex = $"({beginLuisStr},{endLuisStr},P{totalLastYear}Y)";

            int futureYear = beginYear, pastYear = beginYear;
            var startDate = DateObject.MinValue.SafeCreateFromValue(beginYear, 1, 1);
            if (!inputCentury && startDate < referenceDate)
            {
                futureYear += 100;
            }

            if (!inputCentury && startDate >= referenceDate)
            {
                pastYear -= 100;
            }

            ret.FutureValue = new Tuple<DateObject, DateObject>(
                DateObject.MinValue.SafeCreateFromValue(futureYear, 1, 1),
                DateObject.MinValue.SafeCreateFromValue(futureYear + totalLastYear, 1, 1));

            ret.PastValue = new Tuple<DateObject, DateObject>(
                DateObject.MinValue.SafeCreateFromValue(pastYear, 1, 1),
                DateObject.MinValue.SafeCreateFromValue(pastYear + totalLastYear, 1, 1));

            ret.Success = true;

            return ret;
        }

        public List<DateTimeParseResult> FilterResults(string query, List<DateTimeParseResult> candidateResults)
        {
            return candidateResults;
        }

        private DateContext GetYearContext(string startDateStr, string endDateStr, string text)
        {
            var isEndDatePureYear = false;
            var isDateRelative = false;
            int contextYear = Constants.InvalidYear;

            var yearMatchForEndDate = this.config.YearRegex.Match(endDateStr);

            if (yearMatchForEndDate.Success && yearMatchForEndDate.Length == endDateStr.Length)
            {
                isEndDatePureYear = true;
            }

            var relativeMatchForStartDate = this.config.RelativeRegex.Match(startDateStr);
            var relativeMatchForEndDate = this.config.RelativeRegex.Match(endDateStr);
            isDateRelative = relativeMatchForStartDate.Success || relativeMatchForEndDate.Success;

            var dateContext = new DateContext();

            if (!isEndDatePureYear && !isDateRelative)
            {
                foreach (Match match in config.YearRegex.Matches(text))
                {
                    var year = config.DateExtractor.GetYearFromText(match);

                    if (year != Constants.InvalidYear)
                    {
                        if (contextYear == Constants.InvalidYear)
                        {
                            contextYear = year;
                        }
                        else
                        {
                            // This indicates that the text has two different year value, no common context year
                            if (contextYear != year)
                            {
                                contextYear = Constants.InvalidYear;
                                break;
                            }
                        }
                    }
                }
            }

            return new DateContext() { Year = contextYear };
        }
    }
}
