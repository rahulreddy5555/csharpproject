using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo
{

    //make thread function type safe in c#
    class FunctionTypeSafe
    {

        static void Main()
        {
            int Max = 10;
            NumberHelper nh = new NumberHelper(Max);
            Thread t1 = new Thread(new ThreadStart(nh.DisplayNumbers));

            t1.Start();
            Console.ReadKey();

        }
    }
}
