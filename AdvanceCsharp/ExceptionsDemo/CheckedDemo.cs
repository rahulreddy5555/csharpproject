using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class CheckedDemo
    {
        public static void Main()
        {
            //unchecked
            checked{
                int val = int.MaxValue;
                Console.WriteLine(val+2);
            }
            Console.ReadKey();
        }
    }
}
