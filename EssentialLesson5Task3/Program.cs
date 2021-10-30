using EssentialLesson5Task2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EssentialLesson5Task3
{

    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать массив размерностью N элементов, заполнить его произвольными целыми значениями.
    //Вывести наибольшее значение массива, наименьшее значение массива, общую сумму элементов, среднее арифметическое всех элементов, вывести все нечетные значения.

    class Program
    {


        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine($"Max of array is: {array.Max()}");
            Console.WriteLine($"Min of array is: {array.Min()}");
            Console.WriteLine($"Sum of array is: {array.Sum()}");
            Console.WriteLine($"Average of array is: {array.Average()}");
            array.PrintOdd();


        }
    }
}
