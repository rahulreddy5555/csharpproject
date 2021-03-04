﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class GlistDemo
    {

        static void Main(string[] args)

        {

            // Creating and initializing list

            List<int> lst = new List<int>();

            lst.Add(1);

            lst.Add(8);

            lst.Add(45);

            List<string> lst2 = new List<string>();

            lst2.Add("Hi");

            lst2.Add("Welcome");

            lst2.Add("to");

            lst2.Add("Collections");

            Console.WriteLine("List1 Elements Count: " + lst.Count);

            Console.WriteLine("List1 Capacity: " + lst.Capacity);

            Console.WriteLine("*********List1 Elements********");

            // Accessing list elements

            foreach (var item in lst)

            {

                Console.WriteLine(item);

            }

            Console.WriteLine("List2 Elements Count: " + lst2.Count);

            Console.WriteLine("List2 Capacity: " + lst2.Capacity);

            Console.WriteLine("*********List2 Elements********");

            foreach (var item in lst2)

            {

                Console.WriteLine(item);

            }

            Console.ReadLine();

        }

    }


}
