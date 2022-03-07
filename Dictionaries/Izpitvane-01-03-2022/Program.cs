using System;
using System.Collections.Generic;

namespace Izpitvane_01_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> toys = new Dictionary<string, int>();
            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0] == "Stop")
                {
                    foreach (var item in toys)
                    {
                        string toy = item.Key;
                        int q = item.Value;
                        Console.WriteLine($"{toy} -> {q}");
                    }
                    break;
                }
                switch (command[0])
                {
                    case "Purchase":
                        {
                            string toy = command[1];
                            int count = int.Parse(command[2]);

                            if (toy.StartsWith("d"))
                            {
                                if (!toys.ContainsKey(toy))
                                {
                                    toys.Add(toy, count);
                                }
                                else
                                {
                                    toys[toy] += count;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input is not correct!");
                            }
                            break;
                        }
                    case "Sale":
                        {
                            string toy = command[1];

                            if (!toys.ContainsKey(toy))
                            {
                                Console.WriteLine($"{toy} does not exists!");
                            }
                            else
                            {
                                if (toys[toy] > 0)
                                {
                                    toys[toy]--;
                                }
                                else
                                {
                                    Console.WriteLine("Sale is not allowed!");
                                }
                            }
                            break;
                        }
                    case "All sale":
                        {
                            foreach (var item in toys)
                            {
                                toys[item.Key] = 0;
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
        }
    }
}
