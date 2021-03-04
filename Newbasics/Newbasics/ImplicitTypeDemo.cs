using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbasics
{
    class ImplicitTypeDemo
    {
        public static void Main()
        {
            var a = 100;
            var name = "rahul";
            var arr = new[] { 1, 2, 3 };
            Console.WriteLine(a+" "+a.GetType());
            Console.WriteLine(name);
            Console.WriteLine(arr);
            Console.ReadKey();
        }
        
    }
}
