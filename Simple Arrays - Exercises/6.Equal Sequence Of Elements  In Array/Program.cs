using System;
using System.Linq;
namespace _5.Increasing_Sequence_of_Elements
{
    class IncreasingSequenceOfElements
    {
        static void Main()
        {
            var arrayOfInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool increasing = false;
            for (int i = 0; i < arrayOfInts.Length - 1; i++)
            {
                if (arrayOfInts[i + 1] == arrayOfInts[i])
                {
                    increasing = true;
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }

            }
            if (increasing)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
