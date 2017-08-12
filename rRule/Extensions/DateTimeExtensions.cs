using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vico.rRule.Extensions
{
    public static class DateTimeExtensions
    {
        private const int MinWeekDays = 4;

        public static int WeekOfYear(this DateTime date)
        {
            // use default week start
            return WeekOfYear(date, DayOfWeek.Monday);
        }

        /// <summary>
        /// Gets week number the day belongs to
        /// </summary>
        /// <param name="date">Date to get week number for</param>
        /// <param name="weekStart">Definition of the first day of week</param>
        /// <see href="https://icalendar.org/iCalendar-RFC-5545/3-3-10-recurrence-rule.html">
        /// A week is defined as a seven day period, starting on the day of the week defined to be the week start (see WKST).
        /// Week number one of the calendar year is the first week that contains at least four (4) days in that calendar year.
        /// </see>
        /// <returns></returns>
        public static int WeekOfYear(this DateTime date, DayOfWeek weekStart)
        {
            int offset = GetWeekOffset(date, weekStart);

            if (offset < 0)
            {
                // recalculate for the last day of previous year
                var lastDay = date.AddDays(-date.DayOfYear);

                offset = GetWeekOffset(lastDay, weekStart);
            }

            return 1 + offset / 7;
        }

        public static int GetWeekOffset(this DateTime date, DayOfWeek weekStart)
        {
            // derive day of week of 1st Jan by the specified date
            int offsetFromFirstJan = date.DayOfYear - 1;
            var dayOfWeekFirstJan = (7 + (int)date.DayOfWeek - offsetFromFirstJan % 7) % 7;

            int startWeekOffset = (7 + (int)weekStart - dayOfWeekFirstJan) % 7;

            return startWeekOffset < MinWeekDays
                ? offsetFromFirstJan - startWeekOffset
                : offsetFromFirstJan - startWeekOffset + 7;
        }

        public static DateTime ToInvariantDateTime(this string dateTime)
        {
            // TODO
            return DateTime.Parse(dateTime);
        }

        public static DateTime LastDayInYear(this DateTime date)
        {
            return LastDayInYear(date.Year);
        }

        public static DateTime LastDayInYear(this int year)
        {
            //TODO remove used hardcoded values
            return new DateTime(year, 12, 31);
        }

        public static int DaysInYear(this DateTime date)
        {
            // count as order of the last day in requested year
            return LastDayInYear(date).DayOfYear;
        }
    }
}
