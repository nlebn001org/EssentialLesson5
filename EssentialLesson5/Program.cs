using EssentialLesson5Task1;
using System;

namespace EssentialLesson5
{

    //    Задание
    //Расширьте пример 5 (русско-английский словарь) еще и украинским словарем.Реализуйте возможность поиска не только по ключевым русским словам и словам на остальных языках.

    class Program
    {
        static Dictionary dict;
        static string str;
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;


            while (true)
            {
                dict = new Dictionary();

                Console.WriteLine("Input your word for transaltion to rus, ukr or eng");
                str = Console.ReadLine();

                Console.WriteLine(dict[str]);
                Console.WriteLine();

            }
        }
    }
}
