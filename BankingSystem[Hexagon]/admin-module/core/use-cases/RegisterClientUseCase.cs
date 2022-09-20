using BankingSystem_Hexagon_.admin_module.core.exception;
using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using FieldValidationLib;

namespace BankingSystem_Hexagon_.admin_module.core.use_cases {
    internal class RegisterClientUseCase {
        private readonly IRegisterRepository registerRepository;
        public RegisterClientUseCase(IRegisterRepository registerRepository) {
            this.registerRepository = registerRepository;
        }
        public void Register(Client client) {

            FieldValidation.LengthValidate("Name", client.Name, 20);
            FieldValidation.LengthValidate("Surname", client.Surname, 20);
            FieldValidation.LengthValidate("Phone", client.Phone, 14);
            FieldValidation.PasswordValidate(client.Password);
            FieldValidation.EmailValidate(client.Email);

            registerRepository.SaveClient(client);
        }
    }
}
