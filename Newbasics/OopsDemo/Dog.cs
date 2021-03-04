using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Dog
    {
        private String name;
        private String breed;

        public Dog()
        {
            this.name = "balkin";
            this.breed = "street excellent";
        }

        public Dog(String name,String breed)
        {
            this.name = name;
            this.breed = breed;
        }
        //defining properties for the fields
        public string Name { get { return name; } set { name = value; } }
        public string Breed { get { return breed; } set { breed = value; } }

        public void saybou()
        {
            Console.WriteLine("{0} with breed {1} said: bauuuu",name,breed);
        }
    }
}
