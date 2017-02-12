using System;


namespace _7.Count_of_Capital_Letters_in_Array
{
    class CountOfCapitalLetters
    {
        static void Main()
        {
            var letters = Console.ReadLine().Split(' ');
            var count = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                var currentLetter = letters[i];
                if (currentLetter.Length == 1)
                {
                    char currentChar = currentLetter[0];

                    if (currentChar >= 'A' && currentChar <= 'Z')
                    {
                        count++;
                    }
                }
               
            }
            Console.WriteLine(count);
        }
    }
}
