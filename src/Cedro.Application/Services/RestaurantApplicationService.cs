using AutoMapper;
using Cedro.Application.Interfaces;
using Cedro.Application.ViewModels;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Interfaces.Services;
using Cedro.Domain.Models;
using Cedro.Infra.Data.UoW;
using System;
using System.Collections.Generic;
namespace Cedro.Application.Services
{
    public class RestaurantApplicationService : ApplicationService, IRestaurantApplicationService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IRestaurantService _restaurantService;
        public RestaurantApplicationService(IUnitOfWork uow, 
                                            IRestaurantRepository restaurantRepository,
                                            IRestaurantService restaurantService
                                           ) : base(uow)
        {
            _restaurantRepository = restaurantRepository;
            _restaurantService = restaurantService;
        }
        public RestaurantViewModel Update(RestaurantViewModel restaurantViewModel)
        {
            var restaurant = Mapper.Map<Restaurant>(restaurantViewModel);
            _restaurantService.Update(restaurant);
            Commit();
            return restaurantViewModel;
        }        
        public IEnumerable<RestaurantViewModel> GetAll()
        {
            
            return Mapper.Map<IEnumerable<RestaurantViewModel>>(_restaurantRepository.GetAll());
        }
        public RestaurantViewModel GetById(Guid id)
        {
            return Mapper.Map<RestaurantViewModel>(_restaurantRepository.GetbyId(id));
        }       
        public void Remover(Guid id)
        {
            _restaurantService.Delete(id);
        }

        public RestaurantViewModel Add(RestaurantViewModel restaurant)
        {
            throw new NotImplementedException();
        }

        public MenuViewModel GetByMenuId(Guid id)
        {
            return Mapper.Map<MenuViewModel>(_restaurantRepository.GetbyId(id));
        }

        public IEnumerable<MenuViewModel> GetManuAll()
        {
            return Mapper.Map<IEnumerable<MenuViewModel>>(_restaurantRepository.GetAll());
        }

        public MenuViewModel Update(MenuViewModel menuViewModel)
        {
            throw new NotImplementedException();
        }

        public void RemoverMenu(Guid id)
        {
            _restaurantService.Delete(id);
        }

        public MenuViewModel AddMenu(MenuViewModel menuViewModel)
        {
            throw new NotImplementedException();
        }

        //=============================================================
        public ReviewViewModel GetByReviewId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewViewModel> GetReviewAll()
        {
            return Mapper.Map<IEnumerable<ReviewViewModel>>(_restaurantRepository.GetAll());
        }

        public MenuViewModel Update(ReviewViewModel reviewViewModel)
        {
            throw new NotImplementedException();
        }

        public void RemoverReview(Guid id)
        {
            throw new NotImplementedException();
        }

        public ReviewViewModel AddMenu(ReviewViewModel reviewViewModel)
        {
            throw new NotImplementedException();
        }

        //==============================
    }
}
