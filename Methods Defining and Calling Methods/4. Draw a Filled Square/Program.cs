using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = int.Parse(Console.ReadLine());

            PrintFigure(number);
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        } //end method


        static void PrintMiddleRow(int n)
        {
            
            Console.Write("-");
            for (int i = 0; i <= n - 2; i++)
            {
                Console.Write(@"\/");
            }
            Console.WriteLine("-");
         
        } // end method

        static void PrintFigure(int n)
        {
            PrintHeader(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddleRow(n);
            }
            PrintHeader(n);
        } // end method
    }
}
