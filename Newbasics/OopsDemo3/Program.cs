using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    public interface IArea
    {
        void area(double a, double b); 
    }
    class Rectangle : IArea
    {
        public void area(double a, double b)
        {
            double ar;
            ar = a * b;
            Console.WriteLine("area of rectangle is: " + ar);
        }
    }

    class Circle : IArea
    {
        static double pi = 3.14;
        public void area(double a, double b)
        {
            double ar;
            ar = pi * a * a;
            Console.WriteLine("area of circle is: "+ar);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IArea a = new Rectangle();
            a.area(5, 6);
            IArea b = new Circle();
            b.area(7, 0);
            Console.ReadKey();
            
        }
    }
}
