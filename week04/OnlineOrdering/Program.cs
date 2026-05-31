using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("El criollo 1318", "General Rodriguez", "Buenos Aires", "Argentina");
        Customer customer1 = new Customer("Thomas Gomez", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Computer", "CCP1137663738", 35, 1));
        order1.AddProduct(new Product("Printer", "TTP1137663738", 20, 2));

        Address address2 = new Address("Franklin 1594", "Beverly Hills", "California", "USA");
        Customer customer2 = new Customer("Ryan Brattz", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Shoes", "NIK1137662456", 40, 1));
        order2.AddProduct(new Product("T-Shirt", "NAW1137394875", 20, 1));
        order2.AddProduct(new Product("Pants", "OCN1137123456", 20, 1));

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        foreach (Order element in orders)
        {
            Console.WriteLine($"Packing Label: \n{element.GetPackingLabel()}");
            Console.WriteLine($"Shipping Label: \n{element.GetShippingLabel()}");
            Console.WriteLine();
            Console.WriteLine($"Total Cost: ${element.GetTotalCost()} USD");
            Console.WriteLine("__________  __________  __________  __________  __________  __________  __________  __________  __________  __________  _________");

        }
    }
}