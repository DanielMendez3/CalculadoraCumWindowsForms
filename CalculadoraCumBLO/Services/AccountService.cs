using CalculadoraCumBLO.DTOS;
using CalculadoraCumBLO.DTOS.AccountModel;
using CalculadoraCumBLO.Interfaces;
using CalculadoraCumBLO.Models;
using CalculadoraCumBLO.Models.AccountModel;
using CalculadoraCumDAL.Interfaces;
using CalculadoraCumDAL.Models;
using CalculadoraCumDAL.Repositories;

namespace CalculadoraCumBLO.Services
{
    public class AccountService : ServiceBase, IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService() : base()
        {
            _accountRepository = new AccountRepository();
            
        }

        public Result Create(CreateAccountRequest model)
        {
            var account = _mapper.Map<Account>(model);
            _accountRepository.Add(account);
            return new Result();
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
            if (account == null)
            {
                result.Status = StatusCode.Error;
                result.Message = "Usuario o contraseña incorrectos.";
                return result;
            }

            var accountDTO = _mapper.Map<AccountDTO>(account);

            return result;
        }
    }
}
