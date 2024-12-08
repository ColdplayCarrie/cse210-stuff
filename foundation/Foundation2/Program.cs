using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1234 Ever Circle", "The Bakery", "England", "United Kingdom");
        Address address2 = new Address("42 Poppyfields Lane", "Boring", "Oregon", "USA");
        
        Customer customer1 = new Customer("Chris Martin", address1);
        Customer customer2 = new Customer("Grunkel Stan", address2);

        Product product1a = new Product("Grand Piano", 446834, 10.00m, 1);
        Product product1b = new Product("Dr Pepper", 232323, 1.75m, 100);

        Product product2a = new Product("Sasquatch", 133113, 130.00m, 13);
        Product product2b = new Product("Memory Gun", 2255522, 1300.00m, 1);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1a);
        order1.AddProduct(product1b);

        order2.AddProduct(product2a);
        order2.AddProduct(product2b);

        Console.WriteLine("ORDER #1");
        order1.PackingLabel();
        Console.WriteLine($"Total (including shipping): ${order1.GrandTotalOfOrder()}");
        Console.WriteLine();
        order1.ShippingLabel();      
        Console.WriteLine("__________________");
        Console.WriteLine();
        Console.WriteLine("ORDER #2");
        order2.PackingLabel();
        Console.WriteLine($"Total (including shipping): ${order2.GrandTotalOfOrder()}");
        Console.WriteLine();
        order2.ShippingLabel();
        Console.WriteLine();        
    }
}