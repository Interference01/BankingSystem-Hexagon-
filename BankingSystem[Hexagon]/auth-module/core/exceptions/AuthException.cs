using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.auth_module.core.exceptions {
    internal class AuthException : Exception{
        public AuthException(string message) : base(message) { }    
    }
}
