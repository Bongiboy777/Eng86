using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameData
{
    public class Gun
    {
        public Gun()
        {
            Ammos = new HashSet<Ammo>();       
        }
        public int GunID { get; set; }
        public string Name { get; set; }
        public int FireRate { get; set; }
        public virtual ICollection<Ammo> Ammos{ get; set; }
}
}
