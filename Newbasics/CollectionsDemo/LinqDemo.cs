using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class LinqDemo
    {
        static void Main()
        {
            //define linq data source
            List<int> myintist = new List<int>()
            {
                1,2,3,4,5,6,7,8
            };
            //linq query 
            var qry = from i in myintist
                      where i>4
                      select i;
            //execution
            foreach(var item in qry)
            {
                Console.WriteLine(item);
            }
            //linq query with method syntax
            var mthdQuery = myintist.Where(i => i < 5).ToList();
            foreach(var item in mthdQuery)
            {
                Console.WriteLine(item);
            }
            //link query using mixed syntax
            var mixedquery = (from i in myintist
                              where i > 5
                              select i).Sum();
            Console.WriteLine(mixedquery);


            Console.ReadKey();
        }
    }
}
