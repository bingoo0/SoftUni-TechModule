using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            var index = int.Parse(Console.ReadLine());

            var digit =  FindNthDigit(number, index);
            Console.WriteLine(digit);
        }

        static int FindNthDigit(long number, int index)
        {
            var currentIndex = 1;

            while (number > 0)
            {

                if (currentIndex == index)
                {
                    return (int)(number % 10);
                }
                currentIndex++;
                number /= 10;
            } // end while

            return (int)(number % 10);
        } // end method
    }
}
