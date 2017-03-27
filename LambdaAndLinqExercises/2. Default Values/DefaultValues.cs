
namespace _2.Default_Values
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class DefaultValues
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, string>();

            while (input != "end")
            {
                var token = input.Split(new [] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var firstParam = token[0];
                var secondParam = token[1];

                dictionary[firstParam] = secondParam;

                input = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var unchangeValue = 
                dictionary
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length);

            var dicWithDefaultValue = dictionary
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var entry in unchangeValue)
            {
                Console.WriteLine($"{entry.Key} <-> {entry.Value}");
            }

            foreach (var entry in dicWithDefaultValue)
            {
                Console.WriteLine($"{entry.Key} <-> {entry.Value}");
            }

        }
    }
}
