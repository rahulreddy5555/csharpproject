using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class DataStore<T>
    {
       public T data { get; set; }     //generic propertyyt

        public DataStore(T val)    // generic constructor
        {
            Console.WriteLine(val);
        }

    }
    class GenericsClassDemo
    {
        static void Main() {
            DataStore<string> store = new DataStore<string>("ram");
            store.data="hello aliens";
            DataStore<int> store1 = new DataStore<int>(100);
            store1.data = 10;
            Console.WriteLine(store.data);
            Console.WriteLine(store1.data);
            Console.ReadKey();

        }
    }
}
