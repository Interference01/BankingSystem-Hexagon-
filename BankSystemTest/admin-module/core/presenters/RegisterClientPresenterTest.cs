using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.admin_module.core.presenters;
using BankingSystem_Hexagon_.admin_module.core.use_cases;
using BankingSystem_Hexagon_.admin_module.core.view;
using Bogus;
using NSubstitute;
using NSubstitute.ExceptionExtensions;

namespace BankSystemTest.admin_module.core.presenters {
    public class RegisterClientPresenterTest {

        [Fact]
        public void RegisterCorrectClient() {
            //Given
            var client = new Client();

            var registerRepository = Substitute.For<IRegisterRepository>();
            var registerClientUseCase = Substitute.For<RegisterClientUseCase>(registerRepository);
            var registerClientView = Substitute.For<IRegisterClientView>();

            var registerClientPresenter = new RegisterClientPresenter(registerClientView, registerClientUseCase);

            //When

            registerClientPresenter.RegisterClient(client);

            //Then
            registerClientUseCase.Received().Register(client);
            registerClientView.Received().ShowSuccessInfo();
            registerClientView.DidNotReceive().ShowRegisterValidation(Arg.Any<string>());
        }

        [Fact]
        public void RegisterIncorrectClient() {
            //Given
            var faker = new Faker();
            var client = new Client();
            var errorText = faker.Random.String();
            var error = new ValidationException(errorText);
            
            var registerRepository = Substitute.For<IRegisterRepository>();
            var registerClientUseCase = Substitute.For<RegisterClientUseCase>(registerRepository);
            var registerClientView = Substitute.For<IRegisterClientView>();

            var registerClientPresenter = new RegisterClientPresenter(registerClientView, registerClientUseCase);

            registerClientUseCase.When(x => x.Register(client)).Do(call => { throw error; });
            //When

            registerClientPresenter.RegisterClient(client);

            //Then
            registerClientUseCase.Received().Register(client);
            registerClientView.DidNotReceive().ShowSuccessInfo();
            registerClientView.Received().ShowRegisterValidation(errorText);
        }
    }
}
