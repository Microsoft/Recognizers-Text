﻿using System;
using System.Collections.Generic;
using Microsoft.Recognizers.Text.Sequence;
using Microsoft.Recognizers.Text.Sequence.Chinese;
using Microsoft.Recognizers.Text.Sequence.Dutch;
using Microsoft.Recognizers.Text.Sequence.English;
using Microsoft.Recognizers.Text.Sequence.French;
using Microsoft.Recognizers.Text.Sequence.German;
using Microsoft.Recognizers.Text.Sequence.Hindi;
using Microsoft.Recognizers.Text.Sequence.Italian;
using Microsoft.Recognizers.Text.Sequence.Korean;
using Microsoft.Recognizers.Text.Sequence.Portuguese;
using Microsoft.Recognizers.Text.Sequence.Spanish;
using Microsoft.Recognizers.Text.Sequence.Turkish;

namespace Microsoft.Recognizers.Text.Sequence
{
    public class SequenceRecognizer : Recognizer<SequenceOptions>
    {
        public SequenceRecognizer(string targetCulture, SequenceOptions options = SequenceOptions.None, bool lazyInitialization = false)
            : base(targetCulture, options, lazyInitialization)
        {
        }

        public SequenceRecognizer(string targetCulture, int options, bool lazyInitialization = false)
            : this(targetCulture, GetOptions(options), lazyInitialization)
        {
        }

        public SequenceRecognizer(SequenceOptions options = SequenceOptions.None, bool lazyInitialization = true)
            : base(null, options, lazyInitialization)
        {
        }

        public SequenceRecognizer(int options, bool lazyInitialization = true)
            : this(null, GetOptions(options), lazyInitialization)
        {
        }

        public static List<ModelResult> RecognizePhoneNumber(string query, string culture, SequenceOptions options = SequenceOptions.None, bool fallbackToDefaultCulture = true)
        {
            return RecognizeByModel(recognizer => recognizer.GetPhoneNumberModel(culture, fallbackToDefaultCulture), query, options);
        }

        public static List<ModelResult> RecognizeIpAddress(string query, string culture, SequenceOptions options = SequenceOptions.None, bool fallbackToDefaultCulture = true)
        {
            return RecognizeByModel(recognizer => recognizer.GetIpAddressModel(culture, fallbackToDefaultCulture), query, options);
        }

        public static List<ModelResult> RecognizeMention(string query, string culture, SequenceOptions options = SequenceOptions.None, bool fallbackToDefaultCulture = true)
        {
            return RecognizeByModel(recognizer => recognizer.GetMentionModel(culture, fallbackToDefaultCulture), query, options);
        }

        public static List<ModelResult> RecognizeHashtag(string query, string culture, SequenceOptions options = SequenceOptions.None, bool fallbackToDefaultCulture = true)
        {
            return RecognizeByModel(recognizer => recognizer.GetHashtagModel(culture, fallbackToDefaultCulture), query, options);
        }

        public static List<ModelResult> RecognizeEmail(string query, string culture, SequenceOptions options = SequenceOptions.None, bool fallbackToDefaultCulture = true)
        {
            return RecognizeByModel(recognizer => recognizer.GetEmailModel(culture, fallbackToDefaultCulture), query, options);
        }

        public static List<ModelResult> RecognizeURL(string query, string culture, SequenceOptions options = SequenceOptions.None, bool fallbackToDefaultCulture = true)
        {
            return RecognizeByModel(recognizer => recognizer.GetURLModel(culture, fallbackToDefaultCulture), query, options);
        }

        public static List<ModelResult> RecognizeGUID(string query, string culture, SequenceOptions options = SequenceOptions.None, bool fallbackToDefaultCulture = true)
        {
            return RecognizeByModel(recognizer => recognizer.GetGUIDModel(culture, fallbackToDefaultCulture), query, options);
        }

        public IModel GetPhoneNumberModel(string culture = null, bool fallbackToDefaultCulture = true)
        {
            if (culture != null && (
                culture.ToLowerInvariant().StartsWith("zh-", StringComparison.Ordinal) ||
                culture.ToLowerInvariant().StartsWith("ja-", StringComparison.Ordinal)))
            {
                return GetModel<PhoneNumberModel>(Culture.Chinese, fallbackToDefaultCulture);
            }

            return GetModel<PhoneNumberModel>(culture, fallbackToDefaultCulture);
        }

        public IModel GetIpAddressModel(string culture = null, bool fallbackToDefaultCulture = true)
        {
            if (culture != null && (
                    culture.ToLowerInvariant().StartsWith("zh-", StringComparison.Ordinal) ||
                    culture.ToLowerInvariant().StartsWith("ja-", StringComparison.Ordinal)))
            {
                return GetModel<IpAddressModel>(Culture.Chinese, fallbackToDefaultCulture);
            }

            return GetModel<IpAddressModel>(Culture.English, fallbackToDefaultCulture);
        }

        public IModel GetMentionModel(string culture = null, bool fallbackToDefaultCulture = true)
        {
            return GetModel<MentionModel>(Culture.English, fallbackToDefaultCulture);
        }

        public IModel GetHashtagModel(string culture = null, bool fallbackToDefaultCulture = true)
        {
            return GetModel<HashtagModel>(Culture.English, fallbackToDefaultCulture);
        }

        public IModel GetEmailModel(string culture = null, bool fallbackToDefaultCulture = true)
        {
            return GetModel<EmailModel>(Culture.English, fallbackToDefaultCulture);
        }

        public IModel GetURLModel(string culture = null, bool fallbackToDefaultCulture = true)
        {
            if (culture.ToLowerInvariant().StartsWith("zh-", StringComparison.Ordinal) ||
                culture.ToLowerInvariant().StartsWith("ja-", StringComparison.Ordinal))
            {
                return GetModel<URLModel>(Culture.Chinese, fallbackToDefaultCulture);
            }

            return GetModel<URLModel>(Culture.English, fallbackToDefaultCulture);
        }

        public IModel GetGUIDModel(string culture = null, bool fallbackToDefaultCulture = true)
        {
            return GetModel<GUIDModel>(Culture.English, fallbackToDefaultCulture);
        }

        protected override void InitializeConfiguration()
        {
            RegisterModel<PhoneNumberModel>(
                Culture.English,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new EnglishPhoneNumberExtractorConfiguration(options))));

            RegisterModel<IpAddressModel>(
                Culture.English,
                (options) => new IpAddressModel(
                    new IpParser(),
                    new BaseIpExtractor(new EnglishIpExtractorConfiguration(options))));

            RegisterModel<MentionModel>(
                Culture.English,
                (options) => new MentionModel(new MentionParser(), new MentionExtractor()));

            RegisterModel<HashtagModel>(
                Culture.English,
                (options) => new HashtagModel(new HashtagParser(), new HashtagExtractor()));

            RegisterModel<EmailModel>(
                Culture.English,
                (options) => new EmailModel(new EmailParser(), new EmailExtractor()));

            RegisterModel<URLModel>(
                Culture.English,
                (options) => new URLModel(
                    new URLParser(),
                    new BaseURLExtractor(new EnglishURLExtractorConfiguration(options))));

            RegisterModel<GUIDModel>(
                Culture.English,
                (options) => new GUIDModel(new GUIDParser(), new GUIDExtractor()));

            RegisterModel<PhoneNumberModel>(
                Culture.Chinese,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new ChinesePhoneNumberExtractorConfiguration(options))));

            RegisterModel<IpAddressModel>(
                Culture.Chinese,
                (options) => new IpAddressModel(
                    new IpParser(),
                    new BaseIpExtractor(new ChineseIpExtractorConfiguration(options))));

            RegisterModel<URLModel>(
                Culture.Chinese,
                options => new URLModel(
                    new URLParser(),
                    new BaseURLExtractor(new ChineseURLExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.Portuguese,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new PortuguesePhoneNumberExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.Spanish,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new SpanishPhoneNumberExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.Dutch,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new DutchPhoneNumberExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.French,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new FrenchPhoneNumberExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.German,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new GermanPhoneNumberExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.Hindi,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new HindiPhoneNumberExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.Italian,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new ItalianPhoneNumberExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.Korean,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new KoreanPhoneNumberExtractorConfiguration(options))));

            RegisterModel<PhoneNumberModel>(
                Culture.Turkish,
                (options) => new PhoneNumberModel(
                    new PhoneNumberParser(),
                    new BasePhoneNumberExtractor(new TurkishPhoneNumberExtractorConfiguration(options))));
        }

        private static List<ModelResult> RecognizeByModel(Func<SequenceRecognizer, IModel> getModelFunc, string query, SequenceOptions options)
        {
            var recognizer = new SequenceRecognizer(options);
            var model = getModelFunc(recognizer);
            return model.Parse(query);
        }
    }
}
