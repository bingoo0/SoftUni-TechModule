
namespace _1.Serialize_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SerializeString
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var dictionary = new Dictionary<char, List<int>>();

            foreach (var letter in inputLine)
            {
                if (!dictionary.ContainsKey(letter))
                {
                    dictionary[letter] = new List<int>();

                    for (int i = 0; i < inputLine.Length; i++)
                    {
                        if (inputLine[i].Equals(letter))
                        {
                            dictionary[letter].Add(i);
                        }
                    }
                }
            } // end main foreach

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}:{string.Join("/", kvp.Value)}");
            }
        }
    }
}
