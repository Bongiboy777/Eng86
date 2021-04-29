using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Airplane: Vehicle
    {
        private string _airline;
        private int _altitude;
        private int maxAltitude = 6500;

        public int Altitude 
        {
            get { return _altitude; }
        }

        public void SetAltitude(int altitude)
        {
            _altitude = altitude < 0 ? 0:
                        altitude > maxAltitude ? maxAltitude:
                        altitude;
        }

        public Airplane(int capacity)
        {
            _capacity = capacity;
        }

        public Airplane(int capacity, int speed, string airline)
        {
            _capacity = capacity;
            _speed = speed;
            _airline = airline;

        }

        public void Ascend(int distance)
        {
            
            _altitude = _altitude + distance <= maxAltitude ?  distance+_altitude : maxAltitude;
        }

        public void Desc(int distance)
        {

            _altitude -= _altitude - distance >= 0 ? distance : _altitude;
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} capacity: {_capacity} passengers: {_numPassengers} speed: {_speed} position: {Position} altitude: {_altitude}";
        }

        public override string Move()
        {
            return $"{base.Move().Replace(".","")} at an altitude of {_altitude} meters.";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times).Replace(".", "")} at an altitude of {_altitude} meters.";
        }

    }
}
