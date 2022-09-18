using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;

namespace BankingSystem_Hexagon_.auth_module.repositories {
    internal class AuthRepositoryTemp : IAuthRepository {
        public User? GetUser(string login, string password) {
            if (login == "val" && password == "1111") {
                return new User(Guid.NewGuid(),User.Role.Client);
            }
            if (login == "admin" && password == "1111") {
                return new User(Guid.NewGuid(), User.Role.Admin);
            }
            return null;
        }
    }
}
