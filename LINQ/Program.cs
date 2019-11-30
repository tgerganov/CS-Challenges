using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Customer
    {
        public string Name;
        public string City;
        public Order[] Orders;
    }

    class Order
    {
        public int Quantity;
        public Product Product;
    }

    class Product
    {
        public string Name;
        public decimal Price;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //a) Using "Object Initializers"
            Customer customer1 =
                new Customer
                {
                    Name = "Kim Foged",
                    City = "Beder",
                    Orders = new Order[] 
                    {
                        new Order { Product = new Product { Name = "Milk", Price = 7.50m}, Quantity = 1 },
                        new Order { Product = new Product { Name = "Butter", Price = 12.50m}, Quantity = 2 },
                        new Order { Product = new Product { Name = "Bread", Price = 18.50m }, Quantity = 3 }
                    } 
                };

            Customer customer2 =
                new Customer
                {
                    Name = "Ib Havn",
                    City = "Horsens",
                    Orders = new Order[]
                    {
                        new Order { Product = new Product { Name = "Milk", Price = 6.50m}, Quantity = 2 },
                        new Order { Product = new Product { Name = "Butter", Price = 10m}, Quantity = 4 },
                        new Order { Product = new Product { Name = "Bread", Price = 8.50m }, Quantity = 2 },
                        new Order { Product = new Product { Name = "Cacao", Price = 34.85m }, Quantity = 1 }
                    }
                };

            Customer customer3 =
                new Customer
                {
                    Name = "Rasmus Bjerner",
                    City = "Horsens",
                    Orders = new Order[]
                    {
                        new Order { Product = new Product { Name = "Juice", Price = 11.20m}, Quantity = 8 }
                    }
                };

            //b) Select all customers
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            var bQuery = from c in customers select c;
            foreach(Customer c in bQuery)
            {
                Console.WriteLine("Name: {0}, City: {1}", c.Name, c.City);
            }
            Console.WriteLine();

            //c) Select all customers from Horsens
            var cQuery = from c in customers where c.City == "Horsens" select c;
            foreach(Customer c in cQuery)
            {
                Console.WriteLine("Name: {0}", c.Name);
            }
            Console.WriteLine();

            //d) Select the count of orders for customer Ib Havn
            var dQuery = from c in customers where c.Name == "Ib Havn" select c;
            foreach(Customer c in dQuery)
            {
                Console.WriteLine("Number of orders: {0}", c.Orders.Count());
            }
            Console.WriteLine();

            //e) Select all customers buying milk
            var eQuery = customers.Where(c => c.Orders.Any(order => order.Product.Name == "Milk")).Select(c => c.Name);
            foreach (var name in eQuery)
            {
                Console.WriteLine("Name: {0}", name);
            }
            Console.WriteLine();

            //f) Select the total sum for each customer
            var fQuery =
                from c in customers
                let sum = c.Orders.Sum(order => order.Product.Price * order.Quantity)
                select c.Name + " " + sum;
            foreach(var item in fQuery)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //g) Select the total sum for all customers
            var gQuery =
                (from c in customers
                 select c.Orders.Sum(order => order.Product.Price * order.Quantity)).Sum();
            Console.WriteLine("Total sum: {0}", gQuery);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}



