using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = int.Parse(Console.ReadLine());

            PrintTriagle(number);
        }

        static void PrintTriagle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);

            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
            
            
        }

        static void PrintLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
