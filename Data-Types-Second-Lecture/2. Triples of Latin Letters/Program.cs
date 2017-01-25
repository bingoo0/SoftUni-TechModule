using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number ; i++)
            {
                for (int j = 0; j < number ; j++)
                {
                    for (int k = 0; k < number ; k++)
                    {
                        var firstLetter = (char)(i + 'a');
                        var secondLetter = (char)(j + 'a');
                        var thirthLetter = (char)(k + 'a');

                        Console.WriteLine($"{firstLetter}{secondLetter}{thirthLetter}");
                    }
                }
            }

        }
    }
}
