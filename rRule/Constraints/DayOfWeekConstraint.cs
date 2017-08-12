using System;
using System.Collections.Generic;
using System.Linq;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Constraints
{
    public class DayOfWeekConstraint : ConstraintBase<IStringConstraintValue>, IRecurrenceConstraint, IImmutable
    {
        private static readonly IEnumDataType<DayOfWeek> DataType = new EnumDataType<DayOfWeek>();

        public DayOfWeekConstraint(IStringConstraintValue allowedDays) : this (new [] {allowedDays})
        {
        }

        public DayOfWeekConstraint(IList<IStringConstraintValue> allowedDays) : base(allowedDays)
        {
            // convert to numeric value
            AllowedWeekDays = AllowedValues.GetDaysOfWeek(DataType).ToList();
        }

        public string TagName => ConstraintConst.ByDayTag;

        public int Priority => ConstraintConst.ByDayPriority;

        public ICollection<IEnumConstraintValue<DayOfWeek>> AllowedWeekDays { get; }

        public bool Filter(DateTime testDate)
        {
            // Day must match
            return AllowedWeekDays.Any(dw => dw.Value == testDate.DayOfWeek);
        }
    }
}
