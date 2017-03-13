
namespace _2.Dict_Ref_Advanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class DictRefAdvanced
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dictRef = new Dictionary<string, List<string>>();
            var separetors = new char[] { '>', ' ', ',' };
            while (input != "end")
            {
                var tokens = input.Split('-').ToList();
                var name = tokens[0].Trim();
                var value = tokens[1].Split(separetors, StringSplitOptions.RemoveEmptyEntries).ToList();

                var result = 0;
                if (int.TryParse(value[0], out result))
                {
                    if (!dictRef.ContainsKey(name))
                    {
                        dictRef[name] = new List<string>();
                    }
                    dictRef[name].AddRange(value);
                }
                else
                {
                    if (dictRef.ContainsKey(value[0]))
                    {
                        dictRef[name] = new List<string>();
                        dictRef[name].AddRange(dictRef[value[0]]);
                    }
                }

                input = Console.ReadLine();
            } // end while

            foreach (var kvp in dictRef)
            {
                var names = kvp.Key;
                var grades = kvp.Value;

                Console.WriteLine($"{names} === {string.Join(", ", grades)}");
            }
        }
    }
}
