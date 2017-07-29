using System;

namespace Vico.rRule.Frequencies
{
    public class WeeklyRecurrenceFrequency : RecurrenceFrequencyBase, IRecurrenceFrequency
    {
        public override string PatternName => FrequencyConsts.Weekly;

        public bool TryApply(DateTime date, int quantity, out DateTime result)
        {
            result = date.AddDays(7 * quantity);
            return true;
        }
    }
}
