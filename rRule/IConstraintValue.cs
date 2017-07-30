using Vico.rRule.DataTypes;

namespace Vico.rRule
{
    public interface IConstraintValue<T> where T : IDataType
    {
        T DataType { get; }
    }
}