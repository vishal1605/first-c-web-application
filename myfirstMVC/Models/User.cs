using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myfirstMVC.Models
{
    public class User
    {
        public int U_id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public String Psw { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public User(int id, string email, string name, string password)
        {
            this.U_id = id;
            this.Email = email;
            this.Name = name;
            this.Psw = password;

        }
        public User()
        {

        }
    }
}
