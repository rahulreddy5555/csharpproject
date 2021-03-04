using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    class TestNamespace
    {
        public static void Main()
        {
            Computer.Hardware h1 = new Computer.Hardware();
           // Television.Hardware h2 = new Television.Hardware();
            h1.test();
           // h2.test();
            Console.ReadKey();

        }
    }
}
