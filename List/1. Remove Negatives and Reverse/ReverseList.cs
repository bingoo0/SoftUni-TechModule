using System;
using System.Collections.Generic;
using System.Linq;


namespace _1.Remove_Negatives_and_Reverse
{
    class ReverseList
    {
        static void Main()
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
    
            number.Reverse();

                foreach (var numbers in number)
                {
                    if (numbers >= 0)
                    {
                        Console.Write(numbers + " ");
                    }             
                }        
            }
        }
    }

