using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class GenericDemo2
    {
        
     static void add<T>(T n1,T n2)
        {
            dynamic a = n1;
            dynamic b = n2;

           
            Console.WriteLine(a+b);
        }

        static void Main()
        {
            add<int>(1, 2);
            add<String>("rahul", "reddy");
            add<float>(20.4f,23.2f);
            Console.ReadKey();
        }
    }
}
