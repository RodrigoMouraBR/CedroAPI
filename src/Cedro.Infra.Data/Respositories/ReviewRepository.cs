using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Models;
using Cedro.Infra.Data.Context;
namespace Cedro.Infra.Data.Respositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(CedroContext context) : base(context)
        {

        }
    }
}
