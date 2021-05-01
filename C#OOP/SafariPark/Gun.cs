using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public abstract class Gun : Weapon, IShootable
    {
        public List<Ammo> _ammoTypes = new List<Ammo>();
        public List<Ammo> AmmoTypes { get => _ammoTypes; set => _ammoTypes = value; }

        private Ammo selectedAmmo;

        private int _ammo;

        private int _ammoCapacity;
        public int Ammo { get => _ammo; set => _ammo = value; }
        public Ammo SelectedAmmo
        {
            get => selectedAmmo;
            set { 
                if (_ammoTypes.Contains(value))
                    { selectedAmmo = value; }
                else { 
                    Console.WriteLine($"{this} does not take {value} as ammo.");
                    Console.WriteLine(_ammoTypes[0].GetHashCode());
                    Console.WriteLine(value.GetHashCode());
                }
                
            }
        }

        public virtual string Reload(int ammo)
        {
            _ammo += ammo + _ammo <= _ammoCapacity ? ammo : _ammoCapacity - _ammo;
            return "Replenished Magazine";
            
        }

        public override Damage Attack(int times)
        {
            return Shoot(1);
        }

        public override Damage Attack2(int times)
        {
            return MeleeAttack(1);

        }
        public abstract Damage Shoot(int times);

        public abstract Damage MeleeAttack(int times);

        public Gun(string brand,int startAmmo) : base(brand)
        {
            Ammo = startAmmo;
        }

        
    }
    

    public class LaserGun : Gun
    {

        public LaserGun(string brand) : base(brand, 100)
        {
            AmmoTypes = new List<Ammo>() { Ammos.laserFuel };
            SelectedAmmo = Ammos.laserFuel;
        }
        public override Damage Shoot(int times)
        {
            if (Ammo > 1)
            {
                Durability -= 5*times;
                Console.WriteLine($"Peew. Shot with LaserGun\nDamage dealt: {SelectedAmmo.Damage.CalculateDamage()}");
                return AttackDmg*times;
            }

            Console.WriteLine($"Need to recharge battery. {Reload()}");

            return new Damage();
        }

        public override Damage MeleeAttack(int times)
        {
            throw new NotImplementedException();
        }
        public string Reload()
        {
            return $"Recharged battery - battery: {Ammo}";
        }

 

        
    }

    public class WaterPistol : Gun
    {

        public WaterPistol(string brand) : base(brand, 30)
        {
            AmmoTypes = new List<Ammo>() { Ammos.water };
            SelectedAmmo = Ammos.water;

        }
        public override Damage Shoot(int times)
        {
            return new Damage();
        }

        public override Damage MeleeAttack(int times)
        {
            throw new NotImplementedException();
        }
        public string Reload()
        {
            return "";
        }

        public class Spear : Weapon, IShootable
        {
            private int _durability = 50;
            public int Durability { get; set; }
            public Spear(string brand) : base(brand)
            {

            }
            public Damage Shoot(int times)
            {
                return new Damage();
            }

            public override Damage Attack(int times)
            {
                throw new NotImplementedException();
            }

            public override Damage Attack2(int times)
            {
                throw new NotImplementedException();
            }

            public string Reload()
            {
                return "";
            }
        }

        public class FireSpear : Weapon, IMelee,IShootable
        {
            private int _durability = 50;
            public int Durability { get; set; }
            public FireSpear(string brand) : base(brand)
            {

            }
            public override Damage Attack(int times)
            {
                throw new NotImplementedException();
            }

            public override Damage Attack2(int times)
            {
                throw new NotImplementedException();
            }
            public Damage Shoot(int times)
            {
                return new Damage();
            }
            public string Reload()
            {
                return "";
            }

            public string IMeleeAttack => throw new NotImplementedException();


            string IMelee.MeleeAttack()
            {
                throw new NotImplementedException();
            }

            string IMelee.MeleeAttack(int times)
            {
                throw new NotImplementedException();
            }
        }

        public class ThunderDagger : Weapon, IMelee
        {
            private int _durability = 50;
            public int Durability { get; set; }
            public ThunderDagger(string brand) : base(brand)
            {

            }

            public override Damage Attack(int times)
            {
                throw new NotImplementedException();
            }

            public override Damage Attack2(int times)
            {
                throw new NotImplementedException();
            }
            public Damage Shoot(int times)
            {
                return new Damage();
            }
            public string Reload()
            {
                return "";
            }

            string IMelee.MeleeAttack()
            {
                throw new NotImplementedException();
            }

            string IMelee.MeleeAttack(int times)
            {
                throw new NotImplementedException();
            }
        }

        public class WaterMace : Weapon, IMelee
        {
            private int _durability = 50;
            public int Durability { get; set; }
            public WaterMace(string brand) : base(brand)
            {

            }
            public override Damage Attack(int times)
            {
                throw new NotImplementedException();
            }

            public override Damage Attack2(int times)
            {
                throw new NotImplementedException();
            }
            public string Reload()
            {
                return "";
            }

            string IMelee.MeleeAttack()
            {
                throw new NotImplementedException();
            }

            string IMelee.MeleeAttack(int times)
            {
                throw new NotImplementedException();
            }
        }

        public class Knife : Weapon
        {
            public override Damage Attack(int times)
            {
                throw new NotImplementedException();
            }

            public override Damage Attack2(int times)
            {
                throw new NotImplementedException();
            }
            public Knife(string brand) : base(brand)
            {

            }

            public string Shoot()
            {
                return "";
            }
            public string Shoot(int times)
            {
                return "Zing! ";
            }
            public string Reload()
            {
                return "";
            }

        }

        public class Club : Weapon
        {
            private int _durability = 50;
            public int Durability { get; set; }
            public Club(string brand) : base(brand)
            {

            }
            public override Damage Attack(int times)
            {
                throw new NotImplementedException();
            }

            public override Damage Attack2(int times)
            {
                throw new NotImplementedException();
            }
            public string Reload()
            {
                return "";
            }
        }
    }
}
