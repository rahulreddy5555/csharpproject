using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbasics
{
    class MltiArray
    {
        static void Main()
        {
            int[,] a = new int[3,3];  //declaring 2d array

            //initialization
            a[0, 0]=100;
            a[1, 1] = 200;
            a[2, 2] = 300;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j]+ " ");
                }
                Console.WriteLine();
            }
            int[,] b = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] c = new int[2, 5];
            Console.WriteLine("size of aarray b is" + b.Length);
            Console.WriteLine("rank of aarray b is" + b.Rank);
            Console.WriteLine("no of rows"+c.GetLength(0));
            Console.WriteLine("no of columns" + c.GetLength(1));
            Console.ReadKey();

        }
    }
}
