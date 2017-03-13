using System;
using System.Linq;

namespace _3.Phonebook
{
    class Program
    {
        static void Main()
        {
            string[] phoneNumber = Console.ReadLine().Split(' ');
            string[] name = Console.ReadLine().Split(' ');

            var currentName = string.Empty;

            while (currentName != "done")
            {
                currentName = Console.ReadLine();
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == currentName)
                    {
                        Console.WriteLine($"{name[i]} -> {phoneNumber[i]}");
                    }
                }
            }
            

        }
    }
}
