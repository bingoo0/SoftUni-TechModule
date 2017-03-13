using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Hornet_Wings
{
    class HornetWing
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var rests = n / endurance;
            long seconds = rests * 5L;

            var distance = (n / 1000) * m;

            seconds += (n / 100);
            Console.WriteLine("{0:F2} m.", distance);
            Console.WriteLine("{0} s.", seconds);

        }
    }
}
