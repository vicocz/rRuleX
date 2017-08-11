using System;
using Vico.rRule.Constraints;

namespace Vico.rRule.DataTypes
{
    public static class DefaultDataTypes
    {
        private const int FirstMonth = 1;
        private const int LastMonth = 12;

        private const int FirstSecond = 0;
        private const int LastSecond = 59;

        private const int FirstMinute = 0;
        private const int LastMinute = 59;

        private const int FirstHour = 0;
        private const int LastHour = 23;

        private const int FirstDayInMonth = 1;
        private const int LastDayInMonth = 31;

        private const int FirstDayInWeek = 0;
        private const int LastDayInWeek = 6;

        private const int FirstWeekInYear = 1;
        private const int LastWeekInYear = 53;

        public static readonly INumericDataType SecondsDataType = new NumericIntervalDataType(FirstSecond, LastSecond);
        public static readonly INumericDataType MinutesDataType = new NumericIntervalDataType(FirstMinute, LastMinute);
        public static readonly INumericDataType HoursDataType = new NumericIntervalDataType(FirstHour, LastHour);

        public static readonly INumericDataType MonthDataType = new NumericIntervalDataType(FirstMonth, LastMonth);

        public static readonly IEnumDataType<DayOfWeek> DayOfWeekDataType = new EnumDataType<DayOfWeek>();

        /// <summary>
        /// Valid values are 1 to 31 or -31 to -1
        /// </summary>
        public static readonly INumericDataType DayOfMonthDataType = new NumericIntervalDataType(-LastDayInMonth, LastDayInMonth);

        public static readonly INumericDataType DayOfYearDataType = new NumericIntervalDataType(-DayOfYearConstraint.LeapYearDays, DayOfYearConstraint.LeapYearDays);

        public static readonly INumericDataType WeekOfYearDataType = new NumericIntervalDataType(-LastWeekInYear, LastWeekInYear);

        public static readonly IStringDataType StringDataType = new StringDataType();


    }
}
