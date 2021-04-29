using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    interface IMelee
    {
        public string MeleeAttack();
        public string MeleeAttack(int times);
    }
}
