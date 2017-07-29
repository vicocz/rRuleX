using System;

namespace Vico.rRule
{
    /// <summary>
    /// Defines frequency pattern of recurrence 
    /// </summary>
    /// <remarks>Implementation is expected to be immutable.</remarks>
    public interface IRecurrenceFrequency : IImutable
    {
        /// <summary>
        /// Get unique pattern name
        /// </summary>
        string PatternName { get; }

        /// <summary>
        /// Tries to apply the frequency pattern to the specified date/time
        /// </summary>
        /// <param name="date">Base date to be applied to</param>
        /// <param name="quantity">Frequency quantity to apply</param>
        /// <param name="result">Resulting date if the frequenci was applied</param>
        /// <returns>true if the pattern is appliable; false otherwise</returns>
        bool TryApply(DateTime date, int quantity, out DateTime result);
    }
}
