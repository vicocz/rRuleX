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
}
