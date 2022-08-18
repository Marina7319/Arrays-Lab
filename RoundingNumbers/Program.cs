using System;
using System.Linq;
namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundNumbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                roundNumbers[i] = (int)Math.Round(input[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{input[i]} => {roundNumbers[i]}");
            }
        }
    }
}
