using AutoMapper;
using CalculadoraCumBLO.Helpers;

namespace CalculadoraCumBLO.Services
{
    public abstract class ServiceBase
    {
        protected readonly IMapper _mapper;
        public ServiceBase()
        {
            var config = new MapperConfiguration(x => {
                x.AddProfile<MappingProfile>();
            });
            this._mapper = config.CreateMapper();
        }
    }
}
