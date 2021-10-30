using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson5Task3
{
    class MyMatrix
    {
        private int rows;
        private int columns;

        public int Rows { get { return rows; } set { rows = value; } }
        public int Columns { get { return columns; } set { columns = value; } }

        public MyMatrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }

        public void PrintMatrix()
        {
            Random r = new Random();
            

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{r.Next(0, 9)} ");
                }
                Console.WriteLine();
            }
        }

    }
}
