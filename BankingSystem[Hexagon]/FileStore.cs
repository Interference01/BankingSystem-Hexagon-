using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_ {
    public class FileStore{
        private List<UserDTO> Users { get; set; }

        public FileStore() {
            Users = new List<UserDTO>() {
                new UserDTO() {
                    Id = Guid.NewGuid(),
                    Name = "Vlad",
                    Surname = "Mertvech",
                    Email = "v@g.com",
                    Password = "1111",
                    Phone = "+380665047766",
                    Role = "A"
                },
                new UserDTO() {
                    Id = Guid.NewGuid(),
                    Name = "Val",
                    Surname = "Tsvet",
                    Email = "tsvetk@gmail.com",
                    Password = "1111",
                    Phone = "+380665768679",
                    Role = "C"
                }
            };
        }

        public UserDTO[] GetAllUsers() {
            return Users.ToArray();
        }

        public void AddUser(UserDTO userDTO) {
            Users.Add(userDTO);
        }

        public class UserDTO {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string Role { get; set; }
            public Card? Card { get; set; }
        }

        public class Card {
            public string? Number { get; set; }
        }
    }
}
