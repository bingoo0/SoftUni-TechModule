using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Smallest_Element_in_Array
{
    class Program
    {
        static void Main()
        {
            var listOfInts = Console.ReadLine().Split().Select(int.Parse).ToList();

            var smallestElements = int.MaxValue;

            foreach (var number in listOfInts)
            {
                if (number < smallestElements)
                {
                    smallestElements = number;
                }
            }
            Console.WriteLine(smallestElements);
        }
    }
}
