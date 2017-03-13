using System;
using System.Collections.Generic;
using System.Linq;


namespace _6.Batteries
{
    class Program
    {
        static void Main()
        {
            var capacitieOfBattery = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var usagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var stresTest = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var batteryBatch = 0.0;
            var countOfBattery = 0;
             
                for (int i = 0; i < capacitieOfBattery.Length; i++)
                {
                    sum = capacitieOfBattery[i] - (usagePerHour[i] * stresTest);
                    batteryBatch = capacitieOfBattery[i] - sum;
                    batteryBatch = capacitieOfBattery[i] - batteryBatch;
                    countOfBattery++;
                var percentOfBattery = (batteryBatch / capacitieOfBattery[i]) * 100.0;
                var batteryHour = Math.Abs(Math.Ceiling(capacitieOfBattery[i] / usagePerHour[i])) ;
                if (batteryBatch > 0)
                {
                    Console.WriteLine("Battery {0}: {1:f2} mAh ({2:f2})%", countOfBattery, batteryBatch, percentOfBattery);
                }
                else
                {
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)", countOfBattery, batteryHour);
                }
           }                                     
        }   
    }
}
