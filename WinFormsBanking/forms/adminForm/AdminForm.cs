using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.presenters;
using WinFormsBanking.forms.adminForm;
using WinFormsBanking.views.showClients;

namespace WinFormsBanking.forms
{
    public partial class AdminForm : Form {
        private readonly RegisterForm RegisterForm; 
        private readonly InputForm InputForm;
        private readonly FormController formController;
        private readonly CurrentUser currentUser;

        private readonly ShowClientsPresenter ShowClientsPresenter;
        private readonly ShowClientsState ShowClientsState;
        public AdminForm(RegisterForm registerForm, InputForm inputForm, ShowClientsPresenter showClientsPresenter, ShowClientsState state,
            FormController formController, CurrentUser currentUser) {

            this.RegisterForm = registerForm;
            this.InputForm = inputForm;
            this.ShowClientsPresenter = showClientsPresenter;
            this.ShowClientsState = state;
            this.formController = formController;
            this.currentUser = currentUser;

            ShowClientsState.showClientsEvent += ShowClients;
            InitializeComponent();
        }

        private void bRegisterClient_Click(object sender, EventArgs e) {
            RegisterForm.ShowCleanDialog();
        }

        private void bShowAllClients_Click(object sender, EventArgs e) {
            ShowClientsPresenter.ShowClients();
        }

        private void bAddCard_Click(object sender, EventArgs e) {
            InputForm.ShowCleanDialog();
        }

        private void ShowClients(Client[] clients) {
            tbWindowShow.Clear();
            foreach (var item in clients) {
                tbWindowShow.Text += $"Name: {item.Name} {Environment.NewLine}" +
                    $"Surname: {item.Surname} {Environment.NewLine}" +
                    $"Email: {item.Email} {Environment.NewLine}" +
                    $"Password: {item.Password} {Environment.NewLine}" +
                    $"Phone: {item.Phone} {Environment.NewLine}{Environment.NewLine}";
            }
        }

        private void bExit_Click(object sender, EventArgs e) {
            formController.ShowHomeForm();
        }

        private void AdminForm_Load(object sender, EventArgs e) {
            lName.Text = $"Hello NAME";
        }
    }
}
