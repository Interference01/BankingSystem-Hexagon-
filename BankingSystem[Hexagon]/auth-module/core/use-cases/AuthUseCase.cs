using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.auth_module.use_cases {
    internal class AuthUseCase {
        private readonly IAuthRepository authRepository;
        public AuthUseCase(IAuthRepository authRepository) {
            this.authRepository = authRepository;
        }

        public User Login(string login, string password) {
            var user = authRepository.GetUser(login, password);

            if (user == null) {
                throw new Exception("Invalid login or pass");
            }

            return user;
        }
    }
}
