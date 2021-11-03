using System;

namespace EssentialLesson5Task4
{
    class Store
    {

        const int length = 10;
        public int Length { get { return length; } }

        Article[] artArray = new Article[length];

        public Article this[int index]
        {
            get
            {
                if (artArray[index] != null)
                {
                    return artArray[index];
                }
                else
                {
                    throw new Exception("This index doesnt exits.");
                }
            }
            set
            {
                if (index<artArray.Length)
                {
                    artArray[index] = value;
                }
                else
                {
                    throw new Exception("Out of Range Exception.");
                }
            }
        }

    }
}
