﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In the below example, we calculate 
//the electricity bills for commercial and domestic plans using abstract class and abstract methods.
namespace OopsDemo3
{
    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();

        public void calculation(int units)
        {
            double bill = rate * units;
            Console.WriteLine("bill amount of {0} units is: {1}", bill, units);



        }

    }

    class CommercialPlan : Plan
    {
        public override void getRate()
        {
            rate = 5.00;
        }
    }

    class DomesticPlan : Plan
    {
        public override void getRate()
        {
            rate = 2.50;
        }
    }

    class AbstractDemo1
    {
        static void Main()
        {
            Plan p;
            Console.WriteLine("COMMERCIAL CONNECTION");
            p = new CommercialPlan();
            p.getRate();
            p.calculation(250);
            Console.WriteLine("DOMESTIC CONNECTION");
            p = new DomesticPlan();
            p.getRate();
            p.calculation(150);
            Console.ReadKey();
        }
    }
}