using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopsDemo2;

namespace OopsDemo2
{
    class EmployeeTest
    {
        public static void Main()
        {
            Employee e1 = new Employee();
            e1.GetBranchData();
            e1.GetEmployeeData();
            e1.DisplayBranchData();
            e1.DisplayBranchData();
            Console.ReadKey();
            int i = 1000;
            bool res = i.IsGreaterThan(100);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
