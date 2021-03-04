using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
   public class Mammal
    {
        private int age;

        public Mammal(int age)
        {
            this.age = age;
        }

        public int Age { get => age; set => age = value; }

        public void sleep()
        {
            Console.WriteLine("im sleeping");
        }
    }
}
