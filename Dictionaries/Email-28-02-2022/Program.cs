using System;
using System.Collections.Generic;

namespace Email_28_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (true)
            {
                var command = Console.ReadLine().Split();
                if (command[0]=="Stop")
                {
                    break;
                }
                if (command[0]=="Add")
                {
                    var name = command[1];
                    var email = command[2];
                    if (!emails.ContainsKey(name))
                    {
                        emails.Add(name, email);
                    }
                    else
                    {
                        emails[name] = email;
                    }               
                }
                if (command[0]=="Sent")
                {
                    foreach (var item in emails)
                    {
                        var name = command[1];
                        var email = item.Value;
                        if (emails.ContainsKey(name))
                        {
                            Console.WriteLine($"{name} -> {email}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exists.");
                        }
                    }                   
                }
            }
            foreach (var email in emails)
            {
                string name = email.Key;
                string em = email.Value;
                Console.WriteLine($"{name} -> {em}");
            }
        }
    }
}
