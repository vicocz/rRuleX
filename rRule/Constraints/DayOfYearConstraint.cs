using System;
using System.Collections.Generic;
using System.Linq;

namespace Vico.rRule.Constraints
{
    public class DayOfYearConstraint : ConstraintBase<INumericConstraintValue>, IRecurrenceConstraint, IImmutable
    {
        public const int LeapYearDays = 366;
        private const int NoLeapYearDays = 365;

        public DayOfYearConstraint(INumericConstraintValue allowedMonth) : base(allowedMonth)
        {
        }

        public DayOfYearConstraint(IList<INumericConstraintValue> allowedMonths) : base(allowedMonths)
        {
        }

        public string TagName => ConstraintConst.ByYearDayTag;

        public int Priority => ConstraintConst.ByYearDayPriority;

        public ICollection<INumericConstraintValue> AllowedYearDays => AllowedValues;

        public bool Filter(DateTime testDate)
        {
            // Day must match
            return AllowedYearDays.Any(md => IsMatch(md, testDate));
        }

        private static bool IsMatch(INumericConstraintValue yearDay, DateTime testDate)
        {
            // if positive, just check if day of year is equal, otherwise count from end of year
            int dayOfYear = yearDay.Value >= 0
                ? yearDay.Value
                : yearDay.Value + DaysInYear(testDate) + 1;

            return testDate.DayOfYear == dayOfYear;
        }

        internal static int DaysInYear(DateTime date)
        {
            return DateTime.IsLeapYear(date.Year) ? LeapYearDays : NoLeapYearDays;
        }
    }
}
