using System;
using System.Collections.Generic;

namespace Clothes_07_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> clothesColor = new Dictionary<string, string>();
            Dictionary<string, int> clothesCount = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="Show")
                {
                    break;
                }
                switch (input[0])
                {
                    case "AddColor":
                        {
                            string clothes = input[1];
                            string color = input[2];
                            if (clothes.StartsWith("t"))
                            {
                                if (!clothesColor.ContainsKey(clothes)) 
                                {
                                    clothesColor.Add(clothes, color);
                                    clothesCount.Add(clothes, 1);
                                }
                                else
                                {
                                    clothesColor[clothes] = color;
                                    clothesCount[clothes] += 1;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input!");
                            }
                            break;
                        }
                    case "AddQuantity":
                        {
                            string cloth = input[1];
                            int count = int.Parse(input[2]);
                            if (clothesColor.ContainsKey(cloth))
                            {
                                clothesCount[cloth] += count;
                            }
                            break;
                        }
                    case "Remove":
                        {
                            string clothes = input[1];
                            int count = int.Parse(input[2]);
                            if (clothesCount.ContainsKey(clothes))
                            {
                                if (count>=clothesCount[clothes])
                                {
                                    Console.WriteLine("Not enough quantity!");
                                }
                                else
                                {
                                    clothesCount[clothes] -= count;
                                }
                            }
                            break;
                        }
                    case "Empty":
                        {
                            foreach (var item in clothesCount)
                            {
                                clothesCount[item.Key] = 0;
                            }
                            foreach (var item in clothesColor)
                            {
                                clothesColor[item.Key] = "blank";
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            int grandTotal = 0;
            foreach (var item in clothesCount)
            {
                string name = item.Key;
                int count = item.Value;
                string color = clothesColor[name];
                Console.WriteLine($"{name}: {color} - {count}");
                grandTotal += count;
            }
            Console.WriteLine($"Grand Total: {grandTotal}");
        }
    }
}
