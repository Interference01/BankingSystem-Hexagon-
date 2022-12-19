namespace BankingSystem_Hexagon_.database.entities {
    public class Card {
        public Guid CardId  { get; set; }
        public string NumberCard { get; set; }
        public float Balance { get; set; }

        public Guid? UserId { get; set; }
        public User User { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
