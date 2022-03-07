using System;
using System.Collections.Generic;

namespace Email_07_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> emails = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="List")
                {
                    foreach (var email in emails)
                    {
                        Console.WriteLine($"{email.Key} -> {email.Value}");
                    }
                    break;
                }
                switch (input[0])
                {
                    case "Add":
                        {
                            string email = input[1];
                            if (email.Contains("@"))
                            {
                                if (!emails.ContainsKey(email))
                                {
                                    emails.Add(email, 0);
                                }
                                else
                                {
                                    Console.WriteLine($"{email} already exists!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Input is not correct!");
                            }
                            break;
                        }
                    case "Receive":
                        {
                            string email = input[1];
                            int count = int.Parse(input[2]);
                            if (email.Contains("@"))
                            {
                                if (!emails.ContainsKey(email))
                                {
                                    emails.Add(email, count);
                                }
                                else
                                {
                                    emails[email] += count;
                                }
                            }
                            break;
                        }
                    case "Sent":
                        {
                            string email = input[1];
                            int count = int.Parse(input[2]);
                            if (emails.ContainsKey(email))
                            {
                                if (emails[email]>=count)
                                {
                                    emails[email] -= count;
                                }
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
