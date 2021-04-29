using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Hunter: Human
    {
        public int Durability { get; set; }
        public Weapon Weapon { get => _weapon;}

        private Weapon _weapon;

        public Hunter(Weapon weapon)
        {
            _weapon = weapon;

        }

        public Hunter(string fName, string lName, Weapon weapon) : base(fName: fName,lName: lName, age: 22)
        {
            _weapon = weapon;

        }

        public Damage Attack()
        {
            if(_weapon is IShootable)
            {
                if(_weapon is LaserGun)
                {
                    var gun = (LaserGun)_weapon;
                    return gun.Shoot(2);
                }

                if (_weapon is WaterPistol)
                {
                    var gun = (WaterPistol)_weapon;
                    return gun.Shoot(2);
                }




                return new Damage();

            }

            var weapon = (IMelee)Weapon;
            return new Damage();
        }

        public Damage Attack(Weapon weapon, int times)
        {
            if (Weapon is IShootable)
            {
                Console.WriteLine("Shooting");
                var gun = (IShootable)Weapon;
                return gun.Shoot(times);
            }

            var weaponA = (IMelee)Weapon;
            Console.WriteLine("Hitting");
            return new Damage();
        }

        private string Reload()
        {
            if (_weapon is Gun)
            {
                Gun g = _weapon as Gun;
                return g.Reload(3);
            };

            return $"{_weapon} is not a gun, cannot be reloaded.";
        }
    }
}
