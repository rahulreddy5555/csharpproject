using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIO
{
    class FileStreamDemo
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("c:\\Demo\\abc.txt",FileMode.OpenOrCreate);
            Console.WriteLine("file opened");
            f.WriteByte(70);
            Console.WriteLine("data writtern in file");
            f.Close();

            FileStream f1= new FileStream("c:\\Demo\\abc.txt", FileMode.OpenOrCreate);
            char a = (char)f1.ReadByte();
            Console.WriteLine("data read from file is "+a);
            f1.Close();
            Console.WriteLine("file stream closed");

            Console.ReadKey();
        }
    }
}
