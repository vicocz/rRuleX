using Vico.rRule.DataTypes;

namespace Vico.rRule
{
    public interface INumericConstraintValue : IConstraintValue<INumericDataType>
    {
        /// <summary>
        /// Gets value
        /// </summary>
        int Value { get; }
    }
}