using BankingSystem_Hexagon_.card_module.core.models;

namespace BankingSystem_Hexagon_.card_module.repositories {
    public class FileGetBalanceRepository : IGetBalanceRepository {
        private readonly FileStore fileStore;

        public FileGetBalanceRepository(FileStore fileStore) {
            this.fileStore = fileStore;
        }

        public Card? GetCard(Guid id) { 
            var user = fileStore.GetAllUsers().FirstOrDefault(u =>u.Id == id);

            if (user == null || user.Card == null) {
                return null;
            }


            return new Card() {
                Id = user.Card.Id,
                Balance = user.Card.Balance,
                NumberCard = user.Card.Number
            };
        }
    }
}
