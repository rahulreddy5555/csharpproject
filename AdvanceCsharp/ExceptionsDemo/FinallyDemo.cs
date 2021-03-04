using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class FinallyDemo
    {
        static void Main(string[] args)

        {
            String name=null;
            try
            {
                if (name.Length >0) // Exception will occur
                {
                    Console.WriteLine("Name: " + name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}",ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block.");
            }

            Console.ReadKey();
        }
    }
}
