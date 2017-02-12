using System;


namespace _2.Count_of_Negative_Elements_in_Array
{
    class NegativeElementsInArray
    {
        static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());

            var array = new int[numbers];
            var countOfNegativeNums = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                array[i] = currentNum;
                if (array[i] < 0)
                {
                    countOfNegativeNums++;
                }
            }
            Console.WriteLine(countOfNegativeNums);
        }
    }
}
