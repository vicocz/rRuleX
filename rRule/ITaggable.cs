using System;
using System.Collections.Generic;
using System.Text;

namespace Vico.rRule
{
    /// <summary>
    /// Defines properties for object that might be tagged by its name
    /// </summary>
    public interface ITaggable
    {
        string TagName { get; }
    }
}
