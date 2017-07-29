using NUnit.Framework;
using Vico.rRule.Frequencies;

namespace Vico.rRule.Tests.Frequencies
{
    [TestFixture]
    public class MinutelyRecurrenceFrequencyTests : FrequencyTestBase<MinutelyRecurrenceFrequency>
    {
        protected override MinutelyRecurrenceFrequency CreateInstance()
        {
            return new MinutelyRecurrenceFrequency();
        }


        [TestCase("MINUTELY")]
        public void PatternName(string expectedName)
        {
            AssertPatternName(expectedName);
        }

        [TestCase("2016-01-29 12:58:59", 00, "2016-01-29 12:58:59")]
        [TestCase("2016-01-29 12:58:59", 01, "2016-01-29 12:59:59")]
        [TestCase("2016-01-29 12:58:59", 99, "2016-01-29 14:37:59")]
        [TestCase("2016-01-29 12:58:59", -1, "2016-01-29 12:57:59")]
        public void TryApply(string testString, int quantity, string expectedString)
        {
            AssertTryApply(testString, quantity, expectedString);
        }
    }
}
