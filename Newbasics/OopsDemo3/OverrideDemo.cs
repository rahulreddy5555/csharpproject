using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    class Developer
    {
        public  virtual void getinfo()  //virtual method be overriden in derived class
        {
            Console.WriteLine("Im a team leader");
        }
    }

    class Csharpdeveloper:Developer
    {
        public override void getinfo()  //virtual method be overriden in derived class
        {
            Console.WriteLine("Im a c# developer");
        }
    }
    class OverrideDemo
    {
        static void Main()
        {
            Csharpdeveloper c = new Csharpdeveloper();
            c.getinfo();
            Developer d = new Developer();
            d.getinfo();
            Console.ReadKey();
        }
    }
}
