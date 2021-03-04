using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class StudentDemo
    {
        public static void Main()
        {
            Student s1 = new Student(11, "rahul");
            s1.Course = "ds and al";
            s1.display();
            //s1.Name = "reddy";   throws error because it is read only property
            Console.WriteLine(s1.Rollno + "  " + s1.Name);
            s1.City = "hyd";
            Console.WriteLine(s1.City);
            Console.ReadKey();
        }
    }
}
