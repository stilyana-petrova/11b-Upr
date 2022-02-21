using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary11b2 = new Dictionary<int, string>();
            dictionary11b2.Add(14, "Maria");
            dictionary11b2.Add(15, "Martin Ivanov");
            dictionary11b2.Add(16, "Martin Petrov");
            dictionary11b2.Add(17, "Martin Stoyanov");

            foreach (var student in dictionary11b2)
            {
                Console.WriteLine($"{student.Key} -> {student.Value}");
            }

            dictionary11b2[17] = "Metodi";

            foreach (var student in dictionary11b2)
            {
                Console.WriteLine($"{student.Key} -> {student.Value}");
            }

            if (!dictionary11b2.ContainsKey(17))
            {
                dictionary11b2.Add(17, "Mira");
            }
            else
            {
                //Console.WriteLine("No");
                dictionary11b2[17] = "Mira";
            }
            foreach (var student in dictionary11b2)
            {
                Console.WriteLine($"{student.Key} -> {student.Value}");
            }
        }
    }
}
