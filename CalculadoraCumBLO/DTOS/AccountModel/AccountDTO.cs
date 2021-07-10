using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraCumBLO.DTOS.AccountModel
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? Rol { get; set; }
    }
}
