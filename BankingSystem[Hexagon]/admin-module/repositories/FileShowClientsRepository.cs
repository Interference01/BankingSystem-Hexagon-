using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;

namespace BankingSystem_Hexagon_.admin_module.repositories {
    public class FileShowClientsRepository : IGetClientsRepository {
        private readonly FileStore fileStore;

        public FileShowClientsRepository(FileStore fileStore) {
            this.fileStore = fileStore;
        }

        public Client[] GetAllClients() {
            var users = fileStore.GetAllUsers();
            
            return users
                .Where(user => user.Role == "C")
                .Select(user => new Client() {
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    Phone = user.Phone,
                })
                .ToArray();
        }
    }
}
