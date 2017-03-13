using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main()
        {
            var myList = Console.ReadLine().Split(' ').ToList();
            var evenList = new List<string>();

            for (int i = 0; i < myList.Count; i++)
            {
                if (i % 2 != 0)
                {
                    evenList.Add(myList[i]);
                }
            }
            Console.WriteLine(string.Join("", evenList));
        }
    }
}
