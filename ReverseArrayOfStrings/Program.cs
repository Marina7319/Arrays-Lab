using System;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
