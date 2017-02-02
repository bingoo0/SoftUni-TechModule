using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = long.Parse(Console.ReadLine());
            var power = long.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(number, power)); 

        }

        static long MathPower(long number, long power)
        {
            var result = 1L;

            for (long i = 0; i < power; i++)
            {
                result *= number;   
            }
            return result;
        }
    }
}
