using System;
using System.Collections.Generic;
using System.Linq;

namespace Izpitvane
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="Stop")
                {
                    Console.WriteLine(string.Join(" ", names));
                    break;
                }
                if (int.TryParse(command,out int n)==true )
                {
                    names.Sort();
                    Console.WriteLine(string.Join(" ", names));
                    break;
                }
                string[] str = command.Split();
                switch (str[0])
                {
                    case "add":
                        string element = str[1];
                        if (!names.Contains(element))
                        {
                            names.Add(element);
                        }
                        else
                        {
                            Console.WriteLine("Element already exists!");
                        }
                        break;

                    case "contains":
                        string element2 = str[1];
                        if (names.Contains(element2))
                        {
                            Console.WriteLine(names.IndexOf(element2));
                        }
                        break;

                    case "insert":
                        int index = int.Parse(str[1]);
                        int x = names.Count();
                        
                        for (int i = 0; i < x; i++)
                        {
                            //names.Insert(x, names[x]);
                            Console.WriteLine(string.Join($"{x}-", names));
                        }
                        
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", names));
                        break;

                    default: break;
                }
            }
        }
    }
}
