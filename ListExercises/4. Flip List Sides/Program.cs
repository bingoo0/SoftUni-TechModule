using System;
using System.Collections.Generic;
using System.Linq;


namespace _4.Flip_List_Sides
{
    class Program
    {
        static void Main()
        {
            var listOne = Console.ReadLine().Split(' ').ToList();
            listOne.Reverse();

            var first = listOne[0];
            var last = listOne[listOne.Count - 1];

            listOne[0] = last;
            listOne[listOne.Count - 1] = first;

            Console.WriteLine(string.Join(" ", listOne));
        }
    }
}
