using System;

namespace DataTypesPt2Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class Methods
    {
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if(date < birthDate)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            return (int)((date - birthDate).TotalDays/365.5);
        }

        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        public static string Fortune(Suit suit)
        {
            switch (suit)
            {
                case Suit.HEARTS:
                    return ("You've broken my heart");
                    
                case Suit.DIAMONDS:
                    return ("Diamonds are a girls best friend");
                    
                case Suit.CLUBS:
                    return ("And the seventh rule is if this is your first night at fight club, you have to fight.");
                    
                case Suit.SPADES:
                    return ("Bucket and spade");
                    
                default:
                    return "";
                    
            }
            return string.Empty;
        }
    }
}
    