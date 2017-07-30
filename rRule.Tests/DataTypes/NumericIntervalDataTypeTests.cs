using NUnit.Framework;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.DataTypes
{
    [TestFixture]
    public class NumericIntervalDataTypeTests : NumericDataTypeTestBase<NumericIntervalDataType>
    {
        private const int MinVal = -3;
        private const int MaxVal = 15;

        protected override NumericIntervalDataType CreateInstance()
        {
            return new NumericIntervalDataType(MinVal, MaxVal);
        }

        [TestCase(-3, 15)]
        public void MinMaxValues(int expectedMinValue, int expectedMaxValue)
        {
            AssertMinMaxValues(expectedMinValue, expectedMaxValue);
        }
    }
}