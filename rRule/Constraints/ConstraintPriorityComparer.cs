using System.Collections.Generic;

namespace Vico.rRule.Constraints
{
    /// <summary>
    /// Comparer according to priority of a recurrence constraint
    /// </summary>
    public class ConstraintPriorityComparer : IComparer<IRecurrenceConstraint>
    {
        public int Compare(IRecurrenceConstraint x, IRecurrenceConstraint y)
        {
            if (x == null) return y == null ? 0 : -1;

            return y == null ? 1 : Comparer<int>.Default.Compare(x.Priority, y.Priority);
        }
    }
}
