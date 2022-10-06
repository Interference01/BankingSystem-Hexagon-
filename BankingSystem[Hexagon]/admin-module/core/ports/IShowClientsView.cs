using BankingSystem_Hexagon_.admin_module.core.models;

namespace BankingSystem_Hexagon_.admin_module.core.ports {
    public interface IShowClientsView {
        public void ShowClientInfo(Client[] client);
        public void ShowErrorMessage(string message);
    }
}
