using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlJsonDemo
{
    class GenerateJson
    {
        static void Main()
        {
            Student s1 = new Student();
            s1.Rollno = 101;
            s1.Name = "rahul";
            s1.Courses = new List<string> {"Ajax","csharp","java","c++"};

            string jsonresult = JsonConvert.SerializeObject(s1);
            string path = @"c://Demo//student.json";
            using(var t=new StreamWriter(path, true))
            {
                t.WriteLine(jsonresult.ToString());
                t.Close();

            }
        }
    }
}
