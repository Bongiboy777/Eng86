using System;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace CSharpWithSql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                connection.Open();
                Console.WriteLine(connection.State);
                for (int i = 0; i < 2; i++)
                {
                    //using (var command = new SqlCommand("select * from customers", connection))
                    //{
                    //    SqlDataReader sqlreader = command.ExecuteReader();
                    //    var customerList = new List<Customer>();

                    //    while(sqlreader.Read())
                    //    {
                    //        //Read table and extract variables/columns
                    //        var customerID = sqlreader["CustomerID"].ToString();
                    //        var contactName = sqlreader["ContactName"].ToString();
                    //        var contactTitle = sqlreader["ContactTitle"].ToString();
                    //        var city = sqlreader["City"].ToString();
                    //        var companyName = sqlreader["CompanyName"].ToString();

                    //        customerList.Add(new Customer(city,contactTitle,companyName,customerID, contactName.Split(' ')[1], contactName.Split(' ')[0]));
                    //    }

                    //    customerList.ForEach(x => Console.WriteLine(x.ContactTitle));
                    //}
                    //var newCustomer = new Customer() { CustomerID = "Pizzaman", Firstname = "Cecil", Lastname = "Steadman" };
                    //string insertSQLString = $"insert into customers(customerID,ContactName,CompanyName,City) Values('{newCustomer.CustomerID}','{newCustomer.Firstname}', 'PizzaLand', 'Peterborough')";

                    //using (var command2 = new SqlCommand(insertSQLString, connection))
                    //{
                    //    int affected = command2.ExecuteNonQuery();
                    //}
                    ///Udate
                    //var newCustomer = new Customer() { CustomerID = "Pizzaman", Firstname = "Cecil", Lastname = "Steadman" };
                    //string update = $"update customers set city = 'London' Where customerID = 'MANDA'";

                    //using (var command3 = new SqlCommand(update, connection))
                    //{
                    //    int affected = command3.ExecuteNonQuery();
                    //}

                    //string delete = $"delete from customers where city = 'nok'";

                    //using (var command3 = new SqlCommand(delete, connection))
                    //{
                    //    int affected = command3.ExecuteNonQuery();
                    //}

                    //Update using stored procedure
                    //using(var storedcoman = new SqlCommand("UpdateCustomer",connection))
                    //{
                    //    storedcoman.CommandType = System.Data.CommandType.StoredProcedure;
                    //    storedcoman.Parameters.AddWithValue("ID", "Luwe");
                    //    storedcoman.Parameters.AddWithValue("NewName", "Luwemba");
                    //}
                }


            }

            
        }
    }

    public class Customer
    {
        
        private string _city;
        private string _contactTitle;
        private string _companyName;
        private string _customerID;
        private string _lastname;
        private string _firstname;

        public Customer(string city, string contactTitle, string companyName, string customerID, string lastname, string firstname)
        {
            _city = city;
            _contactTitle = contactTitle;
            _companyName = companyName;
            _customerID = customerID;
            _lastname = lastname;
            _firstname = firstname;
        }

        public Customer()
        {

        }

        public string City { get => _city; set => _city = value; }
        public string ContactTitle { get => _contactTitle; set => _contactTitle = value; }
        public string CompanyName { get => _companyName; set => _companyName = value; }
        public string CustomerID { get => _customerID; set => _customerID = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string Firstname { get => _firstname; set => _firstname = value; }
    }
}
