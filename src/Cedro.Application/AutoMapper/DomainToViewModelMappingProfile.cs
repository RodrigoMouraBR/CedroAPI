using AutoMapper;
using Cedro.Application.ViewModels;
using Cedro.Domain.Models;
namespace Cedro.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Restaurant, RestaurantViewModel>();
            CreateMap<Menu, MenuViewModel>();
            CreateMap<Review, ReviewViewModel>();
        }
    }
}
