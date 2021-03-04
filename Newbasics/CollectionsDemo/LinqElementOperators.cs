using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqElementOperators
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int MethodSyntax = numbers.ElementAt(3);
           // int MethodSyntax1 = numbers.ElementAt(10);

            int MethodSyntax2 = numbers.ElementAtOrDefault(10); //returns zero if no element present at that index
            Console.WriteLine(MethodSyntax2);

            int MethodSyntax3 = numbers.First(); 
            Console.WriteLine(MethodSyntax3);

            int MethodSyntax4 = numbers.FirstOrDefault();
            Console.WriteLine(MethodSyntax4);

            int MethodSyntax5 = numbers.Last();
            Console.WriteLine(MethodSyntax5);
            //  Console.WriteLine(MethodSyntax2);
            Console.ReadLine();
        }
    }
}
