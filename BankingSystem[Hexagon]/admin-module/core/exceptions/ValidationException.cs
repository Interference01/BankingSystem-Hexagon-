using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.admin_module.core.exception {
    internal class ValidationException : Exception {
        public ValidationException(string message) : base(message) {

        }
    }
}
