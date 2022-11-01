using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using WinFormsBanking.forms;

namespace WinFormsBanking.views {
    public class AuthView : IAuthView {
        private readonly FormController formController;
        private readonly AdminForm adminForm;
        private readonly ClientForm clientForm;

        public AuthView(FormController formController, AdminForm adminForm, ClientForm clientForm) {
            this.formController = formController;
            this.adminForm = adminForm;
            this.clientForm = clientForm;
        }


        public void SetCurrentUser(User user) {

        }

        public void ShowAdminContent(User user) {
            formController.Show(adminForm);
        }

        public void ShowClientContent(User user) {
            formController.Show(clientForm);
        }

        public void ShowError(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
