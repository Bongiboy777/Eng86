using System;

namespace IterationLib
{
    public class Highest
    {
        public static int HighestWhileLoop(int[] nums)
        {
            // this method should use a while loop
            int index = 0;
            int compareIndex = 0;
            while(compareIndex < nums.Length -1)
            {
                if (nums[index] >= nums[compareIndex])
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

        public static int HighestForLoop(int[] nums)
        {
            // this method should use a for loop
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x= 0; x < nums.Length; x++)
                {
                    if (nums[i] >= nums[x])
                        {
                            if (x != nums.Length - 1)
                                {
                                continue;
                                }
                            return nums[i];
                        }
                    break;
                }
            }
            return -1;
        }

        public static int HighestForEachLoop(int[] nums)
        {
            int comparecount = 0;
            foreach(int num in nums)
            {
                foreach(int number in nums)
                {
                   if (num >= number)
                    {
                        comparecount++;
                        if (comparecount == nums.Length - 1)
                        {
                            return num;
                        }
                                             
                    }

                    else {
                        comparecount = 0;
                        break;
                    }
                }
            }
            return -1;
        }

        public static int HighestDoWhileLoop(int[] nums)
        {
            int index = 0;
            int compareIndex = 0;
            do
            {
                if (nums[index] >= nums[compareIndex])
                {
                    compareIndex++;
                    continue;
                }

                else
                {
                    index++;
                    compareIndex = 0;
                }
            } while (compareIndex < nums.Length - 1);
            return nums[index];
        }
    }
}