using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.presenters;

namespace BankingSystem_Hexagon_.console_ui.pages {
    internal class AdminPage : IPage {
        private readonly RegisterClientPresenter registerClientPresenter;
        private readonly ConsoleUI consoleUI;
        public AdminPage(RegisterClientPresenter registerClientPresenter, ConsoleUI consoleUI) {
            this.registerClientPresenter = registerClientPresenter;
            this.consoleUI = consoleUI;
        }

        public void ShowContent() {
            Console.WriteLine("\t\tAdmin page\n\n");

            Console.WriteLine(
                "\t1 - Register new client \n" +
                "\t0 - Exit"
            );
            var command = Console.ReadLine();
            switch (command) {
                case "1":
                RegisterUser();
                break;

                case "0":
                consoleUI.ShowHomePage();
                break;

                default:
                break;
            }
        }
        private void RegisterUser() {
            Client client = new Client();
            Console.Write("Input name: ");
            client.Name = Console.ReadLine();
            Console.Write("Input surname: ");
            client.Surname = Console.ReadLine();
            Console.Write("Input email: ");
            client.Email = Console.ReadLine();
            Console.Write("Input password: ");
            client.Password = Console.ReadLine();
            Console.Write("Input phone: ");
            client.Phone = Console.ReadLine();

            registerClientPresenter.RegisterClient(client);
        }
    }
}
