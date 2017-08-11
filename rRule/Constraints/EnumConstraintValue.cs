using System;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Constraints
{
    public class EnumConstraintValue<T> : IEnumConstraintValue<T> where T : struct, IConvertible
    {
        public EnumConstraintValue(T value, IEnumDataType<T> dataType)
        {
            DataType = dataType ?? throw new ArgumentNullException(nameof(dataType));

            // validation (including throwing an exception)
            Value = dataType.Validate(value);
        }

        public T Value { get; }

        public IEnumDataType<T> DataType { get; }
    }
}
