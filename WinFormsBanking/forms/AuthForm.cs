using BankingSystem_Hexagon_.auth_module.core.presenters;

namespace WinFormsBanking.views {
    public partial class AuthForm : Form {
        private readonly AuthPresenter authPresenter;
        public AuthForm(AuthPresenter authPresenter) {
            InitializeComponent();
            this.authPresenter = authPresenter;
            tbLogin.Select();
            ChangeLanguageOnEnglish();
        }


        private void bOK_Click(object sender, EventArgs e) {
            authPresenter.Login(tbLogin.Text, tbPassword.Text);
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                tbPassword.Select();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                bOK.Select();
            }
        }

        private void ChangeLanguageOnEnglish() {
            var culture = System.Globalization.CultureInfo.GetCultureInfo(0x0409);
            var language = InputLanguage.FromCulture(culture);
            InputLanguage.CurrentInputLanguage = language;
        }
    }
}
