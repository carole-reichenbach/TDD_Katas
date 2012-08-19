using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace StringCalculator
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void returns_0_if_empty_string()
        {
            Calculator calc = new Calculator();
            
            int result = calc.Add("");

            Assert.That(result, Is.EqualTo(0));
        }
    }

    public class Calculator
    {
        public int Add(string numbers)
        {
            return 0;
        }
    }
}
