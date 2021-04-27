using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Vehicle
    {
        private int _capacity, _numPassengers, _speed;
        public int NumPassengers {
            get { return _numPassengers; } 
            set {
                _numPassengers = value < 0 ? 0 :
                            value > _capacity ? _capacity :
                            value;
                }}

        public int Position { get; private set; }

        public string Move()
        {
            Position += _speed;
            return "Moving along.";
        }

        public string Move(int times)
        {
            Position += _speed * times;
            return $"Moving along {times} times.";

        }

        public Vehicle(int speed = 10)
        {
            _speed = speed;
            _capacity = 4;
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            _speed = speed;

        }

    }
}
