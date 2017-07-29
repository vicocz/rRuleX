using NUnit.Framework;
using System;
using Vico.rRule.Frequencies;

namespace Vico.rRule.Tests.Frequencies
{
    [TestFixture]
    public class DailyRecurrenceFrequencyTests : FrequencyTestBase<DailyRecurrenceFrequency>
    {
        protected override DailyRecurrenceFrequency CreateInstance()
        {
            return new DailyRecurrenceFrequency();
        }


        [TestCase("DAILY")]
        public void PatternName(string expectedName)
        {
            AssertPatternName(expectedName);
        }

        [TestCase("2016-02-29", 0, "2016-02-29")]
        [TestCase("2016-02-29", 1, "2016-03-01")]
        [TestCase("2016-12-29", 3, "2017-01-01")]
        [TestCase("2016-02-29", -3, "2016-02-26")]
        public void TryApply(string testString, int quantity, string expectedString)
        {
            AssertTryApply(testString, quantity, expectedString);
        }
    }
}
