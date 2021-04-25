using NUnit.Framework;
using CalculatorApp;
namespace CalculatorAppTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("1+6+7", 14)]
        [TestCase("200000+200000", 400000)]
        [TestCase("1+6+7", 14)]
        [TestCase("1+6+7", 14)]
        public void SimpleAdditionExclusive(string calculation, int expected)
        {
            Assert.AreEqual(MainWindow.Calculate(calculation), expected);
        }
    }
}