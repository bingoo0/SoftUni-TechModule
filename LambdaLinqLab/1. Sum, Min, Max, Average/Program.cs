using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var myList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                myList.Add(input);
            }

            var max = myList.Max();
            var min = myList.Min();
            var average = myList.Average();
            var sum = myList.Sum();

            Console.WriteLine($"{sum}");
            Console.WriteLine($"{min}");
            Console.WriteLine($"{max}");
            Console.WriteLine($"{average}");
        }
    }
}
