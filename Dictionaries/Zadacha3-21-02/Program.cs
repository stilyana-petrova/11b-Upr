using System;
using System.Collections.Generic;

namespace Zadacha3_21_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> students = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0]=="exit")
                {
                    foreach (var student in students)
                    {
                        Console.WriteLine($"{student.Key} -> {student.Value}");
                    }
                    break;
                }
                string name = input[0];
                string phone = input[1];
                if (!students.ContainsKey(name))
                {
                    students.Add(name, phone);
                }
                else
                {
                    students[name] = phone;
                }

            }
        }
    }
}
