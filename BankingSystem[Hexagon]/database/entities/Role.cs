namespace BankingSystem_Hexagon_.database.entities {
    public class Role {
        public Role() {
            this.Users = new HashSet<User>();
        }
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
