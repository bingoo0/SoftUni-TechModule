using System;
using System.Linq;


namespace _2.Multiply_an_Array_of_Doubles
{
    class MultipleArray
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var p = double.Parse(Console.ReadLine());

            for (int i = 0; i < number.Length; i++)
            {
                number[i] *= p;
            }

            var result = string.Join(" ", number);
            Console.WriteLine(result);
        }
    }
}
