using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", "P001", 1200, 1);
        Product product2 = new Product("Mouse", "P002", 30, 2);

        Address customerAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer = new Customer("John Doe", customerAddress);

        Order order1 = new Order(customer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
    }
}
