
namespace BankingSystem_Hexagon_.console_ui.pages {
    public class ClientPage : IPage {
        private readonly ConsoleUI ConsoleUI;

        public ClientPage(ConsoleUI consoleUI) {
            ConsoleUI = consoleUI;
        }

        public void ShowContent() {
            if (ConsoleUI.CurrentPage == null) {
                throw new Exception("Current user = null");
            }
            Console.WriteLine("Client Page"); // Add menu
        }
    }
}
