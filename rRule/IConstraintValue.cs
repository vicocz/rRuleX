using Vico.rRule.DataTypes;

namespace Vico.rRule
{
    public interface IConstraintValue<out T> where T : IDataType
    {
        T DataType { get; }
    }
}