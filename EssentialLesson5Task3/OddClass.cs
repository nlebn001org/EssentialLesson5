using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson5Task2
{
    static class OddClass
    {

        public static void PrintOdd(this int[] array)
        {

            List<int> list = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    list.Add(array[i]);
                }
            }

            Console.Write("All Odd numbers are: ");

            for (int i = 0; i < list.Count; i++)
            {
                if (i < list.Count - 1)
                {
                    Console.Write($"{list[i]}, ");
                }
                else
                {
                    Console.Write($"{list[i]}.");
                }
            }
        }


    }
}
