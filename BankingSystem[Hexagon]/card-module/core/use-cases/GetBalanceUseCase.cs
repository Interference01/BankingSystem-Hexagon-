using BankingSystem_Hexagon_.card_module.repositories;

namespace BankingSystem_Hexagon_.card_module.core.use_cases {
    public class GetBalanceUseCase {
        private readonly IGetBalanceRepository balanceRepository;
        public GetBalanceUseCase(IGetBalanceRepository balanceRepository) {
            this.balanceRepository = balanceRepository;
        }

        public float GetBalance(Guid id) {
            var card = balanceRepository.GetCard(id);

            if (card == null) {
                throw new Exception("You don't have the card");
            }

            return card.Balance;
        }
    }
}
