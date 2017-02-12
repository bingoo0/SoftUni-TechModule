using System;
using System.Linq;

namespace _4.CountOccurrencesOfLargerNumbersInArray
{
    class CountOfLargerNums
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var p = double.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var current = numbers[i];
                if (current > p)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
