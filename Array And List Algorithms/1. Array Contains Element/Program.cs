using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var containedElement = int.Parse(Console.ReadLine());
            var isTrue = false;
            foreach (var number in numbers)
            {
                if (number == containedElement)
                {
                    Console.WriteLine("yes");
                    isTrue = true;
                    break;
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("no");
            }
        }
    }
}
