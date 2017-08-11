using System;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class DayOfWeekConstraintTests
    {

        private static DayOfWeekConstraint Create(string value)
        {
            var contraintValue = new StringConstraintValue(value, DefaultDataTypes.StringDataType);
            return new DayOfWeekConstraint(contraintValue);
        }

        [TestCase("SU", false)]
        [TestCase("MO", true)]
        public void Filter(string value, bool expectedResult)
        {
            var constraint = Create(value);

            var testDate = new DateTime(2016, 2, 29);

            bool result = constraint.Filter(testDate);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void TagName()
        {
            var constraint = Create("FR");

            Assert.AreEqual("BYDAY", constraint.TagName);
        }
    }
}