using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Distinct_List
{
    class DistinctList
    {
        static void Main()
        {
            var lineOfNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            var newList = new List<int>();
            newList.Add(lineOfNums[0]);

            for (int i = 1; i < lineOfNums.Count; i++)
            {
                if (newList.Contains(lineOfNums[i]))
                {
                    continue;
                }
                else
                {
                    newList.Add(lineOfNums[i]);
                }               
            }
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
