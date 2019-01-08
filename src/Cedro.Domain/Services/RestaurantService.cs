using System;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Interfaces.Services;
using Cedro.Domain.Models;
namespace Cedro.Domain.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public Restaurant Add(Restaurant restaurant)
        {
            if (!restaurant.IsValidated())
                return restaurant;                
           return !restaurant.ValidationResult.IsValid ? restaurant : _restaurantRepository.Add(restaurant);
        }

        public Menu AddMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public Review AddReview(Review review)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            _restaurantRepository.Delete(id);
        }

        public void DeleteMenu(Guid id)
        {
            throw new NotImplementedException();
        }

        public void DeleteReview(Guid id)
        {
            throw new NotImplementedException();
        }

        public Restaurant Update(Restaurant restaurant)
        {
            return _restaurantRepository.Update(restaurant);
        }

        public Menu UpdateMenu(Menu menu)
        {
            throw new NotImplementedException();
        }

        public Review UpdateReview(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
