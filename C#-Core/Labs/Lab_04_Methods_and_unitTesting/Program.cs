using System;

namespace Lab_04_Methods_and_unitTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var addStuff = Addition(4,6);
            //Console.WriteLine(addStuff);

            Console.WriteLine(TripleCalc(2,3,4, out int Sum));
            Console.WriteLine(Sum);
            var (ThisSum, Product) = TripleCalc(5,6,7);
            Console.WriteLine(ThisSum);
            Console.WriteLine(Product);
        }

        (string fname, string lname, int age)[] tu = new (string, string, int)[5];

        public static int TripleCalc(int a, int b, int c, out int sum)
        {
            sum = a + b + c;
            return a*b*c;
        }

        public static (int sum, int product) TripleCalc(int a, int b, int c)
        {
            return (a+b+c,a * b * c);
        }

        public static int Addition(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }
        public static float Addition(float[] nums)
        {
            float sum = 0.0f;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }
        public static int Addition(int numA = 5, int numB = 5)
        {
            return Addition(new int[] {numA,numB});

        }
    }
}
