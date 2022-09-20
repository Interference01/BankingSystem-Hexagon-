
namespace BankingSystem_Hexagon_.auth_module.models {
    public class User {
        public Guid Id { get; set; }
        public Role _Role { get; set; }

        public User(Guid id, Role role) {
            Id = id;
            _Role = role;
        }

        public enum Role { Client, Admin }
    }
}
