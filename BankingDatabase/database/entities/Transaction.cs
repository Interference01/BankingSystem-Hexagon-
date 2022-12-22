using System.ComponentModel.DataAnnotations.Schema;

namespace BankingSystem_Hexagon_.database.entities {

    public class Transaction {
        public Guid Id { get; set; }

		public Card CardTo { get; set; }
		public Card CardFrom { get; set; }

        public float Sum {get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; } 
    }
}
