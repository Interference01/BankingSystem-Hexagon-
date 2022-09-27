using BankingSystem_Hexagon_.admin_module.core.models;

namespace BankingSystem_Hexagon_.admin_module.core.ports {
    public interface IShowClientsRepository {
        public Client[] GetAllClients();
    }
}
