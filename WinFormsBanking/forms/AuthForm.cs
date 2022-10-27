using BankingSystem_Hexagon_.auth_module.core.presenters;

namespace WinFormsBanking.views {
    public partial class AuthForm : Form{
        private readonly AuthPresenter authPresenter;
        public AuthForm(AuthPresenter authPresenter) {
            InitializeComponent();
            this.authPresenter = authPresenter;
        }


        private void bOK_Click(object sender, EventArgs e) {
            authPresenter.Login(tbLogin.Text, tbPassword.Text);
        }
    }
}
