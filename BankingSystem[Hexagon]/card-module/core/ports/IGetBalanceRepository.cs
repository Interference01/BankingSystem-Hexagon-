using BankingSystem_Hexagon_.card_module.core.models;
using static BankingSystem_Hexagon_.FileStore;

namespace BankingSystem_Hexagon_.card_module.repositories {
    public interface IGetBalanceRepository {
        public Card GetCard(Guid id);
    }
}
