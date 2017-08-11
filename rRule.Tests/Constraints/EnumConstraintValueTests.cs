using System;
using Moq;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    public class EnumConstraintValueTests
    {
        [Test]
        public void Constructor_NullDataType_ExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => new EnumConstraintValue<decimal>(1, null));
        }

        [TestCase(DayOfWeek.Tuesday)]
        public void Value(DayOfWeek expectedEnum)
        {
            var dataTypeMock = new Mock<IEnumDataType<DayOfWeek>>(MockBehavior.Strict);
            dataTypeMock.Setup(d => d.Validate(It.IsAny<DayOfWeek>())).Returns(expectedEnum);

            var value = new EnumConstraintValue<DayOfWeek>(expectedEnum, dataTypeMock.Object);

            Assert.AreEqual(expectedEnum, value.Value);
            Assert.AreEqual(dataTypeMock.Object, value.DataType);

            dataTypeMock.Verify(d => d.Validate(It.IsAny<DayOfWeek>()), Times.Once);
        }
    }
}
