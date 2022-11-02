using Newtonsoft.Json;

namespace BankingSystem_Hexagon_ {
    [Serializable]
    public class FileStore {
        public List<UserDTO> Users { get; set; }

        public static void Serialize(FileStore fileStore) {
            // serialize JSON to a string and then write string to a file
            File.WriteAllText(@"fileStore.json", JsonConvert.SerializeObject(fileStore));
        }

        public static FileStore CreateFileStore() {
            try {
                return JsonConvert.DeserializeObject<FileStore>(File.ReadAllText(@"fileStore.json"));
            } catch {
                return new FileStore();
            }

        }

        public UserDTO[] GetAllUsers() {
            return Users.ToArray();
        }

        public void AddUser(UserDTO userDTO) {
            Users.Add(userDTO);
            FileStore.Serialize(this);
        }

        [Serializable]
        public class UserDTO {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string Role { get; set; }
            public CardDTO? Card { get; set; }
        }
        [Serializable]
        public class CardDTO {
            public Guid Id { get; set; }
            public string? Number { get; set; }
            public float Balance { get; set; }
        }
    }
}
