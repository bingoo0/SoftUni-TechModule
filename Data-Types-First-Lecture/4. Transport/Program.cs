using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Transport
{
    class Program
    {
        static void Main(string[] args)
        {

            var numPeople = int.Parse(Console.ReadLine());
            var capacity = 4 + 8 + 12;

            var courses = (double)numPeople / (capacity);

            Console.WriteLine(Math.Ceiling(courses));

        }
    }
}
