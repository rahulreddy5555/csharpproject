using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
    class Person
    {
        protected string name;
        protected int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printperson()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("age  :" + age);
        }
    }

    class Staff : Person
    {
        protected int staff_id;
        protected long staffsalary;

        public Staff(int staff_id, long staffsalary,String name,int age): base(name,age)
        {
            this.staff_id = staff_id;
            this.staffsalary = staffsalary;
        }
        public void printstaff()
        {
            Console.WriteLine("staff_id"+staff_id);
            // Console.WriteLine("staff name" + name);
            base.printperson();
            Console.WriteLine("staff salary" + staffsalary);
           // Console.WriteLine("staff name" + age);

        }
    }
    class Student : Person
    {
        protected int rollno;
        protected double fees;

        public Student(int rollno, double fees,string name, int age): base(name,age)
        {
            this.rollno = rollno;
            this.fees = fees;
        }

        public void printStudent()
        {
            Console.WriteLine("rollno" +rollno);
            //   Console.WriteLine("student name" + name);
            // Console.WriteLine("student age" + age);
            base.printperson();
            Console.WriteLine("student fees" + fees);

        }
    }
    class HeirarichalDemo
    {
        static void Main()
        {
            Staff s1 = new Staff(1000,10000,"alex",30);
            Student c1 = new Student(100, 1500, "john", 19);
            s1.printperson();
          //  s1.printstaff();
            c1.printStudent();
            Console.ReadKey();
        }
    }
}
