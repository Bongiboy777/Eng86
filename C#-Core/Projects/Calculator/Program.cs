using System;

namespace CalculatorLib
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class MathLib
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        public static float Add(float[] nums)
        {
            float sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int numA, int numB)
        {
           
            return numA*numB;
        }

        public static int Multiply(int[] nums)
        {
            int sum = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                sum *= nums[i];
            }
            return sum;
        }

        public static float Multiply(float[] nums)
        {
            float sum = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                sum *= nums[i];
            }
            return sum; 
        }

        public static int Divide(int numA, int numB)
        {
            return numA / numB;
        }

        public static float Divide(float numA, float numB)
        {
            return numA/numB;
        }

        public static int Modulus(int numA, int numB)
        {
            return numA % numB;
        }


    }
}
