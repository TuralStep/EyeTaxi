using Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source.Repositories.Contexts
{
    public class FakeDbContext
    {

        public static List<User> Users { get; set; } = new()
        {
            new User() { Name = "Tural", Email = "email1", Password = "tural123" },
            new User() { Name = "Ilham", Email = "email2", Password = "ilham123" },
            new User() { Name = "Iqbal", Email = "email3", Password = "iqbal123" },
            new User() { Name = "Nihad", Email = "email4", Password = "nihad123" }
        };

        public static List<User> GetUsers()
        {
            var list = new List<User>();

            // data from json

            return list;
        }

    }
}
