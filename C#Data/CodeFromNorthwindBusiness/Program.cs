using System;
using System.Linq;
using NorthwindCodeModel;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CodeFromNorthwindBusiness

{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                var bong = db.Customers.Find("MANDA");

                var newOrder = new Order { OrderDate = DateTime.Now, ShipCountry = "Egypt", Customer = bong };

                db.Orders.Add(newOrder);

                db.SaveChanges();

                var bonQuery = db.Orders.Include(o => o.Customer).Where(c => c.CustomerId == "MANDA");
                bonQuery.ToList().ForEach(n => Console.WriteLine($"{n.Customer.ContactName} made this order: {n.OrderId}"));

                ///var methodsyntax = db.Customers.Where(c => ).OrderBy(c =>).Select();
                ///MethodSyntax
                ///
                var nums = new List<int> { 1, 2, 3, 1, 45, 5, 7, 3, 2 };
                int counteven = 0;

                nums.Count(aMethod);

                foreach (var item in nums)
                {
                    if(aMethod(item))
                    {
                        counteven++;
                    }
                }
                var people_over20 = people.Count(AgeOver20);

                var evencount = nums.Count(x =>
                {
                    return x % 2 == 0;
                });

                var evencount2 = nums.Count(x => x % 2 == 0);

                var evencount3 = nums.Count(delegate (int x) { return x % 2 == 0; });

                db.Customers.Where(c => c.City == "Berlin").ToList().ForEach(c => Console.WriteLine(c.ContactName));

                db.Products.GroupBy(p => p.SupplierId).Select(newGroup => new
                {
                    SupID = newGroup.Key,
                    UnitsInStock = newGroup.Sum(c => c.UnitsInStock)
                }).ToList().ForEach(s => Console.WriteLine($"{s.SupID}\t{s.UnitsInStock}"));

                db.Products.OrderByDescending(p => p.QuantityPerUnit).ThenByDescending(c => c.ReorderLevel).Select(c => new {name = c.ProductName, QPU = c.QuantityPerUnit, RL = c.ReorderLevel }).ToList().ForEach(c => Console.WriteLine($"{c.name}\t{c.QPU}\t{c.RL}"));
                db.Products.Include(o => o.Supplier).Where(p => p.Supplier.SupplierId == p.SupplierId);
                //db.Customers.Add(new Customer 
                //{ CustomerId ="JDRHS",
                //    ContactName = "Jude Rush",
                //Address = "323 asdda strret as",
                //CompanyName = "JHS",
                //City = "Night Citt" });
                //db.SaveChanges();

                //Console.WriteLine(db.Customers.Find("JDRH").Address);
                //var copy = db.Customers.Where(c => c.CustomerId == "JDRH").FirstOrDefault();
                //copy.CompanyName = "HAPP";
                //db.SaveChanges();
                //Console.WriteLine(db.Customers.Where(c => c.ContactName == "Jade Rush").FirstOrDefault().CompanyName);

                //var querySyntax = (from s in db.SalesByCategories
                //                   join a in db.SalesTotalsByAmounts on s.CategoryId == a.)

                //db.Customers.RemoveRange(db.Customers.Where(c => c.City == "London"));
                //db.Customers.Remove(db.Customers.Find("PIEK"));
                db.Orders.Include(c => c.Customer).Include(e => e.Employee).ThenInclude(s => s.EmployeeTerritories).ThenInclude(t => t.Territory).ToList().ForEach(x => Console.WriteLine($"{x.Employee.FirstName + " " + x.Employee.LastName} delivered order {x.OrderId}, from region {x.ShipRegion}"));
            
            }

           

            for (int i = 0; i < 2; i++)
            {
                ////using (var db = new NorthwindContext())
                ////{
                ////    var selectedCustomer = db.Customers.Where
                ////        (c => c.CustomerId == "FRNHY").FirstOrDefault();

                ////    var newCustomer = new Customer
                ////    {
                ////        CustomerId = "V",
                ////        ContactName = "V",
                ////        CompanyName = "StreetKid",
                ////        City = "Night City"

                ////    };
                ////    db.Customers.Add(newCustomer);


                ////    db.Customers.Remove(newCustomer);
                ////    db.SaveChanges();



                ////    foreach (var item in db.Customers)
                ////    {
                ////        Console.WriteLine($"{item}\t{item.City}");
                ////    }
                ////    Console.WriteLine(selectedCustomer);
                //using (var database = new NorthwindContext())
                //{
                //    //IOrderedQueryable<Customer> query1 =
                //    //    from c in database.Customers
                //    //    where c.City == "London"
                //    //    orderby c.City
                //    //    select c;

                //    var query3 =
                //        from c in database.Customers
                //        where c.City == "London" || c.City == "Berlin"
                //        select new { customerName = c.ContactName };
                //    //Forcing execution
                //    //query2.ToList<Customer>().ForEach(x => Console.WriteLine($"{x.ContactName}\t{x.City}"));

                //    //Function on query forces execution, default execution is first or firstordefault
                //    //foreach (var item in query3)
                //    //{
                //    //    Console.WriteLine(item.customerName);
                //    //}

                //    //var groupProductBuUnitsInStockQuery =
                //    //    from p in database.Products
                //    //    group p by p.Supplier into newGroup
                //    //    orderby newGroup.Sum(c => c.UnitsInStock) descending
                //    //    select new
                //    //    {
                //    //        SupplierID = newGroup.Key,
                //    //        UnitsInStock = newGroup.Sum(c => c.UnitsInStock)
                //    //    };

                //    //foreach (var item in groupProductBuUnitsInStockQuery)
                //    //{
                //    //    Console.WriteLine(item);
                //    //}

                //    //var h = database.Products.GroupBy(c => c.Category).Select();

                //    var orderProductsByPrice =
                //        from p in database.Products
                //        orderby p.UnitPrice descending
                //        select p;
                //    orderProductsByPrice.ToList().ForEach(k => Console.WriteLine($"{k.ProductName}\t{k.UnitPrice}"));


                //    //AWWW CRUD!////

                //    ///Create
                //    ///
                //    var customer = database.Customers.Add(new Customer() { CustomerId = "VECT", Address = "34,BlindStreet, NightCity, NewAmerica", ContactName = "v" });
                //    database.SaveChanges();

                //    var chg = 
                //    (from c in database.Customers
                //     where c.ContactName == "V"
                //     select c).FirstOrDefault().City = "Paris";


                //    database.SaveChanges();

                //    database.Remove(from s in database.Customers
                //                    where s.City == "London"
                //                    select s);

                //    database.SaveChanges();

                //    database.Customers.ToList();

            }
            
           
        }

        static int bMethod(int x)
        {
            return x * x;
        }

        static bool aMethod(int x)
        {
            return x>3;
        }

        static List<Person> people = new List<Person>()
        {
            new Person{Name= "Madara", Age= 122},
            new Person{Name= "Luffy", Age = 23 },
            new Person{Name= "Goku", Age = 40}
        };

        

        static bool AgeOver20(Person p)
        {
            return p.Age > 20;

        }

        

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }


    }
        }
    
