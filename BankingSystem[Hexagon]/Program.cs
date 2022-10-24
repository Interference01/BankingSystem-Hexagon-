using BankingSystem_Hexagon_.admin_module.core.presenters;
using BankingSystem_Hexagon_.admin_module.core.use_cases;
using BankingSystem_Hexagon_.admin_module.core.view;
using BankingSystem_Hexagon_.admin_module.repositories;
using BankingSystem_Hexagon_.admin_module.view;
using BankingSystem_Hexagon_.auth_module.core.presenters;
using BankingSystem_Hexagon_.auth_module.repositories;
using BankingSystem_Hexagon_.auth_module.use_cases;
using BankingSystem_Hexagon_.auth_module.view;
using BankingSystem_Hexagon_.card_module.core.presenters;
using BankingSystem_Hexagon_.card_module.core.use_cases;
using BankingSystem_Hexagon_.card_module.repositories;
using BankingSystem_Hexagon_.card_module.view;
using BankingSystem_Hexagon_.console_ui;
using BankingSystem_Hexagon_.console_ui.pages;

namespace BankingSystem_Hexagon_ {
    internal class Program { 
        static void Main(string[] args) {
            var consoleUI = new ConsoleUI();
            var fileStore = FileStore.CreateFileStore();

            var authRepo = new FileAuthRepository(fileStore);
            var authRepoDecorator = new AuthRepositorySaveNameToFileDecorator(authRepo);
            var authUseCase = new AuthUseCase(authRepoDecorator);

            var registerRepository = new FileRegisterRepository(fileStore);
            var registerClientUseCase = new RegisterClientUseCase(registerRepository);
            var consoleRegisterView = new ConsoleRegisterView(consoleUI);
            var registerClientPresenter = new RegisterClientPresenter(consoleRegisterView, registerClientUseCase);

            var showClientsRepository = new FileShowClientsRepository(fileStore);
            var showClientsUseCase = new GetClientsUseCase(showClientsRepository);
            var consoleShowClientsView = new ConsoleShowClientsView(consoleUI);
            var showClientsPresenter = new ShowClientsPresenter(showClientsUseCase, consoleShowClientsView);

            var addCardRepository = new FileAddCardRepository(fileStore);
            var addCardUseCase = new AddCardUseCase(addCardRepository);
            var consoleAddCardView = new ConsoleAddCardView(consoleUI);
            var addCardPresenter = new AddCardPresenter(addCardUseCase, consoleAddCardView);

            var getBalanceRepository = new FileGetBalanceRepository(fileStore);
            var getBalanceUseCase = new GetBalanceUseCase(getBalanceRepository);
            var consoleShowBalanceView = new ConsoleShowBalanceView(consoleUI);
            var showBalancePresenter = new ShowBalancePresenter(getBalanceUseCase, consoleShowBalanceView);

            var clientPage = new ClientPage(consoleUI, showBalancePresenter);
            var adminPage = new AdminPage(registerClientPresenter, showClientsPresenter, addCardPresenter, consoleUI);

            var authView = new ConsoleAuthView(consoleUI, clientPage, adminPage);
            var authPresenter = new AuthPresenter(authUseCase, authView);
            var authPage = new AuthPage(authPresenter);

            consoleUI.HomePage = authPage;
            consoleUI.ShowHomePage();
        }
    }
}