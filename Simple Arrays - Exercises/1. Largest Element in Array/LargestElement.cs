using System;
using System.Linq;

namespace _1.Largest_Element_in_Array
{
    class LargestElement
    {
        static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());
            var arrayOfNums = new int[numbers];

            var largestNum = int.MinValue;
            for (int i = 0; i < arrayOfNums.Length; i++)
            {
                
                var currentNumber = int.Parse(Console.ReadLine());
                arrayOfNums[i] = currentNumber;

                if (currentNumber > largestNum)
                {
                    largestNum = currentNumber ;
                    
                }   
            } // end for
            Console.WriteLine(largestNum);
        }
    }
}
