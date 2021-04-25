using System;
using System.Collections.Generic;
using System.Text;


namespace CollectionsExercises
{
    public class CollectionsExercisesClass
    {
        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            //List<string> copy = new List<string>();
            //string output = "";
            //if(num < 1 || queue.Count == 0)
            //{
            //    return "";
            //}

            //for (int i = 0; i < num; i++)
            //{
            //    try
            //    {
            //        copy.Add(queue.Dequeue());
            //        output += copy[i] + ", ";
            //    }
            //    catch(Exception e)
            //    {
            //        output = output.Remove(output.Length - 2, 2);
            //        return output.ToString();
            //    }
            //}

            //output = output.Remove(output.Length - 2, 2);
            //return output;
            var result = new StringBuilder();

            num = num > queue.Count ? queue.Count : num;
            
            for (int i = 0; i < num; i++)
            {

                result.Append($"{queue.Dequeue()}, ");
            }


            return result.Length < 1 ? "" : result.Remove(result.Length - 2, 2).ToString();
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int[] reversed = new int[original.Length];
            Stack<int> convert = new Stack<int>(original);
            for (int i = 0; i < original.Length; i++)
            {
                reversed[i] = convert.Pop();
            }

            return reversed;
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            List<char> nums = new List<char>{ '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string output = "";
            Dictionary<char, int> digitCounter = new Dictionary<char, int>();
            foreach (char c in input)
            {

                if (digitCounter.ContainsKey(c))
                {
                    digitCounter[c]++;
                }
                else if(nums.Contains(c))
                {
                    digitCounter.Add(c, 1);
                }
            }

            foreach (var item in digitCounter)
            {
                output += $"[{item.Key}, {item.Value}]";

            }

            return output;
        }
    }
}