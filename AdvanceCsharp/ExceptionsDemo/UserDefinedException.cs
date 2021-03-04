using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    public class OddnumbeException : Exception
    {
        public override string Message { get { return "divisor cannot be odd number"; } }
        class UserDefinedException
        {
            static void Main()
            {
                int x, y, z;
                Console.WriteLine("ENTER TWO INTEGER NUMBERS:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                try
                {
                    if (y % 2 > 0)
                    {
                        throw new OddnumbeException();
                    }
                    z = x / y;
                    Console.WriteLine(z);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        
        }
    }
}
