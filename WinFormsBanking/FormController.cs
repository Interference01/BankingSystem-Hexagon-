
namespace WinFormsBanking {
    public class FormController {
        public Form CurrentForm { get; set; }
        public Form HomeForm { get; set; }


        public void Show(Form form) {
            if (CurrentForm != null) {
                CurrentForm.Visible = false;
            }

            CurrentForm = form;

            form.Show();
        }

        public void ShowHomeForm() {
            if (CurrentForm == null) {
                CurrentForm = HomeForm;
                Application.Run(HomeForm);
            } else {
                CurrentForm.Visible = false;
                HomeForm.Visible = true;
            }
        }
    }
}
