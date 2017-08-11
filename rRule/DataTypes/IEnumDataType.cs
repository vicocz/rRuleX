using System;

namespace Vico.rRule.DataTypes
{
    /// <summary>
    /// Represents enumeration data type having definition of minimum and maximum allowed values
    /// </summary>
    public interface IEnumDataType<T> : IDataType<T> where T : struct, IConvertible
    {
    }
}
