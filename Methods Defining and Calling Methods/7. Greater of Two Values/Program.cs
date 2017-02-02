﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greater_of_Two_Values
{
    class Program
    {


        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            PrintMax(type);

        } // end method

        private static void PrintMax(string type)
        {
            switch (type)
            {
                case "int":
                    {
                        var first = int.Parse(Console.ReadLine());
                        var second = int.Parse(Console.ReadLine());

                        var greater = GetMax(first, second);
                        Console.WriteLine(greater);

                        break;
                    }
                case "string":
                    {
                        var first = Console.ReadLine();
                        var second = Console.ReadLine();

                        var greater = GetMax(first, second);
                        Console.WriteLine(greater);

                        break;
                    }
                case "char":
                    {
                        var first = char.Parse(Console.ReadLine());
                        var second = char.Parse(Console.ReadLine());

                        var greater = GetMax(first, second);
                        Console.WriteLine(greater);

                        break;
                    }

            } // end switch
        }

        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            return second;
        }

        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }
    }
}
