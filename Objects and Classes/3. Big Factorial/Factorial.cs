using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _3.Big_Factorial
{
    class Factorial
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i > 1 ; i--)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
