using System;
using System.Text;

namespace ReverseWordOrder
{
    public class WordReverser
    {

        public static string ReverseWords(string input)
        {

            string[] splitString = input.Split(' ');
            string output = "";
            for (int i = splitString.Length - 1; i >=0 ; i--)
            {
                output += splitString[i] + ' ';

            }

            return output.Trim();
        }

    }
}
