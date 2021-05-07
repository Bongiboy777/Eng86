using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
#nullable disable
    public partial class Ammo
    {
        public Ammo()
        {
            Damage = new Damage();
        }

        public Ammo(Damage d)
        {
            Damage = d;
        }
        public string AmmoID { get; set; }
        public Damage Damage { get; set; }
        
    }
}
