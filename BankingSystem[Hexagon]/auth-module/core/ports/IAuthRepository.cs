using BankingSystem_Hexagon_.auth_module.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.auth_module.core.ports {
    internal interface IAuthRepository {
        public User? GetUser(string login, string password);
    }
}
