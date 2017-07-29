using System;

namespace Vico.rRule.Frequencies
{
    public class MinutelyRecurrenceFrequency : RecurrenceFrequencyBase, IRecurrenceFrequency
    {
        public override string PatternName => FrequencyConsts.Minutely;

        public bool TryApply(DateTime date, int quantity, out DateTime result)
        {
            result = date.AddMinutes(quantity);
            return true;
        }
    }
}
