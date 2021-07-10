using System;
using System.Collections.Generic;

#nullable disable

namespace CalculadoraCumDAL.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Rol { get; set; }
    }
}
