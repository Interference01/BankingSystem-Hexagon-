using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.admin_module.core.use_cases;

namespace BankingSystem_Hexagon_.admin_module.core.presenters {
    internal class AddCardPresenter {
        private readonly AddCardUseCase addCardUseCase;
        private readonly IAddCardView addCardView;

        public AddCardPresenter(AddCardUseCase addCardUseCase, IAddCardView addCardView) {
            this.addCardUseCase = addCardUseCase;
            this.addCardView = addCardView;
        }

        public void AddCard(Guid id) {
            try {
                addCardUseCase.AddCardForClient(id);

                addCardView.ShowSuccessInfo();
            } catch (Exception e) {
                addCardView.ShowError(e.Message);
            }
        }

        public void AddCard(string email) {
            try {

                addCardUseCase.AddCardForClient(email);

                addCardView.ShowSuccessInfo();
            } catch (Exception e) {
                addCardView.ShowError(e.Message);
            }
        }
    }
}
