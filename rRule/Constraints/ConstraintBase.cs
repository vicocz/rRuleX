using System.Collections.Generic;
using System.Collections.ObjectModel;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Constraints
{
    public abstract class ConstraintBase<T> where T : INumericConstraintValue
    {
        protected readonly IList<T> AllowedValues;

        protected ConstraintBase(T allowedValue) : this (new[] { allowedValue })
        {
        }

        protected ConstraintBase(IList<T> allowedValue)
        {
            AllowedValues = new ReadOnlyCollection<T>(allowedValue);
        }
    }
}
