using System;

namespace DailyCodingProblemProblem_374
{
    class Program
    {
        static int[] array = new int[] { -10, -1, 0, 2, 4, 11, 30, 50, 100 };

        static void Main(string[] args)
        {
            OofNSolution();
            Console.WriteLine($"The Value is { OLogNSoltuion(array, array.Length - 1, 0)}");
        }

        static int OLogNSoltuion(int[] array, int max, int min)
        {
            var mid = (max + min) / 2;
            if (array[mid] == mid)
            {
                return mid;
            }
            if (array[mid] < mid)
            {
                return OLogNSoltuion(array, max, (mid + 1));
            }
            else
            {
                return OLogNSoltuion(array, (mid - 1), min);
            }
        }

        static void OofNSolution()
        {

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                {
                    Console.WriteLine($"The Value is {i}");
                    break;
                }
            }
        }


    }
}
