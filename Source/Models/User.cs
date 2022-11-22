using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Models
{
    public class User : Entity
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            Id = Guid.NewGuid();
        }

        public User(string name, string email, string password)
            :this()
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
