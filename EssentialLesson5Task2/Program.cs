﻿using System;

namespace EssentialLesson5Task3
{
    class Program
    {

        //        Задание 3
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Требуется:
        //Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера с возможностью изменения числа строк и столбцов.
        //Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков.

        static void Main(string[] args)
        {
            MyMatrix m = new MyMatrix(3,4);
            m.PrintMatrix();
            
        }
    }
}
