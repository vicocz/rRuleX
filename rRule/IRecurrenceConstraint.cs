using System;

namespace Vico.rRule
{
    public interface IRecurrenceConstraint : ITaggable
    {
        int Priority { get; }
    }
}
