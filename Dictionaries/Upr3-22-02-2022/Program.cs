using System;
using System.Collections.Generic;

namespace Upr3_22_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input =="stop")
                {
                    foreach (var product in products)
                    {
                        Console.WriteLine($"{product.Key} -> {product.Value}");
                    }
                    break;
                }
                string productName = input;
                int quantity = int.Parse(Console.ReadLine());
                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, quantity);
                }
                else
                {
                    products[productName] += quantity;
                }
            }
        }
    }
}
