using BankingSystem_Hexagon_.admin_module.core.models;

namespace WinFormsBanking.views.showClients
{
    public class ShowClientsState
    {
        public delegate void ShowClientsDelegate(Client[] client);
        public event ShowClientsDelegate showClientsEvent;

        public void ShowClients(Client[] client) {
            showClientsEvent(client);
        }

    }
}
