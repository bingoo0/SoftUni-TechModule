using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<int, Dictionary<int, int>>();

            while (input != "end")
            {
                var token = input.Split(' ');
                var firstInt = int.Parse(token[0]);
                var secondInt = int.Parse(token[1]);
                var thirthInt = int.Parse(token[2]);

                AddToDictionary(dictionary, firstInt, secondInt, thirthInt);

                input = Console.ReadLine();
            }

            foreach (var kvp in collection)
            {

            }
        }
    }
}
