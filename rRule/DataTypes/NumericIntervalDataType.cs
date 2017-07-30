using System;

namespace Vico.rRule.DataTypes
{
    public class NumericIntervalDataType : NumericDataTypeBase, INumericDataType
    {
        public NumericIntervalDataType(int minValue, int maxValue)
        {
            if (minValue > maxValue)
                throw new ArgumentException(nameof(minValue));

            MininumValue = minValue;
            MaximumValue = maxValue;
        }

        public int MininumValue { get; }

        public int MaximumValue { get; }

        public int Validate(int value)
        {
            if (!IsValid(value, MininumValue, MaximumValue))
                throw new InvalidNumericValueException(nameof(value));

            return value;
        }
    }
}
