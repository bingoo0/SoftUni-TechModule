
namespace _1.Placeholders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Placeholders
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParameters = inputLine.Split(new []{ '-', '>'}, StringSplitOptions.RemoveEmptyEntries);

                var sentence = inputParameters[0].Trim();
                var elements = inputParameters[1].Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}"; // {0} , {1} ....

                    sentence = sentence.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(sentence);
                inputLine = Console.ReadLine();
            } // end while
        }
    }
}
