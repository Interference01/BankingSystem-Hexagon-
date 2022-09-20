using BankingSystem_Hexagon_.auth_module.core.ports;
using BankingSystem_Hexagon_.auth_module.models;
using BankingSystem_Hexagon_.auth_module.use_cases;
using NSubstitute;
using NSubstitute.ReturnsExtensions;

namespace BankSystemTest.auth_module.core.use_cases {
    public class AuthUseCaseTest {
        [Fact]
        public void ShouldLoginInSystem() {
            // Given
            var login = "valentin14@gmail.com";
            var password = "1999";
            var expectedUser = new User(Guid.NewGuid(), User.Role.Client);
            var repository = Substitute.For<IAuthRepository>();
            repository.GetUser(login, password).Returns(expectedUser);

            var authUseCase = new AuthUseCase(repository);
            
            //When
            var actual = authUseCase.Login(login, password);

            //Then
            Assert.Equal(expectedUser, actual);
        }

        [Fact]
        public void ShouldNotLoginInSystem() {
            // Given
            var login = "valentin14@gmail.com";
            var password = "1999";
            var expectedErrorMessage = "Invalid login or pass";
            var repository = Substitute.For<IAuthRepository>();
            repository.GetUser(login, password).ReturnsNull();

            var authUseCase = new AuthUseCase(repository);

            //When
            string actualMessage = "";
            try {
                authUseCase.Login(login, password);
            } catch (Exception ex) {
                actualMessage = ex.Message;
            }

            //Then
            Assert.Equal(expectedErrorMessage, actualMessage);
        }
    }
}
