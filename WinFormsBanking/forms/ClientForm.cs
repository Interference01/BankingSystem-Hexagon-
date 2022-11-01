using BankingSystem_Hexagon_.card_module.core.presenters;
using WinFormsBanking.views.cardBalanceView;

namespace WinFormsBanking.forms {
    public partial class ClientForm : Form {
        private readonly ShowBalancePresenter showBalancePresenter;
        private readonly CardBalanceState cardBalanceState;

        public ClientForm(ShowBalancePresenter showBalancePresenter, CardBalanceState cardBalanceState) {
            this.showBalancePresenter = showBalancePresenter;
            this.cardBalanceState = cardBalanceState;
            cardBalanceState.cardBalanceEvent += CardBalance;
            InitializeComponent();
            ActuallyInfo();
        }

        private void ActuallyInfo() {
            showBalancePresenter.ShowBalanceCard();
        }
        private void CardBalance(float cardBalance) {
            lInfo.Text = $"Balance: {cardBalance}";
        }
    }
}
