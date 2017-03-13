using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Dict_Ref
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();

            var dictRef = new Dictionary<string, int>();

            while (line != "end")
            {
                var tokens = line.Split();
                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    dictRef[firstElement] = number;
                }
                else
                {
                    if (dictRef.ContainsKey(lastElement))
                    {
                        dictRef[firstElement] = dictRef[lastElement];
                        dictRef[lastElement] = dictRef[firstElement];

                    }
                }
                line = Console.ReadLine();
            } // end while

            foreach (var kvp in dictRef)
            {
                var item = kvp.Key;
                var cash = kvp.Value;

                Console.WriteLine($"{item} === {cash}");
            }
        }
    }
}
