using BankingSystem_Hexagon_.admin_module.core.view;

namespace WinFormsBanking.views {
    public class RegisterClientView : IRegisterView {
        public void ShowRegisterValidation(string message) {
            MessageBox.Show(message);
        }

        public void ShowSuccessInfo() {
            MessageBox.Show("Client successfully registered");
        }
    }
}
