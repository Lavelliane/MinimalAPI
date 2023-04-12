using AutoMapper;
using RealEstate_API.Models;
using RealEstate_API.Models.DTO;

namespace RealEstate_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            CreateMap<Coupon, CouponCreateDTO>().ReverseMap();
            CreateMap<Coupon, CouponDTO>().ReverseMap();
        }
    }
}
