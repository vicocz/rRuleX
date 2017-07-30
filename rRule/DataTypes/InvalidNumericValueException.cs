using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vico.rRule.DataTypes
{
    public class InvalidNumericValueException : ArgumentException
    {
        private const string DefaultMessage = "Passed numeric value does not meet value requirements.";

        public InvalidNumericValueException(string paramName) : base(DefaultMessage, paramName)
        {
        }
    }
}
