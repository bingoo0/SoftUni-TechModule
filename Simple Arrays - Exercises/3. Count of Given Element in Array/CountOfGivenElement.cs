using System;
using System.Linq;

namespace _3.Count_of_Given_Element_in_Array
{
    class CountOfGivenElement
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var existedTimes = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (existedTimes == numbers[i])
                {
                    count++;
                }
            } // end for

            Console.WriteLine(count);
        }
    }
}
