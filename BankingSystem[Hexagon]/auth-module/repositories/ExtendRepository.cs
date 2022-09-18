using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;

namespace BankingSystem_Hexagon_.auth_module.repositories {
    class ExtendRepository : IAuthRepository {

        public List<User> Users = new List<User>() {
                new User(Guid.NewGuid(), User.Role.Client) {Login = "Lav"},
                new User(Guid.NewGuid(), User.Role.Client){Login = "Val" },
                new User(Guid.NewGuid(), User.Role.Client){Login = "Sara" },
                new User(Guid.NewGuid(), User.Role.Admin){Login = "Vlad" }
        };

        public User? GetUser(string login, string password) {
            User user= Users.Find(x => x.Login == login && x.Password == password);

            if (user != null) 
            return user;

            return null;
        }





    }
}
