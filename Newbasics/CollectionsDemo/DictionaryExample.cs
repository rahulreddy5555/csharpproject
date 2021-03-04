using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class DictionaryExample
    {

        static void Main()
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(101, "rahul");
            names.Add(102, "kumar");
            names.Add(103, "reddy");
            names.Add(104, "roshan");
            foreach(KeyValuePair<int,string> kv in names)
            {
                Console.WriteLine(kv.Key+" "+kv.Value);
            }
            Console.WriteLine(names[102]);
            names.Remove(104);
            foreach(int k in names.Keys)
            {
                Console.WriteLine(k+"-"+names[k]);
            }

            Console.ReadKey();
        }
    }
}
