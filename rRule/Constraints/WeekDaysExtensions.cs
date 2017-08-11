using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Constraints
{
    public static class WeekDaysExtensions
    {
        public static IEnumerable<IEnumConstraintValue<DayOfWeek>> GetDaysOfWeek(this IEnumerable<IStringConstraintValue> dayOfWeeks, IEnumDataType<DayOfWeek> dataType)
        {
            return dayOfWeeks.Select(d => new EnumConstraintValue<DayOfWeek>(d.Value.GetDayOfWeek(), dataType));
        }

        public static IEnumerable<DayOfWeek> GetDaysOfWeek(this IEnumerable<string> dayOfWeeks)
        {
            return dayOfWeeks.Select(d => d.GetDayOfWeek());
        }

        public static DayOfWeek GetDayOfWeek(this string dayOfWeek)
        {
            if (dayOfWeek == "SU")
                return DayOfWeek.Sunday;
            if (dayOfWeek == "MO")
                return DayOfWeek.Monday;
            if (dayOfWeek == "TU")
                return DayOfWeek.Tuesday;
            if (dayOfWeek == "WE")
                return DayOfWeek.Wednesday;
            if (dayOfWeek == "TH")
                return DayOfWeek.Thursday;
            if (dayOfWeek == "FR")
                return DayOfWeek.Friday;
            if (dayOfWeek == "SA")
                return DayOfWeek.Sunday;

            throw new ArgumentException("Provided DayOfWeek value was not recognized.", nameof(dayOfWeek));
        }
    }
}
