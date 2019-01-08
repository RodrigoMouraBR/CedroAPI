using Cedro.Application.Interfaces;
using Cedro.Application.Services;
using Cedro.Domain.Interfaces.Repositories;
using Cedro.Domain.Interfaces.Services;
using Cedro.Domain.Services;
using Cedro.Infra.Data.Context;
using Cedro.Infra.Data.Respositories;
using Cedro.Infra.Data.UoW;
using SimpleInjector;
namespace Cedro.Infra.CrossCutting.IoC
{
    public class SimpleInjectorContainer
    {
        public static void Register(Container container)
        {
            container.Register<IRestaurantApplicationService, RestaurantApplicationService>(Lifestyle.Scoped);
            container.Register<IRestaurantRepository, RestaurantRepository>(Lifestyle.Scoped);
            container.Register<IMenuRepository, MenuRepository>(Lifestyle.Scoped);
            container.Register<IReviewRepository, ReviewRepository>(Lifestyle.Scoped);
            container.Register<IRestaurantService, RestaurantService>(Lifestyle.Scoped);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<CedroContext>(Lifestyle.Scoped);
        }
    }
}
