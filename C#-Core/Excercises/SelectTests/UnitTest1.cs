using NUnit.Framework;
using Lab_07_Selection;
using System;

namespace SelectTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(40)]
        public void Over40Passes(int mark)
        {
            Assert.AreEqual("Pass", Program.PassFail(mark));
        }

        [TestCase(39)]
        public void Under40Fails(int mark)
        {
            Assert.AreEqual("Fail", Program.PassFail(mark));
        }

        [TestCase(75)]
        [TestCase(85)]
        [TestCase(100)]
        [TestCase(79)]
        public void Mark75PlusPassWithDistinction(int mark)
        {
            Assert.AreEqual("Pass with Distinction.", Program.PassFail(mark));
        }

        [TestCase(62)]
        [TestCase(60)]
        [TestCase(74)]
        public void Mark60to74PassWithMerit(int mark)
        {
            Assert.AreEqual("Pass with Merit.", Program.PassFail(mark));
        }

        [TestCase(262)]
        [TestCase(160)]
        [TestCase(-374)]
        public void MarkOutOfRangeThrowsexception(int mark)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Program.PassFail(mark));
        }

        [Test]
        public void DaysOFWeekPassTest()
        {
            Assert.AreEqual("Monday", Program.DayOfWeek(2));
        }
    }
}