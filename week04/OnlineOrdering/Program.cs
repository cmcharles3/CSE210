using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- ORDER 1 (Customer in USA) ---
            Address address1 = new Address("123 Main St", "New York", "NY", "USA");
            Customer customer1 = new Customer("John Doe", address1);
            Order order1 = new Order(customer1);
            
            order1.AddProduct(new Product("Laptop", "LP-1001", 999.99, 1));
            order1.AddProduct(new Product("Wireless Mouse", "WM-2002", 25.50, 2));
            order1.AddProduct(new Product("USB-C Cable", "UC-3003", 12.00, 3));

            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice():F2}");
            Console.WriteLine();


            // --- ORDER 2 (Customer in Canada) ---
            Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
            Customer customer2 = new Customer("Jane Smith", address2);
            Order order2 = new Order(customer2);

            order2.AddProduct(new Product("Mechanical Keyboard", "MK-4004", 120.00, 1));
            order2.AddProduct(new Product("Monitor", "MN-5005", 299.99, 2));

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice():F2}");
        }
    }
}