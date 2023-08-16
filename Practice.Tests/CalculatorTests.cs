using HomeWorkTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [Test]
        public void Additional_ReturnCorrectValue()
        {
            Assert.That(calculator.Additional(500, 200) == 700);
        }
        [Test]
        public void Substraction_ReturnCorrectValue()
        {
            Assert.True(calculator.Subtraction(400, 20) == 380);
        }
        [Test]
        public void Substraction_ReturnNegativeValue()
        {
            Assert.True(calculator.Subtraction(0, 20) == -20);
        }
        [Test]
        public void Multiplication_ReturnCorrectValue()
        {
            Assert.True(calculator.Miltiplication(4, 6) == 24);
        }
        [Test]
        public void Multiplication_MustBy0()
        {
            Assert.True(calculator.Miltiplication(20, 0) == 0);
        }
        [Test]
        public void Division_ReturnCorrectValue()
        {
            Assert.True(calculator.Division(20, 5) == 4);
        }
        [Test]
        public void Division_MustThrowExeption()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(20, 0));
        }
    }
}

