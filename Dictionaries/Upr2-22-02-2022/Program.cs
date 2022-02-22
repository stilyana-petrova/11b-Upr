using System;
using System.Collections.Generic;

namespace Upr2_22_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phones = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="END")
                {
                    break;
                }
                if (input[0]=="A")
                {
                    string name = input[1];
                    string phone = input[2];
                    if (!phones.ContainsKey(name))
                    {
                        phones.Add(name, phone);
                    }
                    else
                    {
                        phones[name] = phone;
                    }
                }
                if (input[0]=="S")
                {
                    string name = input[1];
                    if (!phones.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {phones[name]}");
                    }
                }
            }
        }
    }
}
