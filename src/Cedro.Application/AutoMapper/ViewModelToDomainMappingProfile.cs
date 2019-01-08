using AutoMapper;
using Cedro.Application.ViewModels;
using Cedro.Domain.Models;
namespace Cedro.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<RestaurantViewModel, Restaurant>();
            CreateMap<MenuViewModel, Menu>();
            CreateMap<ReviewViewModel, Review>();
        }
    }
}
