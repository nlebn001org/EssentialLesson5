using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson5Task4
{
    class StoreList
    {

        List<Article> arlist = new List<Article>();

        private int count;
        public int Count { get { return count; } }
        
        public Article this[int index]
        {
            get
            {
                if (arlist[index] != null)
                {
                    return arlist[index];
                    
                }
                else
                {
                    throw new Exception("This index doesnt exits.");
                }
            }
            set
            {
                arlist.Add(value);
                count++;
            }
        }


    }
}
