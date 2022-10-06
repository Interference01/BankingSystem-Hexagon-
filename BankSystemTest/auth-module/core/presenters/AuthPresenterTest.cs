using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.core.presenters;
using BankingSystem_Hexagon_.auth_module.models;
using BankingSystem_Hexagon_.auth_module.use_cases;
using Bogus;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NSubstitute.ReturnsExtensions;

namespace BankSystemTest.auth_module.core.presenters {
    public class AuthPresenterTest {
        [Fact]
        public void LoginForClientSuccess() {
            //Given
            var login = "val@gmail.com";
            var password = "11111";
            var user = new User(Guid.NewGuid(), User.Role.Client);

            var repository = Substitute.For<IAuthRepository>();
            var authUseCase = Substitute.For<AuthUseCase>(repository);
            var authView = Substitute.For<IAuthView>();

            var authPresenter = new AuthPresenter(authUseCase,authView);

            authUseCase.Login(login,password).Returns(user);

            //When

            authPresenter.Login(login, password);

            //Then
            authUseCase.Received().Login(login, password);
            authView.Received().ShowClientContent(user);
            authView.DidNotReceive().ShowAdminContent(Arg.Any<User>());
        }

        [Fact]
        public void LoginForAdminSuccess() {
            //Given
            var login = "val@gmail.com";
            var password = "11111";
            var user = new User(Guid.NewGuid(), User.Role.Admin);

            var repository = Substitute.For<IAuthRepository>();
            var authUseCase = Substitute.For<AuthUseCase>(repository);
            var authView = Substitute.For<IAuthView>();

            var authPresenter = new AuthPresenter(authUseCase, authView);

            authUseCase.Login(login, password).Returns(user);

            //When

            authPresenter.Login(login, password);

            //Then
            authUseCase.Received().Login(login, password);
            authView.Received().ShowAdminContent(user);
            authView.DidNotReceive().ShowClientContent(Arg.Any<User>());
        }

        [Fact]
        public void LoginForIncorrectUser() {
            //Given
            var faker = new Faker();
            var login = faker.Random.String(10);
            var password = faker.Internet.Password();
            var error = new Exception("Invalid login or pass");

            var repository = Substitute.For<IAuthRepository>();
            var authUseCase = Substitute.For<AuthUseCase>(repository);
            var authView = Substitute.For<IAuthView>();

            var authPresenter = new AuthPresenter(authUseCase, authView);

            authUseCase.Login(login, password).ThrowsForAnyArgs(error);

            //When

            authPresenter.Login(login, password);

            //Then
            authUseCase.Received().Login(login, password);
            authView.Received().ShowError(error.Message);
            authView.DidNotReceive().ShowAdminContent(Arg.Any<User>());
            authView.DidNotReceive().ShowClientContent(Arg.Any<User>());
        }
    }
}
