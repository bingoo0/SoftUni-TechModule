using System;


namespace _1.Sum_Array_Elements
{
    class SumArrayElements
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var sumArray = new int[number];

            var sum = 0;

            for (int i = 0; i < number; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());

                sumArray[i] = currentNum;
                sum += sumArray[i];
            } // end for

            Console.WriteLine(sum);
        }
    }
} // end main 
