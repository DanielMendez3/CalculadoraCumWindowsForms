using CalculadoraCumDAL.Interfaces;
using CalculadoraCumEntities;
using System;
using System.Threading.Tasks;

namespace CalculadoraCumDAL.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public Account Login(string Email, string Password)
        {
            return new Account();
        }
    }
}
