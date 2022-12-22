namespace BankingSystem_Hexagon_.database.entities {
    public class User {
        public User() {
            this.Roles = new HashSet<Role>();
        }
        public Guid Id {get; set;}
        public string Name {get; set;}
        public string Surname {get; set;}
        public string Email {get; set;}
        public string Password {get; set;}
        public string Phone {get; set;}

        public virtual ICollection <Role> Roles {get; set;}
    }
}
