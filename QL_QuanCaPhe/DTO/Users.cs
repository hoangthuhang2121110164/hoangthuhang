using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_QuanCaPhe.DTO
{
    internal class Users
    {
        public int id;
        public string userID;
        public string firstName;
        public string lastName;
        public string email;
        public string tel;
        public DateTime DOB;
        public bool gender;
        public string userRole;
        public string username;
        public string password;
        public byte[] avatar { get; set; }
    }
}
