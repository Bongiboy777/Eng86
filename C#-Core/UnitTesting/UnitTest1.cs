using NUnit.Framework;
using Lab_04_Methods_and_unitTesting;

namespace UnitTesting
{
    public class Tests
    {
        private int _sum;
        [SetUp]
        public void Setup()
        {
            var result = Program.TripleCalc(1, 2, 3, out int Sum);
            _sum = Sum;
        }

        
        public void TripleCalc_TupleProductCorrect()
        {
            Assert.AreEqual(Program.TripleCalc(1,2,3).product, 6);
            Assert.AreEqual(Program.TripleCalc(4, 2, 3).product, 24);
            Assert.AreEqual(Program.TripleCalc(5,3,2).product, 30);
            Assert.AreEqual(Program.TripleCalc(1000,1000,2000).product, 2E9);
            Assert.AreEqual(Program.TripleCalc(-1000, -1000, -2000).product, -2E9);
            Assert.AreEqual(Program.TripleCalc(1,1,1).product, 1);
        }
       
        [Test]

        public void TripleCalc_ProductCorrect(int a, int b, int c, int Product)
        {
            int _product = Program.TripleCalc(a, b, c, out int Sum);
            Assert.AreEqual(_product,Product);
        }
    }
}