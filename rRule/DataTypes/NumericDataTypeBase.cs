using System;

namespace Vico.rRule.DataTypes
{
    public abstract class NumericDataTypeBase
    {
        public Type DataType => typeof(int);

        protected bool IsValid(int value)
        {
            return value != int.MinValue && value != int.MaxValue;
        }
    }
}
