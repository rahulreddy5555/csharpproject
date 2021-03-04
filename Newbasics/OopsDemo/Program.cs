using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enterfirst dog name");
            String name1 = Console.ReadLine();
            Console.WriteLine("enter first dog breed");
            String breed1= Console.ReadLine();
            Dog d1 = new Dog(name1, breed1);
       
           
            Dog d2 = new Dog();
            Console.WriteLine("enter second dog name");
            String name2 = Console.ReadLine();
            Console.WriteLine("enter secomd dog  breed");
            String breed2 = Console.ReadLine();

            d1.saybou();
            d2.saybou();
            //setting values using properties
            d2.Name = name2;
            d2.Breed = breed2;

            //gettting values using properties
            Console.WriteLine("name is: " + d2.Name);
            Console.WriteLine("breed is:" + d2.Breed);

           
            Console.ReadKey();
        }
    }
}
