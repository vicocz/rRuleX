using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using Vico.rRule.Constraints;
using Vico.rRule.DataTypes;

namespace Vico.rRule.Tests.Constraints
{
    [TestFixture]
    internal class NumericConstraintValueTests
    {
        [Test]
        public void Constructor_NullDataType_ExceptionIsThrown()
        {
            Assert.Throws<ArgumentNullException>(() => new NumericConstraintValue(1, null));
        }

        [Test]
        public void DataType()
        {
            var dataType = new Mock<INumericDataType>(MockBehavior.Strict);
            dataType.Setup(d => d.Validate(It.IsAny<int>())).Returns(0);

            var value = new NumericConstraintValue(2, dataType.Object);

            Assert.AreEqual(0, value.Value);
            Assert.AreEqual(dataType.Object, value.DataType);
        }
    }
}
