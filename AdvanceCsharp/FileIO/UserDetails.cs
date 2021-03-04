using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    [Serializable()]
    class UserDetails
    {
        int userId;
        string userName;
        [NonSerialized()]
        string location;   //feild not saved

        public UserDetails(int userId, string userName, string location)
        {
            this.userId = userId;
            this.userName = userName;
            this.location = location;
        }

        public int UserId { get => userId; set => userId = value; }
        public string UserName { get => userName; set => userName = value; }

      
        public string Location { get => location; set => location = value; }

        public void getDetails()
        {
            Console.WriteLine("user id: {0}",UserId);
            Console.WriteLine("user name: {0}", UserName);
            Console.WriteLine("location: {0}", Location);
        }






    }
}
