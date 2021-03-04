using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class HashTableDemo1
    {
        static void Main() {
            Hashtable h1 = new Hashtable();
            h1.Add(100, "ravi");
            h1.Add(200, "ram");
            h1.Add(300, "reddy");
            foreach(DictionaryEntry de in h1)
            {
                Console.WriteLine(de.Key+" "+de.Value);
            }
            Console.WriteLine("-------------------------------------");

            ICollection Keys = h1.Keys;
            foreach(var k in Keys)
            {
                Console.WriteLine(k + " - " + h1[k]);
            }
            Console.ReadKey();
        }  
    }
}
