using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LambdaDemo
    {
        public static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> evennums = list.FindAll(x => (x % 2 == 0));
            foreach(var num in evennums)
            {
                Console.WriteLine("{0}", num);
                
            }
            var square = list.Select(x => x * x);
            Console.WriteLine("squares");
            foreach (var squares in square ) {
                Console.WriteLine("{0}", squares);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
