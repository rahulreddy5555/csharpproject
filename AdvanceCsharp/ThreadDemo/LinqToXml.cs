﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThreadDemo
{
    class LinqToXml
    {
        static void Main()
        {
            XElement doc = XElement.Load("..\\..\\Employee.xml");
            /* IEnumerable<XElement> employees = xelement.Elements();
             // Read the entire XML
             foreach (var employee in employees)
             {
                 Console.WriteLine(employee);
             }
             Console.ReadKey();*/

            var result = from ed in doc.Descendants("employee")
                         where Convert.ToInt32(ed.Element("salary").Value) >= 30000
                         select new
                         {
                             Id = ed.Element("empid").Value,
                             Name = ed.Element("empname").Value,
                             Salary = ed.Element("salary").Value,
                             Gender = ed.Element("gender").Value

                         };

            foreach (var i in result)
            {
                Console.WriteLine(i.Id + " " + i.Name + " " + i.Gender + " " + i.Salary);
            }
            //Console.WriteLine(result);
            Console.ReadKey();





        }
    }
}
