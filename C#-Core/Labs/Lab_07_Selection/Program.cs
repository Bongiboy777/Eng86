using System;

namespace Lab_07_Selection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(PassFail(-4));
        }

        public static string PassFail(int mark)
        {
            string result = "";
            if (mark > 100 || mark < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (mark >=40)
                {
                result += "Pass";

                
                if (mark >= 75)
                {
                    result += " with Distinction.";
                }

                else if (mark >= 60)
                {
                    result += " with Merit.";
                }

                }
            else
            {
                result += "Fail";
            }


            return result;
        }

        public static string PassFailTernary(int mark)
        {
            return mark >= 40 ? "Pass" : "Fail";
        }

        public static string DayOfWeek(int day)
        {
            switch(day)
            {
                case 1:
                    return "Sunday";

                case 2:
                    return "Monday";

                case 3:
                    return "Tuesday";

                case 4:
                    return "Wednesday";

                case 5:
                    return "Thursday";

                case 6:
                    return "Friday";

                case 7:
                    return "Saturday";

                default:
                    return "Not valid";
            }
        }

    }
}
