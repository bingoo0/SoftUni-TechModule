using System;
using System.Linq;
namespace _4.Phone
{
    class Program
    {
        static void Main()
        {
            string[] phoneNumber = Console.ReadLine().Split(' ');
            string[] name = Console.ReadLine().Split(' ');

            string currentCall = Console.ReadLine();
            while (currentCall != "done")
            {
                Call(phoneNumber, name, currentCall);
            }
            
        }

         static void Call(string[] phoneNumber, string[] name, string currentCall)
        {
            var sum = 0;

            phoneNumber.Select(int.Parse);
            for (int i = 0; i < name.Length; i++)
            {
                if (phoneNumber[i] % 2 == 0)
                {

                }
            }
        }
    }
}
