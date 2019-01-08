using Cedro.Application.Interfaces;
using Cedro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cedro.Service.Api.Controllers
{
    public class RestaurantController : ApiController
    {
        private readonly IRestaurantApplicationService _restaurantApplicationService;
        public RestaurantController(IRestaurantApplicationService restaurantApplicationService)
        {
            _restaurantApplicationService = restaurantApplicationService;
        }
        // GET: api/Restaurant
        public IEnumerable<RestaurantViewModel> Get()
        {
            return _restaurantApplicationService.GetAll();
        }

        // GET: api/Restaurant/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Restaurant
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Restaurant/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Restaurant/5
        public void Delete(int id)
        {
        }
    }
}
