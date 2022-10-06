using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.console_ui;

namespace BankingSystem_Hexagon_.admin_module.view {
    internal class ConsoleAddCardView : IAddCardView {
        private readonly ConsoleUI consoleUI;

        public ConsoleAddCardView(ConsoleUI consoleUI) {
            this.consoleUI = consoleUI;
        }

        public void ShowError(string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

            consoleUI.Rerender();
        }

        public void ShowSuccessInfo() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The client is successfully added card");
            Console.ForegroundColor = ConsoleColor.White;

            consoleUI.Rerender();
        }
    }
}
