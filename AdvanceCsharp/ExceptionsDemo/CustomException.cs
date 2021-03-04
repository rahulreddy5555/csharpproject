using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Userdefinedexception : Exception
    {
        public static void validate(int a)
        {
            if (a < 18)
            {
                throw new invalidAgeException("sorry!! age should be great than 18");

            }
            else
            {
                Console.WriteLine("submitted");
            }
        }
    }



    [Serializable]
    internal class invalidAgeException : Exception
    {
        public invalidAgeException(string msg)
        {
        }

        public invalidAgeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected invalidAgeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }







    class CustomException
    {
        static void Main()
        {
            int age;
            Console.WriteLine("enter age");
            age = Convert.ToInt32(Console.ReadLine());
            try
            {
                Userdefinedexception.validate(age);
            }
            catch(invalidAgeException e)
            {
                Console.WriteLine(e.Source);
            }
            Console.ReadKey();

        }
    }
}
