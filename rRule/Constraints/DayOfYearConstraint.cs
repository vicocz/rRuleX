using System;
using System.Collections.Generic;
using System.Linq;
using Vico.rRule.Extensions;

namespace Vico.rRule.Constraints
{
    public class DayOfYearConstraint : ConstraintBase<INumericConstraintValue>, IRecurrenceConstraint, IImmutable
    {
        public DayOfYearConstraint(INumericConstraintValue allowedDays) : base(allowedDays)
        {
        }

        public DayOfYearConstraint(IList<INumericConstraintValue> allowedDays) : base(allowedDays)
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
                : yearDay.Value + testDate.DaysInYear() + 1;

            return testDate.DayOfYear == dayOfYear;
        }
    }
}
