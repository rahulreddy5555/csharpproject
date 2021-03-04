using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    class SuperClass
    {
        public void display()
        {
            Console.WriteLine("Base class method is called");
        }
    }
    class DerivedClass : SuperClass
    {
        public new void display()
        {
            Console.WriteLine("derived class method is called");
        }
    }
    class MethodHidingDemo
    {
        static void Main()
        {
            DerivedClass d = new DerivedClass();
            d.display();
            Console.ReadKey();
        }
    }
}
