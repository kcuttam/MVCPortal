using System;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using WebStoreSln.DataProvider;

namespace WebUI.Infrastructure
{
    public class NInjectControllerFactory : DefaultControllerFactory
    {
        private IKernel nInjectKernel;
        public NInjectControllerFactory()
        {
            nInjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ?
                null :
                (IController)nInjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            nInjectKernel.Bind<IProductRepository>().To<ProductRepository>();
            nInjectKernel.Bind<ICategoryRepository>().To<CategoryRepository>();
        }
    }
}