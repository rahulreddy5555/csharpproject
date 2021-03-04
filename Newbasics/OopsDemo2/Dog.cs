using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
  public class Dog : Mammal
    {
        private string breed;

        public Dog(string breed,int age): base (age)
        {
            this.breed = breed;
        }

        public string Breed { get => breed; set => breed = value; }

        public void wagTail()
        {
            Console.WriteLine("waiging tail");
        }
    }
}
