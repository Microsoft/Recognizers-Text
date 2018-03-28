from typing import Pattern, List, Dict
from recognizers_text.utilities import RegExpUtility
from recognizers_date_time.date_time.base_set import SetExtractorConfiguration
from recognizers_date_time.date_time.extractors import DateTimeExtractor
from recognizers_date_time.date_time.base_date import BaseDateExtractor
from recognizers_date_time.date_time.base_dateperiod import BaseDatePeriodExtractor
from recognizers_date_time.date_time.base_duration import BaseDurationExtractor
from recognizers_date_time.date_time.base_datetime import BaseDateTimeExtractor
from recognizers_date_time.date_time.base_datetimeperiod import BaseDateTimePeriodExtractor
from recognizers_date_time.date_time.base_time import BaseTimeExtractor
from recognizers_date_time.date_time.base_timeperiod import BaseTimePeriodExtractor
from .duration_extractor_config import EnglishDurationExtractorConfiguration
from .time_extractor_config import EnglishTimeExtractorConfiguration
from .date_extractor_config import EnglishDateExtractorConfiguration
from .datetime_extractor_config import EnglishDateTimeExtractorConfiguration
from .dateperiod_extractor_config import EnglishDatePeriodExtractorConfiguration
from .timeperiod_extractor_config import EnglishTimePeriodExtractorConfiguration
from .datetimeperiod_extractor_config import EnglishDateTimePeriodExtractorConfiguration
from recognizers_date_time.resources.english_date_time import EnglishDateTime

class EnglishSetExtractorConfiguration(SetExtractorConfiguration):
    @property
    def last_regex(self) -> Pattern:
        return self._last_regex

    @property
    def each_prefix_regex(self) -> Pattern:
        return self._each_prefix_regex

    @property
    def periodic_regex(self) -> Pattern:
        return self._periodic_regex

    @property
    def each_unit_regex(self) -> Pattern:
        return self._each_unit_regex

    @property
    def each_day_regex(self) -> Pattern:
        return self._each_day_regex

    @property
    def before_each_day_regex(self) -> Pattern:
        return self._before_each_day_regex

    @property
    def set_week_day_regex(self) -> Pattern:
        return self._set_week_day_regex

    @property
    def set_each_regex(self) -> Pattern:
        return self._set_each_regex

    @property
    def duration_extractor(self) -> DateTimeExtractor:
        return self._duration_extractor

    @property
    def time_extractor(self) -> DateTimeExtractor:
        return self._time_extractor

    @property
    def date_extractor(self) -> DateTimeExtractor:
        return self._date_extractor

    @property
    def date_time_extractor(self) -> DateTimeExtractor:
        return self._date_time_extractor

    @property
    def date_period_extractor(self) -> DateTimeExtractor:
        return self._date_period_extractor

    @property
    def time_period_extractor(self) -> DateTimeExtractor:
        return self._time_period_extractor

    @property
    def date_time_period_extractor(self) -> DateTimeExtractor:
        return self._date_time_period_extractor

    def __init__(self):
        self._duration_extractor = BaseDurationExtractor(EnglishDurationExtractorConfiguration())
        self._time_extractor = BaseTimeExtractor(EnglishTimeExtractorConfiguration())
        self._date_extractor = BaseDateExtractor(EnglishDateExtractorConfiguration())
        self._date_time_extractor = BaseDateTimeExtractor(EnglishDateTimeExtractorConfiguration())
        self._date_period_extractor = BaseDatePeriodExtractor(EnglishDatePeriodExtractorConfiguration())
        self._time_period_extractor = BaseTimePeriodExtractor(EnglishTimePeriodExtractorConfiguration())
        self._date_time_period_extractor = BaseDateTimePeriodExtractor(EnglishDateTimePeriodExtractorConfiguration())
        self._last_regex = RegExpUtility.get_safe_reg_exp(EnglishDateTime.SetLastRegex)
        self._each_prefix_regex = RegExpUtility.get_safe_reg_exp(EnglishDateTime.EachPrefixRegex)
        self._periodic_regex = RegExpUtility.get_safe_reg_exp(EnglishDateTime.PeriodicRegex)
        self._each_unit_regex = RegExpUtility.get_safe_reg_exp(EnglishDateTime.EachUnitRegex)
        self._each_day_regex = RegExpUtility.get_safe_reg_exp(EnglishDateTime.EachDayRegex)
        self._set_week_day_regex = RegExpUtility.get_safe_reg_exp(EnglishDateTime.SetWeekDayRegex)
        self._set_each_regex = RegExpUtility.get_safe_reg_exp(EnglishDateTime.SetEachRegex)
        self._before_each_day_regex = None
