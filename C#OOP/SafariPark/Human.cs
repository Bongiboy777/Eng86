using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Human: Entity
    {

        string _firstName;
        string _lastName;
        int _age;
        public int Age { get { return _age; }
        set {   _age =  value < 1 ? 0 : 
                        value > 120 ? 120 : 
                        value; }
        }

        public Human(int health = 50):base(health)
        {
            _lastName = "Luwemba";
            _firstName = "Bongani";
            Age = 22;
        }

        public Human(string fName,string lName, int age, int health = 50): base(health)
        {
            
            _lastName = lName;
            _firstName = fName;
            Age = age;
        }



        public override string ToString()
        {
            return $"{base.ToString()} Name: {_firstName} Age: {Age}";
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
