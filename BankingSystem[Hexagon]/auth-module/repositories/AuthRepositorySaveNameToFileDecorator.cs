using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;

namespace BankingSystem_Hexagon_.admin_module.repositories {
    public class AuthRepositorySaveNameToFileDecorator : IAuthRepository {
        private readonly IAuthRepository authRepository;

        public AuthRepositorySaveNameToFileDecorator(IAuthRepository authRepository) {
            this.authRepository = authRepository;
        }

        public User GetUser(string login, string password) {
            var user = this.authRepository.GetUser(login, password);

            DateTime dateTime = DateTime.Now;
            using (var streamWriter = new StreamWriter($"{Environment.CurrentDirectory}\\logging.txt", true))
                streamWriter.WriteLine($" Data: {dateTime} - Name: {login} ");

            return user;
        }
    }
}
