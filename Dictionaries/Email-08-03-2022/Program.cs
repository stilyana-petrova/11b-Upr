using System;

namespace Email_08_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string[] words = email.Split('@');
            if (words.Length>0)
            {
                int a = int.Parse(email);
                
            }
        }
    }
}
