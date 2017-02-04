using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < number; i++)
            {
                var currentChar = char.Parse(Console.ReadLine());
                var encrypted = Encrypted(currentChar);

                result += encrypted;
            }
            Console.WriteLine(result);
        }

        static string Encrypted(char currentChar)
        {
            var asciiCode = (int)currentChar;

            var firstDigit = GetFirstDigit(asciiCode);
            var lastDigit =  GetLastDigit(asciiCode);

            var firstSymbol = (char)(asciiCode + lastDigit);
            var secondSybol = (char)(asciiCode - firstDigit);

            var result = $"{firstSymbol}{firstDigit}{lastDigit}{secondSybol}";

            return result;
        } // end method

        static int GetLastDigit(int asciiCode)
        {
            var lastDigit = asciiCode % 10;

            return lastDigit;
        }

        static int GetFirstDigit(int asciiCode)
        {
            var firstDigit = asciiCode;

            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            return firstDigit;
        }
    }
}
