using System;

namespace IterationLib
{

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //ignore
        }
    }
    public class Exercises
    {
        // returns the lowest number in the array nums
        public static int Lowest(int[] nums)
        {
            int index = 0;
            int compareIndex = 0;
            if (nums.Length == 0)
            {
                return int.MaxValue;
            }
            while (compareIndex < nums.Length - 1)
            {
                if (nums[index] <= nums[compareIndex])
                {
                    compareIndex++;
                    continue;
                }

                else
                {
                    index++;
                    compareIndex = 0;
                }
            }
            return nums[index];

        }

        // returns the sum of all numbers between 1 and n inclusive that are divisible by either 2 or 5
        public static int SumEvenFive(int max)
        {
            int sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if(i % 2 == 0 || i % 5 ==0)
                {
                    sum += i;
                }

            }
            return sum;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int aCount, bCount, cCount, dCount = aCount = bCount = cCount = 0;

            foreach(char letter in input.ToLower())
            {
                switch(letter)
                    {
                        case 'a':
                            aCount++;
                            break;

                        case 'b':
                            bCount++;
                            break;

                        case 'c':
                            cCount++;
                            break;

                        case 'd':
                            dCount++;
                            break;

                        default:
                            break;
                    }
            }
            return $"A:{aCount} B:{bCount} C:{cCount} D:{dCount}";
        }
    }
}