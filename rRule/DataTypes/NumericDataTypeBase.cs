using System;

namespace Vico.rRule.DataTypes
{
    public abstract class NumericDataTypeBase
    {
        public Type DataType => typeof(int);

        protected static bool IsValid(int value, int minValue, int maxValue)
        {
            return value >= minValue && value <= maxValue;
        }
    }
}
