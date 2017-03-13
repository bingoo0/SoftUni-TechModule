using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Array_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            var foundWords = new List<string>();
            var wordsCount = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                if (foundWords.Contains(currentWord))
                {
                    var wordIndex = foundWords.IndexOf(currentWord);
                    wordsCount[wordIndex]++;
                }
                else
                {
                    foundWords.Add(currentWord);
                    wordsCount.Add(1);
                }
            } // end for

            SortElements(foundWords, wordsCount, words);
            PrintElements(words, foundWords, wordsCount);
        }

        private static void PrintElements(string[] words, List<string> foundWords, List<int> wordsCount)
        {
            for (int i = 0; i < foundWords.Count; i++)
            {

                var percentage = (wordsCount[i] * 100.0) / words.Length;
                Console.WriteLine($"{foundWords[i]} -> {wordsCount[i]} times ({percentage:F2}%)");
            }
        }

        static void SortElements(List<string> foundWords, List<int> wordsCount, string[] words)
        {
            bool swape = false;
            while (swape)
            {
                for (int i = 0; i < wordsCount.Count; i++)
                {                   
                    var temp = wordsCount[i];
                    wordsCount[i] = wordsCount[i + 1];
                    wordsCount[i + 1] = temp;

                    var tempString = foundWords[i];
                    foundWords[i] = foundWords[i + 1];
                    foundWords[i + 1] = tempString;
                    if (wordsCount.Count - 1 == foundWords.Count - 1)
                    {
                        temp = wordsCount[i];
                        wordsCount[i] = wordsCount[i + 1];
                        wordsCount[i + 1] = temp;

                        tempString = foundWords[i];
                        foundWords[i] = foundWords[i + 1];
                        foundWords[i + 1] = tempString;
                        swape = true;
                    }
                    
                }
               
                
            }
        }
    }
}
