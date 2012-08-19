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

        [Test]
        public void returns_the_same_number_when_you_pass_1_number()
        {
            Calculator calc = new Calculator();

            int result = calc.Add("26");

            Assert.That(result, Is.EqualTo(26));
        }
    }

    public class Calculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
                return 0;
            else
                return Convert.ToInt32(numbers);
        }
    }
}
