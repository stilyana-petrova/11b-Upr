using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                }
                if (int.TryParse(command, out int n)== true)
                {
                    numbers.Sort();
                    Console.WriteLine(string.Join(" ", numbers));
                }
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "add":
                        int index1 = int.Parse(tokens[1]);
                        int num2 = int.Parse(tokens[2]);
                        if (!numbers.Contains(num2))
                        {
                            numbers.Insert(index1, num2);
                        }
                        break;

                    case "contains":
                        int numberrToSearch = int.Parse(tokens[1]);
                        if (numbers.Contains(numberrToSearch))
                        {
                            Console.WriteLine(numbers.IndexOf(numberrToSearch));
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }
                        break;

                    case "remove":
                        int index2 = int.Parse(tokens[1]);
                        if (index2<0 || index2>=numbers.Count)
                        {
                            Console.WriteLine("Index is not correct!");
                        }
                        else
                        {
                            numbers.RemoveAt(index2);
                        }
                        break;
                    case "swap":
                        int fE = int.Parse(tokens[1]);
                        int indexOfFE = numbers.IndexOf(fE);

                        int sE = int.Parse(tokens[2]);
                        int indexOfSE = numbers.IndexOf(sE);

                        int temp = fE;
                        numbers[indexOfFE] = sE;
                        numbers[indexOfSE] = temp;
                        break;
                    

                    default:
                        break;
                }

            }
        }
    }
}
