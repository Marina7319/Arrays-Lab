using System;

namespace PrintNumbersinReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int j = numbers.Length - 1; j >= 0; j--)
            {
                Console.Write($"{numbers[j]} ");
            }
        }
    }
}
