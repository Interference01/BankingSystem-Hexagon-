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

        public void SaveCard(Guid userId, string numberCard) {
            var users = fileStore.GetAllUsers();
            var user = users.First(user => user.Id == userId);

            if (user.Card == null) {
                throw new Exception("This user has a card");
            }

            user.Card = new CardDTO() {
                Number = numberCard,
            };

        }
    }
}
