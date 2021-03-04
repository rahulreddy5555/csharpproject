using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Dog
    {
        string name;
        int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
    class LambdaDemo2
    {
        static void Main()
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog { Name = "rock1", Age = 1 },
                  new Dog { Name = "rock2", Age = 2 },
                    new Dog { Name = "rock3", Age = 3 }
            };
            var names = dogs.Select(x => x.Name);
            foreach(var i in names)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
