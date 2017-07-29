using System;

namespace Vico.rRule.Frequencies
{
    public class MonthlyRecurrenceFrequency : RecurrenceFrequencyBase, IRecurrenceFrequency
    {
        public override string PatternName => FrequencyConsts.Monthly;

        public bool TryApply(DateTime date, int quantity, out DateTime result)
        {
            result = date.AddMonths(quantity);
            return true;
        }
    }
}
