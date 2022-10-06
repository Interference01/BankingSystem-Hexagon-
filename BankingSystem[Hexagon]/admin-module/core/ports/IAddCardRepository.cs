using BankingSystem_Hexagon_.admin_module.core.models;

namespace BankingSystem_Hexagon_.admin_module.core.ports {
    public interface IAddCardRepository {
        public void SaveCard(Guid guid, string numberCard);
        public bool IsExistCard(string numberCard);
        public Guid GetUserIdByEmail(string email);
    }
}
