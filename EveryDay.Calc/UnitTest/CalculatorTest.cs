using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EveryDay.Calc.Calculation;

namespace UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestSum()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var sum = calc.Sum(1, 2);
            var sum1 = calc.Sum(0, 0);
            var sum2 = calc.Sum(1, -1);

            // Assert
            Assert.AreEqual(3, sum);
            Assert.AreEqual(0, sum1);
            Assert.AreEqual(0, sum2);
        }

        [TestMethod]
        public void TestDiv()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var div = calc.Div(2, 1);
            var div1 = calc.Div(0, 0);
            var div2 = calc.Div(1, -1);

            // Assert
            Assert.AreEqual(2, div);
            Assert.AreEqual(0, div1);
            Assert.AreEqual(-1, div2);
        }
        [TestMethod]
        public void TestSqua()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var squa = calc.Squa(2);
            var squa1 = calc.Squa(0);
            var squa2 = calc.Squa(1);

            // Assert
            Assert.AreEqual(4, squa);
            Assert.AreEqual(0, squa1);
            Assert.AreEqual(1, squa2);
        }

        [TestMethod]
        public void TestMySqrt()
        {
            // Arrange
            var calc = new Calculator();

            // Act
            var sqrt = calc.MySqrt(2);
            var sqrt1 = calc.MySqrt(0);
            var sqrt2 = calc.MySqrt(1);

            // Assert
            Assert.AreEqual(4, sqrt);
            Assert.AreEqual(0, sqrt1);
            Assert.AreEqual(1, sqrt2);
        }
    }
}
