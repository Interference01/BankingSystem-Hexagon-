using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.admin_module.core.use_cases;
using NSubstitute;

namespace BankSystemTest.admin_module.core.use_cases {
    public class ShowClientsUseCaseTest {
        [Fact]
        public void ShowClients() {
            //Given
            Client[] clients = new Client[2] {
                new Client {
                    Name = "vlad",
                    Surname = "Mert",
                    Email = "vlad@gmail.com",
                    Password = "11111111B+",
                    Phone = "3800002000",
                },
                new Client {
                    Name = "val",
                    Surname = "ts",
                    Email = "val@gmail.com",
                    Password = "11111111B+",
                    Phone = "3800002000",
                }};

            var repository = Substitute.For<IGetClientsRepository>();
            var showClientsUseCase = new GetClientsUseCase(repository);


            //When
            showClientsUseCase.GetClients();
            //Then
        }

    }
}
