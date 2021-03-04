using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo
{
    class NumberHelper
    {
        int _number;

        public NumberHelper(int number)
        {
            _number = number;
        }

        public void DisplayNumbers()
        {
            for (int i = 1; i <= _number; i++)
            {
                Console.WriteLine("value : " + i);
            }
        }
    }
}
