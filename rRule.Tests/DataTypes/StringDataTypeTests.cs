using System;
using NUnit.Framework;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.DataTypes
{
    [TestFixture]
    public class StringDataTypeTests 
    {
        [TestCase("test")]
        public void Validate(string value)
        {
            var stringDataType = new StringDataType();

            var validated = stringDataType.Validate(value);

            Assert.AreEqual(validated, value);
        }

        [Test]
        public void DataType()
        {
            var stringDataType = new StringDataType();

            Assert.AreEqual(typeof(string), stringDataType.DataType);
        }
    }
}