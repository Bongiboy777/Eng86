
using System;
using System.Collections.Generic;

namespace CollectionsExercisesLib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> nums = new List<int>();
            for (int i = 1; i <= max; i++)
            {
                if(i % 5 == 0)
                {
                    nums.Add(i);
                }
            }
            return nums;
        }

        // return the average of all the numbers in argList 
        public static double Average(List<double> argList)
        {
            if (argList.Count < 1)
            {
                return 0;
            }
            double sum = 0;
            argList.ForEach(delegate(double a) { sum += a; });
            return sum / argList.Count; 
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> output = new List<string>();
            foreach(string element in sourceList)
            {
                if (element.ToLower().StartsWith('a'))
                {
                    output.Add(element);
                }
            }
            return output;
        }
    }
}
  