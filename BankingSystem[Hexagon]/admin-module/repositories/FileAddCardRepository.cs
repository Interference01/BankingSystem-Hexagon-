using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.auth_module.repositories.models;
using static BankingSystem_Hexagon_.FileStore;

namespace BankingSystem_Hexagon_.admin_module.repositories {
    public class FileAddCardRepository : IAddCardRepository {
        private readonly FileStore fileStore;

        public FileAddCardRepository(FileStore fileStore) {
            this.fileStore = fileStore;
        }

        public Guid GetUserIdByEmail(string email) {
            var user = fileStore.GetAllUsers().First(x => x.Email == email);
            
            return user.Id;
        }

        public bool IsExistCard(string numberCard) {
            var users = fileStore.GetAllUsers();
            
            return users.Any(x => x.Card != null && x.Card.Number == numberCard);
        }

        public void SaveCard(Guid guid, string numberCard) {
            var users = fileStore.GetAllUsers();
            var user = users.Where(user => user.Id == guid).ToList();

            user[0].Card = new Card() {
                Number = numberCard,
            };
        }
    }
}
