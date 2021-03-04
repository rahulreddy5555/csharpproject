using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computer;
using Television;

namespace OopsDemo3
{
    class DemonameSpace
    {
        public static void Main()
        {
            Hardware h1 = new Hardware();
            Hardware1 h2 = new Hardware1();
            Console.WriteLine("from demonamespace class");
            h1.test();
            h2.test();
            Console.ReadKey();
        }
    }
}
