using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class MethodsDemo
    {
        public static void multiplication(int x)
        {
            x *= x;
            Console.WriteLine("variable value inside method is {0}", x);
        }
        public static void multiplication1(ref int x)
        {
            x *= x;
            Console.WriteLine("variable value inside method is {0}", x);
        }
        public static void multiplication2(out int x)
        {
            x = 10;  // out type should be initialized inside method
            x *= x;
            Console.WriteLine("variable value inside method is {0}", x);
        }
        static void Main()
        {
            int a = 10;
           int b ;
            Console.WriteLine("pass by refernce");
            Console.WriteLine("the value of a before method call {0}",a);
            multiplication(a);
            Console.WriteLine("the value of a after method call {0}", a);

            /* In c#, passing a value type parameter to a method by reference means passing a
 * reference of the variable to the method.
 * So the changes made to the parameter inside of the called method will have an
 * effect on the original data stored in the argument variable. */
            Console.WriteLine("pass by refernce");
            Console.WriteLine("the value of a before method call {0}", a);
            multiplication1(ref a);
            Console.WriteLine("the value of a after method call {0}", a);

            /* In c#, out keyword is used to pass arguments to the method as a reference type.
 * The out keyword same as the ref keyword but the only difference is out doesn’t
 * require a variable to be initialized before we pass it as an argument to the
 * method but the variable must be initialized in called method before it returns a
 * value to the calling method. */

            Console.WriteLine("pass by out");
           // Console.WriteLine("the value of a before method call {0}", a);
            multiplication2(out b); //passing parameters by out
            Console.WriteLine("the value of a after method call {0}", b);

            Console.ReadKey();
        }
    }
}
