using System;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class MonthConstraintTests
    {
        [TestCase(1, false)]
        [TestCase(2, true)]
        public void Filter(int value, bool expectedResult)
        {
            var contraintValue = new NumericConstraintValue(value, DefaultDataTypes.MonthDataType);
            var constraint = new MonthConstraint(contraintValue);

            bool result = constraint.Filter(new DateTime(2016, 2, 29));

            Assert.AreEqual(expectedResult, result);
        }
    }
}