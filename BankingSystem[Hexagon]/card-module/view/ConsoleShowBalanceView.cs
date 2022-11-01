using BankingSystem_Hexagon_.card_module.core.ports;
using BankingSystem_Hexagon_.console_ui;

namespace BankingSystem_Hexagon_.card_module.view {
    internal class ConsoleShowBalanceView : IShowBalanceView {
        private readonly ConsoleUI consoleUI;
        public ConsoleShowBalanceView(ConsoleUI consoleUI) {
            this.consoleUI = consoleUI;
        }
        public void ShowBalance(float balance) {
            Console.WriteLine($"\tYour balance: {balance}$");
            Console.ReadKey();

            consoleUI.Rerender();
        }

        public void ShowErrorCard(string message) {
            Console.WriteLine(message);
        }
    }
}
