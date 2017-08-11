using System;

namespace Vico.rRule.DataTypes
{
    /// <summary>
    /// Defines base set of preperties for value data type
    /// </summary>
    public interface IDataType
    {
        /// <summary>
        /// Get type of value
        /// </summary>
        Type DataType { get; }
    }

    /// <summary>
    /// Defines base set of preperties for value data type
    /// </summary>
    public interface IDataType<T> : IDataType
    {
        /// <summary>
        /// Validate the specified value and if not valid throw exception
        /// </summary>
        /// <param name="value">Typed value to be validated</param>
        /// <returns>Input value if valid</returns>
        T Validate(T value);
    }
}