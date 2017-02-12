using System;
using System.Linq;
namespace _8.Array_Symmetry
{
    class ArraySymmetry
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ');

            bool isTrue = true;
            for (int i = 0; i < words.Length / 2; i++)
            {
                var firstWord = words[i];
                var secondWord = words[words.Length - 1 - i];

                if (firstWord != secondWord)
                {
                    isTrue = false;
                    break;
                }
            }

            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");       
            }
        }
    }
}
