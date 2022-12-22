using BankingSystem_Hexagon_.admin_module.core.models;
using BankingSystem_Hexagon_.admin_module.core.ports;
using BankingSystem_Hexagon_.admin_module.core.presenters;
using BankingSystem_Hexagon_.admin_module.core.use_cases;
using Bogus;
using NSubstitute;

namespace BankSystemTest.admin_module.core.presenters {
    public class ShowClientsPresenterTest {

        [Fact]
        public void ShowClientsSuccess() {
            //Given
            var facker = new Faker();
            var errorText = facker.Random.String();
            var clients = new Client[4];

            var showClientsRepository = Substitute.For<IGetClientsRepository>();
            var showClientsUseCase = Substitute.For<GetClientsUseCase>(showClientsRepository);
            var showClientsView = Substitute.For<IShowClientsView>();

            var showClientsPresenter = new ShowClientsPresenter(showClientsUseCase, showClientsView);

            showClientsUseCase.GetClients().Returns(clients);
            //When

            showClientsPresenter.ShowClients();

            //Then
            showClientsUseCase.Received().GetClients();
            showClientsView.Received().ShowClientInfo(clients);
            showClientsView.DidNotReceive().ShowErrorMessage(errorText);

        }

        [Fact]
        public void ShowClientsNotSuccess() {
            //Given
            var facker = new Faker();
            var errorText = "Clients not exist";
            var clients = new Client[0];

            var showClientsRepository = Substitute.For<IGetClientsRepository>();
            var showClientsUseCase = Substitute.For<GetClientsUseCase>(showClientsRepository);
            var showClientsView = Substitute.For<IShowClientsView>();

            var showClientsPresenter = new ShowClientsPresenter(showClientsUseCase, showClientsView);

            showClientsUseCase.GetClients().Returns(clients);
            //When

            showClientsPresenter.ShowClients();

            //Then
            showClientsUseCase.Received().GetClients();
            showClientsView.DidNotReceive().ShowClientInfo(clients);
            showClientsView.Received().ShowErrorMessage(errorText);

        }
    }
}
