

using BankingSystem_Hexagon_.card_module.core.presenters;

namespace BankingSystem_Hexagon_.console_ui.pages {
    public class ClientPage : IPage {
        private readonly ConsoleUI consoleUI;
        private readonly ShowBalancePresenter showBalancePresenter;

        public ClientPage(ConsoleUI consoleUI, ShowBalancePresenter showBalancePresenter) {
            this.consoleUI = consoleUI;
            this.showBalancePresenter = showBalancePresenter;
        }

        public void ShowContent() {
            if (consoleUI.CurrentUser == null) {
                throw new Exception("Current user is null");
            }

            Console.WriteLine("\t\tClient page\n\n");

            Console.WriteLine(
                "\t1 - Show balance card  \n" +
                "\t2 -  \n" +
                "\t3 -  \n" +
                "\t0 - Exit"
            );
            var command = Console.ReadLine();
            switch (command) {
                case "1":
                    showBalancePresenter.ShowBalanceCard(consoleUI.CurrentUser.Id);
                break;

                case "2":
                break;

                case "3":
                break;

                case "0":
                consoleUI.ShowHomePage();
                break;

                default:
                break;
            }
        }
    }
}
