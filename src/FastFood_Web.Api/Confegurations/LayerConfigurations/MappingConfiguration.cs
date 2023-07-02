using AutoMapper;
using FastFood_Web.Domain.Entities.Customers;
using FastFood_Web.Domain.Entities.Users;
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
