using System;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class WeekOfYearConstraintTests
    {
        [TestCase(53, 2015, 12, 31, true)]
        [TestCase(-1, 2015, 12, 31, true)]
        [TestCase(53, 2016, 1, 3, true)]
        [TestCase(1, 2016, 1, 3, false)]
        [TestCase(-52, 2016, 1, 4, true)]
        public void Filter_DefaultWeekStart(int value, int year, int month, int day, bool expectedResult)
        {
            var contraintValue = new NumericConstraintValue(value, DefaultDataTypes.WeekOfYearDataType);
            var constraint = new WeekOfYearConstraint(new INumericConstraintValue[] { contraintValue });

            var testDate = new DateTime(year, month, day);

            bool result = constraint.Filter(testDate);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TagName()
        {
            var contraintValue = new NumericConstraintValue(1, DefaultDataTypes.WeekOfYearDataType);
            var constraint = new WeekOfYearConstraint(contraintValue);

            Assert.AreEqual("BYWEEKNO", constraint.TagName);
        }
    }
}