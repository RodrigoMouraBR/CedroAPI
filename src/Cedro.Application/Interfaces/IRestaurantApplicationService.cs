using Cedro.Application.ViewModels;
using System;
using System.Collections.Generic;
namespace Cedro.Application.Interfaces
{
    public interface IRestaurantApplicationService
    {
        //Restaurant
        RestaurantViewModel GetById(Guid id);
        IEnumerable<RestaurantViewModel> GetAll();        
        RestaurantViewModel Update(RestaurantViewModel restaurantViewModel);
        void Remover(Guid id);
        RestaurantViewModel Add(RestaurantViewModel restaurant);

        //Menu
        MenuViewModel GetByMenuId(Guid id);
        IEnumerable<MenuViewModel> GetManuAll();
        MenuViewModel Update(MenuViewModel menuViewModel);
        void RemoverMenu(Guid id);
        MenuViewModel AddMenu(MenuViewModel menuViewModel);

        //Review
        ReviewViewModel GetByReviewId(Guid id);
        IEnumerable<ReviewViewModel> GetReviewAll();
        MenuViewModel Update(ReviewViewModel reviewViewModel);
        void RemoverReview(Guid id);
        ReviewViewModel AddMenu(ReviewViewModel reviewViewModel);
    }
}
