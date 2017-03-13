using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.User_Logins
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var accountInfo = new Dictionary<string, string>();
            var countOfUnsuccesfullLogins = 0;

            while (input != "login")
            {
                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var accountName = tokens[0];
                var accountPassword = tokens[1];

                if (!accountInfo.ContainsKey(accountName))
                {
                    accountInfo[accountName] = string.Empty;
                }
                accountInfo[accountName] = accountPassword;

                input = Console.ReadLine();
            } // end while

            input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var accountName = tokens[0];
                var accountPassword = tokens[1];
                

                if (accountInfo.ContainsKey(accountName) && accountInfo.ContainsValue(accountPassword))
                {
                    Console.WriteLine($"{accountName}: logged in successfully");
                }
                else
                {
                    countOfUnsuccesfullLogins++;
                    Console.WriteLine($"{accountName}: login failed");
                }
                
                input = Console.ReadLine();
            } // end while
            Console.WriteLine($"unsuccessful login attempts: {countOfUnsuccesfullLogins}");
        }
    }
}
