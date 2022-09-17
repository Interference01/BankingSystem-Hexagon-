using BankingSystem_Hexagon_.auth_module.core.presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.console_ui.pages {
    internal class AuthPage : IPage {
        private readonly AuthPresenter authPresenter;

        public AuthPage(AuthPresenter authPresenter) {
            this.authPresenter = authPresenter;
        }

        public void ShowContent() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Auth page");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Enter login: ");
            var login = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter password: ");
            var password = Console.ReadLine();

            authPresenter.Login(login, password);
        }
    }
}
