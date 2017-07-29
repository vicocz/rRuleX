using NUnit.Framework;
using Vico.rRule.Frequencies;

namespace Vico.rRule.Tests.Frequencies
{
    [TestFixture]
    public class YearlyRecurrenceFrequencyTests : FrequencyTestBase<YearlyRecurrenceFrequency>
    {
        protected override YearlyRecurrenceFrequency CreateInstance()
        {
            return new YearlyRecurrenceFrequency();
        }

        [TestCase("YEARLY")]
        public void PatternName(string expectedName)
        {
            AssertPatternName(expectedName);
        }

        [TestCase("2016-02-28", 0, "2016-02-28")]
        [TestCase("2016-02-29", 1, "2017-02-28")]
        [TestCase("2016-02-29", -100, "1916-02-29")]
        public void TryApply(string testString, int quantity, string expectedString)
        {
            AssertTryApply(testString, quantity, expectedString);
        }
    }
}
