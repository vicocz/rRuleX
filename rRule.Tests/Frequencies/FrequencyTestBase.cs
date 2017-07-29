using NUnit.Framework;
using System;
using Vico.rRule;

namespace Vico.rRule.Tests.Frequencies
{
    public abstract class FrequencyTestBase<T> where T : IRecurrenceFrequency
    {
        protected abstract T CreateInstance();

        protected void AssertPatternName(string expectedName)
        {
            var freqency = CreateInstance();
            Assert.AreEqual(expectedName, freqency.PatternName);
        }

        protected void AssertTryApply(string dateTime, int quantity, string exceptedValue)
        {
            T frequency = CreateInstance();

            var testDate = dateTime.ToInvariantDateTime();
            var expectedDate = exceptedValue.ToInvariantDateTime();

            DateTime result;
            bool applied = frequency.TryApply(testDate, quantity, out result);

            Assert.IsTrue(applied);
            Assert.AreEqual(expectedDate, result);
        }
    }
}
