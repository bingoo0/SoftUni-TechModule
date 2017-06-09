using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Fish_Statistics
{
    public class FishStatistics
    {
        public static void Main(string[] args)
        {
            var inputFishes = Console.ReadLine();
            var pattern = @"([>]*)[<]([(])+(['x-])[>]";

            var regex = new Regex(pattern);

            var matches = regex.Matches(inputFishes);
            var count = 0;
            var tailType = string.Empty;
            foreach (Match match in matches)
            {
                var tailLenght = match.Groups[1].Length * 2;
                if (tailLenght > 1)
                {
                    tailType = "Medium";
                }
                else if (tailLenght == 1)
                {
                    tailType = "Short";
                }
                else if (tailLenght >= 5)
                {
                    tailType = "Long";
                }
                else
                {
                    tailType = "None";
                }

                count++;
                Console.WriteLine("Fish "+ count + ": " + string.Join(" ", match.Value));
                Console.WriteLine($"Tail type: {tailType} ({tailLenght})");
            }
        }
    }
}
