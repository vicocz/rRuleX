using Vico.rRule.DataTypes;

namespace Vico.rRule
{
    public interface IStringConstraintValue : IConstraintValue<IStringDataType>
    {
        /// <summary>
        /// Gets associated string value
        /// </summary>
        string Value { get; }
    }
}