using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.String_Repeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            StringRepeat(name, count);

        }

        static string StringRepeat(string name, int count)
        {
            var result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += name;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
