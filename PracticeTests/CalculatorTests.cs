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
        [Test]
        public void AdditionalReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(500, 200) == 700);
        }
    }
}
