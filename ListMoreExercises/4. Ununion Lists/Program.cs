using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ununion_Lists
{
    class Program
    {
        static void Main()
        {
            var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var countOfLists = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfLists ; i++)
            {
                var notPrimalLists = Console.ReadLine().Split().Select(int.Parse).ToList();
                foreach (var nums in notPrimalLists)
                {                
                    if (primalList.Contains(nums))
                    {
                        primalList.Remove(nums);
                    }
                    else
                    {
                        primalList.Add(nums);
                    }
                    var last = notPrimalLists[notPrimalLists.Count - 1];

                    if (last == nums)
                    {
                        primalList.Remove(nums);
                    }
                } // end foreach

            } // end for
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
