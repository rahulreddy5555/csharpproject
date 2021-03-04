using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Address
    {
        public int ID { get; set; }
        public string AddressLine{ get; set; }
      
        public static List<Address> GetAllAddress()
        {
            return new List<Address>()
            {
                new Address { ID = 1, AddressLine="ranchi" },
                new Address { ID = 2, AddressLine="kochi"},
                new Address{ ID = 3, AddressLine="kerela" },
                new Address { ID = 4,AddressLine="manali"},
                new Address { ID = 5, AddressLine="jarkand" },
                new Address { ID = 6,AddressLine="medak"},
                new Address { ID = 7, AddressLine="karnataka"},
                new Address { ID = 8, AddressLine="kanyakumari" },
               
            };
        }
    }
}
