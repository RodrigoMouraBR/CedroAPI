using Cedro.Application.Interfaces;
using Cedro.Application.ViewModels;
using Cedro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cedro.Service.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IRestaurantApplicationService _restaurantApplicationService;
        public ValuesController(IRestaurantApplicationService restaurantApplicationService)
        {
            _restaurantApplicationService = restaurantApplicationService;
        }
        // GET api/values
        public IEnumerable<RestaurantViewModel> Get()
        {
            return _restaurantApplicationService.GetAll();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
