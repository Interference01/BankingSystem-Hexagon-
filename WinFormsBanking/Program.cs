using BankingSystem_Hexagon_;
using BankingSystem_Hexagon_.admin_module.core.presenters;
using BankingSystem_Hexagon_.admin_module.core.use_cases;
using BankingSystem_Hexagon_.admin_module.repositories;
using BankingSystem_Hexagon_.auth_module.core.presenters;
using BankingSystem_Hexagon_.auth_module.repositories;
using BankingSystem_Hexagon_.auth_module.use_cases;
using BankingSystem_Hexagon_.card_module.core.presenters;
using BankingSystem_Hexagon_.card_module.core.use_cases;
using BankingSystem_Hexagon_.card_module.repositories;
using WinFormsBanking.forms;
using WinFormsBanking.forms.adminForm;
using WinFormsBanking.views;
using WinFormsBanking.views.cardBalanceView;
using WinFormsBanking.views.showClients;

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

            var registerRepo = new FileRegisterRepository(fileStore);
            var registerUseCase = new RegisterClientUseCase(registerRepo);
            var registerView = new RegisterClientView();
            var registerPresenter = new RegisterClientPresenter(registerView, registerUseCase);

            var showClientsState = new ShowClientsState();
            var showClientsRepo = new FileShowClientsRepository(fileStore);
            var getClientsUseCase = new GetClientsUseCase(showClientsRepo);
            var showClientsView = new ShowClientsView(showClientsState);
            var showClientsPresenter = new ShowClientsPresenter(getClientsUseCase, showClientsView);

            var addCardRepo = new FileAddCardRepository(fileStore);
            var addCardUseCase = new AddCardUseCase(addCardRepo);
            var addCardView = new AddCardView();
            var addCardPresenter = new AddCardPresenter(addCardUseCase, addCardView);

            var inputForm = new InputForm(addCardPresenter, "Input email of client");
            var registerForm = new RegisterForm(registerPresenter);
            var adminForm = new AdminForm(registerForm, inputForm, showClientsPresenter, showClientsState);

            var cardBalanceState = new CardBalanceState();
            var cardBalanceRepo = new FileGetBalanceRepository(fileStore);
            var cardBalanceUseCase = new GetBalanceUseCase(cardBalanceRepo);
            var cardBalanceView = new ShowBalanceView(cardBalanceState);
            var cardBalancePresenter = new ShowBalancePresenter(cardBalanceUseCase, cardBalanceView);

            var clientForm = new ClientForm(cardBalancePresenter, cardBalanceState);


            var authView = new AuthView(formController, adminForm, clientForm);
            var authPresenter = new AuthPresenter(authUseCase, authView);
            var authForm = new AuthForm(authPresenter);


            formController.HomeForm = authForm;
            formController.ShowHomeForm();
        }
    }
}