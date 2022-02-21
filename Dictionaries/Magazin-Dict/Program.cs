using System;
using System.Collections.Generic;

namespace Magazin_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="stop")
                {
                    foreach (var pr in products)
                    {
                        Console.WriteLine($"{pr.Key} => {pr.Value}");
                    }
                    break;
                }
                //potato 10
                string product = input[0];
                int quantity = int.Parse(input[1]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, quantity);
                }
                else
                {
                    products[product] += quantity;
                }

            }
            
        }
    }
}
