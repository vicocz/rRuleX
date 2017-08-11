using System;
using Moq;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class StringConstraintValueTests
    {
        [Test]
        public void Constructor_NullDataType_ExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => new NumericConstraintValue(1, null));
        }

        [TestCase("alfa")]
        public void Value(string expectedString)
        {
            var dataTypeMock = new Mock<IStringDataType>(MockBehavior.Strict);
            dataTypeMock.Setup(d => d.Validate(It.IsAny<string>())).Returns("beta");

            var value = new StringConstraintValue(expectedString, dataTypeMock.Object);

            Assert.AreEqual("beta", value.Value);
            Assert.AreEqual(dataTypeMock.Object, value.DataType);
        }
    }
}
