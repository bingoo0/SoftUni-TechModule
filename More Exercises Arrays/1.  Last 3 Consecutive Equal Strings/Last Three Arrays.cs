using System;

namespace _1.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ');

            var count = 1;
            for (int i = words.Length - 1; i > 0 ; i--)
            {
                if (words[i] == words[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count == 3)
                {
                    Console.WriteLine($"{words[i]} {words[i]} {words[i]}");
                    break;
                }
            }
        }
    }
}
