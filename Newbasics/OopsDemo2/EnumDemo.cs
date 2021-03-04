using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo2
{
    class EnumDemo
    {
        enum colors { RED,GREEN,BLUE};

        enum colors1{ RED=10, GREEN=20, BLUE };

        enum days { sun,mon,tue,wed,thur,fri,sat};

       // public enum Emp {​​​​ Pacino, Spacey, Crowe, Pitt, Jolie }​​​​;
  
        static void Main()
        {
            Console.WriteLine("red :{0}",(int)colors.RED);
            Console.WriteLine("Green :{0}", (int)colors.GREEN);
            Console.WriteLine("Blue :{0}", (int)colors.BLUE);

            Console.WriteLine("red :{0}", (int)colors1.RED);
            Console.WriteLine("Green :{0}", (int)colors1.GREEN);
            Console.WriteLine("Blue :{0}", (int)colors1.BLUE);

            foreach(days d in  Enum.GetValues(typeof(days)))
            {
                Console.WriteLine(d);
            }
            int count = 0;
         /*   foreach(Emp e in Enum.GetValues(typeof))
int count = 0;
            foreach (Emp e in Enum.GetValues(typeof(Emp)))
            {​​​​
                count++;
                Console.Write("Employee " + count + "...");
                Console.WriteLine(e);
            }​​​​*/
            Console.ReadKey();

        }
    }
}
