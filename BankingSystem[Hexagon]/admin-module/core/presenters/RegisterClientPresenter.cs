using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.use_cases;
using BankingSystem_Hexagon_.admin_module.core.view;

namespace BankingSystem_Hexagon_.admin_module.core.presenters {
    public class RegisterClientPresenter {
        private IRegisterClientView registerClientView;
        private RegisterClientUseCase registerClientUseCase;

        public RegisterClientPresenter(IRegisterClientView registerClientView, RegisterClientUseCase registerClientUseCase) {
            this.registerClientView = registerClientView;
            this.registerClientUseCase = registerClientUseCase;
        }

        public void RegisterClient(Client client) {
            try {
                registerClientUseCase.Register(client);

                registerClientView.ShowSuccessInfo();
            } catch (Exception e) {
                registerClientView.ShowRegisterValidation(e.Message);
            }
        }
    }
}
