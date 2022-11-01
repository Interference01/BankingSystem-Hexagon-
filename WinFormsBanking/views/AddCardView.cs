using BankingSystem_Hexagon_.admin_module.core.ports;

namespace WinFormsBanking.views {
    public class AddCardView : IAddCardView {
        public void ShowError(string message) {
            MessageBox.Show(message);
        }

        public void ShowSuccessInfo() {
            MessageBox.Show("The client is successfully added card");
        }
    }
}
