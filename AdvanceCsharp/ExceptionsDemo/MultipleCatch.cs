﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class MultipleCatch
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("ENTER ANY TWO NUMBERS");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine("second number should not be zero   , "+dbze.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("enter only integer numbers  , "+fe.Message);
            }
            finally
            {
                Console.WriteLine("in finally block");
            }
            Console.ReadKey();
        }
    }
}
