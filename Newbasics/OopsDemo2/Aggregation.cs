using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
    class Address
    {
        public  string street,sity,state;

        public Address(string street, string sity, string state)
        {
            this.street = street;
            this.sity = sity;
            this.state = state;
        }
    }
    class Pupil
    {
        int rollno;
        String name;
        static int batch;
        static string course = "B.Tech";
        Address adr;
        public Pupil(int rollno,String name,Address adr)
        {
           
            this.rollno = rollno;
            this.name = name;
            this.adr=adr;
        }
        public void display()
        {
            Console.WriteLine(rollno + " " + name + " " + adr.street+" "+adr.state);
        }




    }
    class Aggregation
    {
        static void Main()
        {
            Address a = new Address("indranagar", "Bengaluru", "karnataka");
            Pupil p = new Pupil(101,"mike",a);
            p.display();
            
            Console.ReadKey();

        }
    }
}
