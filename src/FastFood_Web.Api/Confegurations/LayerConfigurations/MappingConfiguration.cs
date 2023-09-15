using AutoMapper;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Entities.Empolyees;
using FastFood_Web.Service.Dto.ProductDto;
using FastFood_Web.Service.Dtos.AccountDto;
using FastFood_Web.Service.Dtos.AdminDto;

namespace FastFood_Web.Api.Confegurations.LayerConfigurations
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<AccountRegisterDto, Customer>();
            CreateMap<AccountRegisterDto, User>();
            CreateMap<AdminRegisterDto, Admin>();
            CreateMap<CreateProductDto, Product>();
        }
    }
}
