namespace Vico.rRule.DataTypes
{
    /// <summary>
    /// Represents numeric data type having definition of minimum and maximum allowed values
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
        /// Validate the specified value and if not valid throw exception
        /// </summary>
        /// <param name="value">Numeric value to be validated</param>
        /// <returns>Input value if valid</returns>
        int Validate(int value);
    }
}
