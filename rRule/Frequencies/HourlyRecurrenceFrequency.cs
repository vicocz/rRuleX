using System;

namespace Vico.rRule.Frequencies
{
    public class HourlyRecurrenceFrequency : RecurrenceFrequencyBase, IRecurrenceFrequency
    {
        public override string PatternName => FrequencyConsts.Hourly;

        public bool TryApply(DateTime date, int quantity, out DateTime result)
        {
            result = date.AddHours(quantity);
            return true;
        }
    }
}
