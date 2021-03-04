using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo3
{
    class Employee : IEmployee
    {
        int id;
        string name;

        public int empID { get { return id; } set { id = value; } }
        public string empName { get { return name; } set { name = value; } }
    }
}
