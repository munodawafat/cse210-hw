using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Seattle", "Washington", "USA");

        Customer customer1 = new Customer("Lee Munoz", address1);

        Product product1 = new Product("laptop", "P001", 980.00, 1);

        Product product2 = new Product("Wireless Mouse", "P002", 10.00, 2);

        Product product3 = new Product("Keyboard", "P003", 30.00, 1);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("25 Mbada Street", "Rimuka", "Kadoma", "Zimbabwe");

        Customer customer2 = new Customer("Tapiwa Munodawafa", address2);

        Product product4 = new Product("Boombox", "P004", 100.00, 1);

        Product product5 = new Product("Thumb drive", "P005", 5.00, 5);

        Product product6 = new Product("Headphones", "P006", 20.00, 2);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("ORDER 1");
        Console.WriteLine();
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");

        Console.WriteLine();
        Console.WriteLine("ORDER 2");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}