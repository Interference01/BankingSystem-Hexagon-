using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using BankingSystem_Hexagon_.console_ui;
using BankingSystem_Hexagon_.console_ui.pages;

namespace BankingSystem_Hexagon_.auth_module.view {
    internal class ConsoleAuthView : IAuthView {
        private readonly ConsoleUI ConsoleUI;
        private readonly IPage ClientPage;
        private readonly IPage AdminPage;

        public ConsoleAuthView(ConsoleUI consoleUI, IPage clientPage, IPage adminPage) {
            this.ConsoleUI = consoleUI;
            this.ClientPage = clientPage;
            this.AdminPage = adminPage;
        }

        public void SetCurrentUser(User user) {
            ConsoleUI.CurrentUser = user;
        }

        public void ShowAdminContent(User user) {
            ConsoleUI.Show(AdminPage);
        }

        public void ShowClientContent(User user) {
            ConsoleUI.Show(ClientPage);
        }

        public void ShowError(string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

            ConsoleUI.Rerender();
        }
    }
}
