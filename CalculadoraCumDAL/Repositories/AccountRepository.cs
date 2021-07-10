using CalculadoraCumDAL.Interfaces;
using CalculadoraCumDAL.Models;
using System.Linq;

namespace CalculadoraCumDAL.Repositories
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        private readonly CumCalculatorDBContext _context;

        public AccountRepository()
        {
            this._context = new CumCalculatorDBContext();
        }

        public Account Login(string Email, string Password)
        {
            return this._context.Accounts
                        .FirstOrDefault(x => x.Email == Email && x.Password == Password);           
        }
    }
}
