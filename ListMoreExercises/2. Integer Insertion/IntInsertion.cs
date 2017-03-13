using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Integer_Insertion
{
    class IntInsertion
    {
        static void Main()
        {
            var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();

            
                var otherLists = Console.ReadLine();
                while (otherLists != "end")
                {
                  int firstDigit = (otherLists.ToString()[0]) - 48;
                      primalList.Insert(firstDigit, int.Parse(otherLists));
                      otherLists = Console.ReadLine();
                }
                 Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
