using NUnit.Framework;
using Vico.rRule.Frequencies;

namespace Vico.rRule.Tests.Frequencies
{
    [TestFixture]
    public class MonthlyRecurrenceFrequencyTests : FrequencyTestBase<MonthlyRecurrenceFrequency>
    {
        protected override MonthlyRecurrenceFrequency CreateInstance()
        {
            return new MonthlyRecurrenceFrequency();
        }

        [TestCase("MONTHLY")]
        public void PatternName(string expectedName)
        {
            AssertPatternName(expectedName);
        }

        [TestCase("2016-02-29", 00, "2016-02-29")]
        [TestCase("2016-02-29", 01, "2016-03-29")]
        [TestCase("2016-01-30", 01, "2016-02-29")]
        [TestCase("2016-02-29", 12, "2017-02-28")]
        [TestCase("2016-02-29", -3, "2015-11-29")]
        public void TryApply(string testString, int quantity, string expectedString)
        {
            AssertTryApply(testString, quantity, expectedString);
        }
    }
}
