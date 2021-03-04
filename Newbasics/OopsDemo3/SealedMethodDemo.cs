using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("im eating");

        }
        public virtual void run()
        {
            Console.WriteLine("im running");

        }
    }

    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("eating chicken");

        }
        public sealed override void run()
        {
            Console.WriteLine("running fast");

        }
    }
    
    class BabyDog: Dog
    {
        public override void eat()
        {
            Console.WriteLine("eating slowly");

        }
        public  void run1()
        {
            Console.WriteLine("running slowly");

        }
    }
    class SealedMethodDemo
    {

       public static void Main()
        {
            BabyDog b = new BabyDog();
            b.eat();
            b.run1();
            Console.ReadKey();
        }
    }
}
