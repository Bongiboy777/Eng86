using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingObjects
{
    public class Human: IEquatable<Human>, IComparable<Human>
    {
        private string _firstname, _lastname;

        public Human(string firstname, string lastname, int age = 22)
        {
            Age = age;
            _firstname = firstname;
            _lastname = lastname;
        }

        public override string ToString() => $"{Firstname} {Lastname}.";

        public int Age { get; set; }
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }

        public bool Equals(Human human)
        {
            return Lastname == human.Lastname 
                && Firstname == human.Firstname
                && Age == human.Age
                ? true: false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Firstname,Lastname,Age);
        }

        public int CompareTo([AllowNull]Human other)
        {
            return other == null ? 1 :
                Firstname != other.Firstname ? Firstname.CompareTo(other.Firstname) :
                    Lastname != other.Lastname ? Lastname.CompareTo(other.Lastname) :
                    
                    Age.CompareTo(other.Age);
        }

        public static bool operator ==(Human a, Human b)
        {
            return EqualityComparer<Human>.Default.Equals(a, b); ;
        }

        public static bool operator !=(Human a, Human b)
        {
            return !(a == b);
        }
    }

}

