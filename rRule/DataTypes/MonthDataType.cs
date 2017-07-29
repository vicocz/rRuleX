using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vico.rRule.DataTypes
{
    public class MonthDataType : NumericDataTypeBase, INumericDataType
    {
        public MonthDataType(int value)
        {
            if (!base.IsValid(value))
                throw new ArgumentException(nameof(value));

            Value = value;
        }


        const int FirstMonth = 1;
        const int LastMonth = 12;

        public int MininumValue => FirstMonth;

        public int MaximumValue => LastMonth;

        public int Value { get; }
    }
}
