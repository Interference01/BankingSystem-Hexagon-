using BankingSystem_Hexagon_.console_ui.pages;

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
                Thread.Sleep(1000);
                Show(CurrentPage);
            }
        }
    }
}
