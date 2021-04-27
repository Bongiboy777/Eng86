using NUnit.Framework;
using CalculatorApp;
namespace CalculatorAppTests
{
    public class ArithmeticOperationTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("1+6+7", 14)]
        [TestCase("200000+200000", 400000)]
        [TestCase("1+2+3+4+5+6+7+8+9+10+11+12+13+14+15+16+17+18+19+20+21+22+23+24", 300)]
        public void SimpleAddition(string calculation, int expected)
        {
            Assert.AreEqual(MainWindow.Calculate(calculation), expected);
        }

        
        [TestCase("200000-200000", 0)]
        [TestCase("5-24-23-22-21-20-19-18-17-16-15-14-13-12-11-10-9-8-7-6-5-4-3-2-1", -295)]
        public void SimpleSubtraction(string calculation, int expected)
        {
            Assert.AreEqual(MainWindow.Calculate(calculation), expected);
        }

        [TestCase("1x2x3x4x5", 120)]
        [TestCase("300x300", 90000)]
        public void SimpleMultiplication(string calculation, int expected)
        {
            Assert.AreEqual(MainWindow.Calculate(calculation), expected);
        }

        [TestCase("8/2", 4)]
        [TestCase("200000/200000", 1)]
        [TestCase("22500/150", 150)]
        public void SimpleDivision(string calculation, int expected)
        {
            Assert.AreEqual(MainWindow.Calculate(calculation), expected);
        }

        [TestCase("8%2", 0)]
        [TestCase("9%7", 2)]
        [TestCase("23%4", 3)]
        public void SimpleModulus(string calculation, int expected)
        {
            Assert.AreEqual(MainWindow.Calculate(calculation), expected);
        }
    }

    //public class CompoundArithmeticOperationTests
    //{
    //    [SetUp]
    //    public void Setup()
    //    {
    //    }

    //    [TestCase("1+6+7", 14)]
    //    [TestCase("200000+200000", 400000)]
    //    [TestCase("1+2+3+4+5+6+7+8+9+10+11+12+13+14+15+16+17+18+19+20+21+22+23+24", 300)]
    //    public void AddingNegativeNumbers(string calculation, int expected)
    //    {
    //        Assert.AreEqual(MainWindow.Calculate(calculation), expected);
    //    }


    //    [TestCase("200000-200000", 0)]
    //    [TestCase("5-24-23-22-21-20-19-18-17-16-15-14-13-12-11-10-9-8-7-6-5-4-3-2-1", -295)]
    //    public void SimpleSubtraction(string calculation, int expected)
    //    {
    //        Assert.AreEqual(MainWindow.Calculate(calculation), expected);
    //    }

    //    [TestCase("1x2x3x4x5", 120)]
    //    [TestCase("300x300", 90000)]
    //    public void SimpleMultiplication(string calculation, int expected)
    //    {
    //        Assert.AreEqual(MainWindow.Calculate(calculation), expected);
    //    }

    //    [TestCase("8/2", 4)]
    //    [TestCase("200000/200000", 1)]
    //    [TestCase("22500/150", 150)]
    //    public void SimpleDivision(string calculation, int expected)
    //    {
    //        Assert.AreEqual(MainWindow.Calculate(calculation), expected);
    //    }
    //}
}