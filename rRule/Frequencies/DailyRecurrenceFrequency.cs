using System;

namespace Vico.rRule.Frequencies
{
    public class DailyRecurrenceFrequency : RecurrenceFrequencyBase, IRecurrenceFrequency
    {
        public override string PatternName => FrequencyConsts.Daily;

        public bool TryApply(DateTime date, int quantity, out DateTime result)
        {
            result = date.AddDays(quantity);
            return true;
        }
    }
}
