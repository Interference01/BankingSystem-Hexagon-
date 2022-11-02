using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;

namespace BankingSystem_Hexagon_.admin_module.core.use_cases {
    public class GetClientsUseCase {
        private readonly IGetClientsRepository showClientsRepository;

        public GetClientsUseCase(IGetClientsRepository showClientsRepository) {
            this.showClientsRepository = showClientsRepository;
        }

        public Client[] GetClients() {
            var clients = showClientsRepository.GetAllClients();

            return clients;
        }
    }
}
