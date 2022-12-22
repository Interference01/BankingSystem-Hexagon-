namespace BankingSystem_Hexagon_.database.entities {
    public class Card {
        public Guid Id  { get; set; }
        public string Number { get; set; }
        public float Balance { get; set; }

        public User User { get; set; }

    }
}
