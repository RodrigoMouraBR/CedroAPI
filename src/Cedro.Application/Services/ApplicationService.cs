using Cedro.Infra.Data.UoW;
namespace Cedro.Application.Services
{
    public abstract class ApplicationService
    {
        private IUnitOfWork _uow;
        protected ApplicationService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        protected void Commit()
        {
            _uow.Commit();
        }
    }
}
