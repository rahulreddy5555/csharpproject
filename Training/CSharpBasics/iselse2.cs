﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
	class iselse2
	{
		public static void Main(string[] args)
		{
			int number = 12;

			if (number < 5)
			{
				Console.WriteLine("{0} is less than 5", number);
			}
			else if (number > 5)
			{
				Console.WriteLine("{0} is greater than 5", number);
			}
			else
			{
				Console.WriteLine("{0} is equal to 5");
			}
			Console.ReadKey();
		}
	}
}
