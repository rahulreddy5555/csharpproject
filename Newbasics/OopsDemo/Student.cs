using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Student
    {
        private int rollno;
        private string name;

        private string course;
        private string city;

        public Student(int rollno,string name)
         {
            this.rollno = rollno;
            this.name = name;
        }

        public int Rollno { get => rollno;  } //readonly property
        public string Name { get => name; }
        public string Course { set => course = value; } //writeonly property

        public string City { get; set; }
        public void display(){
            Console.WriteLine(course);
        }
    }
}
