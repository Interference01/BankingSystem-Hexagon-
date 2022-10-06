
namespace BankingSystem_Hexagon_.admin_module.core.ports {
    internal interface IAddCardView {
        public void ShowSuccessInfo();
        public void ShowError(string message);
    }
}
