using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var firstRow = numbers
                .Take(k)
                .Reverse();

            var secondRow = numbers
                .Reverse()
                .Take(k);

            var firstAndSecondRow = firstRow.Concat(secondRow).ToArray();
            var lowerRow = numbers
                .Skip(k)
                .Take(k * 2)
                .ToArray();

            var sum = new int[firstAndSecondRow.Length];

            for (int i = 0; i < firstAndSecondRow.Length; i++)
            {
                sum[i] = firstAndSecondRow[i] + lowerRow[i];
            }
            Console.WriteLine(string.Join(" ", sum));
             
        }
    }
}
