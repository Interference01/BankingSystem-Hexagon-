using BankingSystem_Hexagon_.console_ui.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.console_ui {
    internal class ConsoleUI {
        public IPage CurrentPage { get; set; }

        public void Show(IPage page) {
            Console.Clear();

            CurrentPage = page;

            page.ShowContent();
        }
        public void Rerender() {
            if (CurrentPage != null) {
                Thread.Sleep(2000);
                Show(CurrentPage);
            }
        }
    }
}
