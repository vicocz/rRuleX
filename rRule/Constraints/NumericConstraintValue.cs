using System;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Constraints
{
    public class NumericConstraintValue : INumericConstraintValue
    {
        public NumericConstraintValue(int value, INumericDataType dataType)
        {
            DataType = dataType ?? throw new ArgumentNullException(nameof(dataType));

            // validation (including throwing an exception)
            Value = dataType.Validate(value);
        }

        public int Value { get; }

        public INumericDataType DataType { get; }
    }
}
