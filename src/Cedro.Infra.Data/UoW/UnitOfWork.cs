using Cedro.Infra.Data.Context;
namespace Cedro.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CedroContext _context;
        public UnitOfWork(CedroContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
