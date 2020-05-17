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
    }
}