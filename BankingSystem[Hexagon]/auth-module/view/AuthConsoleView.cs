using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using BankingSystem_Hexagon_.console_ui;
using BankingSystem_Hexagon_.console_ui.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.auth_module.view {
    internal class AuthConsoleView : IAuthView {
        private readonly ConsoleUI consoleUI;
        private readonly IPage clientPage;
        public AuthConsoleView(ConsoleUI consoleUI, IPage clientPage) {
            this.consoleUI = consoleUI;
            this.clientPage = clientPage;
        }
        public void ShowClientContent(User user) {
            consoleUI.Show(clientPage);
        }

        public void ShowError(string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

            consoleUI.Rerender();
        }
    }
}
