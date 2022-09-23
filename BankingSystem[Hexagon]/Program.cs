using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.core.presenters;
using BankingSystem_Hexagon_.auth_module.models;
using BankingSystem_Hexagon_.auth_module.repositories;
using BankingSystem_Hexagon_.auth_module.use_cases;
using BankingSystem_Hexagon_.auth_module.view;
using BankingSystem_Hexagon_.console_ui;
using BankingSystem_Hexagon_.console_ui.pages;

namespace BankingSystem_Hexagon_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleUI = new ConsoleUI();

            var authRepo = new AuthRepositoryList();
            var authUseCase = new AuthUseCase(authRepo);

            var clientPage = new ClientPage();
            var adminPage = new AdminPage();
            var authView = new ConsoleAuthView(consoleUI, clientPage, adminPage);
            var authPresenter = new AuthPresenter(authUseCase, authView);

            var authPage = new AuthPage(authPresenter);
            
            
            consoleUI.Show(authPage);








            Console.ReadKey();
        }
    }
}