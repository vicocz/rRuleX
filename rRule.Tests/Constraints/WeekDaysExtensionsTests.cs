using NUnit.Framework;
using System;
using Vico.rRule.Constraints;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class WeekDaysExtensionsTests
    {
        [TestCase("SU", DayOfWeek.Sunday)]
        [TestCase("MO", DayOfWeek.Monday)]
        [TestCase("TU", DayOfWeek.Tuesday)]
        [TestCase("WE", DayOfWeek.Wednesday)]
        [TestCase("TH", DayOfWeek.Thursday)]
        [TestCase("FR", DayOfWeek.Friday)]
        [TestCase("SA", DayOfWeek.Saturday)]
        public void GetDayOfWeek(string input, DayOfWeek expectedDayOfWeek)
        {
            var dayOfWeek = input.GetDayOfWeek();

            Assert.AreEqual(expectedDayOfWeek, dayOfWeek);
        }

        [TestCase(null)]
        [TestCase("su")]
        [TestCase("sunday")]
        public void GetDayOfWeek_InvalidInput_ExceptionIsThrown(string input)
        {
            Assert.Throws<ArgumentException>(() => input.GetDayOfWeek());
        }
    }
}