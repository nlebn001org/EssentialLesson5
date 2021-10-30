using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson5Task4
{
    class Article
    {

        string productName;
        string storeName;
        double price;
        static int counter;

        public static int Counter { get { return counter; } }
        public string ProductName { get { return productName; } }
        public string StoreName { get { return storeName; } }
        public double Price { get { return price; } }

        //public Article()
        //{
        //    counter++;
        //}

        public Article(string productName, string storeName, double price)
        {
            counter++;
            this.productName = productName;
            this.storeName = storeName;
            this.price = price;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Product is: {ProductName}, Store is: {StoreName}, Price is: {Price}");
        }

    }
}
