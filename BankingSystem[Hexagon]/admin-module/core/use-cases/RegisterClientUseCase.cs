using BankingSystem_Hexagon_.admin_module.core.exception;
using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using System.Net.Mail;
using System;
using System.Text.RegularExpressions;

namespace BankingSystem_Hexagon_.admin_module.core.use_cases {
    internal class RegisterClientUseCase {
        private readonly IRegisterRepository registerRepository;
        public RegisterClientUseCase(IRegisterRepository registerRepository) {
            this.registerRepository = registerRepository;
        }
        public Client Register(Client client) {

            LengthValidate(client);
            PasswordValidate(client);
            EmailValidate(client);

            registerRepository.SaveClient(client);
            return client;
        }

        private void LengthValidate(Client client) {
            if (client.Name.Length >= 20 && client.Surname.Length >= 20 && client.Email.Length >= 20 && client.Phone.Length >= 20) {
                throw new ValidationException("Max length it is 20");
            }
        }

        private void PasswordValidate(Client client) {
            if (client.Password.Length < 8 && client.Password.Any(char.IsUpper) && client.Password.Any(char.IsSymbol)) {
                throw new ValidationException("Password must be no more 8 lenght, one upper letter and one any symbol");
            }
        }

        private void EmailValidate(Client client) {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            if (!Regex.IsMatch(client.Email, regex, RegexOptions.IgnoreCase)) {
                throw new ValidationException("Email not validate");
            }
        }
    }
}
