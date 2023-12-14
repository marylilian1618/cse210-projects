using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressUsa = new Address("45 main street", "New York City","New York","United States of America");
        Customer customerUsa =  new Customer("Susan", addressUsa);
        Product product1 =  new Product("Chicken","15424",45.64,4);
        Product product2 = new Product("Kitchen","98645",145.85,2);
        Order order = new Order(customerUsa, new List<Product>{product1, product2});

        Console.WriteLine("Order 1 - Packing Label:");
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine("Order 1 - Shipping Label:");
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine("Order 1 - Total Price:");
        Console.WriteLine($"{order.TotalCoast()}");

        Console.WriteLine("--------------------------");

        Address addressInternational = new Address("Los manzanos", "Huancayo","Junin","Perú");
        Customer customerInternational =  new Customer("Lily", addressInternational);
        Product product1i =  new Product("Soap","45824",9,4);
        Product product2i = new Product("Bed","12645",599.3,2);
        Order orderI = new Order(customerInternational, new List<Product>{product1i, product2i});

        Console.WriteLine("Order 2 - Packing Label:");
        Console.WriteLine(orderI.PackingLabel());
        Console.WriteLine("Order 2 - Shipping Label:");
        Console.WriteLine(orderI.ShippingLabel());
        Console.WriteLine("Order 2 - Total Price:");
        Console.WriteLine($"{orderI.TotalCoast()}");


   

    }
}