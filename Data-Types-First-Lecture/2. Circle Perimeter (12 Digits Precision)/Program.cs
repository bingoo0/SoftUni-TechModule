using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Circle_Perimeter__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var perimetur = 2 * Math.PI * radius;

            Console.WriteLine("{0:f12}" , perimetur);
        }
    }
}
