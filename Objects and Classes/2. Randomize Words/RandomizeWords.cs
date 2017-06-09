using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Randomize_Words
{
    class RandomizeWords
    {
        static void Main()
        {
            var inputWords = Console.ReadLine().Split().ToList();

            Random rand = new Random();

            for (int i = 0; i < inputWords.Count; i++)
            {
                var currentWord = inputWords[i];
                var randomPosition = rand.Next(0, inputWords.Count);

                var tempWord = inputWords[randomPosition];
                inputWords[randomPosition] = currentWord;
                inputWords[i] = tempWord;
            }
            foreach (var kvp in inputWords)
            {
                Console.WriteLine(kvp);
            }
        }
    }
}
