using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _1.Shoot_List_Elements
{
    class ShootListElements
    {
        static void Main()
        {
            var numbers = new List<int>();
            var input = Console.ReadLine();

            var lastRemoved = 0;
            var output = "";
            while (input != "stop")
            {
                if (input == "bang")
                {
                    if (numbers.Count == 0 )
                    {
                        output = $"nobody left to shoot! last one was {lastRemoved}";
                        break;
                    }
                    // REMOVE ELEMENT
                    int sum = SumElements(numbers);
                    double average = (double)sum / numbers.Count;

                 lastRemoved =  RemoveSmallerElement(numbers, average);
                 DecrementElements(numbers);

                }
                else
                {
                    // ADD INTS
                    var number = int.Parse(input);
                    numbers.Insert(0, number);
                }
                input = Console.ReadLine();
            } // end while
            if (numbers.Count > 0 && output == "")
            {
                Console.WriteLine("survivors: {0}", string.Join(" ", numbers));
            }
            else if (numbers.Count == 0 && output == "")
            {
                Console.WriteLine("you shot them all. last one was {0}", string.Join(" ", lastRemoved));
            }
            else
            {
                Console.WriteLine(output, lastRemoved);
            }           
        }

        static void DecrementElements(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        private static int RemoveSmallerElement(List<int> numbers, double average)
        {
            var result = -1;
            if (numbers.Count == 1)
            {
                Console.WriteLine($"shot {numbers[0]}");
                result = numbers[0];
                numbers.RemoveAt(0);
                return result;
            }
            
            for (int i = 0; i < numbers.Count; i++)
            {
                
                if (numbers[i] < average)
                {
                    Console.WriteLine($"shot {numbers[i]}");
                    result = numbers[i];
                    numbers.RemoveAt(i);
                    break;
                } 
            }
            return result;
        }

        static int SumElements(List<int> numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
