using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Test product", 100.01m, 100, new DateTime(2019, 06, 30));
            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine("Single product object: ");
            Console.WriteLine(json);
            Console.WriteLine(new string('-', 50));

            List<Product> products = new List<Product>()
            {
                new Product(1, "Milk", 2.59m, 100, new DateTime(2019, 06, 30)),
                new Product(2, "Lyutenitsa", 2.39m, 100, new DateTime(2019, 08, 30)),
                new Product(3, "Rice", 1.50m, 100, new DateTime(2020, 03, 30)),
                new Product(4, "Salt", 100.01m, 100, new DateTime(2019, 10, 30)),
            };
            string jsonList = JsonConvert.SerializeObject(products);
            Console.WriteLine("List of products: ");
            Console.WriteLine(jsonList);
            Console.WriteLine(new string('-', 50));

            string jsonSizes = @"['Small', 'Medium', 'Large']";
            JArray a = new JArray(jsonSizes);
            foreach (var item in a)
            {
                Console.WriteLine(item); ;
            }
        }
    }
}
