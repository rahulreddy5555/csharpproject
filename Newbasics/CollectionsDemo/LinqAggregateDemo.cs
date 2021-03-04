using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqAggregateDemo
    {
        static void Main() {
            List<int> myIntegerList = new List<int>()
            {
                1,2,3,44,5,33,77,6,9
            };
            int m = myIntegerList.Min();
            int n = myIntegerList.Max();
            double k = myIntegerList.Average();
            int sum = myIntegerList.Sum();
            int c = myIntegerList.Count();

            /* Aggregate function is useful to perform the operations on each item of the list.
             * The Aggregate() function will perform the action on the first and second elements
             * and then carry forward the result. */


            double ag = myIntegerList.Aggregate((a, b) => a + b);
            Console.WriteLine("min  "+m);
            Console.WriteLine("max  "+n);
            Console.WriteLine("average  "+k);
            Console.WriteLine("count is  "+c);
            Console.WriteLine("sum is  " + sum);
            Console.WriteLine("sum of elements in the list is  "+ag);
            //    Console.WriteLine("The Minimum no. in List is {​​​​​​0}​​​​​​", m);
            // Console.WriteLine("The Maximum no. in List is {​​​​​​0}​​​​​​", n);
            //Console.WriteLine("The Average of nos in List is {​​​​​​0}​​​​​​", k);
            //Console.WriteLine("The Total nos in List is {​​​​​​0}​​​​​​", c);

          
           
            string[] charlist = { "a", "b", "c" };
            var concat = charlist.Aggregate((a, b) => a + ',' + b);
            Console.WriteLine(concat);
            Console.ReadKey();
        } }
}
