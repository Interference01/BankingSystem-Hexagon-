using BankingSystem_Hexagon_.admin_module.core.models;

namespace BankingSystem_Hexagon_.admin_module.core.ports {
    internal interface IShowClientsRepository {
        public Client[] GetAllClients();
    }
}
