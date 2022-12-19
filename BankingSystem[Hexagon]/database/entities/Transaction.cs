namespace BankingSystem_Hexagon_.database.entities {
    public class Transaction {
        public Guid TransactionId { get; set; }
        public Guid CardToId { get; set; }
        public Guid CardFromId { get; set; }
        public float Sum {get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; } 
    }
}
