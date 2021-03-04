using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ThreadDemo
{
    class FunctionParameterDemo
    {
        public void DisplayNumbers(object Max)
        {
           int Number = Convert.ToInt32(Max);
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
        static void Main()
        {
            FunctionParameterDemo f = new FunctionParameterDemo();
            ParameterizedThreadStart pt = new ParameterizedThreadStart(f.DisplayNumbers);

            Thread t1 = new Thread(pt);
            Thread t2 = new Thread(pt);
          //  t1.Start("hi");
            t2.Start(10);

            Console.ReadKey();

        }
    }
}
