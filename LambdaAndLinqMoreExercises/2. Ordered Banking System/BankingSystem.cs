using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Ordered_Banking_System
{
    class BankingSystem
    {
        public static void Main()
        {
            var bankingSystemDict = new Dictionary<string, Dictionary<string, decimal>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var splitedInput = input.Split(new[] { " ", "-", ">" }, StringSplitOptions.RemoveEmptyEntries);

                var bank = splitedInput[0];
                var account = splitedInput[1];
                var balance = decimal.Parse(splitedInput[2]);

                if (!bankingSystemDict.ContainsKey(bank))
                {
                    bankingSystemDict.Add(bank, new Dictionary<string, decimal>());
                }

                if (!bankingSystemDict[bank].ContainsKey(account))
                {
                    bankingSystemDict[bank].Add(account, 0);
                }
                bankingSystemDict[bank][account] += balance;

                input = Console.ReadLine();
            } // end while

            foreach (var bank in bankingSystemDict.OrderByDescending(bank => bank.Value.Sum(account => account.Value)).ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {
                foreach (var accountAndBalance in bank.Value)
                {
                    Console.WriteLine($"{accountAndBalance.Key} -> {accountAndBalance.Value} ({bank.Key})");
                }
            }
        }
    }
}
