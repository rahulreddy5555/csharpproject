using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class EmployeeTest
    {
        public static void Main()
        {
            Employee e1 = new Employee();
            e1.input();
            decimal np = e1.calculatesalary();
            e1.display();
            Console.WriteLine("net pay is "+np);
            Console.ReadKey();
        }
    }
}
