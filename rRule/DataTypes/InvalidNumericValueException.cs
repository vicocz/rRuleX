using System;

namespace Vico.rRule.DataTypes
{
    [Serializable]
    public class InvalidNumericValueException : ArgumentException
    {
        private const string DefaultMessage = "Passed numeric value does not meet value requirements.";

        public InvalidNumericValueException(string paramName) : base(DefaultMessage, paramName)
        {
        }
    }
}
