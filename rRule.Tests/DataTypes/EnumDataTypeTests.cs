using System;
using NUnit.Framework;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.DataTypes
{
    [TestFixture]
    public class EnumDataTypeTests 
    {
        [Test]
        public void Validate_NonEnumType_ThrowsException()
        {
            var wrongDataType = new EnumDataType<decimal>();

            Assert.Throws<InvalidDataTypeException>(() => wrongDataType.Validate(decimal.MinValue));
        }

        [TestCase(DayOfWeek.Thursday)]
        public void Validate(DayOfWeek testValue)
        {
            var enumDataType = new EnumDataType<DayOfWeek>();

            var value = enumDataType.Validate(testValue);
            Assert.AreEqual(testValue, value);
        }

        [Test]
        public void DataType()
        {
            var enumDataType = new EnumDataType<DayOfWeek>();

            Assert.AreEqual(typeof(DayOfWeek), enumDataType.DataType);
        }
    }
}