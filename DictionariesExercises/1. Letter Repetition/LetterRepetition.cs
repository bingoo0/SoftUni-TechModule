using System;
using System.Collections.Generic;
using System.Linq;


namespace _1.Letter_Repetition
{
    class LetterRepetition
    {
        static void Main()
        {
            var characters = Console.ReadLine();

            var asciiDictionary = new Dictionary<char, int>();

            foreach (var character in characters)
            {
                if (!asciiDictionary.ContainsKey(character))
                {
                    asciiDictionary[character] = 0;
                }
                asciiDictionary[character]++;
            }
            
            foreach (var kvp in asciiDictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
