using NUnit.Framework;
using NorthwindBusiness;
using NorthwindData;
using System.Linq;
using System;
namespace NorthwindTests
{
    public class CustomerTests
    {
        CustomerManager _customerManager;
        [SetUp]
        public void Setup()
        {
           _customerManager = new CustomerManager();
            // remove test entry in DB if present
            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }

        [Test]
        public void WhenANewCustomerIsAdded_TheNumberOfCustomersIncreasesBy1()
        {
            using (var db = new NorthwindContext())
            {
                var currentCount = db.Customers.Count();
                _customerManager.CreateCustomer("MANDA","Nish Mandal", "Sparta");
                Assert.AreEqual(currentCount+1, db.Customers.Count());
            }
        }

        [TestCase("Mandal")]
        [TestCase("Superman")]
        [TestCase("123243")]
        public void CustomerIDnotover5Chars(string id)
        {
            using (var db = new NorthwindContext())
            {                
                Assert.Throws<Microsoft.EntityFrameworkCore.DbUpdateException>(() => _customerManager.CreateCustomer(id, "Nish Mandal", "Sparta"));
            }
        }

        [TestCase("Greece", "Sparta", "SPA7TA", "Ladnam Hsin")]
        [TestCase("France", "Paris", "SP87EA", "Michael Jordan")]
        public void WhenACustomersDetailsAreChanged_TheDatabaseIsUpdated(string country, string city, string postcode, string contactname)
        {
            using (var db = new NorthwindContext())
            {
                _customerManager.CreateCustomer("MANDA", "Nish Mandal", "Sparta");
                _customerManager.UpdateCustomer("MANDA", contactname, city, postcode, country);
                Assert.AreEqual(db.Customers.Find("MANDA").Country, country);
                Assert.AreEqual(db.Customers.Find("MANDA").City, city);
                Assert.AreEqual(db.Customers.Find("MANDA").PostalCode, postcode);
                Assert.AreEqual(db.Customers.Find("MANDA").ContactName, contactname);
                Assert.NotNull(db.Customers.Find("MANDA"));
            }
        }

        [Test]
        public void WhenACustomerIsRemoved_TheyAreNoLongerInTheDatabase()
        {
            using (var db = new NorthwindContext())
            {
                _customerManager.CreateCustomer("MANDA", "Nish Mandal", "Sparta");
                _customerManager.DeleteCustomer("MANDA");
                Assert.Null(db.Customers.Find("MANDA"));
            }
        }
    

    [TearDown]
        public void TearDown()
        {
            using (var db = new NorthwindContext())
            {
                var selectedCustomers =
                from c in db.Customers
                where c.CustomerId == "MANDA"
                select c;

                db.Customers.RemoveRange(selectedCustomers);
                db.SaveChanges();
            }
        }
    }
}