using BankingSystem_Hexagon_.auth_module.models;

namespace BankingSystem_Hexagon_.auth_module.core.ports {
    public interface IAuthView {
        public void ShowClientContent(User user);
        public void ShowAdminContent(User user);
        public void ShowError(string message);
        public void SetCurrentUser(User user);
    }
}
