using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbasics
{
    class CommandlineDemo
    {
        public static void Main(String[] args)
        {
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            foreach(var v in args)
            {
                Console.WriteLine(v);
            }
            Console.ReadKey();

        }
    }
}