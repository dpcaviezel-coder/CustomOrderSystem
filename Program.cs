using System;
using System.Reflection;

namespace CustomerOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Customer Order System!");
            // Additional code for the application can be added here.

            OrderManager manager = new OrderManager();

            Customer customer1 = new Customer("Alice Johnson", "alice.johnson@example.com");
            Customer customer2 = new Customer("Bob Smith", "bob.smith@example.com");
            Customer customer3 = new Customer("Charlie Brown", "charlie.brown@example.com");

            manager.PlaceOrder(customer1, new Product("keyboard", 59.99));
            manager.PlaceOrder(customer2, new Product("mouse", 49.99));
            manager.PlaceOrder(customer3, new Product("monitor", 349.99));

            manager.DisplayOrders();

        }
    }
    }
