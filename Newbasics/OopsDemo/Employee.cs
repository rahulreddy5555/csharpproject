using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Employee
    {
        private int empId;
        private String empName;
        private String empdesg;
        private decimal basic;
        private decimal hra;
        private decimal tax;
        private decimal da;
        private decimal netpay;
        private decimal grosspay;

        public Employee()
        {
            empdesg = "programmer";
            da = 2000;

        }
         
        public void input()
        {
            Console.WriteLine("enter empid and empname");
            empId = Convert.ToInt32(Console.ReadLine());
            empName = Console.ReadLine();
            Console.WriteLine("enter basic salary");
            basic = Convert.ToInt32(Console.ReadLine());


        }
        public decimal calculatesalary()
        {
            hra=basic*(decimal).20;
            tax = basic * (decimal).10;
            grosspay = basic + hra + da;
            netpay = grosspay - tax;
            return netpay;

        }
        public void display()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Employee Details are : ");
            Console.WriteLine("Employee Id      : " + empId);
            Console.WriteLine("Employee Name    : " + empName);
            Console.WriteLine("Employee Desig   : " + empdesg);
            Console.WriteLine("Employee Basic   : " + basic);
            Console.WriteLine("Employee HRA     : " + hra);
            Console.WriteLine("Employee DA      : " + da);
            Console.WriteLine("Gross Salary     : " + grosspay);
            Console.WriteLine("Tax deductions   : " + tax);
            Console.WriteLine("*********************************");
        }


    }
}
