using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vico.rRule.Tests
{
    public static class Extensions
    {
        public static DateTime ToInvariantDateTime(this string dateTime)
        {
            // TODO
            return DateTime.Parse(dateTime);
        }
    }
}
