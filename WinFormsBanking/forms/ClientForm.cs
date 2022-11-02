using BankingSystem_Hexagon_.card_module.core.presenters;
using WinFormsBanking.views.cardBalanceView;

namespace WinFormsBanking.forms {
    public partial class ClientForm : Form {
        private readonly ShowBalancePresenter showBalancePresenter;
        private readonly CardBalanceState cardBalanceState;
        private readonly CurrentUser currentUser;
        private readonly FormController formController;

        public ClientForm(ShowBalancePresenter showBalancePresenter, CardBalanceState cardBalanceState, CurrentUser currentUser, FormController formController) {
            this.showBalancePresenter = showBalancePresenter;
            this.cardBalanceState = cardBalanceState;
            this.currentUser = currentUser;
            this.formController = formController;
            cardBalanceState.cardBalanceEvent += CardBalance;
            InitializeComponent();
        }

        private void ActuallyInfo() {
            showBalancePresenter.ShowBalanceCard(currentUser.User.Id);
        }
        private void CardBalance(float cardBalance) {
            lInfo.Text = $"Balance: {cardBalance}";
        }

        private void ClientForm_Load(object sender, EventArgs e) {
            ActuallyInfo();
        }

        private void button1_Click(object sender, EventArgs e) {
            formController.ShowHomeForm();
        }
    }
}
