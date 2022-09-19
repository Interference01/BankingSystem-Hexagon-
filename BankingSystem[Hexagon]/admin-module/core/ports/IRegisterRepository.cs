using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.auth_module.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.admin_module.core.ports
{
    internal interface IRegisterRepository
    {
        public Client? SaveClient(Client client);
    }
}
