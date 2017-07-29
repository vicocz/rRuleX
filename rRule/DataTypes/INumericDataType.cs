namespace Vico.rRule.DataTypes
{
    /// <summary>
    /// Represents numeric datatype including minimum and maximum allowed values
    /// </summary>
    public interface INumericDataType : IDataType
    {
        /// <summary>
        /// Gets minimun of allowed values
        /// </summary>
        int MininumValue { get; }

        /// <summary>
        /// Gets maximum of allowed values
        /// </summary>
        int MaximumValue { get; }

        /// <summary>
        /// Gets value
        /// </summary>
        int Value { get; }
    }
}
