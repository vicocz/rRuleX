using System;

namespace Vico.rRule.DataTypes
{
    [Serializable]
    public class InvalidDataTypeException : ArgumentException
    {
        private const string DefaultMessage = "Passed type of value does not meet type requirements.";

        public InvalidDataTypeException(string paramName) : base(DefaultMessage, paramName)
        {
        }
    }
}
