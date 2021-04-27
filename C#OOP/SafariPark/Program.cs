using System;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Mike = new Person("Mike", "Rodriguez", 32);
            Console.WriteLine(Mike.GetFullName());
            Person Beth = new Person("Beth", "Smith", 31);
            Console.WriteLine(Beth.GetFullName());
            Spartan Bongani = new Spartan {_firstName = "", _lastName = "" };

            Point3D point;
            point.Y = 4;
            point.X = point.Z = 3;

            
        }

        public static void PlacePerson(Point3D pos, Person p)
        {
            Console.WriteLine($"{p.GetFullName()} is at position {pos.X}, {pos.Y}, {pos.Z}.");
        }
    }
}
