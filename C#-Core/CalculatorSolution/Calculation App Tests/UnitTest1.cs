using NUnit.Framework;
using System;

namespace CalculatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("1+2+3+4", 10)]
        public void Test1(string calculation, int answer)
        {
            Assert.Pass();
        }
    }
}