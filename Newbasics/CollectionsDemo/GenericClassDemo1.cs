using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Student<Tkey,Tvalue>
    {
        public Tkey Key { get; set; }

        public Tvalue Value { get; set; }


    }
    class GenericClassDemo1
    {
        static void Main()
        {
            Student<int, String> s1 = new Student<int, string>();
            s1.Key = 1;
            s1.Value = "rahul";
            Student<string, string> s2 = new Student<string, string>();
            s2.Key="it";
            s2.Value = "info tech";

            Console.WriteLine(s1.Key+"  "+s1.Value);
            Console.WriteLine(s2.Key + "  " + s2.Value);
            Console.ReadKey();
        }
    }
}
