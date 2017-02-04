using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {

                var result = Console.ReadLine();

                if (result == "success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();

                    ShowSuccess(operation, message);
                }

                else if (result == "error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());

                    ShowError(operation, code);
                }
                
            }
       
        }

        static void ShowSuccess(string operation, string message)
        {
            var result = $"Successfully executed {operation}." + Environment.NewLine;
            result += "==============================" + Environment.NewLine;
            result += $"Message: {message}.";

            Console.WriteLine(result);


        } // end method ShowSucces

        static void ShowError(string operation, int code)
        {
            var result = $"Error: Failed to execute {operation}." + Environment.NewLine;
            result += "==============================" + Environment.NewLine;
            result += $"Error Code: {code}." + Environment.NewLine;

            var reason = string.Empty;

            if (code > 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }

            result += $"Reason: {reason}.";

            Console.WriteLine(result);

        } // end method ShowError

    }
}
