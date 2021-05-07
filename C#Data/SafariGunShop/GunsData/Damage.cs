using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public class Damage
    {
        public Damage(int strike=2, int blunt=2, int pierce=2)
        {
            Strike = strike;
            Blunt = blunt;
            Pierce = pierce;
            ElementalDamage = new Elemental();
        }

        public Damage(Elemental elemental, int strike=2, int blunt=2, int pierce=2)
        {
            Strike = strike;
            Blunt = blunt;
            Pierce = pierce;
            ElementalDamage = elemental;
        }

        public int DamageID { get; set; }
        public int Strike { get; set; }
        public int Blunt { get; set; }
        public int Pierce { get; set; }
        public Elemental ElementalDamage { get; set; }

        public static Damage operator +(Damage r, Damage l)
        {
            return new Damage(r.ElementalDamage + l.ElementalDamage,r.Strike + l.Strike, r.Blunt + l.Blunt, r.Pierce + l.Pierce);
        }

        public static Damage operator -(Damage r, Damage l)
        {
            return new Damage(r.ElementalDamage - l.ElementalDamage, r.Strike - l.Strike, r.Blunt - l.Blunt, r.Pierce - l.Pierce);
        }

        public static Damage operator *(int r, Damage l)
        {
            return new Damage(r * l.ElementalDamage, r * l.Strike, r * l.Blunt, r * l.Pierce);
        }

        public static Damage operator *(Damage l, int r)
        {
            return new Damage(r * l.ElementalDamage, r * l.Strike, r * l.Blunt, r * l.Pierce);
        }

        public static Damage operator /(Damage l, int r)
        {
            return new Damage(l.ElementalDamage / r, l.Strike / r, l.Blunt / r, l.Pierce / r);
        }
    }

    public class Elemental
    {
        public Elemental(int fire = 0, int electricity = 0, int ice = 0, int poison = 0)
        {
            Fire = fire;
            Electricity = electricity;
            Ice = ice;
            Poison = poison;
        }

        public int ElementalID { get; set; }
        public int Fire { get; set; }
        public int Electricity { get; set; }
        public int Ice { get; set; }
        public int Poison { get; set; }

        public static Elemental operator+(Elemental r, Elemental l)
            {
            return new Elemental(r.Fire + l.Fire, r.Electricity + l.Electricity, r.Ice + l.Ice, r.Poison + l.Poison);
            }

        public static Elemental operator -(Elemental r, Elemental l)
        {
            return new Elemental(r.Fire - l.Fire, r.Electricity - l.Electricity, r.Ice - l.Ice, r.Poison - l.Poison);
        }

        public static Elemental operator *(int r, Elemental l)
        {
            return new Elemental(r*l.Fire, r*l.Electricity, r*l.Ice, r*l.Poison);
        }

        public static Elemental operator *( Elemental l, int r)
        {
            return new Elemental(r * l.Fire, r * l.Electricity, r * l.Ice, r * l.Poison);
        }

        public static Elemental operator /(Elemental l, int r)
        {
            return new Elemental( l.Fire/r,  l.Electricity/r, l.Ice/r,  l.Poison/r);
        }

        public static Elemental SFire = new Elemental(10, 0, 0, 0);
        public static Elemental SPoison = new Elemental(0, 0, 0, 10);
        public static Elemental SIce = new Elemental(0, 0, 10, 0);
        public static Elemental SElectricity = new Elemental(0, 10, 0, 0);

        public static Elemental fire = new Elemental(1, 0, 0, 0);
        public static Elemental poison = new Elemental(0, 0, 0, 1);
        public static Elemental ice = new Elemental(0, 0, 1, 0);
        public static Elemental electricity = new Elemental(0, 1, 0, 0);
    }

    public static class ElementalPresets
    {
        public static Elemental Fire = new Elemental(10,0,0,0);
        public static Elemental Poison = new Elemental(0, 0, 0, 10);
        public static Elemental Ice = new Elemental(0, 0, 10, 0);
        public static Elemental Electricity = new Elemental(0, 10, 0, 0);

        public static Elemental fire = new Elemental(1, 0, 0, 0);
        public static Elemental poison = new Elemental(0, 0, 0, 1);
        public static Elemental ice = new Elemental(0, 0, 1, 0);
        public static Elemental electricity = new Elemental(0, 1, 0, 0);
    }
}
