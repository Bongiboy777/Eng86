using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Person
    {
        string _firstName;
        string _lastName;
        int _age;
        public int Age { get { return _age; }
        set {   _age =  value < 1 ? 0 : 
                        value > 120 ? 120 : 
                        value; }
        }

        public Person(string fName,string lName, int age)
        {
            _lastName = lName;
            _firstName = fName;
            Age = age;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
