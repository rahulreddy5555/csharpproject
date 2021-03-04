using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class ReadOnlyDemo
    {
        private readonly String name;
        private readonly String location;
        private readonly int age;
        public ReadOnlyDemo()
        {
            name = "gosling";
            location = "ambarpet";
            age = 23;
        }
        void display()
        {
            Console.WriteLine("hello {0} aged {1} from {2}  ",name,age,location);
        }
        static void Main()
        {
            ReadOnlyDemo rd = new ReadOnlyDemo();
            rd.display();
            Console.ReadKey();
            
        }
    }
}
