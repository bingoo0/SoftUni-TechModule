using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAndLinqMoreExercises
{
    class LambdaExpressions
    {
       public static void Main()
        {
            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            var input = Console.ReadLine();

            while (input != "lambada")
            {
                var whileInput = input.Split(new[] { "=", ">", ".", " "}, StringSplitOptions.RemoveEmptyEntries);

                

                if (whileInput.Length > 1)
                {
                    var selector = whileInput[0];
                    var selectorObject = whileInput[1];
                    var property = whileInput[2];

                    if (!dictionary.ContainsKey(selector))
                    {
                        dictionary.Add(selector, new Dictionary<string, string>());
                    }
                    dictionary[selector][selectorObject] = property;

                }
                else
                {
                    dictionary = dictionary
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                        .ToDictionary(selectorObject => selectorObject.Key, selectorObject => selector.Key + "." + selectorObject.Value));
                }
                input = Console.ReadLine();
            } // end while

            foreach (var selector in dictionary)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
}
