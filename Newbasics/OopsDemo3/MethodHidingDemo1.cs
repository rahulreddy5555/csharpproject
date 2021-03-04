using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    class Software
    {
        public void update()
        {
            Console.WriteLine("Base software update...........");
        }

        public void install()
        {
            Console.WriteLine("Base software installing...........");
        }
    }
    class ApplicationSoftware:Software
    {
        public new void install()
        {
            Console.WriteLine("Derived software installing...........");
        }
        public void run()
        {
            Console.WriteLine("Application software running...........");
        }
    }

    class SystemSoftware : Software
    {
       
        public void run()
        {
            Console.WriteLine("system software running...........");
        }
    }
    class MethodHidingDemo1
    {
       static void Main()
        {
            ApplicationSoftware a = new ApplicationSoftware();
            a.install();
            a.update();
            a.run();

            SystemSoftware s= new SystemSoftware();
            s.install();
            s.update();
            s.run();
            Console.ReadKey();
        }
        
    }
}
