using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _1.Day_of_Week
{
    class DayOfWeek
    {
        static void Main()
        {
            var inputDate = Console.ReadLine();

            var date =  DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
