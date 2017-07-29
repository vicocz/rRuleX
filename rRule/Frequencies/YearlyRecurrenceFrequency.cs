using System;

namespace Vico.rRule.Frequencies
{
    public class YearlyRecurrenceFrequency : RecurrenceFrequencyBase, IRecurrenceFrequency
    {
        public override string PatternName => FrequencyConsts.Yearly;

        public bool TryApply(DateTime date, int quantity, out DateTime result)
        {
            result = date.AddYears(quantity);
            return true;
        }
    }
}
