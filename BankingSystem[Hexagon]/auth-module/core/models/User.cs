using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.auth_module.models {
    internal class User {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Role _Role { get; set; }
        public enum Role { Client, Admin }

        public User(Guid id, Role role) {
            Id = id;
            _Role = role;
            Login = "user";
            Password = "1111";
        }
    }
}
