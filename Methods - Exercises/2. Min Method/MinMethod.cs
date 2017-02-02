using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Min_Method
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            GetMin(firstNumber, secondNumber, thirdNumber);
        }

        static void GetMin(int first, int second, int third)
        {
            Console.WriteLine(Math.Min(third, Math.Min(first, second)));
        }
    }
}
