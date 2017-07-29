using NUnit.Framework;
using Vico.rRule.Frequencies;

namespace Vico.rRule.Tests.Frequencies
{
    [TestFixture]
    public class HourlyRecurrenceFrequencyTests : FrequencyTestBase<HourlyRecurrenceFrequency>
    {
        protected override HourlyRecurrenceFrequency CreateInstance()
        {
            return new HourlyRecurrenceFrequency();
        }


        [TestCase("HOURLY")]
        public void PatternName(string expectedName)
        {
            AssertPatternName(expectedName);
        }

        [TestCase("2016-02-29 23:55:59", 00, "2016-02-29 23:55:59")]
        [TestCase("2016-02-29 23:55:59", 01, "2016-03-01 00:55:59")]
        [TestCase("2016-02-29 23:55:59", 25, "2016-03-02 00:55:59")]
        [TestCase("2016-02-29 23:55:59", -5, "2016-02-29 18:55:59")]
        public void TryApply(string testString, int quantity, string expectedString)
        {
            AssertTryApply(testString, quantity, expectedString);
        }
    }
}
