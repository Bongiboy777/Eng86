using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using GameData;

namespace GameDataManager
{
 public class AmmoManager
    {
        static void Main(string[] args)
        {
            using (var db = new GameDataContext())
            {
                
            }
        }
        //public void AddAmmo(string ID, int strike=5, int blunt = 5, int pierce=6)
        //{
        //    using (var db = new GameDataContext())
        //    {
        //        db.Ammo.Add(new Ammo(strike, blunt, pierce) {AmmoID= ID});                
        //        db.SaveChanges();
        //    }
        //}
    }

}
