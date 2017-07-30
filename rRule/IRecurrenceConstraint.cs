using System;

namespace Vico.rRule
{
    public interface IRecurrenceConstraint : ITaggable
    {
        int Priority { get; }

        /// <summary>
        /// This is rather testing functionality in order to establish evaluation unit tests
        /// </summary>
        /// <param name="testDate"></param>
        /// <returns></returns>
        bool Filter(DateTime testDate);
    }
}
