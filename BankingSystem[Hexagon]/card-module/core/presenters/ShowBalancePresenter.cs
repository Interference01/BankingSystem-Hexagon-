
using BankingSystem_Hexagon_.card_module.core.ports;
using BankingSystem_Hexagon_.card_module.core.use_cases;

namespace BankingSystem_Hexagon_.card_module.core.presenters {
    public class ShowBalancePresenter {
        private readonly GetBalanceUseCase balanceUseCase;
        private readonly IShowBalanceView showBalanceView;
        public ShowBalancePresenter(GetBalanceUseCase balanceUseCase, IShowBalanceView showBalanceView) {
            this.balanceUseCase = balanceUseCase;
            this.showBalanceView = showBalanceView;
        }

        public void ShowBalance() {
            var balance = balanceUseCase.GetBalance();

            showBalanceView.ShowBalance(balance);
        }
    }
}
