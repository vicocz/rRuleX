using System;
using Vico.rRule.DataTypes;

namespace Vico.rRule
{
    public interface IEnumConstraintValue<T> : IConstraintValue<IEnumDataType<T>> where T : struct, IConvertible
    {
        /// <summary>
        /// Gets value
        /// </summary>
        T Value { get; }
    }
}