using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUBERS");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("b shoudn't be zero");
            }
            else
            {
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            Console.ReadKey();
        }
    }
}
