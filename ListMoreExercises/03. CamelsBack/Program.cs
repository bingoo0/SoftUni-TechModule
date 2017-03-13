using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CamelsBack
{
    class Program
    {
        static void Main()
        {
            var buildings = Console.ReadLine().Split().Select(int.Parse).ToList();

            var camelBack = int.Parse(Console.ReadLine());
            var rounds = 0;
            while (buildings.Count > camelBack)
            {
                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
                rounds++;
            }

            
            if (rounds == 0)
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
        }
    }
}
