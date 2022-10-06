using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.admin_module.core.use_cases;

namespace BankingSystem_Hexagon_.admin_module.core.presenters {
    internal class ShowClientsPresenter {
        private readonly GetClientsUseCase showClientUse;
        private readonly IShowClientsView showClientsView;

        public ShowClientsPresenter(GetClientsUseCase showClientsUseCace, IShowClientsView showClientsView) {
            this.showClientUse = showClientsUseCace;
            this.showClientsView = showClientsView;
        }

        public void ShowClients() {
            var clients = showClientUse.GetClients();

            if (clients.Length > 0) {
                showClientsView.ShowClientInfo(clients);
            } else {
                showClientsView.ShowErrorMessage("Clients not exist");
            }
        }
    }
}
