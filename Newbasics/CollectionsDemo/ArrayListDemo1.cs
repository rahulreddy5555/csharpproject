using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class ArrayListDemo1
    {
        static void Main()
        {
            ArrayList list = new ArrayList(); list.Add("Manesh");
            list.Add("Akshay");
            list.Add("Vikash");
            list.Add("Anuj");
            list.Add("Dharmesh");
            list.Add("Raman");
            Console.WriteLine("initia arraylist contents");
            foreach(string v in list)
            {
                Console.WriteLine(v);
            }
            list.Reverse();
            Console.WriteLine("initial arraylist contents after reverse ");
            foreach (string v in list)
            {
                Console.WriteLine(v);
            }

            list.Sort();
            Console.WriteLine("initial arraylist contents after sort");
            foreach (string v in list)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine(list.BinarySearch("Raman"));
            Console.ReadKey();
        }
    }
}
