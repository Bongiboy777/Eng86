using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Ammo
    {
        
        private readonly string _brand;
        public AmmoType _ammoType;
        public string Brand { get { return _brand; } }

        public Ammo(AmmoType ammoType,string brand)
        {
            _brand = brand;
            _ammoType = ammoType;

        }
}
    public class AmmoType
    {

        private Damage _damage;
        public Damage Damage { get => _damage;}
        public AmmoType(Damage damage)
        {
            
            _damage = damage;
        }

        public AmmoType(int blnt = 3, int pierce = 3,int strk = 3)
        {

            _damage = new Damage(new Elemental(0,0,0,3), blnt,pierce,strk);
        }

        //public AmmoType(i)
        //{

        //    _damage = damage;
        //}
    }

    public static class AmmoTypes
    {
        public static readonly AmmoType _shotGunCartridge = new AmmoType(5, 3, 2);
        public static readonly AmmoType _regBullet = new AmmoType(2, 2, 2);
        public static readonly AmmoType _sniperRound = new AmmoType(1, 8, 5);
        public static readonly AmmoType _grenade = new AmmoType(new Damage(Element.FIRE, 3, 9, 8));
        public static readonly AmmoType laserFuel = new AmmoType(new Damage(Element.FIRE, 3, 9, 8));
    }


    
}
