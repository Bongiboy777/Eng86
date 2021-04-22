using System;

namespace Lab_06_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
                if (i % 15 == 0) break;
            }

            //Console.WriteLine(sum);

            //foreach (var c in "NISH IS KING".Trim().ToLower())
            //{
            //    Console.WriteLine(c);
            //}
            
        }
    }

    public class Iterations
    {

    }
}
