using System;
using System.Linq;

namespace _1Zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command=="distinct")
                {
                    array = array.Distinct().ToArray();
                }
                if (command=="reverse")
                {
                    array = array.Reverse().ToArray();
                }
                if (command=="replace")
                {
                    int index = int.Parse(cmd[1]);
                    string newString=cmd[2];
                    array[index] = newString;
                }
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
