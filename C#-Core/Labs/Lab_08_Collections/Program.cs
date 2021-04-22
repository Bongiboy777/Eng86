using System;
using System.Collections.Generic;

namespace Lab_08_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = new List<int>() { 1,5,2,6,7};

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //nums.Add(2);
            //nums.Add(22);
            //nums.Add(6);

            //nums.Insert(2,4);
            //nums.Reverse();
            //nums.RemoveAt(3);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //nums.Sort();
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            Queue<string> Wakandans = new Queue<string>();
            Wakandans.Enqueue("T'Challa");
            Wakandans.Enqueue("Shuri");
            Wakandans.Enqueue("Killmonger");

            foreach(string wakandan in Wakandans)
            {
                Console.WriteLine(wakandan);

            }
            Console.WriteLine($"There are {Wakandans.Count} in line fot the throne.");
            while (Wakandans.Count > 0)
            {
                Console.WriteLine($"{Wakandans.Dequeue()} has been dethroned.");

            }
            Console.WriteLine($"There are {Wakandans.Count} in line fot the throne.");


            Stack<string> Pub = new Stack<string>();
            Pub.Push("Moe");
            Pub.Push("Barney");
            Pub.Push("Homer");
            Pub.Push("Larry");
            Pub.Push("Sam");
            Pub.Push("Carl");
            Pub.Push("Lenny");

            while(Pub.Count > 0)
            {
                Console.WriteLine($"{Pub.Pop()} has left the tavern.");
            }
            Console.WriteLine($"There are {Pub.Count} left in the tavern.");





        }
    }
}
