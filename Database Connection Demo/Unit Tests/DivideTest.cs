using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_Tests
{
    [TestClass]
    public class DivideTest
    {        
        public static double Divide(int quotient, int dividend)
        {
            // Arrange
            int _x = quotient;
            int _z = dividend;

            // Act
            return _x / _z;
        }

        [TestMethod("Test Divide")]
        public void TestDivide()
        {
            // Arrange
            int quotient = 9;
            int divident = 3;
            int zero = 0;

            // Act
            double properAnswer = Divide(quotient, divident);

            // Assert
            Assert.AreEqual<double>(3, properAnswer, "Divides Properly");
            Assert.ThrowsException<DivideByZeroException>(() => Divide(quotient, zero), "Fails on zero");
        }
    }
}
