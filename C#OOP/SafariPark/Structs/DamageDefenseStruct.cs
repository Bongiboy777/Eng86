using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public struct Damage
    {

        private int _blunt, _pierce, _strike;

        private Elemental _elemental;
        public int BluntDmg { get => _blunt; }
        public int PierceDmg { get => _pierce; }
        public int StrikeDmg { get => _strike; }
        public Elemental Elemental { get => _elemental;}

        public Damage(Elemental elementalDamage, int bluntDmg = 5, int pierceDmg = 5, int strikeDmg = 5)
        {
            _elemental = elementalDamage;
            _blunt = bluntDmg;
            _pierce = pierceDmg;
            _strike = strikeDmg;
        }

        public static Damage operator*(Damage left, int right)
        {

            return new Damage(left.Elemental*right,left._blunt*right,left._pierce*right,left._strike*right);

        }

        public static Damage operator +(Damage left, Damage right)
        {

            return new Damage(left.Elemental + right.Elemental, left.BluntDmg + right.BluntDmg, left.PierceDmg + right.PierceDmg, left.StrikeDmg + right.StrikeDmg);

        }

        public static Damage operator -(Damage left, Damage right)
        {

            return new Damage(left.Elemental - right.Elemental, left.BluntDmg - right.BluntDmg, left.PierceDmg - right.PierceDmg, left.StrikeDmg - right.StrikeDmg);

        }

        public int CalculateDamage()
        {
            int sum = StrikeDmg + PierceDmg + BluntDmg;
            sum *= Elemental.Total() + 1;
            return sum;
        }


    }

  

}
