using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;

namespace BankingSystem_Hexagon_.admin_module.core.use_cases {
    internal class ShowClientsUseCace {
        private readonly IShowClientsRepository showClientsRepository;
        public ShowClientsUseCace(IShowClientsRepository showClientsRepository) {
            this.showClientsRepository = showClientsRepository;
        }

        public Client[] ShowClients() {
            var clients = showClientsRepository.GetAllClients();
            
            return clients;
        }
    }
}
