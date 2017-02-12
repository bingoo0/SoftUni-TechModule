using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minNumberSoFar = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                if (currentNumber < minNumberSoFar)
                {
                    minNumberSoFar = currentNumber;
                }
            }

            Console.WriteLine(minNumberSoFar);
        }
    }
}
