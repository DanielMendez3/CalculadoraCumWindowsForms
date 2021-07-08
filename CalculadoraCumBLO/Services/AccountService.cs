using CalculadoraCumBLO.Interfaces;
using CalculadoraCumBLO.Models;
using CalculadoraCumBLO.Models.AccountModel;
using CalculadoraCumDAL.Interfaces;
using CalculadoraCumDAL.Repositories;
using CalculadoraCumEntities;

namespace CalculadoraCumBLO.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }
        public Result Login(LoginRequest model)
        {
            Result result = new Result();
            if (string.IsNullOrEmpty(model.Email))
            {
                result.Status = StatusCode.Advertencia;
                result.Message = "El correo electrónico no puede estar vacío.";
                return result;
            }

            if (string.IsNullOrEmpty(model.Password))
            {
                result.Status = StatusCode.Advertencia;
                result.Message = "La contraseña no puede estar vacía.";
                return result;
            }

            var account =_accountRepository.Login(model.Email, model.Password);

            return result;
        }
    }
}
