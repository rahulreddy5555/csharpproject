using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newbasics
{
    class ArraysDemo
    {
        static void Main()
        {
            int[] evenNums = { 2, 4, 6, 8, 10 };
            string[] cities = { "Mumbai", "London", "New York" };
            int[] nums = new int[6] { 11,10, 15, 16, 8, 6 };

            for (int i = 0; i < evenNums.Length; i++)
                Console.WriteLine(evenNums[i]);

            for (int i = 0; i < evenNums.Length; i++)
                evenNums[i] = evenNums[i] + 10;

            foreach (var item in evenNums)
                Console.WriteLine(item);

            foreach (var city in cities)
                Console.WriteLine(city);

            Console.WriteLine("after sorting");
            Array.Sort(nums); // sorts array 
            foreach (var i in nums)
                Console.WriteLine(i);

            Console.WriteLine("searching");
            Console.WriteLine(Array.BinarySearch(nums, 16));// binary search 
            Console.WriteLine("reversed array");
            Array.Reverse(nums); // sorts array in descending order
            foreach (var j in nums)
                Console.WriteLine(j);

            Console.WriteLine("iterating array using for each");
             Array.ForEach(nums, n => Console.WriteLine(n)); // iterates array

            
           
          
            Console.ReadKey();

        }
    }
}
