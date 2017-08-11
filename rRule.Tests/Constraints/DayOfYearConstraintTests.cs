using System;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class DayOfYearConstraintTests
    {
        [TestCase(29, false)]
        [TestCase(60, true)]
        [TestCase(-307, true)]
        [TestCase(-306, false)]
        public void Filter(int value, bool expectedResult)
        {
            var contraintValue = new NumericConstraintValue(value, DefaultDataTypes.DayOfYearDataType);
            var constraint = new DayOfYearConstraint(new INumericConstraintValue[] { contraintValue });

            var testDate = new DateTime(2016, 2, 29);

            bool result = constraint.Filter(testDate);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TagName()
        {
            var contraintValue = new NumericConstraintValue(1, DefaultDataTypes.DayOfMonthDataType);
            var constraint = new DayOfYearConstraint(contraintValue);

            Assert.AreEqual("BYYEARDAY", constraint.TagName);
        }
    }
}