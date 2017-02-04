using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Integer_to_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            var converted = IntToBase(number, toBase);
            Console.WriteLine(converted);
        }

        static string IntToBase(int number, int toBase)
        {
            var result = string.Empty;

            while(number > 0)
            {
                var remainder = number % toBase;       
                number /= toBase;
                result = remainder + result;
            }
            return result;
        }
    }
}
