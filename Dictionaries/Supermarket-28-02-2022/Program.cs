using System;
using System.Collections.Generic;

namespace Supermarket_28_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productPrice = new Dictionary<string, double>();
            Dictionary<string, int> productCount = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "stocked")
                {
                    break;
                }
                string productName = input[0];
                double price = double.Parse(input[1]);
                int count = int.Parse(input[2]);
                if (!productPrice.ContainsKey(productName))
                {
                    productPrice.Add(productName, price);
                    productCount.Add(productName, count);
                }
                else
                {
                    productPrice[productName] = price;
                    productCount[productName] += count;
                }
            }
            double grandTotal = 0.00;
            foreach (var product in productPrice)
            {
                string productName = product.Key;
                double price = product.Value;
                int count = productCount[productName];
                Console.WriteLine($"{productName}: ${price:F2} * {count} = ${price * count:F2}");
                grandTotal += price * count;
            }
            Console.WriteLine($"Grand Total: ${grandTotal:F2}");

        }
    }
}
