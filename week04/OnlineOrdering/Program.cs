using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Salt Lake", "UT", "USA");
        Address address2 = new Address("305 Anita G St", "Canoas", "RS", "Brazil");

        // Create customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Gabriela Severo", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B456", 19.99, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Desk Chair", "C789", 149.99, 1));
        order2.AddProduct(new Product("Monitor", "D012", 199.99, 1));
        order2.AddProduct(new Product("Keyboard", "E345", 49.99, 1));

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}\n");
    }
}