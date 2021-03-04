﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{

    class BinarywriterExample
    {
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("c:\\Demo\\binaryfile.dat", FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
                Console.WriteLine("Integer Value : " + reader.ReadInt32());

            }
        }

            static void Main(string[] args)
        {
            string fileName = "c:\\Demo\\binaryfile.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(2.5);
                writer.Write("this is string data");
                writer.Write(true);
                writer.Write(10);
            }
            Console.WriteLine("Data written successfully...");
            Console.WriteLine("_____read binary file_____");
            ReadBinaryFile();

            Console.ReadKey();
        }
    }
}
