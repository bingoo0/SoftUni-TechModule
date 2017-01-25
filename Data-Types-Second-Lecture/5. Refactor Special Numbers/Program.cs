using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {


            int number = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                var currentNumber = i;
                foreach (var symbol in currentNumber.ToString())
                {
                    var digit = symbol - '0';
                    sum += digit;
                }

                var result = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {result}");
            }

            
        }
    }
}
