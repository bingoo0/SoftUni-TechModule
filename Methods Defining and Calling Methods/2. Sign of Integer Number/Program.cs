using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = int.Parse(Console.ReadLine());

            PrintSign(number);

        }

        static int PrintSign(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if(n < 0)
            {
                Console.WriteLine($"The number {n} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            return n;
        }
    }
}
