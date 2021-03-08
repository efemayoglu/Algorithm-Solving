using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static int findMaximumElementIndex(List<int> numbers)
        {
            int maxIndex = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] >= numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }
      
            return maxIndex;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(countMoves(new List<int>
            {
                3,4,6,6,3
            }));

            Console.WriteLine(countMoves(new List<int>
            {
                5,6,8,8,5
            }));

            Console.WriteLine(countMoves(new List<int>
            {
                2,2,2
            }));
        }
        static bool checkAllElementIsEqual(List<int> numbers)
        {
            var firstItem = numbers[0];
            foreach (var item in numbers)
            {
                if (firstItem != item) return false;
            }

            return true;
        }

        static long countMoves(List<int> numbers)
        {
            var temp = numbers;
            var stepCount = 0;

            while (!checkAllElementIsEqual(temp))
            {
                var maxIndex = findMaximumElementIndex(numbers);
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i != maxIndex)
                    {
                        temp[i] = temp[i] + 1;
                    }
                }
                stepCount++;
            }


            return stepCount;

        }
    }
}
