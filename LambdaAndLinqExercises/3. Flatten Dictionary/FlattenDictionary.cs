using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Flatten_Dictionary
{
    class FlattenDictionary
    {
        static void Main()
        {
            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            var input = Console.ReadLine();
            while (input != "end")
            {
               
                
                var inputParameters = input.Split(' ');
                if (inputParameters[0] != "flatten")
                {

                    var key = inputParameters[0];
                    var innerKey = inputParameters[1];
                    var innerValue = inputParameters[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, new Dictionary<string, string>());
                    }

                        dictionary[key][innerKey] = innerValue;

                }
                else
                {
                    var key = inputParameters[1];

                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                input = Console.ReadLine();
            } // end while

            var sortedDict = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in sortedDict)
            {
                Console.WriteLine($"{entry.Key}");

                var count = 0;
                var sortedInnerDict =
                    entry.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var sortedFlattnedDict =
                    entry.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var innerEntry in sortedInnerDict)
                {
                    count++;
                    Console.WriteLine($"{count}. {innerEntry.Key} - {innerEntry.Value}");
                }

                foreach (var flattenedInnerEntry in sortedFlattnedDict)
                {
                    count++;
                    Console.WriteLine($"{count}. {flattenedInnerEntry.Key}");
                }
            }
        }
    }
}
