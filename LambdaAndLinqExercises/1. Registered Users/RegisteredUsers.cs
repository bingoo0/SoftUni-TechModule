

namespace _1.Registered_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

  public  class RegisteredUsers
    {
      public  static void Main()
        {
            var input = Console.ReadLine();
            var registryDictionary = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                var token = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var username = token[0];
                var date = DateTime.ParseExact(token[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!registryDictionary.ContainsKey(username))
                {
                    registryDictionary[username] = new DateTime();
                }
                registryDictionary[username] = date;

                input = Console.ReadLine();
            }

            foreach (var kvp in registryDictionary.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value))
            {
                var printUsernameSorted = kvp.Key;
                Console.WriteLine(printUsernameSorted);
            }
        }
    }
}
