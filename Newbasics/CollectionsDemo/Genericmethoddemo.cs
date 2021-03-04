using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Genericclass<T>
    {
        public T msg;
        public void genericmethod(T name, T location)
        {
            Console.WriteLine(msg);
            Console.WriteLine(name);

            Console.WriteLine(location);
        }
    }
    class genericMethodDemo
    {
        static void Main()
        {
            Genericclass<string> g = new Genericclass<string>();
            g.msg = "hello";
            g.genericmethod("ram", "hyd");
            Console.ReadKey();
        }
    }
}
