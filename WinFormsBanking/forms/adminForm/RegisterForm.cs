using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.presenters;

namespace WinFormsBanking.forms.adminForm {
    public partial class RegisterForm : Form {
        private readonly RegisterClientPresenter registerClientPresenter;

        public RegisterForm(RegisterClientPresenter registerClientPresenter) {
            this.registerClientPresenter = registerClientPresenter;
            InitializeComponent();
            tbName.Select();
        }

        public void ShowCleanDialog() {
            while (Controls.Count > 0) {
                Controls[0].Dispose();
            }
            InitializeComponent();

            ShowDialog();
        }

        private void bOK_Click(object sender, EventArgs e) {
            registerClientPresenter.RegisterClient(GenerateClient());
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                tbSurname.Select();
            }
        }

        private void tbSurname_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                tbEmail.Select();
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                tbPassword.Select();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                tbPhone.Select();
            }
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                bOK.Select();
            }
        }

        private Client GenerateClient() {
            var client = new Client();
            client.Name = tbName.Text;
            client.Surname = tbSurname.Text;
            client.Email = tbEmail.Text;
            client.Password = tbPassword.Text;
            client.Phone = tbPhone.Text;

            return client;
        }
    }
}
