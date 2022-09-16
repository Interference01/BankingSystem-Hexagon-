using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.auth_module.repositories {
    internal class AuthRepositoryTemp : IAuthRepository {
        public User? GetUser(string login, string password) {
            if (login == "val" && password == "1111") {
                return new User() { Id = Guid.NewGuid()};
            }
            return null;
        }
    }
}
