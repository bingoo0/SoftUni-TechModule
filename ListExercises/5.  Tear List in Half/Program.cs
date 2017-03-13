using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Tear_List_in_Half
{
    class Program
    {
        static void Main()
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            
            var firstHalf = new List<int>();
            for (int i = 0; i < list.Count / 2; i++)
            {
                firstHalf.Add(list[i]);
            }
            var secondHalf = new List<int>();
            list.Reverse();
            for (int i = 0; i < list.Count / 2; i++)
            {       
                secondHalf.Add(list[i]);
            }

            secondHalf.Reverse();
            var digitList = new List<int>();
            for (int i = 0; i < firstHalf.Count; i++)
            {              
                digitList.Add(secondHalf[i] / 10);
                digitList.Add(firstHalf[i]);
                digitList.Add(secondHalf[i] % 10);
            }
            Console.WriteLine(string.Join(" ", digitList));
        }
    }
}
