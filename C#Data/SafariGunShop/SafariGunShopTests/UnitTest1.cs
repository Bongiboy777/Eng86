using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using GameData;
using GameDataManager;
namespace SafariGunShopTests
{
    public class AmmoTests
    {
        AmmoManager ammoManager;
        [SetUp]
        public void Setup()
        {
            ammoManager = new AmmoManager();            
        }

        [Test]
        public void CanAddAmmoToDatabase_CountIncreases()
        {


            //using (var db = new GameDataContext())
            //{
            //    var currentCount = db.Ammo.Count();
            //    ammoManager.AddAmmo("Missile",60,20,8);
            //    db.SaveChanges();
            //    Assert.AreEqual(currentCount + 1, db.Ammo.Count());
            //}

        }

        //[TestCase(3,3,4)]
        //public void CreatedAmmoDamagesMatch(int strike, int blunt, int pierce)
        //{

        //    using (var db = new GameDataContext())
        //    {
        //        var currentCount = db.Ammo.Count();
        //        ammoManager.AddAmmo("bb", strike, blunt, pierce);
        //        db.SaveChanges();
        //        Assert.AreEqual(db.Ammo.Last().Strike, strike);
        //        Assert.AreEqual(db.Ammo.Last().Blunt, blunt);
        //        Assert.AreEqual(db.Ammo.Last().Pierce, pierce);
        //    }
        //}

        //[TearDown]
        //public void TearDown()
        //{

        //    using (var db = new GameDataContext())
        //    {

        //        db.Ammo.Remove(db.Ammo.Find(db.Ammo.Count()));
        //        db.SaveChanges();
        //    }
        //}


    }
}