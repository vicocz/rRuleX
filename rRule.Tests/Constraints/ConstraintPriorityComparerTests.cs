using System.Collections.Generic;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class ConstraintPriorityComparerTests
    {
        [Test]
        public void Compare()
        {
            var byMonthDay = new DayOfMonthConstraint(new NumericConstraintValue(1, DefaultDataTypes.DayOfMonthDataType));
            var byYearDay = new DayOfYearConstraint(new NumericConstraintValue(1, DefaultDataTypes.DayOfYearDataType));
            var byWeekDay = new DayOfWeekConstraint(new StringConstraintValue("SU", DefaultDataTypes.StringDataType));
            var byMonth = new MonthConstraint(new NumericConstraintValue(1, DefaultDataTypes.MonthDataType));
            var byWeekYear = new WeekOfYearConstraint(new NumericConstraintValue(1, DefaultDataTypes.WeekOfYearDataType));

            var constraints = new List<IRecurrenceConstraint>();
            constraints.AddRange(new IRecurrenceConstraint[]
            {
                byMonthDay,
                byYearDay,
                byWeekDay,
                byMonth,
                byWeekYear,
            });
            constraints.Sort(new ConstraintPriorityComparer());

            Assert.AreEqual(3, constraints.IndexOf(byMonthDay));
            Assert.AreEqual(2, constraints.IndexOf(byYearDay));
            Assert.AreEqual(4, constraints.IndexOf(byWeekDay));
            Assert.AreEqual(0, constraints.IndexOf(byMonth));
            Assert.AreEqual(1, constraints.IndexOf(byWeekYear));
        }
    }
}
