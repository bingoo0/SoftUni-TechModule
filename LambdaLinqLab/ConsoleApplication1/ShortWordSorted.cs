using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApplication1
{
    class ShortWordSorted
    {
        static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new char[]
                {'.',',',':',';','(',')','(',')','\\','\"','\'','/','!','?',' '})
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
