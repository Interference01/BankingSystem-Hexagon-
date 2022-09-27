using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.admin_module.core.use_cases;

namespace BankingSystem_Hexagon_.admin_module.core.presenters {
    internal class ShowClientsPresenter {
        private readonly ShowClientsUseCace showClientUse;
        private readonly IShowClientsView showClientsView;

        public ShowClientsPresenter(ShowClientsUseCace showClientsUseCace, IShowClientsView showClientsView) {
            this.showClientUse = showClientsUseCace;
            this.showClientsView = showClientsView;
        }

        public void ShowClients() {
            var clients = showClientUse.ShowClients();

            if (clients.Length > 0) {
                showClientsView.ShowClientInfo(clients);
            } else {
                showClientsView.ShowErrorMessage("Clients not exist");
            }
        }
    }
}
