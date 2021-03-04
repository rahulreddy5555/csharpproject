using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    public partial class Technician
    {
        partial void setdata();

    }

    public partial class Technician
    {
        public void setsalary()
        {
            setdata();
        }
        partial void setdata()
        {
            Console.WriteLine("This is partial method");
        }

    }
    class PartialMethodDemo
    {
        static void Main()
        {
            Technician t = new Technician();
            t.setsalary();
            Console.ReadKey();
        }
    }
}
