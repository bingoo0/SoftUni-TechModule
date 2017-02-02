using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            var weight = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            Console.WriteLine(PrintTriangleArea(weight, height)); 
        }

        static double PrintTriangleArea(double weight, double height)
        {
            return weight * height / 2;
        }
    }
}
