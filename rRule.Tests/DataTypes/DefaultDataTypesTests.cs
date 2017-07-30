using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.DataTypes
{
    [TestFixture]
    internal class DefaultDataTypesTests
    {

        private static void AssertDataType(INumericDataType dataType, int min, int max, int value, int invalidValue)
        {
            Assert.AreEqual(min, dataType.MininumValue);
            Assert.AreEqual(max, dataType.MaximumValue);
            Assert.AreEqual(value, dataType.Validate(value));
            Assert.Throws<InvalidNumericValueException>(() => dataType.Validate(invalidValue));
        }


        [TestCase(0, 59, 44, 60)]
        public void SecondsDataType(int min, int max, int value, int invalidValue)
        {
            AssertDataType(DefaultDataTypes.SecondsDataType, min, max, value, invalidValue);
        }

        [TestCase(0, 59, 33, -1)]
        public void MinutesDataType(int min, int max, int value, int invalidValue)
        {
            AssertDataType(DefaultDataTypes.MinutesDataType, min, max, value, invalidValue);
        }

        [TestCase(0, 23, 11, 24)]
        public void HoursDataType(int min, int max, int value, int invalidValue)
        {
            AssertDataType(DefaultDataTypes.HoursDataType, min, max, value, invalidValue);
        }

        [TestCase(1, 12, 2, 0)]
        public void MonthDataType(int min, int max, int value, int invalidValue)
        {
            AssertDataType(DefaultDataTypes.MonthDataType, min, max, value, invalidValue);
        }

        [TestCase(-31, 31, 2, 32)]
        public void DayOfMonthDataType(int min, int max, int value, int invalidValue)
        {
            AssertDataType(DefaultDataTypes.DayOfMonthDataType, min, max, value, invalidValue);
        }

        [TestCase(-366, 366, 0, 400)]
        public void DayOfYearDataType(int min, int max, int value, int invalidValue)
        {
            AssertDataType(DefaultDataTypes.DayOfYearDataType, min, max, value, invalidValue);
        }

        [TestCase(-53, 53, 2, 54)]
        public void WeekOfYearDataType(int min, int max, int value, int invalidValue)
        {
            AssertDataType(DefaultDataTypes.WeekOfYearDataType, min, max, value, invalidValue);
        }

    }
}
