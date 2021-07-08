using CalculadoraCumBLO.Models;
using CalculadoraCumBLO.Models.AccountModel;

namespace CalculadoraCumBLO.Interfaces
{
    public interface IAccountService
    {
        Result Login(LoginRequest model);
    }
}
