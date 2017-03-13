using System;
using System.Linq;

namespace _05.Char_Rotation
{
    class CharRotation
    {
        static void Main()
        {
            var arrayOfChars = Console.ReadLine().ToCharArray().ToArray();
            var arrayOfInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string result = string.Empty;
            for (int i = 0; i < arrayOfChars.Length; i++)
            {
                if (arrayOfInts[i] % 2 == 0)
                {
                    result += (char)(arrayOfChars[i] - arrayOfInts[i]);
                }
                else
                {
                    result += (char)(arrayOfChars[i] + arrayOfInts[i]); ;
                 
                }
            }
            Console.WriteLine(result);
        }
    }
}
