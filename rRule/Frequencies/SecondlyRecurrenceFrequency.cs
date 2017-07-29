using System;

namespace Vico.rRule.Frequencies
{
    public class SecondlyRecurrenceFrequency : RecurrenceFrequencyBase, IRecurrenceFrequency
    {
        public override string PatternName => FrequencyConsts.Secondly;

        public bool TryApply(DateTime date, int quantity, out DateTime result)
        {
            result = date.AddSeconds(quantity);
            return true;
        }
    }
}
