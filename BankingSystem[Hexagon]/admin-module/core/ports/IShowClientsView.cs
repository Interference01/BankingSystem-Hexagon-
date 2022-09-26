using BankingSystem_Hexagon_.admin_module.core.models;

namespace BankingSystem_Hexagon_.admin_module.core.ports {
    internal interface IShowClientsView {
        public void ShowClientInfo(Client[] client);
        public void ShowErrorMessage(string message);
    }
}
