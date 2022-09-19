using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using System.Numerics;
using System.Xml.Linq;

namespace BankingSystem_Hexagon_.admin_module.core.use_cases
{
    internal class RegisterClientUseCase
    {
        private readonly IRegisterRepository registerRepository;
        public RegisterClientUseCase(IRegisterRepository registerRepository)
        {
            this.registerRepository = registerRepository;
        }
        public Client Register(string name, string surname, string email, string password, string phone)
        {
            //valid
            if (name.Length == 20 && surname.Length == 20 && email.Length == 20 && password.Length == 20 && phone.Length == 20)
            {
                throw new Exception ("Max length it is 20");
            }
            if (true)
            {

            }

            Client client = registerRepository.SaveClient( name,  surname,  email,  password,  phone);
            return client;
        }

    }
}
