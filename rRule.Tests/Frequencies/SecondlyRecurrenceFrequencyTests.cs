using NUnit.Framework;
using System;
using Vico.rRule.Frequencies;

namespace Vico.rRule.Tests.Frequencies
{
    [TestFixture]
    public class SecondlyRecurrenceFrequencyTests : FrequencyTestBase<SecondlyRecurrenceFrequency>
    {
        protected override SecondlyRecurrenceFrequency CreateInstance()
        {
            return new SecondlyRecurrenceFrequency();
        }


        [TestCase("SECONDLY")]
        public void PatternName(string expectedName)
        {
            AssertPatternName(expectedName);
        }

        [TestCase("2016-12-31 23:59:59", 00, "2016-12-31 23:59:59")]
        [TestCase("2016-12-31 23:59:59", 01, "2017-01-01 00:00:00")]
        [TestCase("2016-12-31 23:59:59", 05, "2017-01-01 00:00:04")]
        [TestCase("2016-12-31 23:59:59", -9, "2016-12-31 23:59:50")]
        public void TryApply(string testString, int quantity, string expectedString)
        {
            AssertTryApply(testString, quantity, expectedString);
        }
    }
}
