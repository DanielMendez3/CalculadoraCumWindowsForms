using AutoMapper;
using CalculadoraCumBLO.DTOS.AccountModel;
using CalculadoraCumDAL.Models;

namespace CalculadoraCumBLO.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Account, AccountDTO>();
            CreateMap<CreateAccountRequest, Account>();
        }
    }
}
