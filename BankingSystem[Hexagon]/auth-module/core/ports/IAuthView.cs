using BankingSystem_Hexagon_.auth_module.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.auth_module.core.ports {
    public interface IAuthView {
        public void ShowClientContent(User user);
        public void ShowAdminContent(User user);
        public void ShowError(string message);

    }
}
