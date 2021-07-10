using CalculadoraCumDAL.Domain;
using CalculadoraCumDAL.Models;

namespace CalculadoraCumDAL.Interfaces
{
    public interface IAccountRepository : IGenericRepository<Account>
    {
        Account Login(string Email, string Password);
    }
}
