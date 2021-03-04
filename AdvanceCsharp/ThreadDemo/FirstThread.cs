using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class FirstThread
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(printInfo));
            t1.Start();
            Console.WriteLine("main thread completed");
            Console.ReadLine();
        }
        static void printInfo()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("child thread completed");
        }
    }
}
