using System;
using System.Collections.Generic;

namespace Lab_05_Arrays_and_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class School
    {
        public Person[] people;

        public School(int numPeople)
        {
            people = new Person[numPeople];
            List<Teachers> Teachers = new List<Teachers>();

        }
    }

    public class Person
    {
        public String firstName;
        public string lastName;
        public int age; // Declared, not used, default is ""
    

        public Person(string _firstName = "Bongani", string _lastName = "Luwemba", int _age = 23)
        {
            firstName = _firstName;
            lastName = _lastName;
        }
    }

    public class Person
    {
        public String firstName;
        public string lastName;
        public int age; // Declared, not used, default is ""
        public DateTime Birthdate;


        public Person(string _firstName = "Bongani", string _lastName = "Luwemba", int _age = 23)
        {
            firstName = _firstName;
            lastName = _lastName;
        }
    }

    public class Generations
    {
        public Person[,,] _3rdGeneration;


        public Generations()
        { }
        }
    }

public class Occupation
{
    public float averageSalary { get; }

    public Field field;
    public string name { get; }


    public Occupation(string _name, string _averageSalary)
    { }
}

public class Field
{
    public float averageSalary { get; }

    public Occupation[] Occupations;

    bool goodfield = Int32.TryParse(Console.ReadLine(), out int howmanyfriensa);
    public string name { get; }


    public Field(string _name, string _averageSalary)
    { }
}
    }


}
