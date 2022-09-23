using BankingSystem_Hexagon_.console_ui;
using BankingSystem_Hexagon_.console_ui.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.admin_module.core.view {
    internal class ConsoleRegisterView : IRegisterClientView {
        private readonly ConsoleUI consoleUI;
        private readonly IPage adminPage;
        public ConsoleRegisterView(ConsoleUI consoleUI, IPage adminPage) {
            this.consoleUI = consoleUI;
            this.adminPage = adminPage;
        }
        public void ShowSuccessInfo() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The client is successfully registered");
            Console.ForegroundColor = ConsoleColor.White;

            consoleUI.Show(adminPage);
        }
        public void ShowRegisterValidation(string message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

            consoleUI.Rerender();
        }
    }
}
