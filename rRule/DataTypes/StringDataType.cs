using System;

namespace Vico.rRule.DataTypes
{
    public class StringDataType : IStringDataType
    {
        public string Validate(string value)
        {
            return value;
        }

        public Type DataType => typeof(string);
    }
}
