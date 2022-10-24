using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;

namespace BankingSystem_Hexagon_.auth_module.repositories {
    internal class FileAuthRepository : IAuthRepository {
        private readonly FileStore fileStore;
        public FileAuthRepository(FileStore fileStore) {
            this.fileStore = fileStore;
        }

        public User? GetUser(string login, string password) {
            var users = fileStore.GetAllUsers();
            var user = users.FirstOrDefault(u => u.Email == login && u.Password == password);

            if (user == null) {
                return null;
            }

            var role = user.Role == "A" ? User.Role.Admin : User.Role.Client;

            return new User(user.Id, role);
        }
    }
}
