using Cedro.Application.Interfaces;
using Cedro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;
namespace Cedro.Api.Controllers
{
    public class RestaurantController : ApiController
    {
        private readonly IRestaurantApplicationService _restaurantApplicationService;
        public RestaurantController(IRestaurantApplicationService restaurantApplicationService)
        {
            _restaurantApplicationService = restaurantApplicationService;
        }
        [HttpGet]
        public IEnumerable<RestaurantViewModel> GetByRestaurant()
        {
            return _restaurantApplicationService.GetAll();
        }
        // GET: api/Restaurant/5
        //public RestaurantViewModel Get(Guid id)
        //{
        //    return _restaurantApplicationService.GetById(id);
        //}
        //// POST: api/Restaurant
        //public void Post([FromBody]string value)
        //{
        //}
        //// PUT: api/Restaurant/5
        //public void Put(int id, [FromBody]RestaurantViewModel restaurantViewModel)
        //{
        //    _restaurantApplicationService.Atualizar(restaurantViewModel);
        //}
        //// DELETE: api/Restaurant/5
        //public void Delete(Guid id)
        //{
        //    _restaurantApplicationService.Remover(id);
        //}
    }
}
