using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.Decode_Radio_Frequencies
{
    class RadioFrequencies
    {
        static void Main()
        {
            var frequencies = Console.ReadLine().Split().ToList();

            var addFrequencies = new List<char>();
            for (int i = 0; i < frequencies.Count; i++)
            {
               
                var element = frequencies[i].Split('.');

                var leftPart = Convert.ToInt32(element[0]);
                var rightPart = Convert.ToInt32(element[1]);

                var convertLeftPart = Convert.ToChar(leftPart);
                var convertRightPart = Convert.ToChar(rightPart);

                if (leftPart != 0)
                {
                    addFrequencies.Insert(i, convertLeftPart);
                }
                if (rightPart != 0)
                {
                    addFrequencies.Insert(addFrequencies.Count - i, convertRightPart);
                }
                
                
            }
            Console.WriteLine(string.Join("", addFrequencies));
        }
                
        }
    }
