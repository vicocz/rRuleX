using System;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Constraints
{
    public class StringConstraintValue : IStringConstraintValue
    {
        public StringConstraintValue(string value, IStringDataType dataType)
        {
            DataType = dataType ?? throw new ArgumentNullException(nameof(dataType));

            // validation (including throwing an exception)
            Value = dataType.Validate(value);
        }

        public string Value { get; }

        public IStringDataType DataType { get; }
    }
}
