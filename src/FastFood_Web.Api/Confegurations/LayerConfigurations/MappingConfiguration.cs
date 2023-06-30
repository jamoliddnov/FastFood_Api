using AutoMapper;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Service.Dtos.AccountDto;

namespace FastFood_Web.Api.Confegurations.LayerConfigurations
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<AccountRegisterDto, Customer>();
            CreateMap<AccountRegisterDto, User>();
        }
    }
}
