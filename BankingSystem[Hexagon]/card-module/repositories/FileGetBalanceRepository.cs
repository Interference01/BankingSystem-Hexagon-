
namespace BankingSystem_Hexagon_.card_module.repositories {
    public class FileGetBalanceRepository : IGetBalanceRepository {
        private readonly FileStore fileStore;

        public FileGetBalanceRepository(FileStore fileStore) {
            this.fileStore = fileStore;
        }

        public float GetBalanceCard() { //
            return 4355;
        }
    }
}
