using AutoMapper;
using Micro.Services.CouponAPI.Models;
using Micro.Services.CouponAPI.Models.Dto;
using System.Runtime.CompilerServices;

namespace Micro.Services.CouponAPI
{
    public class MappingConfig
    {
        public static   MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
                
            });
            return mappingConfig;
        }
    }
}
