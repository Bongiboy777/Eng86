using System;

namespace Lab_o3_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var weeks = 26 / 7;
            var days = 26 % 7;

            var a = 2;

            a += ++days  + weeks++ + -days++ ;
        }
    }
}
