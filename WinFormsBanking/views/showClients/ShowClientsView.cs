using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;

namespace WinFormsBanking.views.showClients
{
    public class ShowClientsView : IShowClientsView
    {
        private readonly ShowClientsState State;
        public ShowClientsView(ShowClientsState state)
        {
            this.State = state;
        }
        public void ShowClientInfo(Client[] client)
        {
            State.ShowClients(client);
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
