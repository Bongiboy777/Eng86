using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public abstract class Weapon
    {
        private int _durability;
        private Damage _attackDmg;
        public int Durability { get => _durability; set => _durability = value; }
        public Damage AttackDmg { get => _attackDmg; set => _attackDmg = value; }

        public readonly string _brand;

        public override string ToString()
        {
            return base.ToString();
        }

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public abstract Damage Attack(int times = 0);
        public abstract Damage Attack2(int times = 0);

    }

        
    }

