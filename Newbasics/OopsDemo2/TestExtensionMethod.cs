using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsDemo2;

namespace OopsDemo2
{
    class TestExtensionMethod
    {
        static void Main()
        {
            int i = 10;
            string myword = "learning c# extension methods is fun";
            bool res = i.IsGreaterThan(100);
            Console.WriteLine(res);

            int mywordcount = myword.getcount();
            Console.WriteLine("count "+mywordcount);
            Console.WriteLine("length " + myword.Length);
            Console.ReadKey();

        }
    }
}
