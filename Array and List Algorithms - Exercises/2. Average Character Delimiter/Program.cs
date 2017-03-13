using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Average_Character_Delimiter
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();ToList();
            var inputToString = string.Join(StringSplitOptions.RemoveEmptyEntries, input);
            var sum = 0;
            for (int i = 0; i < inputToString.Length; i++)
            {
                sum += inputToString[i];
                      
            }
            sum = sum / inputToString.Length;
            char x = Convert.ToChar(sum);

            x = Convert.ToChar(x.ToString().ToUpper());

            var z = Convert.ToChar(x);

            var substrings = input.Split(z).ToArray();

            Console.WriteLine(string.Join("", substrings));

        }
    }
}
