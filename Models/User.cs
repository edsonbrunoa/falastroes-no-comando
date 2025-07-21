using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace falastroes_no_comando.Models
{
    public class User
    {
        public int IdUsers { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password_ { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }
}