using BankingSystem_Hexagon_.auth_module.core.exceptions;
using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;

namespace BankingSystem_Hexagon_.auth_module.use_cases {
    public class AuthUseCase {
        private readonly IAuthRepository authRepository;
        public AuthUseCase(IAuthRepository authRepository) {
            this.authRepository = authRepository;
        }

        public virtual User Login(string login, string password) {
            var user = authRepository.GetUser(login, password);

            if (user == null) {
                throw new AuthException("Invalid login or pass");
            }

            return user;
        }
    }
}
