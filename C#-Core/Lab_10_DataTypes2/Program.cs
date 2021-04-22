using System;
using System.Diagnostics;

namespace Lab_10_DataTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Suit suit = Suit.CLUBS;
            //Suit suite = (Suit)3;
            //int num = (int)suit;
            //Console.WriteLine(Suits(suit));
            //Console.WriteLine(suit);
            //Console.WriteLine(Suits(suite));
            //Console.WriteLine(num);

            bool? hastried = null;
            int? score = null;
            int message = score ?? 23;

            bool haspassed = hastried ?? false;
            
            Console.WriteLine(score);
            Console.WriteLine(hasPassed);

        }

        public static void time()
        {
            DateTime birthDate = new DateTime(year: 1998, month: 1, day: 27 );
        DateTime age = birthDate.AddYears(23);

        TimeSpan dayInYear = DateTime.Today - age;
        Console.WriteLine(dayInYear.ToString("dd"));

            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy-MMM-ddd"));
            // 1 tick =  1E-7, 1 ten millionth

            var newDate = DateTime.Now + new TimeSpan(1, 30, 0);
        var s = new Stopwatch();
        int total = 0;
        s.Start();
            for (int i = 0; i<int.MaxValue; i++)
            {
                total++;
            }
    s.Stop();
            Console.WriteLine(s.ElapsedTicks);
            Console.WriteLine(s.ElapsedMilliseconds);

            var rnd = new Random();
            Console

            
        }

        public enum Suit
        {
            HEARTS, DIAMONDS, CLUBS, SPADES
        }

        public static string Suits(Suit Suit)
        {
            switch (Suit)
            {
                case Suit.HEARTS:
                    return ("3 Heart");
                    break;
                case Suit.DIAMONDS:
                    return ("3 diamond");
                    break;
                case Suit.CLUBS:
                    return ("3 clubs");
                    break;
                case Suit.SPADES:
                    return ("3 spades");
                    break;
                default:
                    return "";
                    break;
            }


        }
        


    }
}
