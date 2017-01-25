using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _3.Exact_Product_of_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            decimal product = 1m;

            for (int i = 0 ; i < number; i++)
            {
                 product *= decimal.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(product);
        }
    }
}
