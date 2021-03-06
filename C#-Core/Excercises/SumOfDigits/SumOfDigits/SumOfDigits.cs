using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SumOfDigits
{
	public class SumOfDigits
	{
		public static long sumMethod(long input)
		{

			/* 
			Given n, take the sum of the digits of n.If that value has more than one digit, 
			continue reducing in this way until a single-digit number is produced.
			This is only applicable to the natural numbers. 

			examples:

			16-- > 1 + 6 = 7
			 942-- > 9 + 4 + 2 = 15-- > 1 + 5 = 6
			132189-- > 1 + 3 + 2 + 1 + 8 + 9 = 24-- > 2 + 4 = 6
			493193-- > 4 + 9 + 3 + 1 + 9 + 3 = 29-- > 2 + 9 = 11-- > 1 + 1 = 2 
			*/


			//long output = combine(input);

			//while(output > 10)
			//         {
			//	output = combine(output);

			//         }

			//return output;
			if (input == 0)
            {
				return 0;
            }
			return (input % 9 == 0) ? 9: input % 9;

		}

		public static long combine(long input)
        {
			int sum = 0;
			int[] output = Array.ConvertAll(input.ToString().ToCharArray(), element => (int)char.GetNumericValue(element));
            for (int i = 0; i < output.Length; i++)
            {
				sum += output[i];
            }
			return sum;
		}

	}
}
