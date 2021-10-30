using System;

namespace EssentialLesson5Task4
{

    //    Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создать класс Article, содержащий следующие закрытые поля:
    //• название товара;
    //• название магазина, в котором продается товар;
    //• стоимость товара в гривнах.
    //Создать класс Store, содержащий закрытый массив элементов типа Article.
    //Обеспечить следующие возможности:
    //• вывод информации о товаре по номеру с помощью индекса;
    //• вывод на экран информации о товаре, название которого введено с клавиатуры, если таких товаров нет, выдать соответствующее сообщение;
    //Написать программу, вывода на экран информацию о товаре.

    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store[0] = new Article("iPhone", "iStore", 10000);
            store[1] = new Article("iPhone2", "iStore2", 20000);
            store[2] = new Article("iPhone3", "iStore3", 30000);
            store[3] = new Article("iPhone4", "iStore", 40000);
            store[4] = new Article("iPhone5", "iStore2", 50000);
            store[5] = new Article("iPhone6", "iStore3", 60000);
            store[6] = new Article("iPhone7", "iStore", 70000);
            store[7] = new Article("iPhone8", "iStore2", 80000);
            store[8] = new Article("iPhone9", "iStore3", 90000);
            store[9] = new Article("iPhone10", "iStore", 100000);


            StoreList storeList = new StoreList();
            storeList[0] = new Article("Samsung", "iStore", 10000);
            storeList[1] = new Article("Samsung", "iStore2", 20000);
            storeList[2] = new Article("Samsung", "iStore3", 30000);
            storeList[3] = new Article("Samsung", "iStore", 40000);
            storeList[4] = new Article("Samsung", "iStore2", 50000);
            storeList[5] = new Article("Samsung", "iStore3", 60000);
            storeList[6] = new Article("Samsung", "iStore", 70000);
            storeList[7] = new Article("Samsung", "iStore2", 80000);
            storeList[8] = new Article("Samsung", "iStore3", 90000);
            storeList[9] = new Article("Samsung", "iStore", 100000);
            storeList[10] = new Article("Samsung", "iStore", 100000);
            storeList[11] = new Article("Samsung", "iStore", 100000);

            Console.WriteLine($"How many object were created: {Article.Counter}\n");



            for (int i = 0; i < store.Length; i++)
            {
                store[i].ShowInfo();
            }

            Console.WriteLine();

            for (int i = 0; i < storeList.Count; i++)
            {
                storeList[i].ShowInfo();
            }

        }
    }
}
