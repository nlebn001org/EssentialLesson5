using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson5Task1
{
    class Dictionary
    {

        string[] english = new string[5];
        string[] russian = new string[5];
        string[] ukrainian = new string[5];

        public Dictionary()
        {
            russian[0] = "книга"; english[0] = "book"; ukrainian[0] = "книга";
            russian[1] = "ручка"; english[1] = "pen"; ukrainian[1] = "ручка";
            russian[2] = "солнце"; english[2] = "sun"; ukrainian[2] = "сонце";
            russian[3] = "яблоко"; english[3] = "apple"; ukrainian[3] = "яблуко";
            russian[4] = "стол"; english[4] = "table"; ukrainian[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < english.Length; i++)
                {
                    if (english[i] == index.Trim())
                    {
                        return $"{english[i]} - {russian[i]} - {ukrainian[i]}";
                    }
                    else if (ukrainian[i] == index.Trim())
                    {
                        return $"{ukrainian[i]} - {english[i]} - {russian[i]}";
                    }
                    else if (russian[i] == index.Trim())
                    {
                        return $"{russian[i]} - {english[i]} -  {ukrainian[i]}";
                    }
                }
                return $"{index} does not exist in this dictionary.";
            }
        }


    }
}
