using System;
using System.Collections.Generic;
namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            Human Mike = new Human("Mike", "Seus");
            Human mikey = Mike;
            Human man = new Human("Mike", "Seus");
            Console.WriteLine(Mike.Equals(man));
            //Console.WriteLine(Mike.Equals(human));

            var sacrifices = new List<Human>
            {
                new Human("Sarai", "Graham"),
                new Human("Edward", "Elric"),
                new Human("Alphonse", "Elric"),
                new Human("T'Challa", "Storm"),
                new Human("Mike", "Seus")

            };
            Console.WriteLine(sacrifices.Contains(Mike));

            sacrifices.Sort();
            sacrifices.ForEach(x => Console.WriteLine(x));
    }
    }

    public class zebra
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public new string ToString()
        {
            return "";
        }
    }
}
