using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
    class people
    {
        public people()
        {
            Console.WriteLine("constructor invoked");
        }
        ~people()
        {
            Console.WriteLine("destructor invoked");
        }
    }
    class DestructorDemo
    {
        static void Main()
        {
            people p1 = new people();
            people p2 = new people();
            people p3 = new people();
           // Console.ReadKey();
        }
    }
}
