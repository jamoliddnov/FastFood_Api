using AutoMapper;
using FastFood_Web.Domain.Entities;
using FastFood_Web.Domain.Entities.Empolyees;
using FastFood_Web.Service.Dto.AccountDto;
using FastFood_Web.Service.Dto.AdminDto;
using FastFood_Web.Service.Dto.DistrictDto;
using FastFood_Web.Service.Dto.ProductDto;

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
            CreateMap<UpdateProductDto, Product>();
            CreateMap<DistrictCreateDto, District>();
        }
    }
}
