using NUnit.Framework;
using CalculatorLib;

namespace CalculatorTests
{
    public class StaticCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2, 3)]
        [TestCase(90, 872, 962)]
        [TestCase(-23, 98, 75)]
        [TestCase(-283, -27, -310)]
        [TestCase((int)2E8, (int)-2E8, 0)]
        [TestCase(0, 3, 3)]
        public void AdditionTestIntEqual(int numA, int numB, int expected)
        {
            var result = MathLib.Add(numA, numB);
            Assert.AreEqual(result, expected);
        }


        [TestCase(new int[] { 1, 2 }, 3)]
        [TestCase(new int[] { 90, 872 }, 962)]
        [TestCase(new int[] { -23, 98, 72, 100, 30 }, 277)]
        [TestCase(new int[] { -283, -27, 310 }, 0)]
        [TestCase(new int[] { (int)2E8, (int)-2E8, 20, 10, 230, 90, 50, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 465)]
        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, -5, 0 }, -3)]
        [TestCase(new int[] { }, 0)]
        public void AdditionTestEqualIntArray(int[] nums, int expected)
        {
            var result = MathLib.Add(nums);
            Assert.AreEqual(result, expected);
        }

        [TestCase(0, 4, -4)]
        [TestCase(0, 0, 0)]
        [TestCase(int.MaxValue, 0, int.MaxValue)]
        [TestCase(int.MaxValue, int.MaxValue, 0)]
        [TestCase(int.MinValue, int.MinValue, 0)]
        [TestCase((int)87.9, (int)4.8, 83)]
        public void SubtractTestIntEqual(int numA, int numB, int expected)
        {
            int result = MathLib.Subtract(numA, numB);
            Assert.AreEqual(expected, result);
        }

        [TestCase( 2, 9 , 18)]
        [TestCase( 0, 2,0)]
        [TestCase(-34,5,-170)]
        [TestCase(-34, -5, 170)]
        public void MultiplyTestInt(int numA, int numB, int expected)
        {
            Assert.AreEqual(expected, MathLib.Multiply(numA,numB));
        }

        [TestCase(new int[] { 2, 2, 9 }, 36)]
        [TestCase(new int[] { 0, 2, 4, 2, 4, 6, 2, 3, 1, 5, 2, 5 }, 0)]
        [TestCase(new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 4096)]
        [TestCase(new int[] { 3, 20, 5, -3, 6 }, -5400)]
        [TestCase(new int[] { -3, -20, -5, -3, 6 }, 5400)]
        public void MultiplyTesTIntArrayEqual(int[] nums, int expected)
        {
            Assert.AreEqual(expected, MathLib.Multiply(nums));
        }

        [TestCase(new float[]{2,2.5f}, 5.0f)]
        [TestCase(new float[] { 0,2,4,2,4,6,2,3,1,5,2,5}, 0)]
        [TestCase(new float[] {2,2,2,2,2,2,2,2,2,2,2,2}, 4096.0f)]
        [TestCase(new float[] {0.1f,20,2.5f,1/3f, 6}, 10)]
        public void MultiplyTesTFloatArrayEqual(float[] nums, float expected)
        {
            Assert.AreEqual(expected, MathLib.Multiply(nums));
        }


        [TestCase(10, 2, 5)]
        [TestCase(0, 89, 0)]
        [TestCase(int.MaxValue, 1,int.MaxValue)]
        [TestCase(int.MaxValue, int.MaxValue, 1)]
        public void DivideTestIntEqual(int numA, int numB, int expected)
        {
            Assert.AreEqual(expected, MathLib.Divide(numA, numB));
        }

        [TestCase(10,2, 5.0f)]
        [TestCase( 0,89.9f, 0)]
        [TestCase(1,1/4096f , 4096.0f)]
        [TestCase(7.5f,2.5f,3.0f)]
        public void DivideTestFloatEqual(float numA, float numB, float expected)
        {
            Assert.AreEqual(expected, MathLib.Divide(numA, numB));
        }

        [TestCase(10, 2, 0)]
        [TestCase(0, 89, 0)]
        [TestCase(133,12,1)]
        [TestCase(35000,34999,1)]
        [TestCase(35000, -34999, 1)]
        [TestCase(-35000, -34999, -1)]
        [TestCase(-35000, 34999, -1)]
        public void ModulusTestIntEqual(int numA, int numB, int expected)
        {
            Assert.AreEqual(expected, MathLib.Modulus(numA, numB));
        }
    }
}