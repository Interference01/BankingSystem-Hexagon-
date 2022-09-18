using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using BankingSystem_Hexagon_.auth_module.repositories.models;

namespace BankingSystem_Hexagon_.auth_module.repositories {
    internal class AuthRepositoryList : IAuthRepository {
        private List<UserDTO> Users = new List<UserDTO>() {
            new UserDTO(){Id = Guid.NewGuid(), Login = "Val", Password = "1111", Role = "C" },
            new UserDTO(){Id = Guid.NewGuid(), Login = "Vlad", Password = "1111", Role = "A" },
        };
        public User? GetUser(string login, string password) {
            UserDTO user = Users.Find(x => x.Login == login && x.Password == password);

            if (user != null) {
                var role = user.Role == "A" ? User.Role.Admin : User.Role.Client;
                return new User(user.Id, role);
            }

            return null;
        }
    }
}
