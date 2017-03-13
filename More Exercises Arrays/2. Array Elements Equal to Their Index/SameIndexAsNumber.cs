using System;
using System.Linq;


namespace _2.Array_Elements_Equal_to_Their_Index
{
    class SameIndexAsNumber
    {
        static void Main()
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var index = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (i == number[i])
                {
                    Console.Write(number[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
