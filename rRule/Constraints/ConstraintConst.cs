namespace Vico.rRule.Constraints
{
    public static class ConstraintConst
    {
        public const string ByMonthTag = "BYMONTH";
        public const string ByMonthDayTag = "BYMONTHDAY";
        public const string ByYearDayTag = "BYYEARDAY";
        public const string ByWeekNumberTag = "BYWEEKNO";

        public const string ByDayTag = "BYDAY";

        public const int UnknownPriority = 1000;
        public const int ByMonthPriority = 1000;
        public const int ByMonthDayPriority = 1001;

        public const int ByYearDayPriority = 1001;
    }
}
