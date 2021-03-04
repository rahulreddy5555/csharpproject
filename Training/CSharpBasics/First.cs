using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class First
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0;
            String name;
            decimal salary;
            double age;
            Console.WriteLine("This is my first c# program");
            Console.WriteLine("enter ur name salary and age");
            name = Console.ReadLine();
            salary = Convert.ToDecimal(Console.ReadLine());
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("hello {0} with age{1} and salary{2} ", name, age, salary);
            Console.WriteLine("enter two numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("sum of two numbers is {2}:",a,b,sum );
            Console.ReadKey();


        }
    }
}
