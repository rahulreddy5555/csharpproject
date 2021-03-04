using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class DeserializationDemo
    {
        static void Main()
        {
            string fpath = @"c:\demo\serialize.txt";

            //open the file
            Stream s = File.Open(fpath, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            //deserialize
            UserDetails ud = (UserDetails)bf.Deserialize(s);
            s.Close();
            Console.WriteLine("after deserialization");

            ud.getDetails();
            Console.ReadKey();


        }
    }
}
