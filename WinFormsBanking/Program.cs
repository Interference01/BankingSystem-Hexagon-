using BankingSystem_Hexagon_;
using BankingSystem_Hexagon_.auth_module.core.presenters;
using BankingSystem_Hexagon_.auth_module.repositories;
using BankingSystem_Hexagon_.auth_module.use_cases;
using WinFormsBanking.views;

namespace WinFormsBanking {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();

            var fileStore = FileStore.CreateFileStore();
            var formController = new FormController();
            var authRepo = new FileAuthRepository(fileStore);
            var authUseCase = new AuthUseCase(authRepo);

            var authView = new AuthView(formController);
            var authPresenter = new AuthPresenter(authUseCase, authView);
            var authForm = new AuthForm(authPresenter);

            formController.HomeForm = authForm;
            formController.ShowHomeForm();
        }
    }
}