using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using WinFormsBanking.forms;

namespace WinFormsBanking.views {
    public class AuthView : IAuthView {
        private readonly FormController formController;

        public AuthView(FormController formController) {
            this.formController = formController;
        }


        public void SetCurrentUser(User user) {

        }

        public void ShowAdminContent(User user) {
            formController.Show(new AdminForm());
        }

        public void ShowClientContent(User user) {
            formController.Show(new ClientForm());
        }

        public void ShowError(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
