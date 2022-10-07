using AutoMapper;
using UserDomain.Contracts.Data.Entities;
using UserDomain.Contracts.DTO;

namespace UserDomain.Core.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Item, ItemDTO>();
        }
    }
}
