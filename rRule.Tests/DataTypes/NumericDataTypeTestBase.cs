using NUnit.Framework;
using System;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.DataTypes
{
    public abstract class NumericDataTypeTestBase<T> where T : INumericDataType
    {
        protected abstract T CreateInstance();

        protected void AssertMinMaxValues(int expectedMinValue, int expectedMaxValue)
        {
            var dateType = CreateInstance();

            Assert.AreEqual(expectedMinValue, dateType.MininumValue);
            Assert.AreEqual(expectedMaxValue, dateType.MaximumValue);
        }
    }
}
