

using System;
using System.Collections.Generic;

namespace Foundation1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some products
            Product product1 = new Product("Sugar", 1, 10.99m, 2);
            Product product2 = new Product("Soccer Ball", 2, 15.49m, 1);

            // Create a customer with an address
            Address customerAddress = new Address("123 Main St", "New York", "NY", "USA");
            Customer customer = new Customer("John Doe", 1, customerAddress, "john@example.com");

            // Create an order with the products and customer
            List<Product> products = new List<Product> { product1, product2 };
            Order order = new Order(101, products, customer, DateTime.Now);

            // Display the order details
            order.DisplayOrder();

            // Calculate and display the total cost of the order
            decimal total = order.CalculateTotal();
            Console.WriteLine($"Total Cost: ${total}");

            // Display the packing label
            string packingLabel = order.PackLabel();
            Console.WriteLine("\nPacking Label:");
            Console.WriteLine(packingLabel);

            // Display the shipping label
            string shippingLabel = order.ShippingLabel();
            Console.WriteLine("\nShipping Label:");
            Console.WriteLine(shippingLabel);
        }
    }
}
