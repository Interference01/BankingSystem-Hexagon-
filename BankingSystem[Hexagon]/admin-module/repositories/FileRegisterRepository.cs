using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.admin_module.repositories {
    public class FileRegisterRepository : IRegisterRepository {
        private readonly FileStore fileStore;
        public FileRegisterRepository(FileStore fileStore) {
            this.fileStore = fileStore;
        }
        public void SaveClient(Client client) {

            fileStore.AddUser(new FileStore.UserDTO {
                Id = Guid.NewGuid(),
                Role = "C",
                Name = client.Name,
                Surname = client.Surname,
                Email = client.Email,
                Password = client.Password,
                Phone = client.Phone,
            });
        }
    }
}
