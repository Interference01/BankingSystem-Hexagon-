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
    internal class ConsoleAuthView : IAuthView {
        private readonly ConsoleUI consoleUI;
        private readonly IPage clientPage;
        private readonly IPage adminPage;
        public ConsoleAuthView(ConsoleUI consoleUI, IPage clientPage, IPage adminPage) {
            this.consoleUI = consoleUI;
            this.clientPage = clientPage;
            this.adminPage = adminPage;
        }

        public void ShowAdminContent(User user) {
            consoleUI.Show(adminPage);
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
