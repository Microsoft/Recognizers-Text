﻿using System.Collections.Generic;
using Microsoft.Recognizers.Text.DataDrivenTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Recognizers.Text.DateTime.Tests
{
    [TestClass]
    public class TestDateTime_Japanese : TestBase
    {
        public static TestResources TestResources { get; private set; }
        public static IDictionary<string, IDateTimeExtractor> Extractors { get; private set; }
        public static IDictionary<string, IDateTimeParser> Parsers { get; private set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            TestResources = new TestResources();
            TestResources.InitFromTestContext(context);
            Extractors = new Dictionary<string, IDateTimeExtractor>();
            Parsers = new Dictionary<string, IDateTimeParser>();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            base.TestSpecInitialize(TestResources);
        }

    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "DateExtractor-Japanese.csv", "DateExtractor-Japanese#csv", DataAccessMethod.Sequential)]
    [TestMethod]
    public void DateExtractor()
    {
      base.ExtractorInitialize(Extractors);
      base.TestDateTimeExtractor();
    }

    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "DateParser-Japanese.csv", "DateParser-Japanese#csv", DataAccessMethod.Sequential)]
    [TestMethod]
    public void DateParser()
    {
      base.ExtractorInitialize(Extractors);
      base.ParserInitialize(Parsers);
      base.TestDateTimeParser();
    }

    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "DatePeriodParser-Japanese.csv", "DatePeriodParser-Japanese#csv", DataAccessMethod.Sequential)]
    [TestMethod]
    public void DatePeriodParser()
    {
      base.ExtractorInitialize(Extractors);
      base.ParserInitialize(Parsers);
      base.TestDateTimeParser();
    }

    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "DateTimeParser-Japanese.csv", "DateTimeParser-Japanese#csv", DataAccessMethod.Sequential)]
    [TestMethod]
    public new void DateTimeParser()
    {
      base.ExtractorInitialize(Extractors);
      base.ParserInitialize(Parsers);
      base.TestDateTimeParser();
    }
  }
}
