﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class SelectionDemo
    {
        static void Main()
        {
            List<Student> lstStudent = new List<Student>() {
            new Student() { Rollno = 1, Name = "Mike", Marks = 500 },
            new Student() { Rollno = 2, Name = "John", Marks = 300 },
            new Student() { Rollno = 3, Name = "Mary", Marks = 400 },
            new Student() { Rollno = 4, Name = "Ravi", Marks = 550 },
            new Student() { Rollno = 5, Name = "Raj", Marks = 600 },
            new Student() { Rollno = 6, Name = "Pavi", Marks = 700 },
            new Student() { Rollno = 7, Name = "Prasad", Marks = 550 }
            };



            //linq select query
            var result = from s in lstStudent
                         select new { roll = s.Rollno, name = s.Name, m = s.Marks };



            foreach (var i in result)
            {
                Console.WriteLine(i.roll + " " + i.name + " " + i.m);
            }
            Console.ReadKey();



        }
    }
}
