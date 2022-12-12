using AutoMapper;
using Computer_Store_Api.Dto;
using Computer_Store_Api.Models;
using Computer_Store_Api.Request;
using Microsoft.Extensions.Hosting;

namespace Computer_Store_Api.Mapper
{
    public class MappingContext : Profile
    {
        public MappingContext()
        {
            // Cart detail
            CreateMap<CartDetail, CartDetailDto>();
        }
    }
}
