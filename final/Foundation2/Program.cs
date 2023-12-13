using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address[] OSaddresses = new Address[2];
        Customer[] OScustomers = new Customer[2];
        List<Product>[] OSproductsLists = new List<Product>[2];
        Order[] OSorders = new Order[2];

        //ORDER 1 (USA)
        OSaddresses[0] = new Address("6894 Rovato Place", "Rancho Cucamonga", "California", "USA");
        OScustomers[0] = new Customer("Mr. Rangi Smart", OSaddresses[0]);
        OSproductsLists[0] = new List<Product>();
        OSproductsLists[0].Add(new Product("Climbing Rope", "1234", 15.67f, 2));
        OSproductsLists[0].Add(new Product("64 oz Hydroflask", "1235", 39.99f, 1));
        OSorders[0] = new Order(OScustomers[0], OSproductsLists[0]);

        //ORDER 2 (NOT USA)
        OSaddresses[1] = new Address("64 Faubourg", "Paris", "Ile-de-France", "France");
        OScustomers[1] = new Customer("Averi Bishop", OSaddresses[1]);
        OSproductsLists[1] = new List<Product>();
        OSproductsLists[1].Add(new Product("Yoga Mat", "1236", 11.99f, 3));
        OSproductsLists[1].Add(new Product("Cookbook for two", "1237", 15.55f, 1));
        OSproductsLists[1].Add(new Product("Toaster oven", "1238", 29.99f, 2));
        OSorders[1] = new Order(OScustomers[1], OSproductsLists[1]);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"\n-----CUSTOMER N{i + 1} ORDER-----");
            Console.WriteLine($"PACKING LABEL:\n{OSorders[i].GetPackingLabel()}");
            Console.WriteLine($"SHIPPING LABEL\n{OSorders[i].GetShippingLabel()}");
            Console.WriteLine($"TOTAL COST: ${OSorders[i].GetTotalCost()}");
        }
    }
}