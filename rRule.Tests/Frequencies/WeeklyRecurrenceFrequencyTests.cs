using NUnit.Framework;
using Vico.rRule.Frequencies;

namespace Vico.rRule.Tests.Frequencies
{
    [TestFixture]
    public class WeeklyRecurrenceFrequencyTests : FrequencyTestBase<WeeklyRecurrenceFrequency>
    {
        protected override WeeklyRecurrenceFrequency CreateInstance()
        {
            return new WeeklyRecurrenceFrequency();
        }

        [TestCase("WEEKLY")]
        public void PatternName(string expectedName)
        {
            AssertPatternName(expectedName);
        }

        [TestCase("2017-02-28", 00, "2017-02-28")]
        [TestCase("2017-02-28", 01, "2017-03-07")]
        [TestCase("2017-02-28", -5, "2017-01-24")]
        public void TryApply(string testString, int quantity, string expectedString)
        {
            AssertTryApply(testString, quantity, expectedString);
        }
    }
}
