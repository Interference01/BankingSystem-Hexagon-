using BankingSystem_Hexagon_.admin_module.core.ports;
using System.Linq;

namespace BankingSystem_Hexagon_.admin_module.core.use_cases {
    public class AddCardUseCase {
        private readonly IAddCardRepository cardRepository;

        public AddCardUseCase(IAddCardRepository cardRepository) {
            this.cardRepository = cardRepository;
        }

        public void AddCardForClient(Guid id) {
            string numberCard;

            while (true) {
                numberCard = GenerateNumberCard();

                if (!cardRepository.IsExistCard(numberCard)) {
                    break;
                }
            }

            cardRepository.SaveCard(id, numberCard);
        }

        public void AddCardForClient(string email) {
            var userId = cardRepository.GetUserIdByEmail(email);

            if (userId == Guid.Empty) {
                throw new Exception("User not found");
            }

            AddCardForClient(userId);
        }

        private string GenerateNumberCard() {
            string numberCard = "";
            var random = new Random();

            for (int i = 0; i < 4; i++) {
                numberCard += random.Next(1000, 9999).ToString();
            }

            return numberCard;
        }
    }
}
