using BankingSystem_Hexagon_.card_module.core.ports;

namespace WinFormsBanking.views.cardBalanceView
{
    public class ShowBalanceView : IShowBalanceView
    {
        private readonly CardBalanceState cardBalanceState;
        public ShowBalanceView(CardBalanceState cardBalanceState) {
            this.cardBalanceState = cardBalanceState;
        }

        public void ShowBalance(float balance)
        {
            cardBalanceState.ShowBalance(balance);
        }

        public void ShowErrorCard(string message) {
            MessageBox.Show(message);
        }
    }
}
