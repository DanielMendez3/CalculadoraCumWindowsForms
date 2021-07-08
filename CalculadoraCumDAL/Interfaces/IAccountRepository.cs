using CalculadoraCumEntities;
using System.Threading.Tasks;

namespace CalculadoraCumDAL.Interfaces
{
    public interface IAccountRepository
    {
        Account Login(string Email, string Password);
    }
}
