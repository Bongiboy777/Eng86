using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public static class Element
    {
        public static readonly Elemental FIRE = new Elemental(5, 10, 3, 5);
        public static readonly Elemental WATER = new Elemental(5, 10, 3, 5);
        public static readonly Elemental LIGHTNING = new Elemental(5, 10, 3, 5);
        public static readonly Elemental EARTH = new Elemental(10, 5, 3, 10);
    }
    public struct Elemental
    {
        private int _lightning, _fire, _water, _earth;

        public Elemental(int lightning, int fire, int water, int earth)
        {
            _lightning = lightning < 0 ? 0 : lightning > 10 ? 10 : lightning;
            _fire = fire < 0 ? 0 : fire > 10 ? 10 : fire;
            _water = water < 0 ? 0 : water > 10 ? 10 : 10;
            _earth = earth < 0 ? 0 : earth > 10 ? 10 : 10;
        }

        public int Lightning { get => _lightning; set => _lightning = value; }
        public int Fire { get => _fire; }
        public int Water { get => _water; }

        public int Earth { get => _earth; }

        public int Total() => Lightning+Fire+Water+Earth;

        public static Elemental operator*(Elemental elemental, int right)
        {
            return new Elemental(elemental.Lightning * right, elemental.Fire * right, elemental.Water * right, elemental.Earth * right);
        }

        public static Elemental operator +(Elemental elemental, Elemental elemental2)
        {
            return new Elemental(elemental.Lightning + elemental2.Lightning, elemental.Fire + elemental2.Fire, elemental.Water + elemental2.Water, elemental.Earth + elemental2.Earth);
        }

        public static Elemental operator -(Elemental elemental, Elemental elemental2)
        {
            return new Elemental(elemental.Lightning - elemental2.Lightning, elemental.Fire - elemental2.Fire, elemental.Water - elemental2.Water, elemental.Earth - elemental2.Earth);
        }

    }
}
