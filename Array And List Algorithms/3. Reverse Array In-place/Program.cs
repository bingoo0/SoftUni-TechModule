using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Reverse_Array_In_place
{
    class Program
    {
        static void Main()
        {
            var listOfInts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
            for (int i = 0; i < listOfInts.Length / 2; i++)
            {
                var leftIndex = i;
                var rightIndex = listOfInts.Length - 1 - i;

                var temp = listOfInts[leftIndex];
                listOfInts[leftIndex] = listOfInts[rightIndex];
                listOfInts[rightIndex] = temp;
            }
            foreach (var reversNumbers in listOfInts)
            {
                Console.Write(reversNumbers + " ");
            }
            Console.WriteLine();
        }
    }
}
