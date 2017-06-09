using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2.Cards
{
   public class Cards
    {
       public static void Main()
        {
            var cardsInput = Console.ReadLine();

            var pattern = @"([1]?[0-9JKAQ])([SHDC])";
            var regex = new Regex(pattern);

            var matches = regex.Matches(cardsInput);

            var cards = new List<string>();
            foreach (Match match in matches)
            {
                var power = 0;
                if (int.TryParse(match.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }   
                }
                cards.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ", cards));
        }
    }
}
