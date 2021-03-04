using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbasics
{
    class JaggedArraysDemo
    {
        public static void Main()
        {
            int[][] a = new int[2][];
            a[0] = new int[] { 20, 30, 40 };
            a[1] = new int[] { 23, 45, 21, 1, 5 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write(a[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}