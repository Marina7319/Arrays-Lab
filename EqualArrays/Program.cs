using System;
using System.Linq;

namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumFirstArray = 0;
            int sumSecondArray = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                int numbersFirstArray = firstArray[i];
                int numbersSecondArray = secondArray[i];
                sumFirstArray += numbersFirstArray;
                sumSecondArray += numbersSecondArray;
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }
            if (sumFirstArray == sumSecondArray)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumFirstArray}");
            }
        }
    }
}
