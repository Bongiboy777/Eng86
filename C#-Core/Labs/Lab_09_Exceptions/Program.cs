using System;
using System.Collections.Generic;
namespace Lab_09_Exceptions
{
    class Program
    {
        string[] Beatles = new string[4];
        static void Main(string[] args)
        {

            
            int[] newnums = {2,3,4,6,4,5,2,5 };
            try
            {
                newnums[11] = 3;
            }
            catch(Exception e)
            {
                Console.WriteLine("Too big dummy");
            }
            finally
            {
                Console.WriteLine("Try again");
            }

            
        }

        
        
        public static void Diction()
        {
            Dictionary<char, int> abbreviations = new Dictionary<char, int>();
            
            foreach (var item in "SomethingIKnew".ToLower())
            {
                if (abbreviations.ContainsKey(item))
                {
                    abbreviations[item]++; 
                }
            }

            foreach (var item in abbreviations)
            {
                Console.WriteLine(item);
            }
        }

        public void AddBeatle(int pos, string name)
        {
            if (pos >= Beatles.Length || Beatles.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Beatles[pos] = name;
        }


    }
}
