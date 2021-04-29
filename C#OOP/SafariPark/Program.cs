using System;
using System.Collections.Generic;

namespace SafariPark
{
    class Program
    {
        

        public static Ammo laser = new Ammo(AmmoTypes.laserFuel, "lsr");

        public static Weapon laserPistol = new LaserGun("Guns4Us") { SelectedAmmo = laser };

        static List<Hunter> hunters = new List<Hunter>()
            {
                new Hunter(laserPistol),
                new Hunter(new WaterPistol("Water Works"))
            };
        static void Main(string[] args)
        {
            Console.WriteLine(hunters[0].Attack().CalculateDamage());
            Console.WriteLine(AmmoTypes._shotGunCartridge.Damage.CalculateDamage());


            //AmmoType shell = new AmmoType(new Damage());





            //Hunter hunter = new Hunter(new LaserGun("Guns4Us"));


            //hunters.ForEach(x => Console.WriteLine(x.Attack()));
        }
    }
}



