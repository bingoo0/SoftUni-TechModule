using System;
using System.Collections.Generic;
using System.Linq;


namespace _6.Filter_Base
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var employeeDict = new Dictionary<string, string>();
            var doubleNum = 0.0;
            var num = 0;

            var firstInput = string.Empty;
            var secondInput = string.Empty;

            var isInt = int.TryParse(secondInput, out num);
            var isDouble = double.TryParse(secondInput, out doubleNum);

            while (input != "filter base")
            {
                var tokens = input.Split(" ->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                firstInput = tokens[0];
                secondInput = tokens[1];

                if (!employeeDict.ContainsKey(firstInput))
                {
                    employeeDict[firstInput] = string.Empty;
                }
                employeeDict[firstInput] = secondInput;

                input = Console.ReadLine();
            }

           var inputElement = Console.ReadLine();

            if (inputElement == "Salary")
            {   
                foreach (var filtredBase in employeeDict)
                {
                    double.TryParse(employeeDict[secondInput], out doubleNum);
                    Console.WriteLine($"Name: {filtredBase.Key}");
                    Console.WriteLine($"Salary: {filtredBase.Value}");
                    Console.WriteLine("====================");
                }

            }
            else if (inputElement == "Position")
            {
                if (!isDouble)
                {
                    isDouble = false;
                    foreach (var filtredBase in employeeDict)
                    {
                        Console.WriteLine($"Name: {filtredBase.Key}");
                        Console.WriteLine($"Position: {filtredBase.Value}");
                        Console.WriteLine("====================");
                    }
                    
                }
                
            }
            else if (inputElement == "Age")
            {
                int.TryParse(employeeDict[secondInput], out num);
                foreach (var filtredBase in employeeDict)
                {
                    Console.WriteLine($"Name: {filtredBase.Key}");
                    Console.WriteLine($"Age: {filtredBase.Value}");
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
