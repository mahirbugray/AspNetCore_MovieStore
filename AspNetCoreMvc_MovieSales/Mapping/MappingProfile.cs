using AspNetCoreMvc_MovieSales.Models;
using AspNetCoreMvc_MovieSales.ViewModels;
using AutoMapper;

namespace AspNetCoreMvc_MovieSales.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
            CreateMap<Customer, CustomerViewModel>().ReverseMap();  
            CreateMap<Genre, GenreViewModel>().ReverseMap();
            CreateMap<MovieSale, MovieSaleViewModel>().ReverseMap();
        }
    }
}
