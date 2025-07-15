using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1//
        Address address1 = new Address("123 Sesame Street", "New York City", "NY", "USA");
        Customer customer1 = new Customer("Big Bird", address1);

        Product product1 = new Product("111", "Socks", 1.00f, 2);
        Product product2 = new Product("222", "Pants", 10.99f, 1);
        Product product3 = new Product("333", "Tie", 8.99f, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("");

        //Order 2//
        Address address2 = new Address("555 Barker Street", "New Orleans", "LA", "USA");
        Customer customer2 = new Customer("Ronald McDonald", address2);

        Product product4 = new Product("444", "Watch", 20.99f, 1);
        Product product5 = new Product("555", "Shoes", 45.00f, 1);
        Product product6 = new Product("666", "Necklace", 5.00f, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("");
    }
}