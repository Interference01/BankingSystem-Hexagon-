using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.admin_module.core.use_cases;
using NSubstitute;

namespace BankSystemTest.registr_module.core.use_cases {
    public class RegisterClientUseCasesTest {
        [Fact]
        public void RegisterCorrectClient() {
            //Given
            var client = new Client() {
                Name = "Val",
                Surname = "Tsvet",
                Email = "valentin@gmail.com",
                Password = "430789000V+",
                Phone = "+380663412222"
            };
            var repository = Substitute.For<IRegisterRepository>();
            repository.SaveClient(client);

            var registerUseCase = new RegisterClientUseCase(repository);
            bool saved = true;

            //When
            try {
                registerUseCase.Register(client);
            } catch {
                saved = false;
            }

            //Then
            Assert.True(saved);
        }


        [Fact]
        public void RegisterIncorrectEmailClient() {
            //Given
            var client = new Client() {
                Name = "Val",
                Surname = "Tsvet",
                Email = "valentin@gmail;com",
                Password = "4307890V+",
                Phone = "+380663412222"
            };
            var repository = Substitute.For<IRegisterRepository>();
            bool saved = true;
            var expectedErrorMessage = "Email not validate";

            var registerUseCase = new RegisterClientUseCase(repository);


            //When
            string actualErrorMessage = "";

            try {
                registerUseCase.Register(client);
            } catch (Exception e) {
                actualErrorMessage = e.Message;
                saved = false;
            }

            //Then
            Assert.False(saved);
            Assert.Equal(expectedErrorMessage, actualErrorMessage);
        }


        [Fact]
        public void RegisterIncorrectPasswordClient() {
            //Given
            var client = new Client() {
                Name = "Val",
                Surname = "Tsvet",
                Email = "valentin@gmail.com",
                Password = "4307890V",
                Phone = "+380663412222"
            };
            var repository = Substitute.For<IRegisterRepository>();
            bool saved = true;
            var expectedErrorMessage = "Password must be no more 8 lenght, one upper letter and one any symbol";

            var registerUseCase = new RegisterClientUseCase(repository);


            //When
            string actualErrorMessage = "";

            try {
                registerUseCase.Register(client);
            } catch (Exception e) {
                actualErrorMessage = e.Message;
                saved = false;
            }

            //Then
            Assert.False(saved);
            Assert.Equal(expectedErrorMessage, actualErrorMessage);
        }


        [Fact]
        public void RegisterIncorrectNameClient() {
            //Given
            var client = new Client() {
                Name = "Valeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee",
                Surname = "Tsvet",
                Email = "valentin@gmail.com",
                Password = "4307890V+",
                Phone = "+380663412222"
            };
            var repository = Substitute.For<IRegisterRepository>();
            bool saved = true;
            var expectedErrorMessage = "Max length for field Name 20";

            var registerUseCase = new RegisterClientUseCase(repository);


            //When
            string actualErrorMessage = "";

            try {
                registerUseCase.Register(client);
            } catch (Exception e){
                actualErrorMessage = e.Message;
                saved = false;
            }

            //Then
            Assert.False(saved);
            Assert.Equal(expectedErrorMessage, actualErrorMessage);
        }


        [Fact]
        public void RegisterIncorrectSurnameClient() {
            //Given
            var client = new Client() {
                Name = "Val",
                Surname = "Tsvetkooooooooooooooooooooooooooooooooo",
                Email = "valentin@gmail.com",
                Password = "4307890V",
                Phone = "+380663412222"
            };
            var repository = Substitute.For<IRegisterRepository>();
            bool saved = true;
            var expectedErrorMessage = "Max length for field Surname 20";

            var registerUseCase = new RegisterClientUseCase(repository);


            //When
            string actualErrorMessage = "";

            try {
                registerUseCase.Register(client);
            } catch (Exception e) {
                actualErrorMessage = e.Message;
                saved = false;
            }

            //Then
            Assert.False(saved);
            Assert.Equal(expectedErrorMessage, actualErrorMessage);
        }


        [Fact]
        public void RegisterIncorrectPhoneClient() {
            //Given
            var client = new Client() {
                Name = "Val",
                Surname = "Tsvet",
                Email = "valentin@gmail.com",
                Password = "4307890V",
                Phone = "+3806634122222222222222222222222222"
            };
            var repository = Substitute.For<IRegisterRepository>();
            bool saved = true;
            var expectedErrorMessage = "Max length for field Phone 14";

            var registerUseCase = new RegisterClientUseCase(repository);


            //When
            string actualErrorMessage = "";

            try {
                registerUseCase.Register(client);
            } catch (Exception e) {
                actualErrorMessage = e.Message;
                saved = false;
            }

            //Then
            Assert.False(saved);
            Assert.Equal(expectedErrorMessage, actualErrorMessage);
        }

    }
}
