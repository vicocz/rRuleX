using System;
using System.Collections.Generic;
using System.Linq;

namespace Vico.rRule.Constraints
{
    public class WeekOfYearConstraint : ConstraintBase<INumericConstraintValue>, IRecurrenceConstraint, IImmutable
    {
        public WeekOfYearConstraint(INumericConstraintValue allowedWeek) : base(allowedWeek)
        {
        }

        public WeekOfYearConstraint(IList<INumericConstraintValue> allowedWeeks) : base(allowedWeeks)
        {
        }

        public string TagName => ConstraintConst.ByweekNumberTag;

        public int Priority => ConstraintConst.UnknownPriority;

        public ICollection<INumericConstraintValue> AllowedWeeks => AllowedValues;

        public bool Filter(DateTime testDate)
        {
            // Day must match
            return AllowedWeeks.Any(md => IsMatch(md, testDate));
        }

        private static bool IsMatch(INumericConstraintValue weekOfYear, DateTime testDate)
        {
            // if positive, just check if month is equal, otherwise count from end of month
            int dayOfYear = weekOfYear.Value >= 0
                ? weekOfYear.Value
                : weekOfYear.Value + WeeksInYear(testDate) + 1;

            return testDate.DayOfYear / 7 == dayOfYear;
        }

        private static int WeeksInYear(DateTime date)
        {
            var daysInYear = DayOfYearConstraint.DaysInYear(date);
            return (daysInYear + 6) / 7;
        }
    }
}
