using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.console_ui;

namespace BankingSystem_Hexagon_.admin_module.view {
    internal class ConsoleShowClientsView : IShowClientsView {
        private readonly ConsoleUI consoleUI;
        public ConsoleShowClientsView(ConsoleUI consoleUI) {
            this.consoleUI = consoleUI;
        }
        public void ShowClientInfo(Client[] clients) {
            foreach (var client in clients) {
                Console.WriteLine($" Name: {client.Name}\n Surname: {client.Surname}\n Phone: {client.Phone}\n");
            }
            
            consoleUI.Rerender();
        }

        public void ShowErrorMessage(string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

            consoleUI.Rerender();
        }
    }
}
