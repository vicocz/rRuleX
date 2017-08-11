namespace Vico.rRule.DataTypes
{
    /// <summary>
    /// Represents numeric data type having definition of minimum and maximum allowed values
    /// </summary>
    public interface INumericDataType : IDataType<int>
    {
        /// <summary>
        /// Gets minimun of allowed values
        /// </summary>
        int MininumValue { get; }

        /// <summary>
        /// Gets maximum of allowed values
        /// </summary>
        int MaximumValue { get; }
    }
}
