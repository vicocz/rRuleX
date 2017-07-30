using System;
using System.Collections.Generic;
using System.Linq;

namespace Vico.rRule.Constraints
{
    public class DayOfMonthConstraint : ConstraintBase<INumericConstraintValue>, IRecurrenceConstraint, IImmutable
    {
        public DayOfMonthConstraint(INumericConstraintValue allowedMonth) : base(allowedMonth)
        {
        }

        public DayOfMonthConstraint(IList<INumericConstraintValue> allowedMonths) : base(allowedMonths)
        {
        }

        public string TagName => ConstraintConst.ByMonthDayTag;

        public int Priority => ConstraintConst.ByMonthDayPriority;

        public ICollection<INumericConstraintValue> AllowedMonthDays => AllowedValues;

        public bool Filter(DateTime testDate)
        {
            // Day must match
            return AllowedMonthDays.Any(md => IsMatch(md, testDate));
        }

        private static bool IsMatch(INumericConstraintValue monthDay, DateTime testDate)
        {
            // if positive, just check if month is equal, otherwise count from end of month
            int day = monthDay.Value >= 0
                ? monthDay.Value
                : monthDay.Value + DaysInMonth(testDate) + 1;

            return testDate.Day == day;
        }

        private static int DaysInMonth(DateTime date)
        {
            return DateTime.DaysInMonth(date.Year, date.Month);
        }
    }
}
