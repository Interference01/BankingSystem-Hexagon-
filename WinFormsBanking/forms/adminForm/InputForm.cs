using BankingSystem_Hexagon_.admin_module.core.presenters;

namespace WinFormsBanking.forms.adminForm {
    public partial class InputForm : Form {
        AddCardPresenter addCardPresenter;
        public InputForm(AddCardPresenter addCardPresenter, string text) {
            InitializeComponent();
            lText.Text = text;
            this.addCardPresenter = addCardPresenter;
            tbInput.Select();
        }
        public void ShowCleanDialog() {
            while (Controls.Count > 0) {
                Controls[0].Dispose();
            }
            InitializeComponent();

            ShowDialog();
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)Keys.Enter) {
                bOK.Select();
            }
        }
        private void bOK_Click(object sender, EventArgs e) {
            addCardPresenter.AddCard(tbInput.Text);
            this.Close();
        }
    }
}
