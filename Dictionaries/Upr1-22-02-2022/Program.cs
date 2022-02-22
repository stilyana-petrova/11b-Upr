using System;
using System.Collections.Generic;

namespace Upr1_22_02_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //JAVA JAVA C# PHP PHP PHP
            Dictionary<string, int> words = new Dictionary<string, int>();
            var input = Console.ReadLine().Split();
            foreach (var word in input)
            {
                if (!words.ContainsKey(word.ToLower()))
                {
                    words.Add(word.ToLower(), 1);
                }
                else
                {
                    words[word.ToLower()] += 1;
                }
            }
            var listOfWords = new List<string>();
            foreach (var word in words)
            {
                if (word.Value%2!=0)
                {
                    listOfWords.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ",listOfWords));
        }
    }
}
