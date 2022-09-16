using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem_Hexagon_.Models
{
    internal class Client
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
