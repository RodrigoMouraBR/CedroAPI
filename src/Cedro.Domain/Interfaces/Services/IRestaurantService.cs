using Cedro.Domain.Models;
using System;
namespace Cedro.Domain.Interfaces.Services
{
    public interface IRestaurantService
    {
        Restaurant Add(Restaurant restaurant);
        Restaurant Update(Restaurant restaurant);
        void Delete(Guid id);

        Menu AddMenu(Menu menu);
        Menu UpdateMenu(Menu menu);
        void DeleteMenu(Guid id);

        Review AddReview(Review review);
        Review UpdateReview(Review review);
        void DeleteReview(Guid id);
    }
}
