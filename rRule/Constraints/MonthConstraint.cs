using System;
using System.Collections.Generic;
using System.Linq;

namespace Vico.rRule.Constraints
{
    public class MonthConstraint : ConstraintBase<INumericConstraintValue>, IRecurrenceConstraint, IImmutable
    {
        public MonthConstraint(INumericConstraintValue allowedMonth) : base (allowedMonth)
        {
        }

        public MonthConstraint(IList<INumericConstraintValue> allowedMonths) : base (allowedMonths)
        {
        }

        public string TagName => ConstraintConst.ByMonthTag;

        public int Priority => ConstraintConst.ByMonthPriority;

        public ICollection<INumericConstraintValue> AllowedMonths => AllowedValues;

        public bool Filter(DateTime testDate)
        {
            // Month must match
            return AllowedMonths.Any(m => m.Value == testDate.Month);
        }
    }
}
