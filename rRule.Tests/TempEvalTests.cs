using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests
{
    [TestFixture]
    internal class TempEvalTests
    {
        [Test]
        public void Filter()
        {
            var monthConstraint = new MonthConstraint(new NumericConstraintValue(5, DefaultDataTypes.MonthDataType));
            var monthDayContraint = new DayOfMonthConstraint(new INumericConstraintValue []
            { new NumericConstraintValue(3, DefaultDataTypes.DayOfMonthDataType), new NumericConstraintValue(29, DefaultDataTypes.DayOfMonthDataType)});

            var source = GetWorkSet(2005);

            var allowed = source.Where(i => monthConstraint.Filter(i))
                .Where(i => monthDayContraint.Filter(i))
                .ToList();

            var testCaseOne = new DateTime(2005, 5, 3);
            var testCaseTwo = new DateTime(2005, 5, 29);

            Assert.AreEqual(2, allowed.Count);
            CollectionAssert.Contains(allowed, testCaseOne);
            CollectionAssert.Contains(allowed, testCaseTwo);
        }

        private static IList<DateTime> GetWorkSet(int year)
        {
            var list = new List<DateTime>(366);
            DateTime seed = new DateTime(year, 1, 1);

            do
            {
                list.Add(seed);

                seed = seed.AddDays(1);
            } while (seed.Year == year);

            return list;
        }
    }
}
