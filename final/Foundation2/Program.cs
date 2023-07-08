using System;

class Program2
{
    public static void Main(string[] args)
    {
        // First product order (domestic)
        // creating list of products
        Product[] products1 = {
            new Product("Pipes", "P019873", 9.99, 10),
            new Product("Fasteners", "F91348S", 0.99, 5),
            new Product("Flux Capacitor", "FLUX1234", 100, 1)
        };
        // creating the address for the customer
        Address marty_home = new Address("308 Negra Arroyo Lane", "Albuquerque", "NM", "United States");
        // creating the customer
        Customer marty_mcfly = new Customer("Marty McFly", marty_home);
        // creating the order
        Order marty_order = new Order(products1, marty_mcfly);

        // Outputting the order, packing and shipping labels, and final price
        Console.WriteLine("Order 1 - Marty McFly's Order");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(marty_order.createPackingLabel());
        Console.WriteLine();
        Console.WriteLine(marty_order.createShippingLabel());
        Console.WriteLine();
        Console.WriteLine(string.Format("Final Price: {0:c}", marty_order.getFinalPrice()));
        Console.WriteLine();

        // Second product order (domestic)
        // creating list of products
        Product[] products2 = {
            new Product("Tires", "TR00123HK", 234.95, 4),
            new Product("Filters", "FIL91340", 8.99, 2),
            new Product("Bolts", "BLT000013", 0.25, 50)
        };
        // creating the address for the customer
        Address mechanic_shop = new Address("1620 Waukegan Rd", "Glenview", "IL", "USA");
        // creating the customer
        Customer mechanic = new Customer("Mechanic", mechanic_shop);
        // creating the order
        Order mechanic_order = new Order(products2, mechanic);

        // Outputting the order, packing and shipping labels, and final price
        Console.WriteLine("Order 2 - Mechanic's Order");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(mechanic_order.createPackingLabel());
        Console.WriteLine();
        Console.WriteLine(mechanic_order.createShippingLabel());
        Console.WriteLine();
        Console.WriteLine(string.Format("Final Price: {0:c}", mechanic_order.getFinalPrice()));
        Console.WriteLine();


        // Third product order (international)
        // creating list of products
        Product[] products3 = {
            new Product("American Cheese", "123CHEESE", 4.99, 10),
            new Product("American Jeans", "LEVIS09345", 24.99, 5)
        };
        // creating the address for the customer
        Address french_shop = new Address("972 Monte Blanc Boulevard", "Paris", "Île-de-France", "France");
        // creating the customer
        Customer french_man = new Customer("Augustine Le'Clair", french_shop);
        // creating the order
        Order french_order = new Order(products3, french_man);

        // Outputting the order, packing and shipping labels, and final price
        Console.WriteLine("Order 3 - Augustine Le'Clair's Order");
        Console.WriteLine("-----------------------------");
        Console.WriteLine(french_order.createPackingLabel());
        Console.WriteLine();
        Console.WriteLine(french_order.createShippingLabel());
        Console.WriteLine();
        Console.WriteLine(string.Format("Final Price: {0:c}", french_order.getFinalPrice()));
        Console.WriteLine();
    }
}