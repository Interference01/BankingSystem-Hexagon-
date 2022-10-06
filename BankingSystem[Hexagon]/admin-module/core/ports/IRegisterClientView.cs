using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.admin_module.core.view {
    public interface IRegisterClientView {
        public void ShowSuccessInfo();
        public void ShowRegisterValidation(string message);
    }
}
