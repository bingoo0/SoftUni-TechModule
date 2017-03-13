using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Odd_Occurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var occurrences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!occurrences.ContainsKey(word))
                {
                    occurrences[word] = 0;
                }
                occurrences[word]++;
            }

            var oddNumbers = new List<string>();

            foreach (var kvp in occurrences)
            {
                var value = kvp.Value;

                if (value % 2 != 0)
                {
                    oddNumbers.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddNumbers));
        }
    }
}
