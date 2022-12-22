namespace BankingSystem_Hexagon_.database.entities {
    public class Role {
        public Role() {
            this.Users = new HashSet<User>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
