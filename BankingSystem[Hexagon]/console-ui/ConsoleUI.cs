using BankingSystem_Hexagon_.console_ui.pages;

namespace BankingSystem_Hexagon_.console_ui {
    internal class ConsoleUI {
        public IPage CurrentPage { get; set; }
        public IPage HomePage { get; set; }


        public void Show(IPage page) {
            Console.Clear();

            CurrentPage = page;

            page.ShowContent();
        }

        public void ShowHomePage() {
            Show(HomePage);
        }

        public void Rerender() {
            if (CurrentPage != null) {
                Console.ReadKey();
                Show(CurrentPage);
            }
        }
    }
}
