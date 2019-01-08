using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Models;
using Cedro.Infra.Data.Context;
namespace Cedro.Infra.Data.Respositories
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(CedroContext context) : base(context)
        {

        }
    }
}
