using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
    class SinleInheritanceDemo
    {
        static void Main()
        {


            Mammal mamal = new Mammal(5);
            Console.WriteLine("age of mammal"+mamal.Age);
            mamal.sleep();

            Dog d = new Dog("building",3);
            d.sleep();
            Console.WriteLine(d.Age);
            Console.WriteLine(d.Breed);
            d.wagTail();
            Console.ReadKey();

        }
    }
}
