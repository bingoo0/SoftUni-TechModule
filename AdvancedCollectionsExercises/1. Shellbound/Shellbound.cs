
namespace _1.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Shellbound
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regionOfShells = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var token = input.Split();
                var region = token[0];
                var countOfShells = int.Parse(token[1]);

                if (!regionOfShells.ContainsKey(region))
                {
                    regionOfShells[region] = new HashSet<int>();
                }
                regionOfShells[region].Add(countOfShells);

                input = Console.ReadLine();
            }

            foreach (var kvp in regionOfShells)
            {
                var region = kvp.Key;
                var shells = kvp.Value;
                var average = shells.Sum() - (shells.Sum() / shells.Count());
                Console.WriteLine($"{region} -> {string.Join(", ", shells)} ({average})");
            }
        }
    }
}
