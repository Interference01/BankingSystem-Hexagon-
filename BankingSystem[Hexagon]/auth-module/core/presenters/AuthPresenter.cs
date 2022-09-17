using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.use_cases;

namespace BankingSystem_Hexagon_.auth_module.core.presenters {
    internal class AuthPresenter {
        private readonly AuthUseCase authUseCase;
        private readonly IAuthView authView;

        public AuthPresenter(AuthUseCase authUseCase, IAuthView authView) {
            this.authUseCase = authUseCase;
            this.authView = authView;
        }

        public void Login(string login, string password) {
            try {
                var user = authUseCase.Login(login, password);

                authView.ShowClientContent(user);
            } catch (Exception e) {
                authView.ShowError(e.Message);
            }
        }
    }
}
