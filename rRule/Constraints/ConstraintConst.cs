namespace Vico.rRule.Constraints
{
    public static class ConstraintConst
    {
        public const string ByMonthTag = "BYMONTH";
        public const string ByMonthDayTag = "BYMONTHDAY";
        public const string ByYearDayTag = "BYYEARDAY";
        public const string ByWeekNumberTag = "BYWEEKNO";

        public const string ByDayTag = "BYDAY";

        // Priorities of constraints
        // If multiple BYxxx rule parts are specified, then after evaluating the specified FREQ and INTERVAL rule parts,
        // the BYxxx rule parts are applied to the current set of evaluated occurrences in the following order:
        // BYMONTH, BYWEEKNO, BYYEARDAY, BYMONTHDAY, BYDAY, BYHOUR, BYMINUTE, BYSECOND and BYSETPOS;
        // then COUNT and UNTIL are evaluated.

        public const int UnknownPriority = 1000;

        public const int BaseConstraintPriority = 100;
        public const int ByMonthPriority = BaseConstraintPriority + 1;
        public const int ByWeekNoPriority = BaseConstraintPriority + 2;
        public const int ByYearDayPriority = BaseConstraintPriority + 3;
        public const int ByMonthDayPriority = BaseConstraintPriority + 4;
        public const int ByDayPriority = BaseConstraintPriority + 5;
        public const int ByHourPriority = BaseConstraintPriority + 6;
        public const int ByMinutePriority = BaseConstraintPriority + 7;
        public const int BySecondsPriority = BaseConstraintPriority + 8;
        public const int BySetPosPriority = BaseConstraintPriority + 9;

        public const int CountPriority = BaseConstraintPriority + 20;
        public const int UntilPriority = BaseConstraintPriority + 21;
    }
}
