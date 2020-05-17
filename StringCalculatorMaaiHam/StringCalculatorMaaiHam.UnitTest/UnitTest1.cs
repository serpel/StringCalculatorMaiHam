using System;
using NUnit.Framework;

namespace StringCalculatorMaaiHam.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void OnStringEmptyShouldReturnZero()
        {
            var result = StringCalculator.Add("");
            Assert.AreEqual(0, result);
        }

        [Test]
        public void OnSingleNumberShouldSameNumber()
        {
            var result = StringCalculator.Add("5");
            Assert.AreEqual(5, result);
        }

        [Test]
        public void OnMultipleNumberShouldSumResult()
        {
            var result = StringCalculator.Add("5,6");
            Assert.AreEqual(11, result);
        }
        
        [Test]
        public void OnInValidDelimterShouldReturnNegative()
        {
            var result = StringCalculator.Add("5*6*3");
            Assert.AreEqual(-1, result);
        }
        
          
        [Test]
        public void OnNegativeNumberShouldReturnException()
        {
            Assert.Throws(Is.TypeOf<Exception>()
                    .And.Message.Contains("Negatives not allowed"),
                () => StringCalculator.Add("1,-2"));
        }
    }
}