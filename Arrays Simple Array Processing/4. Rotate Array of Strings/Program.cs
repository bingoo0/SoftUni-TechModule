using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();

            var rotatedArray = new string[array.Length];
            rotatedArray[0] = array[array.Length - 1];

            for (int i = 0; i < array.Length - 1; i++)
            {
                  rotatedArray[i + 1] = array[i];
            }

            

            var result = string.Join(" ", rotatedArray);
            Console.WriteLine(result);
        }
    }
}
