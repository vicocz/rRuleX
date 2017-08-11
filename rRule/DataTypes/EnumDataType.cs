using System;

namespace Vico.rRule.DataTypes
{
    /// <summary>
    /// Represents enumeration data type 
    /// </summary>
    public class EnumDataType<T> : IEnumDataType<T> where T : struct, IConvertible
    {
        public Type DataType =>typeof(T);

        public T Validate(T value)
        {
            if (!typeof(T).IsEnum)
                throw new InvalidDataTypeException(nameof(value));

            return value;
        }
    }
}
