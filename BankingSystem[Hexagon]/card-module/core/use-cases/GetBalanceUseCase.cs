
using BankingSystem_Hexagon_.card_module.repositories;

namespace BankingSystem_Hexagon_.card_module.core.use_cases {
    public class GetBalanceUseCase {
        private readonly IGetBalanceRepository balanceRepository;
        public GetBalanceUseCase(IGetBalanceRepository balanceRepository) {
            this.balanceRepository = balanceRepository;
        }

        public float GetBalance() {
            var balance = balanceRepository.GetBalanceCard();

            return balance;
        }
    }
}
