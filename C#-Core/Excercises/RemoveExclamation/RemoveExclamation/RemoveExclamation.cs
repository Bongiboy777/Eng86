using System;

namespace RemoveExclamation
{
    public class Remove
    {
        public static string RemoveLastExclamationMark(string input)
        {
            if(input.EndsWith('!'))
            {
                return input.Remove(input.LastIndexOf('!'), 1);

            }
            
            return input;

        }
    }
}
