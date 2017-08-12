using System;
using System.Collections.Generic;
using System.Linq;
using Vico.rRule.Extensions;

namespace Vico.rRule.Constraints
{
    /// <summary>
    /// Defines constraint by week of year
    /// </summary>
    /// <see href="https://icalendar.org/iCalendar-RFC-5545/3-3-10-recurrence-rule.html">
    /// A week is defined as a seven day period, starting on the day of the week defined to be the week start (see WKST).
    /// Week number one of the calendar year is the first week that contains at least four (4) days in that calendar year.
    /// </see>
    public class WeekOfYearConstraint : ConstraintBase<INumericConstraintValue>, IRecurrenceConstraint, IImmutable
    {
        public WeekOfYearConstraint(INumericConstraintValue allowedWeek) : base(allowedWeek)
        {
        }

        public WeekOfYearConstraint(IList<INumericConstraintValue> allowedWeeks) : base(allowedWeeks)
        {
        }

        public string TagName => ConstraintConst.ByWeekNumberTag;

        public int Priority => ConstraintConst.ByWeekNoPriority;

        public ICollection<INumericConstraintValue> AllowedWeeks => AllowedValues;

        public bool Filter(DateTime testDate)
        {
            // Day must match
            return AllowedWeeks.Any(md => IsMatch(md, testDate));
        }

        private static bool IsMatch(INumericConstraintValue weekOfYear, DateTime testDate)
        {
            // if positive, just check if week is equal, otherwise count from end of year
            int week = weekOfYear.Value >= 0
                ? weekOfYear.Value
                : weekOfYear.Value + testDate.LastDayInYear().WeekOfYear() + 1;

            int testDateWeek = testDate.WeekOfYear();

            return testDateWeek == week;
        }
    }
}
