using System;
using System.Linq;
namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(separator: ' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNums = numbers[i];
                if (currentNums % 2 == 0)
                {
                    sum += currentNums;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
