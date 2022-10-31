using AutoMapper;
using SkiNet.Dtos;
using SkiNet.Helpers.ProductHelpers;
using SkiNet.Models;
using SkiNet.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiNet.Helpers.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(d=> d.ProductBrand,o=>o.MapFrom(s=>s.ProductBrand.Name))
                .ForMember(d=>d.ProductType,o=>o.MapFrom(s=>s.ProductType.Name))
                .ForMember(d=>d.PictureUrl,o=>o.MapFrom<ProductUrlResolver>());
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<CustomerBasketDto, CustomerBasket>();
            CreateMap<BasketItemDto, BasketItem>();
        }
    }
}
