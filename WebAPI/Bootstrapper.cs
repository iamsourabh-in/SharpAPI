using System.Web.Mvc;
using Microsoft.Practices;

//using DataModel.UnitOfWork;
using Resolver;
using BusinessServices;
using System.Web.Http;
using Microsoft.Practices.Unity.Mvc;
using Microsoft.Practices.Unity;

namespace WebAPI
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            System.Web.Mvc.DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            // register dependency resolver for WebAPI RC  
            GlobalConfiguration.Configuration.DependencyResolver = new Microsoft.Practices.Unity.WebApi.UnityDependencyResolver(container);
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here  
            // it is NOT necessary to register your controllers  

            // e.g. container.RegisterType<ITestService, TestService>();          
            // container.RegisterType<IProductServices, ProductServices>().RegisterType<UnitOfWork>(new HierarchicalLifetimeManager());

            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {

            //Component initialization via MEF  

            //Component initialization via MEF  
            ComponentLoader.LoadContainer(container, ".\\bin", "WebApi.dll");
            ComponentLoader.LoadContainer(container, ".\\bin", "BusinessServices.dll");
        }
    }
}