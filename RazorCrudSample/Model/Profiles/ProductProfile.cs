using AutoMapper;
using RazorCrudSample.Model.DTOS;
using RazorCrudSample.Model.Entities;
using RazorCrudSample.Model.Repositories;

namespace RazorCrudSample.Model.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductCreationDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }

    }
}
