﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class MultithreadDemo
    {
        static void PrintInfo1()

        {

            for (int i = 1; i <= 4; i++)

            {

                Console.WriteLine("i value: {0}", i);

                Thread.Sleep(1000);

            }

            Console.WriteLine("First method completed");

        }

        static void PrintInfo2()

        {
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("i value: {0}", i);
            }
            Console.WriteLine("Second method completed");
        }
         public static void Main()
        {
            //creating child thread
            Thread t1 = new Thread(new ThreadStart(PrintInfo1));
            Thread t2 = new Thread(new ThreadStart(PrintInfo2));
            t1.Start();
            //t1.Abort();
           // t1.Join();
            t2.Start();
            Console.ReadKey();
        }
    
    }
}
