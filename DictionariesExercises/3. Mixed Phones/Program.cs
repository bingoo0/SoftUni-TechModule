using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.Mixed_Phones
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();

            var phoneDictionary = new SortedDictionary<string, long>();

            while (line != "Over")
            {
                var tokens = line.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var phoneNumber = 0L;
                if (long.TryParse(firstElement, out phoneNumber))
                {
                    phoneDictionary[lastElement] = phoneNumber;
                }
                else if (long.TryParse(lastElement, out phoneNumber))
                {
                    phoneDictionary[firstElement] = phoneNumber;
                }
                line = Console.ReadLine();
            }

            foreach (var phoneNumbers in phoneDictionary)
            {
                var name = phoneNumbers.Key;
                var phoneNumber = phoneNumbers.Value;

                Console.WriteLine($"{name} -> {phoneNumber}");
            }
        }
    }
}
