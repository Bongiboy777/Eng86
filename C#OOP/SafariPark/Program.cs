using System;
using System.Collections.Generic;

namespace SafariPark
{
    class Program
    {
        

        public static Ammo laser = new Ammo(new Damage(new Elemental(3,8,0,0),0,4,2));

        public static Weapon laserPistol = new LaserGun("Guns4Us") { SelectedAmmo = laser };

        static List<Hunter> hunters = new List<Hunter>()
            {
                new Hunter(laserPistol),
                new Hunter(laserPistol),
                new Hunter(new WaterPistol("Water Works"))
            };
        static void Main(string[] args)
        {
                Console.WriteLine(hunters[0].Attack().CalculateDamage());
                Console.WriteLine(hunters[1].Attack().CalculateDamage());
            
                Console.WriteLine((hunters[1].Attack()-hunters[0].Defense).CalculateDamage());





            //AmmoType shell = new AmmoType(new Damage());





            //Hunter hunter = new Hunter(new LaserGun("Guns4Us"));


            //hunters.ForEach(x => Console.WriteLine(x.Attack()));
        }
    }
}



