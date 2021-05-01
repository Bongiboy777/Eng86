using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public struct Ammo: IEquatable<Ammo>
    {
        private Damage _damage;
        public Damage Damage { get => _damage; }

        private readonly string _brand;
        public string Brand { get { return _brand; } }

        public Ammo(int blnt = 3, int pierce = 3, int strk = 3, string brand = "Guns4Us")
        {
            _brand = brand;
            _damage = new Damage(new Elemental(0, 0, 0, 3), blnt, pierce, strk);
        }

        public Ammo(Damage damage, string brand = "Guns4Us")
        {
            _brand = brand;
            _damage = damage;
        }
        public bool Equals(Ammo other)
        {
            return other.GetHashCode() == this.GetHashCode();
        }
    }
   

    public class Ammos
    {
        public static readonly Ammo water = new Ammo(new Damage(Element.WATER, 2,1,1));
        public static readonly Ammo _shotGunCartridge = new Ammo(5, 3, 2);
        public static readonly Ammo _regBullet = new Ammo(2, 2, 2);
        public static readonly Ammo _sniperRound = new Ammo(1, 8, 5);
        public static readonly Ammo _grenade = new Ammo(new Damage(Element.FIRE, 3, 6, 8));
        public static readonly Ammo laserFuel = new Ammo(new Damage(Element.FIRE*2, 0, 10, 2));
    }


    
}
