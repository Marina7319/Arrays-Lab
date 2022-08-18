using System;
using System.Linq;
namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(separator: ' ').Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNums = numbers[i];
                if (currentNums % 2 == 0)
                {
                    evenSum += currentNums;
                }
                else
                {
                    oddSum += currentNums;
                }
            }
            Console.WriteLine(evenSum - oddSum);
        }
    }
}
