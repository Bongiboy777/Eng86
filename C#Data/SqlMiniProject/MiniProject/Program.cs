using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MiniProject
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double i = 1.1; i < 2; i += 0.1)
            {
                QueryAnswers.Answer(Math.Round(i,1));
                MethodAnswers.Answer(Math.Round(i,1));
            }

        }
    }

    public static class QueryAnswers
    {
        public static void Answer(double question)
        {
            Console.WriteLine("\n------Query Answer------");
            using (var db = new NorthwindContext())
            {
                
                switch (question)
                {


                    case 1.1:
                        Console.WriteLine($"\n1.1\nCustomerID\tCompanyName\tAddress");
                        (from c in db.Customers
                         where c.City == "Paris" || c.City == "London"
                         select new { CustomerID = c.CustomerId, CompanyName = c.CompanyName, Address = $"{c.Address}, {c.City} ,{c.Country}" }).ToList().ForEach(x => Console.WriteLine($"{x.CustomerID}\t{x.CompanyName}\t{x.Address}"));
                        break;

                    case 1.2:
                        Console.WriteLine($"\n1.2\nProduct\tQuantity per Unit");
                        (from p in db.Products
                         where p.QuantityPerUnit.Contains("oz") || p.QuantityPerUnit.Contains("ml") || p.QuantityPerUnit.Contains("L")
                         select new { Product = p.ProductName, Units = p.QuantityPerUnit }).ToList().ForEach(x => Console.WriteLine($"{x.Product}\t{x.Units}"));
                        break;

                    case 1.3:
                        Console.WriteLine($"\n1.3\nProduct\tQuantity per Unit\tSupplier\tCountry");
                        (from p in db.Products
                         join s in db.Suppliers on p.SupplierId equals s.SupplierId
                         where p.QuantityPerUnit.Contains("bottles")
                         select new { Product = p.ProductName, Units = p.QuantityPerUnit, Supplier = s.CompanyName, Country = s.Country }).ToList().ForEach(x => Console.WriteLine($"{x.Product}\t{x.Units}\t{x.Supplier}\t{x.Country}"));
                        break;

                    case 1.4:
                        Console.WriteLine($"\n1.4\nCategory\tSum of Products");
                        (from p in db.Products
                         join c in db.Categories on p.CategoryId equals c.CategoryId
                         group p by c.CategoryName into res
                         select new { Category = res.Key, SumProducts = res.Count() }).ToList().ForEach(x => Console.WriteLine($"{x.Category}\t{x.SumProducts}"));

                        break;

                    case 1.5:
                        Console.WriteLine($"\n1.5\nEmployee\tCity");
                        (from e in db.Employees
                         where e.Country == "UK"

                         select new { EmployeeFullName = $"{e.TitleOfCourtesy} {e.FirstName} {e.LastName}", City = e.City }).ToList().ForEach(x => Console.WriteLine($"{x.EmployeeFullName}\t{x.City}"));

                        break;

                    //case 1.6:
                    //    Console.WriteLine($"\n1.6\nRegion\tTotal Sales");
                    //    (from o in db.Orders
                    //     join od in db.OrderDetails on o.OrderId equals od.OrderId
                    //     join et in db.EmployeeTerritories on o.EmployeeId equals et.EmployeeId
                    //     join t in db.Territories on et.TerritoryId equals t.TerritoryId
                    //     join r in db.Regions on t.RegionId equals r.RegionId
                    //     //let TotalSales = (1-od.Discount)*od.UnitPrice*od.Quantity
                    //     group o by r.RegionDescription into res

                    //     select new { Region = res.Key }).ToList().ForEach(x => Console.WriteLine($"{x.Region}"));

                    //    break;

                    case 1.7:
                        Console.WriteLine($"\n1.7\n");
                        var answ = (from o in db.Orders
                                    where o.Freight > 100 && (o.ShipCountry == "USA" || o.ShipCountry == "UK")
                                    select o).ToList().Count();
                        Console.WriteLine(answ);
                        break;

                    case 1.8:
                        Console.WriteLine($"\n1.8\nOrderID\tDiscount");
                        (from odd in db.OrderDetails
                                   let maxdiscount = (from od in db.OrderDetails
                                                      select od.Discount).Max()
                                   where odd.Discount == maxdiscount

                                   select new {ID = odd.OrderId , discount = odd.Discount}).Distinct().ToList().ForEach(x => Console.WriteLine($"{x.ID}\t{x.discount}"));
                        
                        break;


                        // case 1.7:
                        //Console.WriteLine($"\n1.2\n");
                        //(from a in db.Products
                        // where 
                        // select new {}).ToList().ForEach(x => Console.WriteLine($""));
                        //break;
                }


            }
        }
    }

    public static class MethodAnswers
    {
        public static void Answer(double question)
        {
            Console.WriteLine("\n------Method Answer------");
            using (var db = new NorthwindContext())
            {
                switch (question)
                {


                    case 1.1:
                        Console.WriteLine($"\n1.1\nCustomerID\tCompanyName\tAddress");
                        db.Customers.Select(c => new { ID = c.CustomerId, CompanyName = c.CompanyName, Address = $"{c.Address} {c.City} {c.Country}" })
                            .ToList().ForEach(x => Console.WriteLine($"{x.ID}\t{x.CompanyName}\t{x.Address}"));
                        break;

                    case 1.2:
                        Console.WriteLine($"\n1.2\nProduct\tQuantity per Unit");
                        db.Products.Where(p => p.QuantityPerUnit.Contains("bottles")).ToList().ForEach(x => Console.WriteLine($"{x.ProductName}\t{x.QuantityPerUnit}"));
                        break;
                        

                    case 1.3:
                        Console.WriteLine($"\n1.3\nProduct\tQuantity per Unit\tSupplier\tCountry");
                        db.Products.Include(s=>s.Supplier).Where(p => p.QuantityPerUnit.Contains("bottles")).ToList().ForEach(x => Console.WriteLine($"{x.ProductName}\t{x.QuantityPerUnit}\t{x.Supplier.CompanyName}\t{x.Supplier.Country}"));
                        
                        break;

                    case 1.4:
                        Console.WriteLine($"\n1.4\nCategory\tSum of Products");
                        db.Products.Include(c => c.Category).GroupBy(c => c.Category.CategoryName)
                            .Select(newGroup => new
                            {
                                CategoryName = newGroup.Key,
                                SumProducts = newGroup.Count()
                            }

                            ).ToList().ForEach(x => Console.WriteLine($"{x.CategoryName}\t{x.SumProducts}"));
                        
                        break;

                    case 1.5:
                        Console.WriteLine($"\n1.5\nEmployee\tCity");
                        db.Employees.Where(c => c.Country == "UK").Select(x => new { Name = $"{x.TitleOfCourtesy} {x.FirstName} {x.LastName}", City = x.City })
                            .ToList().ForEach(x => Console.WriteLine($"{x.Name}\t{x.City}"));
                       
                        break;

                    //case 1.6:
                    //    Console.WriteLine($"\n1.6\nRegion\tTotal Sales");
                    //    (from o in db.Orders
                    //     join od in db.OrderDetails on o.OrderId equals od.OrderId
                    //     join et in db.EmployeeTerritories on o.EmployeeId equals et.EmployeeId
                    //     join t in db.Territories on et.TerritoryId equals t.TerritoryId
                    //     join r in db.Regions on t.RegionId equals r.RegionId
                    //     //let TotalSales = (1-od.Discount)*od.UnitPrice*od.Quantity
                    //     group o by r.RegionDescription into res

                    //     select new { Region = res.Key }).ToList().ForEach(x => Console.WriteLine($"{x.Region}"));

                    //    break;

                    case 1.7:
                        Console.WriteLine($"\n1.7\n");
                        var ans = db.Orders.Where(q => q.Freight > 100 && (q.ShipCountry == "USA" || q.ShipCountry == "UK")).Count();
                        Console.WriteLine(ans);
               
                        break;

                    case 1.8:
                        Console.WriteLine($"\n1.8\nOrderID\tDiscount");
                        db.OrderDetails
                            .Where(x => x.Discount == db.OrderDetails.Max(c => c.Discount))
                            .Select(x => new {OrderId = x.OrderId, Discount = x.Discount })
                            .Distinct()
                            .ToList().ForEach(x => Console.WriteLine($"{x.OrderId}\t{x.Discount}"));
                        //(from odd in db.OrderDetails
                        // let maxdiscount = (from od in db.OrderDetails
                        //                    select od.Discount).Max()
                        // where odd.Discount == maxdiscount

                        // select new { ID = odd.OrderId, discount = odd.Discount }).Distinct().ToList().ForEach(x => Console.WriteLine($"{x.ID}\t{x.discount}"));
                        break;


                        // case 1.7:
                        //Console.WriteLine($"\n1.2\n");
                        //(from a in db.Products
                        // where 
                        // select new {}).ToList().ForEach(x => Console.WriteLine($""));
                        //break;
                }


            }
        }


    }
}
