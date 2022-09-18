using BankingSystem_Hexagon_.auth_module.models;

namespace BankingSystem_Hexagon_.auth_module.repositories {
    static class ExtendRepository {

        public static List<User> Users = new List<User>() {
                new User(Guid.NewGuid(), User.Role.Client) {Login = "Lav"},
                new User(Guid.NewGuid(), User.Role.Client){Login = "Val" },
                new User(Guid.NewGuid(), User.Role.Client){Login = "Sara" },
                new User(Guid.NewGuid(), User.Role.Admin){Login = "Vlad" }
        };





    }
}
