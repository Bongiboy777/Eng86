using System;
using System.Collections.Generic;
namespace GameData
{
    public partial class PartyMember
    {
        public PartyMember()
        {
            Guns = new HashSet<Gun>();
        }
        public int PartyMemberID { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public int XP { get; set; }
        public ICollection<Gun> Guns { get; set; }
    }
}
