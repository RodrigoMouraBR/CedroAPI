using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Models;
using Cedro.Infra.Data.Context;
namespace Cedro.Infra.Data.Respositories
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(CedroContext context) : base(context)
        {

        }       
    }
}
