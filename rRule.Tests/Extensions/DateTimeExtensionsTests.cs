using System;
using NUnit.Framework;
using Vico.rRule.Extensions;

namespace Vico.rRule.Tests.Extensions
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        [TestCase(2016, 1, 03, 53)]
        [TestCase(2016, 1, 04, 01)]
        [TestCase(2016, 1, 10, 01)]
        [TestCase(2016, 1, 11, 02)]
        public void WeekOfYear_DefaultWeekStart(int year, int month, int day, int expectedWeek)
        {
            var testDate = new DateTime(year, month, day);
            int week = testDate.WeekOfYear();

            Assert.AreEqual(expectedWeek, week);
        }

        [TestCase(2016, 1, 1, DayOfWeek.Thursday, 1)]
        [TestCase(2016, 1, 7, DayOfWeek.Thursday, 2)]
        [TestCase(2015, 12, 26, DayOfWeek.Sunday, 51)]
        [TestCase(2015, 12, 31, DayOfWeek.Sunday, 52)]
        [TestCase(2016, 1, 2, DayOfWeek.Sunday, 52)]
        [TestCase(2016, 1, 3, DayOfWeek.Sunday, 1)]
        public void WeekOfYear(int year, int month, int day, DayOfWeek weekStart, int expectedWeek)
        {
            var testDate = new DateTime(year, month, day);

            int week = testDate.WeekOfYear(weekStart);

            Assert.AreEqual(expectedWeek, week);
        }

        [TestCase(2016, 1, 3, DayOfWeek.Monday, -1)]
        [TestCase(2016, 1, 4, DayOfWeek.Monday, 0)]
        [TestCase(2016, 1, 1, DayOfWeek.Thursday, 1)]
        [TestCase(2016, 1, 7, DayOfWeek.Thursday, 7)]
        [TestCase(2016, 1, 1, DayOfWeek.Sunday, -2)]
        [TestCase(2016, 1, 2, DayOfWeek.Sunday, -1)]
        public void GetWeekOffset(int year, int month, int day, DayOfWeek weekStart, int expectedOffset)
        {
            var testDate = new DateTime(year, month, day);
            int offset = testDate.GetWeekOffset(weekStart);

            Assert.AreEqual(expectedOffset, offset);
        }
    }
}
