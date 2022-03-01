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
                if (command[0] =="Purchase")
                {
                    string toy = command[1];
                    int q = int.Parse(command[2]);
                    
                    if (!toys.ContainsKey(toy))
                    {
                        if (toy.StartsWith("d"))
                        {
                            toys.Add(toy, q);
                        }
                        else
                        {
                            Console.WriteLine("Input is not correct!");
                        }
                    }
                    else
                    {
                        toys[toy] += q;
                    }
                   
                }
                if (command[0] == "Sale")
                {                  
                    string toy = command[1];

                    if (toys.ContainsKey(toy))
                    {
                        foreach (var item in toys)
                        {
                            int q = item.Value;
                            q = 0;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{toy} does not exists!");
                    }
                    foreach (var item in toys)
                    {
                        int q = item.Value;
                        if (q==0)
                        {
                            Console.WriteLine("Sale is not allowed!");
                        }
                    }
                    
                    
                }
                if (command[0] =="All sale")
                {
                    int i = 0;
                    foreach (var item in toys)
                    {
                        int q=item.Value;
                        q = i;
                    }
                }
            }
        }
    }
}
