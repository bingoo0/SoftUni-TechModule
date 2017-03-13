using System;
using System.Collections.Generic;
using System.Linq;


namespace _3.Sort_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < line.Count; i++)
            {
                line.Sort();
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
