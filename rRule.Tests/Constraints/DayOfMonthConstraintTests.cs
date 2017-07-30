using System;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class DayOfMonthConstraintTests
    {
        [TestCase(-2, false)]
        [TestCase(-1, true)]
        [TestCase(29, true)]
        [TestCase(2, false)]
        public void Filter(int value, bool expectedResult)
        {
            var contraintValue = new NumericConstraintValue(value, DefaultDataTypes.DayOfMonthDataType);
            var constraint = new DayOfMonthConstraint(contraintValue);

            var testDate = new DateTime(2016, 2, 29);

            bool result = constraint.Filter(testDate);

            Assert.AreEqual(expectedResult, result);
        }
    }
}